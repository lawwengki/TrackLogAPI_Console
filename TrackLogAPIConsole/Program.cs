using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using TrackLogAPIConsole.Classes;
using TrackLogAPIConsole.Models;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Data;
using System.Configuration;

namespace TrackLogAPIConsole
{
    class Program : APIConfigurations
    {
        public static string credential;
        public static string url;
        static void Main(string[] args)
        {
            Start:

            if (!readConfig())
            {
                Console.Write("Error in reading config file.\n ");
                Console.WriteLine("Do you want to try again? ([Y/N] ");
                ConsoleKey response = Console.ReadKey(false).Key;
                if (response == ConsoleKey.Y)
                {
                    goto Start;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            // 1). Please select on of the api in the list.             
            Console.Write("" +
            "[1] GetAddtoCart\n" +
            "[2] GetPageView\n" +
            "[3] GetPurchase\n" +
            "[4] GetCompleteRegistration\n" +
            "[5] GetInitiateCheckOut\n" +
            "[6] GetPaymentInfo\n" +
            "[7] GetSearch\n" +
            "[8] GetAddToWishList\n" +
            "[9] GetSubscribe\n" +
            "[0] ResetAllEventsData\n");
            Console.Write("Please enter API functions Name: ");
            string argFunc = Console.ReadLine();


            if (args.Length != 0 && Convert.ToInt32(argFunc) < 10)
            {
                Console.WriteLine("Please enter valid functions number.");
                return;
            }
            bool rResult = false;
            string funcName = "";
            switch (argFunc)
            {
                case "1":
                    funcName = "api/TrackLog/GetAddtoCart";
                    break;
                case "2":
                    funcName = "api/TrackLog/GetPageView";
                    break;
                case "3":
                    funcName = "api/TrackLog/GetPurchase";
                    break;
                case "4":
                    funcName = "api/TrackLog/GetCompleteRegistration";
                    break;
                case "5":
                    funcName = "api/TrackLog/GetInitiateCheckOut";
                    break;
                case "6":
                    funcName = "api/TrackLog/GetPaymentInfo";
                    break;
                case "7":
                    funcName = "api/TrackLog/GetSearch";
                    break;
                case "8":
                    funcName = "api/TrackLog/GetAddToWishList";
                    break;
                case "9":
                    funcName = "api/TrackLog/GetSubscribe";
                    break;
                case "0":
                    funcName = "api/TrackLog/ResetAllEventsData";
                    break;
                default:
                    return;
            }

            // e.g string apiUrl = "http://localhost:26404/";
            //Console.Write("Please enter API URL :");
            //string url = Console.ReadLine();


            APIConfigurations apiconfig = new APIConfigurations();
            apiconfig.APIUrl = url;
            apiconfig.APIfunc = funcName;
            apiconfig.Credentials = credential;

            CallWebAPI cWebAPI = new CallWebAPI();
            //call api class
            if (argFunc == "1")
            {
                rResult = cWebAPI.CallAddtoCartAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }
            }
            else if (argFunc == "2")
            {
                rResult = cWebAPI.CallPageViewAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!!\n "); }
            }
            else if (argFunc == "3")
            {

                rResult = cWebAPI.CallPurchaseAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }

            }
            else if (argFunc == "4")
            {
                rResult = cWebAPI.CallCompleteRegistrationAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful.\n ");
                }
                else { Console.Write("Something Wrong!! \n"); }
            }
            else if (argFunc == "5")
            {
                rResult = cWebAPI.CallInitiateCheckOuAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }

            }
            else if (argFunc == "6")
            {
                rResult = cWebAPI.CallPaymentInfoAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }
            }
            else if (argFunc == "7")
            {
                rResult = cWebAPI.CallSearchAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful.\n ");
                }
                else { Console.Write("Something Wrong!!\n "); }
            }
            else if (argFunc == "8")
            {
                rResult = cWebAPI.CallAddToWishListAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful.\n ");
                }
                else { Console.Write("Something Wrong!!\n "); }
            }
            else if (argFunc == "9")
            {
                rResult = cWebAPI.CallSubscribeAPI(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }
            }
            else if (argFunc == "0")
            {
                rResult = cWebAPI.ResetAllEventsData(apiconfig);
                if (rResult)
                {
                    Console.Write("Successful. \n");
                }
                else { Console.Write("Something Wrong!! \n"); }
            }
            goto Start;
        }

        public static bool readConfig()
        {
            try
            {
                url = ConfigurationManager.AppSettings["ApiUrl"];
                credential = ConfigurationManager.AppSettings["Credential"];

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(credential))
                {
                    Console.WriteLine("Configuration cannot be null value. \n");
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in reading app config" + ex.Message);
                return false;
            }

            return true;
        }


    }
}
