using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml;
using System.Text.Json;
using TP_CAPI.Libraries;

namespace TP_CAPI.Models
{
    public class FacebookUserData
    {
        public string clientIpAddress { get; set; }
        public string clientUserAgent { get; set; }
        //Must be hashed
        public string email { get; set; }
        //Must be hashed
        public string phone { get; set; }
        //Must be hashed
        public string city { get; set; }
        //Must be hashed
        public string state { get; set; }
        //Must be hashed
        public string country { get; set; }
        //Must be hashed
        public string firstName { get; set; }
        //Must be hashed
        public string lastName { get; set; }
        //Must be hashed
        public string gender { get; set;  }
        //Must be hashed
        public string zip { get; set; }
        //Must be hashed
        public string dob { get; set; }

        //Click ID
        public string clickId { get; set; }
        //Browser ID
        public string browserId { get; set; }

        public string fbLoginId { get; set; }

        public Dictionary<string, string> toArray()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if(clientUserAgent != null && clientUserAgent.Length > 0)
                ret.Add("client_user_agent", clientUserAgent);
            if (clientIpAddress != null && clientIpAddress.Length > 0)
                ret.Add("client_ip_address", clientIpAddress);

            if (email != null && email.Length > 0)
                ret.Add("em", FacebookEventRequest.toSHA256(email));
            if (phone != null && phone.Length > 0)
                ret.Add("ph", FacebookEventRequest.toSHA256(phone));
            if (city != null && city.Length > 0)
                ret.Add("ct", FacebookEventRequest.toSHA256(city));
            if (country != null && country.Length > 0)
                ret.Add("country", FacebookEventRequest.toSHA256(country));
            if (firstName != null && firstName.Length > 0)
                ret.Add("fn", FacebookEventRequest.toSHA256(firstName));
            if (lastName != null && lastName.Length > 0)
                ret.Add("ln", FacebookEventRequest.toSHA256(lastName));
            if (gender != null && gender.Length > 0)
                ret.Add("ge", FacebookEventRequest.toSHA256(gender));
            if (zip != null && zip.Length > 0)
                ret.Add("zp", FacebookEventRequest.toSHA256(zip));
            if (dob != null && dob.Length > 0)
                ret.Add("db", FacebookEventRequest.toSHA256(dob));
            if (state != null && state.Length > 0)
                ret.Add("st", FacebookEventRequest.toSHA256(state));

            if (clickId != null && clickId.Length > 0)
                ret.Add("fbc", clickId);
            if (browserId != null && browserId.Length > 0)
                ret.Add("fbp", browserId);
            if (fbLoginId != null && fbLoginId.Length > 0)
                ret.Add("fb_login_id", fbLoginId);

            return ret;
        }
    }
}
