using System;
using System.Collections.Generic;
using System.Text;

namespace HmhengXamSeach.Core.Models
{
    public class AppConstants
    {
        #region bing web search api
        /// <summary>
        /// Header parameter used to provide the authentication key for all API calls
        /// </summary>
        public const string OcpApimSubscriptionKey = "Ocp-Apim-Subscription-Key";

        /// <summary>
        /// Url of the Bing Web Search API
        /// </summary>
        public const string BingWebSearchApiUrl = "https://api.cognitive.microsoft.com/bing/v7.0/search?";

        /// <summary>
        /// User's API key for the Bing Web Search API. Not a constant because it can get set in the app
        /// if a user enters a key on the screen that allows key input.
        /// </summary>
        public static string BingWebSearchApiKey = "<YOUR_BING_SEARCH_API_KEY>";
        #endregion
        
    }
}
