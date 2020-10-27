using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using TrackLogAPIConsole.Models;
using System.Web.Script.Serialization;

namespace TrackLogAPIConsole.Classes
{
    class CallWebAPI 
    {
        public bool CallAddtoCartAPI(APIConfigurations api) 
        {

            bool rAPI = false;
            AddtoCartModel  addtocart = new AddtoCartModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
     Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

                AddtoCartModel item = JsonSerializer.Deserialize<AddtoCartModel>(json);

                addtocart.eventid = item.eventid;
                addtocart.products = item.products;
                addtocart.url = item.url;
                addtocart.currency = item.currency;
                addtocart.total_value = item.total_value;
                addtocart.email = item.email;
                addtocart.first_name = item.first_name;
                addtocart.last_name = item.last_name;
                addtocart.phone = item.phone;
                addtocart.DOB = item.DOB;
                addtocart.city = item.city;
                addtocart.state = item.state;
                addtocart.country = item.country;
                addtocart.user_ip = item.user_ip;
                addtocart.browser_user_agent = item.browser_user_agent;
                addtocart.clickid = item.clickid;
                addtocart.browserid = item.browserid;
                addtocart.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }
      
        public bool CallPageViewAPI(APIConfigurations api)
        {

            bool rAPI = false;
            PageViewModel pageview = new PageViewModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

                PageViewModel item = JsonSerializer.Deserialize<PageViewModel>(json);

                        pageview.eventid = item.eventid;
                        pageview.url = item.url;
                        pageview.email = item.email;
                        pageview.first_name = item.first_name;
                        pageview.last_name = item.last_name;
                        pageview.phone = item.phone;
                        pageview.DOB = item.DOB;
                        pageview.city = item.city;
                        pageview.state = item.state;
                        pageview.country = item.country;
                        pageview.user_ip = item.user_ip;
                        pageview.browser_user_agent = item.browser_user_agent;
                        pageview.clickid = item.clickid;
                        pageview.browserid = item.browserid;
                        pageview.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }
        public bool CallPurchaseAPI(APIConfigurations api)
        {

            bool rAPI = false;
            PurchaseModel purchase = new PurchaseModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

        PurchaseModel item = JsonSerializer.Deserialize<PurchaseModel>(json);

                        purchase.eventid = item.eventid;
                        purchase.products = item.products;
                        purchase.currency = item.currency; ;
                        purchase.total_value = item.total_value;
                        purchase.url = item.url;
                        purchase.email = item.email;
                        purchase.first_name = item.first_name;
                        purchase.last_name = item.last_name;
                        purchase.phone = item.phone;
                        purchase.DOB = item.DOB;
                        purchase.city = item.city;
                        purchase.state = item.state;
                        purchase.country = item.country;
                        purchase.user_ip = item.user_ip;
                        purchase.browser_user_agent = item.browser_user_agent;
                        purchase.clickid = item.clickid;
                        purchase.browserid = item.browserid;
                        purchase.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }

        public bool CallCompleteRegistrationAPI(APIConfigurations api)
        {

            bool rAPI = false;
            CompleteRegistrationModel cmpReg = new CompleteRegistrationModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);


                 CompleteRegistrationModel item = JsonSerializer.Deserialize<CompleteRegistrationModel>(json);
                        cmpReg.eventid = item.eventid;
                        cmpReg.content_name = item.content_name;
                        cmpReg.reg_status = item.reg_status;
                        cmpReg.currency = item.currency;
                        cmpReg.total_value = item.total_value;
                        cmpReg.email = item.email;
                        cmpReg.first_name = item.first_name;
                        cmpReg.last_name = item.last_name;
                        cmpReg.phone = item.phone;
                        cmpReg.DOB = item.DOB;
                        cmpReg.city = item.city;
                        cmpReg.state = item.state;
                        cmpReg.country = item.country;
                        cmpReg.user_ip = item.user_ip;
                        cmpReg.browser_user_agent = item.browser_user_agent;
                        cmpReg.clickid = item.clickid;
                        cmpReg.browserid = item.browserid;
                        cmpReg.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }

        public bool CallInitiateCheckOuAPI(APIConfigurations api)
        {

            bool rAPI = false;
            InitiateCheckoutModel initCheckout = new InitiateCheckoutModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

        InitiateCheckoutModel item = JsonSerializer.Deserialize<InitiateCheckoutModel>(json);
                        initCheckout.eventid = item.eventid;
                        initCheckout.products = item.products;
                        initCheckout.currency = item.currency;
                        initCheckout.total_value = item.total_value;
                        initCheckout.url = item.url;
                        initCheckout.email = item.email;
                        initCheckout.first_name = item.first_name;
                        initCheckout.last_name = item.last_name;
                        initCheckout.phone = item.phone;
                        initCheckout.DOB = item.DOB;
                        initCheckout.city = item.city;
                        initCheckout.state = item.state;
                        initCheckout.country = item.country;
                        initCheckout.user_ip = item.user_ip;
                        initCheckout.browser_user_agent = item.browser_user_agent;
                        initCheckout.clickid = item.clickid;
                        initCheckout.browserid = item.browserid;
                        initCheckout.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }

