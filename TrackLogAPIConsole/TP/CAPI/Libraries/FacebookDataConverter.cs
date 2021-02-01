using System;
using System.Collections.Generic;
using System.Globalization;
using TrackLogAPIConsole.Models;
using TP_CAPI.Models;

namespace TP_CAPI.Libraries
{
    public class FacebookDataConverter
    {
        public FacebookDataConverter()
        {
        }

        public static FacebookEvent parseItemData(Object model)
        {
            FacebookEvent facebookEvent = null;

            if (model is AddtoCartModel)
            {
                AddtoCartModel item = (AddtoCartModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.total_value.ToString(CultureInfo.InvariantCulture);
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "AddToCart";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null) {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is AddToWishlistModel)
            {
                AddToWishlistModel item = (AddToWishlistModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.value.ToString(CultureInfo.InvariantCulture);
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "AddToWishlist";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is CompleteRegistrationModel)
            {
                CompleteRegistrationModel item = (CompleteRegistrationModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.contentName = item.content_name;
                customData.status = item.reg_status;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "CompleteRegistration";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is InitiateCheckoutModel)
            {
                InitiateCheckoutModel item = (InitiateCheckoutModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.total_value.ToString(CultureInfo.InvariantCulture);
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "InitiateCheckout";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is PageViewModel)
            {
                PageViewModel item = (PageViewModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "PageView";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;

                facebookEvent = fbEvent;
            }
            else if (model is PurchaseModel)
            {
                PurchaseModel item = (PurchaseModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.total_value.ToString(CultureInfo.InvariantCulture);
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "Purchase";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is SearchModel)
            {
                SearchModel item = (SearchModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.value.ToString(CultureInfo.InvariantCulture);
                customData.searchString = item.search_str;
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "Search";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is SubscribeModel)
            {
                SubscribeModel item = (SubscribeModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.value.ToString(CultureInfo.InvariantCulture);
                customData.predictedLtv = item.predicted_itv;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "Subscribe";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }
            else if (model is AddPaymentInfoModel)
            {
                AddPaymentInfoModel item = (AddPaymentInfoModel)model;

                FacebookUserData userData = new FacebookUserData();
                userData.email = item.email;
                userData.firstName = item.first_name;
                userData.lastName = item.last_name;
                userData.phone = item.phone;
                userData.dob = item.dob;
                userData.city = item.city;
                userData.state = item.state;
                userData.country = item.country;
                userData.clientIpAddress = item.user_ip;
                userData.clientUserAgent = item.browser_user_agent;
                userData.fbLoginId = item.fb_loginid;
                userData.clickId = item.clickid;
                userData.browserId = item.browserid;

                FacebookCustomData customData = new FacebookCustomData();
                customData.currency = item.currency;
                customData.value = item.value.ToString(CultureInfo.InvariantCulture);
                customData.contentType = "product";

                List<string> productIds = new List<string>();

                foreach (products product in item.products)
                {
                    productIds.Add(product.productid.ToString(CultureInfo.InvariantCulture));
                }

                customData.contentIds = productIds;

                FacebookEvent fbEvent = new FacebookEvent();
                fbEvent.eventName = "AddPaymentInfo";
                fbEvent.eventId = item.eventid.ToString(CultureInfo.InvariantCulture);
                long nw = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                nw = nw / 1000;

                fbEvent.eventTime = nw.ToString();
                fbEvent.eventSourceUrl = item.url;

                if (item.GetType().GetProperty("action_source") != null)
                {
                    fbEvent.actionSource = item.GetType().GetProperty("action_source").ToString();
                }

                //Setting user and custom data
                fbEvent.userData = userData;
                fbEvent.customData = customData;

                facebookEvent = fbEvent;
            }

            return facebookEvent;
        }
    }
}
