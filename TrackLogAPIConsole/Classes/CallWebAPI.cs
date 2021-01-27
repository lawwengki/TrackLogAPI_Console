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
            //List<AddtoCartModel>  addtocart = new List<AddtoCartModel>();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
     Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

                List<AddtoCartModel> itemlst = JsonSerializer.Deserialize<List<AddtoCartModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (AddtoCartModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("total_value:" + item.total_value);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }

        public bool CallPageViewAPI(APIConfigurations api)
        {

            bool rAPI = false;
            //   PageViewModel pageview = new PageViewModel();
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);

                List<PageViewModel> itemlst = JsonSerializer.Deserialize<List<PageViewModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (PageViewModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<PurchaseModel> itemlst = JsonSerializer.Deserialize<List<PurchaseModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (PurchaseModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("total_value:" + item.total_value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<CompleteRegistrationModel> itemlst = JsonSerializer.Deserialize<List<CompleteRegistrationModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (CompleteRegistrationModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("content_name:" + item.content_name);
                        Console.WriteLine("reg_status:" + item.reg_status);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("total_value:" + item.total_value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<InitiateCheckoutModel> itemlst = JsonSerializer.Deserialize<List<InitiateCheckoutModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (InitiateCheckoutModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("total_value:" + item.total_value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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


                List<SearchModel> itemlst = JsonSerializer.Deserialize<List<SearchModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (SearchModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("search_str:" + item.search_str);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("value:" + item.value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<AddPaymentInfoModel> itemlst = JsonSerializer.Deserialize<List<AddPaymentInfoModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (AddPaymentInfoModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("value:" + item.value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<AddToWishlistModel> itemlst = JsonSerializer.Deserialize<List<AddToWishlistModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (AddToWishlistModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("products:" + item.products);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("value:" + item.value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

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

                List<SubscribeModel> itemlst = JsonSerializer.Deserialize<List<SubscribeModel>>(json);

                if (itemlst.Count > 0)
                {
                    Console.WriteLine("===============Result================");
                    foreach (SubscribeModel item in itemlst)
                    {

                        Console.WriteLine("eventid:" + item.eventid);
                        Console.WriteLine("predicted_itv:" + item.predicted_itv);
                        Console.WriteLine("currency :" + item.currency);
                        Console.WriteLine("value:" + item.value);
                        Console.WriteLine("url:" + item.url);
                        Console.WriteLine("email:" + item.email);
                        Console.WriteLine("first_name :" + item.first_name);
                        Console.WriteLine("phone :" + item.phone);
                        Console.WriteLine("DOB :" + item.dob);
                        Console.WriteLine("city:" + item.city);
                        Console.WriteLine("state:" + item.state);
                        Console.WriteLine("country:" + item.country);
                        Console.WriteLine("user_ip :" + item.user_ip);
                        Console.WriteLine("browser_user_agent :" + item.browser_user_agent);
                        Console.WriteLine("clickid :" + item.clickid);
                        Console.WriteLine("browserid:" + item.browserid);
                        Console.WriteLine("fb_loginid :" + item.fb_loginid);
                        Console.WriteLine("\n");

                    }
                    Console.WriteLine("=============== End Result=============");
                }

                rAPI = true;
            }
            Console.WriteLine();
            return rAPI;
        }
        public bool ResetAllEventsData(APIConfigurations api)
        {
            bool rAPI = false;
            using (WebClient webClient = new WebClient())
            {
                webClient.BaseAddress = api.APIUrl;
                webClient.Headers["Content-type"] = "application/json";
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.Authorization,
    Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(api.Credentials)));
                var json = webClient.DownloadString(api.APIfunc);
                RVal item = JsonSerializer.Deserialize<RVal>(json);


                if (item.rStatus)
                {
                    Console.WriteLine("===============Result================");
                    Console.WriteLine("Data has been reset.");
                    Console.WriteLine("=============== End Result=============");

                    rAPI = true;
                }
                else {
                    Console.WriteLine("===============Result================");
                    Console.WriteLine("Data reset Failed. Please try again. ");
                    Console.WriteLine("=============== End Result=============");
                }


                return rAPI;
            }
            
        }
    }

}

        
