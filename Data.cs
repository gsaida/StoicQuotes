using System;
using System.Text.Json.Serialization;

namespace StoicQuotes
{
	public class Data
	{
        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("quote")]
        public string Quote { get; set; }

    }
}

