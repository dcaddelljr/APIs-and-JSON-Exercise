using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
	public class Quotes
	{
		public static string KanyeQuote()
		{
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";  //end point. storing as a string to plug into the program
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;

        }

        public static string RonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;
        }
    }
}

