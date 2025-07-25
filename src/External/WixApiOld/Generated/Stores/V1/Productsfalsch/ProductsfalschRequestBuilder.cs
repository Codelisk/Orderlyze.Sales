// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using MyApi.Client.Stores.V1.Productsfalsch.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace MyApi.Client.Stores.V1.Productsfalsch
{
    /// <summary>
    /// Builds and executes requests for operations under \stores\v1\productsfalsch
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProductsfalschRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the MyApi.Client.stores.v1.productsfalsch.item collection</summary>
        /// <param name="position">Product ID</param>
        /// <returns>A <see cref="global::MyApi.Client.Stores.V1.Productsfalsch.Item.WithProductItemRequestBuilder"/></returns>
        public global::MyApi.Client.Stores.V1.Productsfalsch.Item.WithProductItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("productId", position);
                return new global::MyApi.Client.Stores.V1.Productsfalsch.Item.WithProductItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Stores.V1.Productsfalsch.ProductsfalschRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsfalschRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/stores/v1/productsfalsch", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::MyApi.Client.Stores.V1.Productsfalsch.ProductsfalschRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductsfalschRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/stores/v1/productsfalsch", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
