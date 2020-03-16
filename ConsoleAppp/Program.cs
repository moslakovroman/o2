using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using api.Interfaces;
using api.Repositories;
using api.Servises;
using model.db;
using ServiceStack.Text;
using ConsoleAppp.Config;
using model.ViewModels;
using System.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.UI.WebControls;
using ServiceStack.OrmLite;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;



namespace ConsoleAppp
{

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Funq.Container();
            AppConfig.Initialize(container);
            
            IAddressService _addressService = container.Resolve<IAddressService>();
            IRepoAddress _repoAddress = container.Resolve<IRepoAddress>();

            Console.WriteLine("select operation : 1- grabbing cities, 2- grabbing streets");
            
            int checkKey = Convert.ToInt32(Console.ReadLine());

            if (checkKey != 1 && checkKey != 2)
            {
                Console.WriteLine("wrong choice");
            }

            else
            {
                switch (checkKey)
                {
                    case 1:
                        GetCities();
                        break;
                    case 2:
                        GetStreets();
                        break;
                }
            }
            



            //O2 City grabbing

            void GetCities()
            {
                Console.WriteLine("Cities grabbing");
                var url = "https://www.o2online.de/e-shop/rest/dsl-availability-check/autocompletion/city";

                IEnumerable<Address> model;

                Console.WriteLine("enter value, min value = (1067)");
                int minValue = Convert.ToInt32(Console.ReadLine());
                if (minValue < 1067)
                {
                    minValue = 1067;
                }

                Console.WriteLine("enter value, max value = (99998)");
                int maxValue = Convert.ToInt32(Console.ReadLine());
                if (maxValue > 99998)
                {
                    maxValue = 99998;
                }



                for (int i = minValue; i <= maxValue; i++)
                {
                    string zipCode = Convert.ToString(i.ToString("00000"));

                    using (var client = new HttpClient())
                    {

                        HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, url);

                        var contenteeee =
                        new StringContent($"\"{zipCode}\"", Encoding.UTF8, "application/vnd.commerce.message+json");

                        var respo = client.PostAsync(url, contenteeee);

                        var responseString = respo.Result.Content.ReadAsStringAsync();

                        var city = responseString.Result.ToString();

                        var cn = city
                            .FromJson<List<string>>()
                            .Select(x => new Address() { zc = zipCode, cn = x })
                            .ToList();

                        if (cn.Count == 0)
                        {
                            cn = new List<Address> { new Address { zc = zipCode } };
                        }

                        var o2 = cn;

                        _addressService.SaveAll(o2.ToList());

                        Console.WriteLine(zipCode);
                    }

                }
            }


            // O2 City grabbing




            //O2 Streets grabbing

            void GetStreets()

            {
                Console.WriteLine("Streets grabbing");
                var urlStreet = "https://www.o2online.de/e-shop/rest/dsl-availability-check/autocompletion/street";


                //string zipcode = Convert.ToString(i.ToString("00000"));

                var bdinfo = _addressService.GetAddressInfo();
                

                foreach (var VARIABLE in bdinfo)
                {
                    Console.WriteLine(VARIABLE.Id);
                    Console.WriteLine(VARIABLE.zc);
                    Console.WriteLine(VARIABLE.cn);

                    if (VARIABLE.sn == null)
                    {
                        
                        using (var clientStreet = new HttpClient())
                        {
                            HttpRequestMessage requestMessageStreet = new HttpRequestMessage(HttpMethod.Post, urlStreet);

                            var contentStreet =
                                new StringContent(
                                    ($"{{\"@type\":\"dslAvailabilityCheck:StreetSearchValue\",\"zipCode\":\"{VARIABLE.zc}\",\"city\":\"{VARIABLE.cn}\"}}"
                                    ), Encoding.UTF8, "application/vnd.commerce.message+json");

                            var respoStreet = clientStreet.PostAsync(urlStreet, contentStreet);
                            //var response = client.SendAsync(requestMessage);

                            var responseStringStreet = respoStreet.Result.Content.ReadAsStringAsync();

                            string street = responseStringStreet.Result.ToString();

                            //var stringStreets = street.FromJson<List<string>>();
                            //var addressInfo = new AllDbInfoViewModel();

                            var ssn = street.FromJson<List<string>>()
                                .Select(x => new AllDbInfoViewModel() { zc = VARIABLE.zc, cn = VARIABLE.cn, sn = x })
                                .ToList();

                            //var sn = street
                            //    .FromJson<List<string>>()
                            //    .Select(x => new Address() { zc = VARIABLE.zc, cn = VARIABLE.cn, sn = "done" })
                            //    .ToList();

                            


                            var o2Street = ssn;
                            
                            _addressService.SaveStreets(o2Street);


                            
                            VARIABLE.sn = "done";
                            _repoAddress.Save(VARIABLE);



                        }
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            
            
            // O2 Streets grabbing




















































            Console.WriteLine("complete");
            Console.ReadKey();

        }
    }
}



