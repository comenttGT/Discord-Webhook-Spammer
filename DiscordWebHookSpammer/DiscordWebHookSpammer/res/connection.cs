using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DiscordWebHookSpammer.res
{
    internal class connection
    {
        public static byte[] post(string url, NameValueCollection pair)
        {
            using (WebClient client = new WebClient())
            {
                return client.UploadValues(url, pair);
            }
        }
    }
}
