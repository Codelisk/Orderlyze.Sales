// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace MyApi.Client.Inbox.V2.Messages
{
    /// <summary>
    /// Builds and executes requests for operations under \inbox\v2\messages
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MessagesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/inbox/v2/messages?conversationId={conversationId}{&paging%2Ecursor*,sendAs*,visibility*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/inbox/v2/messages?conversationId={conversationId}{&paging%2Ecursor*,sendAs*,visibility*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves messages in a conversation.
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesGetResponse?> GetAsMessagesGetResponseAsync(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesGetResponse> GetAsMessagesGetResponseAsync(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::MyApi.Client.Inbox.V2.Messages.MessagesGetResponse>(requestInfo, global::MyApi.Client.Inbox.V2.Messages.MessagesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves messages in a conversation.
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsMessagesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse?> GetAsync(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse> GetAsync(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse>(requestInfo, global::MyApi.Client.Inbox.V2.Messages.MessagesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sends a message in a conversation.
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesPostResponse?> PostAsMessagesPostResponseAsync(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesPostResponse> PostAsMessagesPostResponseAsync(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::MyApi.Client.Inbox.V2.Messages.MessagesPostResponse>(requestInfo, global::MyApi.Client.Inbox.V2.Messages.MessagesPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sends a message in a conversation.
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsMessagesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse?> PostAsync(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse> PostAsync(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::MyApi.Client.Inbox.V2.Messages.MessagesResponse>(requestInfo, global::MyApi.Client.Inbox.V2.Messages.MessagesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves messages in a conversation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, "{+baseurl}/inbox/v2/messages?conversationId={conversationId}{&paging%2Ecursor*,visibility*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Sends a message in a conversation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::MyApi.Client.Inbox.V2.Messages.MessagesPostRequestBody body, Action<RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/inbox/v2/messages{?sendAs*}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves messages in a conversation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MessagesRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("conversationId")]
            public string? ConversationId { get; set; }
#nullable restore
#else
            [QueryParameter("conversationId")]
            public string ConversationId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("paging%2Ecursor")]
            public string? PagingCursor { get; set; }
#nullable restore
#else
            [QueryParameter("paging%2Ecursor")]
            public string PagingCursor { get; set; }
#endif
            [Obsolete("This property is deprecated, use VisibilityAsGetVisibilityQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("visibility")]
            public string? Visibility { get; set; }
#nullable restore
#else
            [QueryParameter("visibility")]
            public string Visibility { get; set; }
#endif
            [QueryParameter("visibility")]
            public global::MyApi.Client.Inbox.V2.Messages.GetVisibilityQueryParameterType? VisibilityAsGetVisibilityQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MessagesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Sends a message in a conversation.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MessagesRequestBuilderPostQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sendAs")]
            public string? SendAs { get; set; }
#nullable restore
#else
            [QueryParameter("sendAs")]
            public string SendAs { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MessagesRequestBuilderPostRequestConfiguration : RequestConfiguration<global::MyApi.Client.Inbox.V2.Messages.MessagesRequestBuilder.MessagesRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
