namespace Spotify.WebApi.Model.Objects
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CursorPaging<T>
    {
        /// <summary>
        /// The cursors used to find the next set of items.
        /// </summary>
        [JsonPropertyName("cursors")]
        public Cursor Cursors { get; set; }

        /// <summary>
        /// A link to the Web API endpoint returning the full result of the request.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The requested data.
        /// </summary>
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }

        /// <summary>
        /// The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// URL to the next page of items. ( null if none)
        /// </summary>
        [JsonPropertyName("next")]
        public string Next { get; set; }

        /// <summary>
        /// The total number of items available to return.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
