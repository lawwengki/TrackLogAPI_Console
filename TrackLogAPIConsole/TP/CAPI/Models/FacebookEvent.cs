using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml;
using System.Text.Json;

namespace TP_CAPI.Models
{
    public class FacebookEvent
    {
        public string eventName { get; set; }
        public string eventId { get; set; }
        public string eventTime { get; set; }
        public string eventSourceUrl { get; set; }
        public string actionSource { get; set; }

        public FacebookUserData userData { get; set; }
        public FacebookCustomData customData { get; set; }
        public bool optOut { get; set; }

        public string toJsonString()
        {
            string str;

            Dictionary<string, Object> ret = new Dictionary<string, Object>();

            if (eventId != null)
                ret.Add("event_id", eventId);

            if (actionSource != null)
            {
                ret.Add("action_source", actionSource);
            }
            else {
                //Default parameter
                ret.Add("action_source", "website");
            }
               
            ret.Add("event_name", eventName);
            ret.Add("event_time", eventTime);
            ret.Add("opt_out", optOut.ToString().ToLower());

            if (eventSourceUrl != null)
                ret.Add("event_source_url", eventSourceUrl);

            if (userData != null)
                ret.Add("user_data", userData.toArray());
            if (customData != null)
                ret.Add("custom_data", customData.toArray());

            List<Object> data = new List<Object>();
            data.Add(ret);

            str = JsonSerializer.Serialize(data);

            return str;
        }
    }
}