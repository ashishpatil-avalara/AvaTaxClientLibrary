<?php
/*
 * AvaTax Enum Class
 *
 * (c) 2004-2016 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
namespace Avalara.AvaTax;

/**
 * @author Ted Spence <ted.spence@avalara.com>
 * @author Bob Maidens <bob.maidens@avalara.com>
 */class TransactionAddressType extends AvaTaxEnum 
{

    const ShipFrom = "ShipFrom";
    const ShipTo = "ShipTo";
    const PointOfOrderAcceptance = "PointOfOrderAcceptance";
    const PointOfOrderOrigin = "PointOfOrderOrigin";
    const SingleLocation = "SingleLocation";
}
