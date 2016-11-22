﻿using Avalara.AvaTax.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        /// <summary>
        /// To debug this application, call app must be called with args[0] as username and args[1] as password
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // Connect to the server
            var client = new AvaTaxClient("ConsoleTest", "1.0", Environment.MachineName, AvaTaxEnvironment.Sandbox);
            client.WithSecurity(args[0], args[1]);

            // Call Ping
            var pingResult = client.Ping();
            Console.WriteLine(pingResult.version);

            // Call fetch
            try {
                var companies = client.QueryCompanies(null, null, 0, 0, null);
                Console.WriteLine(companies.ToString());

                // Initialize a company and fetch it back
                var init = client.CompanyInitialize(new CompanyInitializationModel()
                {
                    city = "Bainbridge Island",
                    companyCode = Guid.NewGuid().ToString("N").Substring(0, 25),
                    country = "US",
                    email = "bob@example.org",
                    faxNumber = null,
                    firstName = "Bob",
                    lastName = "Example",
                    line1 = "100 Ravine Lane",
                    line2 = null,
                    line3 = null,
                    mobileNumber = null,
                    name = "Bob Example",
                    phoneNumber = "206 555 1212",
                    postalCode = "98110",
                    region = "WA",
                    taxpayerIdNumber = "123456789",
                    title = "Owner",
                    vatRegistrationId = null
                });
                Console.WriteLine(init.ToString());

                // Fetch it back
                var fetchBack = client.GetCompany(init.id, "Locations");
                Console.WriteLine(fetchBack.ToString());

                // Execute a transaction
                var t = new TransactionBuilder(client, init.companyCode, DocumentType.SalesInvoice, "ABC")
                    .WithAddress(TransactionAddressType.SingleLocation, "123 Main Street", "Irvine", "CA", "92615", "US")
                    .WithLine(100.0m)
                    .WithExemptLine(50.0m, "NT")
                    .Create().Result;
                Console.WriteLine(t.ToString());

            } catch (AvaTaxError ex) {
                Console.WriteLine(ex.error.ToString());
            } catch (Exception ex2) {
                Console.WriteLine(ex2.ToString());
            }

            // Finished
            Console.WriteLine("Done");
        }
    }
}
