using System;
using System.Linq;
using RestSharp.Portable;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace HOLA.Methods
{
	public static class API
	{
		private static string baseUrl = "http://wwww.hola.kz/";
		private static RestClient client = new RestClient (baseUrl + "");

		public static async Task<JObject> Execute(string callback, HttpMethod httpMethod,
									  			  Dictionary<string,string> parameters, 
									  			  Dictionary<string,string> files = null, object obj = null)
		{
			//init request
			var request = new RestRequest (callback, httpMethod);
			request.AddHeader("Content-Type", "application/json; charset=utf-8");


			//add parameters
			foreach (var key in parameters.Keys) 
			{
				request.AddParameter (key, parameters [key].ToString ());
			}
			

			//add files
			//if (files != null && files.Keys.Count > 0) {
			//	foreach (var key in files.Keys) {
			//		request.AddFile( .AddFile (key, files[key]);
			//	}
			//}


			//execute
			var result = await client.Execute<string>(request);


			//print response
			Debug.WriteLine (callback);
			Debug.WriteLine (result.Data);


			//save cookies
			//var sessionCookie = response.Cookies.SingleOrDefault(x => x.Name == "WRAD_SESSION");
			//if (sessionCookie != null && APIHelper.restClient.CookieContainer==null)
			//{
			//	APIHelper.restClient.CookieContainer = new CookieContainer ();
			///	APIHelper.restClient.CookieContainer.Add(new Uri(APIHelper.baseUrl),new Cookie(sessionCookie.Name, sessionCookie.Value, sessionCookie.Path, sessionCookie.Domain));
			//}


			//string to JObect deserialization
			try{
				return JObject.Parse(result.Data);
			} catch(Exception ex){
				Debug.WriteLine (ex.Message + (ex.InnerException != null ? ("\n" + ex.InnerException.Message) : ""));
				return null;
			}
		}
	}
}

