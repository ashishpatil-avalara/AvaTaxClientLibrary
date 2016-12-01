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
 */class VoidReasonCode extends AvaTaxEnum 
{

    const Unspecified = "Unspecified";
    const PostFailed = "PostFailed";
    const DocDeleted = "DocDeleted";
    const DocVoided = "DocVoided";
    const AdjustmentCancelled = "AdjustmentCancelled";
}
