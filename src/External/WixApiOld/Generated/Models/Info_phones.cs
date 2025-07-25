// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace MyApi.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Info_phones : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The countryCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The e164Phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? E164Phone { get; set; }
#nullable restore
#else
        public string E164Phone { get; set; }
#endif
        /// <summary>The formattedPhone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FormattedPhone { get; set; }
#nullable restore
#else
        public string FormattedPhone { get; set; }
#endif
        /// <summary>The phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The primary property</summary>
        public bool? Primary { get; set; }
        /// <summary>The tag property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tag { get; set; }
#nullable restore
#else
        public string Tag { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Models.Info_phones"/> and sets the default values.
        /// </summary>
        public Info_phones()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Models.Info_phones"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::MyApi.Client.Models.Info_phones CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::MyApi.Client.Models.Info_phones();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "countryCode", n => { CountryCode = n.GetStringValue(); } },
                { "e164Phone", n => { E164Phone = n.GetStringValue(); } },
                { "formattedPhone", n => { FormattedPhone = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "primary", n => { Primary = n.GetBoolValue(); } },
                { "tag", n => { Tag = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteStringValue("e164Phone", E164Phone);
            writer.WriteStringValue("formattedPhone", FormattedPhone);
            writer.WriteStringValue("phone", Phone);
            writer.WriteBoolValue("primary", Primary);
            writer.WriteStringValue("tag", Tag);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
