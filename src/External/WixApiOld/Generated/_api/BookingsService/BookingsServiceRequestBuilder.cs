// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using MyApi.Client._api.BookingsService.V2;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace MyApi.Client._api.BookingsService
{
    /// <summary>
    /// Builds and executes requests for operations under \_api\bookings-service
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BookingsServiceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The v2 property</summary>
        public global::MyApi.Client._api.BookingsService.V2.V2RequestBuilder V2
        {
            get => new global::MyApi.Client._api.BookingsService.V2.V2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client._api.BookingsService.BookingsServiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingsServiceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/_api/bookings-service", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client._api.BookingsService.BookingsServiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BookingsServiceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/_api/bookings-service", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
