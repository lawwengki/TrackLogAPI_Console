using System;
using System.Collections.Generic;
using TrackLogAPIConsole.Models;
using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Net;
using TP_CAPI.Libraries;
using System.Net.Http;
using TP_CAPI.Models;

namespace TP_CAPI.Libraries
{
    public class FacebookEventRequest
    {
        private const string eventsEndpoint = "events";

        private string pixelId;
        private FacebookClient client;
        private List<FacebookEvent> events;
        

        public FacebookEventRequest(string pixelId, FacebookClient client)
        {
            this.client = client;
            this.pixelId = pixelId;

            events = new List<FacebookEvent>();
        }

        public void addEventItem(FacebookEvent e)
        {
            events.Add(e);
        }

        public void execute()
        {
          
            foreach (FacebookEvent e in events)
            {
                string data = e.toJsonString();

                try {
                    this.client.postAsync(data, this.pixelId + "/" + eventsEndpoint).Wait();
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
                
        }

        public static string toSHA256(string value)
        {
            if (value == null) return null;
            StringBuilder Sb = new StringBuilder();
            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
