using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppp
{
    class HlamFrom_programm
    {
        //Selenium WebDriver

        // IWebDriver webDriwer = new OpenQA.Selenium.Chrome.ChromeDriver();

        //webDriwer.Navigate().GoToUrl("https://www.o2online.de/e-shop/dsl-festnetz");
        //webDriwer.Manage().Window.Maximize();
        ////webDriwer.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //WebDriverWait waitFor = new WebDriverWait(webDriwer,TimeSpan.FromSeconds(5));

        //for (int i = 1067; i <= 1100; i++)
        //{
        //    string zipToString = Convert.ToString(i.ToString("00000"));
        //    Console.WriteLine(zipToString);

        //     IWebElement znElement = webDriwer.FindElement(By.Id("dslAvailabilityCheckAddressPostCode"));
        //     znElement.Click();
        //     znElement.Clear();
        //     znElement.SendKeys(zipToString);

        //     var spanCityElement = webDriwer.FindElement(By.XPath("//body/span[1]/div[last()]")).GetAttribute("textContent");
        // //waitFor.Until(ExpectedConditions.InvisibilityOfElementWithText(By.XPath("//body/span[1]/div[last()][text()]"), "No search results."));
        // //(driver =>
        // //    driver.FindElement(By.XPath("//body/span[1]/div[last()]")).GetAttribute("textContent")); //webDriwer.FindElement(By.XPath("//body/span[1]/div[last()]"));
        // string test2Element = spanCityElement;

        //     if (spanCityElement == "No search results.")
        //     {
        //         Console.WriteLine("no city with it zipcode");
        //         continue;
        //     }

        //     IWebElement inputElement =
        //         waitFor.Until(ExpectedConditions.ElementExists(By.Id("dslAvailabilityCheckAddressCity")));//webDriwer.FindElement(By.Id("dslAvailabilityCheckAddressCity"));


        //     inputElement.Click();
        //     inputElement.Clear();
        //     inputElement.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
        //     List<IWebElement> ssnElement = webDriwer.FindElements(By.XPath("//ul[contains(@id,'ui-id-1')]/li[text()]")).ToList();



        //     string[] somElements = new string[ssnElement.Count];

        //     for (int j = 0; j < ssnElement.Count; j++)
        //     {

        //         somElements[j] = ssnElement[j].Text;
        //     }

        //     inputElement.Click();
        //     inputElement.SendKeys(OpenQA.Selenium.Keys.ArrowRight);
        //     inputElement.SendKeys(OpenQA.Selenium.Keys.Tab);


        //     for (int j = 0; j < somElements.Length; j++)
        //     {
        //         inputElement.Clear();
        //         //inputElement.Click();
        //         //inputElement.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
        //         inputElement.SendKeys(somElements[j]);


        //         IWebElement inputStreet =
        //             waitFor.Until(ExpectedConditions.ElementExists(By.Id("dslAvailabilityCheckAddressStreet"))); //webDriwer.FindElement(By.Id("dslAvailabilityCheckAddressStreet"));
        //         inputStreet.Click();
        //         inputStreet.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
        //         inputStreet.SendKeys(OpenQA.Selenium.Keys.ArrowDown);


        //         IWebElement spanStreetElement = webDriwer.FindElement(By.XPath("//body/span[2]/div[last()]"));
        //             //waitFor.Until(ExpectedConditions.ElementExists(By.XPath("//body/span[2]/div[last()]")));
        //         string testElement = spanStreetElement.GetAttribute("textContent");
        //         //Console.WriteLine(testElement);
        //         if (testElement != "No search results.")
        //         {
        //             List<IWebElement> snElement = webDriwer.FindElements(By.XPath("//ul[@id='ui-id-2']/li[text()]")).ToList();
        //             foreach (var VARIABLEsn in snElement)
        //             {
        //                 Console.WriteLine(VARIABLEsn.GetAttribute("textContent"));
        //             }
        //             snElement.Clear();
        //             inputStreet.Clear();
        //         }
        //         else
        //         {
        //             Console.WriteLine("snElement = null");
        //         }

        //     }

        // }



        //Selenium WebDriver




        //TELECOM.DE hn



        //var container = new Funq.Container();
        //AppConfig.Initialize(container);


        //IAddressService _addressService = container.Resolve<IAddressService>();
        //IRepoAddress _repoAddress = container.Resolve<IRepoAddress>();



        //var test = _repoAddress.GetEmptyHousesList(5);
        //int counter = 0;
        //while (test.Any())
        //{
        //    Console.WriteLine(DateTime.Now);

        //    foreach (var VARIABLE in test)
        //    {
        //        try
        //        {
        //            var myRequest =
        //                $@"https://www.telekom.de/autocomplete/v1/housenumbers?zipcode={VARIABLE.zc}&city={VARIABLE.cn}&street={VARIABLE.sn}";
        //            WebRequest reqGETHh = WebRequest.Create(myRequest);
        //            WebResponse respHh = reqGETHh.GetResponse();
        //            Stream streamHh = respHh.GetResponseStream();
        //            StreamReader srHh = new StreamReader(streamHh);
        //            string sHh = srHh.ReadToEnd();
        //            var modelsHh = sHh.FromJson<List<HhViewModel>>()
        //                .Where(x => x.HouseNumber != "0")
        //                .Select(number => number.HouseNumber + number.HouseNumberAdditional);

        //            VARIABLE.hn = modelsHh.ToArray();

        //            counter++;
        //            Console.WriteLine(counter);
        //        }
        //        catch (WebException ex)
        //        {
        //            VARIABLE.ec = (int) ((HttpWebResponse) ex.Response).StatusCode;
        //            VARIABLE.hn = new string[] { };
        //        }

        //        _repoAddress.Save(VARIABLE);
        //    }
        //    test = _repoAddress.GetEmptyHousesList(5);
        //}

        //Console.WriteLine(DateTime.Now);
        //Console.WriteLine("complete");

        //Console.ReadKey();


        //TELECOM.DE hn





        //GRABBING

        //Выбор номеров домов по данным запроса


        //string ChangeUri(string zipcode, string city, string street)
        //{
        //    string zipCodeInStringFormat = zipStartValue;
        //    //Console.WriteLine(zipCodeInString.GetType());
        //    return $@"https://www.telekom.de/autocomplete/v1/housenumbers?zipcode={zipCodeInStringFormat}&city={cityStartValue}&street={streetStartValue}";
        //}



        //long startId = 1;

        //WebRequest reqGETHh = WebRequest.Create(ChangeId(startId));
        //WebResponse respHh = reqGETHh.GetResponse();
        //Stream streamHh = respHh.GetResponseStream();
        //StreamReader srHh = new StreamReader(streamHh);
        //string sHh = srHh.ReadToEnd();
        //var modelsHh = sHh.FromJson<List<Address>>();


        //for (int i = 0; i < 10; i++)
        //{

        //    WebRequest reqGETHh = WebRequest.Create(ChangeId(startId));
        //    WebResponse respHh = reqGETHh.GetResponse();
        //    Stream streamHh = respHh.GetResponseStream();
        //    StreamReader srHh = new StreamReader(streamHh);
        //    string sHh = srHh.ReadToEnd();
        //    var modelsHh = sHh.FromJson<List<Address>>();

        //    Console.WriteLine(modelsHh.ToString());

        //    var itemHouse = from houseNumber in modelsHh
        //                    select new Address()
        //                    {
        //                        Id = startId,
        //                        hn = houseNumber.hn
        //                    };
        //    string[] arr = itemHouse.Select(n => n.ToString()).ToArray();
        //    var saveHouseNumber = _repoAddress.Get(startId);
        //    saveHouseNumber.hn = arr;
        //    _repoAddress.Save(saveHouseNumber);
        //    startId++;
        //    Console.WriteLine("complete");

        //Выбор номеров домов по данным запроса





        //AddAddress();

        //WebRequest reqGETHh = WebRequest.Create(@"https://www.telekom.de/autocomplete/v1/housenumbers?zipcode=01067&city=Dresden&street=Alfred-Althus-Str.");
        //WebResponse respHh = reqGETHh.GetResponse();
        //Stream streamHh = respHh.GetResponseStream();
        //StreamReader srHh = new StreamReader(streamHh);
        //string sHh = srHh.ReadToEnd();
        //var modelsHh = sHh.FromJson<List<HhViewModel>>();


        //var item = from addHouses in modelsHh

        //    select new Address()
        //    {
        //        Id = addHouses.Id,


        //        hn = addHouses.HouseNumber 
        //    };

        //var complex = from com in models
        //    join address in modelsHh on com.Id equals address.Id
        //    select new Address()
        //    {
        //        Id = com.Id,
        //        zc = com.ZipCode,
        //        cn = com.City,
        //        ds = com.District,
        //        sn = com.Street,
        //        hn = address.HouseNumber
        //    };

        ////void AddHousesNumber(long id)
        ////{
        ////    var itemadd = from str in modelsHh
        ////        where (str.Id == id)
        ////        select new Address()
        ////        {
        ////            hn = str.HouseNumber
        ////        };
        ////    AddAddress();
        ////}


        //void AddHouse()
        //{
        //    foreach (var VARIABLE in item)
        //    {
        //        _addressService.DbAddress(VARIABLE);
        //    }
        //}

        //AddHouse();




    }
}
