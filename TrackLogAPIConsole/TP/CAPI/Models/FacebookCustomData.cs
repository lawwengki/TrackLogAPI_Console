using System;
using System.Text;
using System.Xml;
using System.Text.Json;
using System.Collections.Generic;

namespace TP_CAPI.Models
{
    public class FacebookCustomData
    {
        public string value { get; set; }
        public string currency { get; set; }
        public List<string> contentIds { get; set; }
        public string contentType { get; set; }
        public string contentName { get; set; }
        public string contentCategory { get; set; }
        public string status { get; set; }
        public string searchString { get; set; }
        public string predictedLtv { get; set; }


        public Dictionary<string, Object> toArray()
        {

            Dictionary<string, Object> ret = new Dictionary<string, Object>();

            if (currency != null)
                ret.Add("currency", currency);
            if (value != null)
                ret.Add("value", value);
            if(contentIds != null)
                ret.Add("content_ids", contentIds);
            if (contentType != null)
                ret.Add("content_type", contentType);
            if (contentName != null)
                ret.Add("content_name", contentName);
            if (status != null)
                ret.Add("status", status);
            if (contentCategory != null)
                ret.Add("content_category", contentCategory);
            if (searchString != null)
                ret.Add("search_string", searchString);
            if (predictedLtv != null)
                ret.Add("predicted_ltv", predictedLtv);

            return ret;
        }
    }
}
