using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // Properties
        private readonly Dictionary<string, string> _dictionary;

        public DateTime Expiry { get; set; }

        // Constructor
        public HttpCookie()
        {   
            // Initialise
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}