        public bool CallSearchAPI(APIConfigurations api)
        {

            bool rAPI = false;
            SearchModel search = new SearchModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

        SearchModel item = JsonSerializer.Deserialize<SearchModel>(json);

                        search.eventid = item.eventid;
                        search.search_str = item.search_str;
                        search.products = item.products;
                        search.currency = item.currency;
                        search.value = item.value;
                        search.url = item.url;
                        search.email = item.email;
                        search.first_name = item.first_name;
                        search.last_name = item.last_name;
                        search.phone = item.phone;
                        search.DOB = item.DOB;
                        search.city = item.city;
                        search.state = item.state;
                        search.country = item.country;
                        search.user_ip = item.user_ip;
                        search.browser_user_agent = item.browser_user_agent;
                        search.clickid = item.clickid;
                        search.browserid = item.browserid;
                        search.fb_loginid = item.fb_loginid;

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }
        public bool CallPaymentInfoAPI(APIConfigurations api)
        {

            bool rAPI = false;
            AddPaymentInfoModel addpayInfo = new AddPaymentInfoModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

        AddPaymentInfoModel item = JsonSerializer.Deserialize<AddPaymentInfoModel>(json);

                        addpayInfo.eventid = item.eventid;
                        addpayInfo.products = item.products;
                        addpayInfo.value = item.value;
                        addpayInfo.url = item.url;
                        addpayInfo.email = item.email;
                        addpayInfo.first_name = item.first_name;
                        addpayInfo.last_name = item.last_name;
                        addpayInfo.phone = item.phone;
                        addpayInfo.DOB = item.DOB;
                        addpayInfo.city = item.city;
                        addpayInfo.state = item.state;
                        addpayInfo.country = item.country;
                        addpayInfo.user_ip = item.user_ip;
                        addpayInfo.browser_user_agent = item.browser_user_agent;
                        addpayInfo.clickid = item.clickid;
                        addpayInfo.browserid = item.browserid;
                        addpayInfo.fb_loginid = item.fb_loginid;
                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }
        public bool CallAddToWishListAPI(APIConfigurations api)
        {

            bool rAPI = false;
            AddToWishlistModel addToWishList = new AddToWishlistModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

        AddToWishlistModel item = JsonSerializer.Deserialize<AddToWishlistModel>(json);

                        addToWishList.eventid = item.eventid;
                        addToWishList.products = item.products;
                        addToWishList.currency = item.currency;
                        addToWishList.url = item.url;
                        addToWishList.eventid = item.eventid;
                        addToWishList.email = item.email;
                        addToWishList.first_name = item.first_name;
                        addToWishList.last_name = item.last_name;
                        addToWishList.phone = item.phone;
                        addToWishList.DOB = item.DOB;
                        addToWishList.city = item.city;
                        addToWishList.state = item.state;
                        addToWishList.country = item.country;
                        addToWishList.user_ip = item.user_ip;
                        addToWishList.browser_user_agent = item.browser_user_agent;
                        addToWishList.clickid = item.clickid;
                        addToWishList.browserid = item.browserid;
                        addToWishList.fb_loginid = item.fb_loginid;
                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }

        public bool CallSubscribeAPI(APIConfigurations api)
        {

            bool rAPI = false;
            SubscribeModel subscribe = new SubscribeModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

                SubscribeModel item = JsonSerializer.Deserialize<SubscribeModel>(json);
                        subscribe.eventid = item.eventid;
                        subscribe.predicted_itv = item.predicted_itv;
                        subscribe.currency = item.currency;
                        subscribe.value = item.value;
                        subscribe.url = item.url;
                        subscribe.email = item.email;
                        subscribe.first_name = item.first_name;
                        subscribe.last_name = item.last_name;
                        subscribe.phone = item.phone;
                        subscribe.DOB = item.DOB;
                        subscribe.city = item.city;
                        subscribe.state = item.state;
                        subscribe.country = item.country;
                        subscribe.user_ip = item.user_ip;
                        subscribe.browser_user_agent = item.browser_user_agent;
                        subscribe.clickid = item.clickid;
                        subscribe.browserid = item.browserid;
                        subscribe.fb_loginid = item.fb_loginid;
                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }


    }
     

    
}
