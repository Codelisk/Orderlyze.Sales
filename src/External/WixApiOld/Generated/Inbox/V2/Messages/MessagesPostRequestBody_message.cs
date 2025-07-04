// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace MyApi.Client.Inbox.V2.Messages
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MessagesPostRequestBody_message : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_content? Content { get; set; }
#nullable restore
#else
        public global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_content Content { get; set; }
#endif
        /// <summary>The direction property</summary>
        public global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_direction? Direction { get; set; }
        /// <summary>The targetChannels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetChannels { get; set; }
#nullable restore
#else
        public List<string> TargetChannels { get; set; }
#endif
        /// <summary>The visibility property</summary>
        public global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_visibility? Visibility { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message"/> and sets the default values.
        /// </summary>
        public MessagesPostRequestBody_message()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content", n => { Content = n.GetObjectValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_content>(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_content.CreateFromDiscriminatorValue); } },
                { "direction", n => { Direction = n.GetEnumValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_direction>(); } },
                { "targetChannels", n => { TargetChannels = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "visibility", n => { Visibility = n.GetEnumValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_visibility>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_content>("content", Content);
            writer.WriteEnumValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_direction>("direction", Direction);
            writer.WriteCollectionOfPrimitiveValues<string>("targetChannels", TargetChannels);
            writer.WriteEnumValue<global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody_message_visibility>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
