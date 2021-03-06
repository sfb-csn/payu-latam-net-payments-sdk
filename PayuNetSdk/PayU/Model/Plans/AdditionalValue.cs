﻿// <copyright file="AdditionalValue.cs" company="PayU Latam">
//    PayU Latam. All rights reserved.
// </copyright>
// <author>Jorge D. Porras</author>

namespace PayuNetSdk.PayU.Model.Plans
{
    using System.Xml.Serialization;
    using PayuNetSdk.PayU.Messages.Enums;

    /// <summary>
    /// Represents an additional value.
    /// </summary>
    [XmlType("additionalValue")]
    public class AdditionalValue
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [XmlElement("value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [XmlElement("currency")]
        public Currency Currency { get; set; }
    }
}
