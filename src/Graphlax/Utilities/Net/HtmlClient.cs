using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Graphlax.Utilities.Net
{
    public class HtmlClient
    {
        public async static Task<HtmlDocument> LoadDocumentAsync(Uri uri){
            CookieContainer cookies=new CookieContainer();
            Cookie cookie=new Cookie("mature_content","/");
            cookie.Domain=uri.Host;
            cookie.Expires=DateTime.Now.AddDays(365);
            cookies.Add(uri,cookie);
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.CookieContainer = cookies;
            request.Headers.Set("Accept-Language","tr-TR");

            HttpWebResponse response = (HttpWebResponse) await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();

            HtmlDocument htmlDocument=new HtmlDocument();
            htmlDocument.Load(stream);
            return htmlDocument;
        }
    }
}