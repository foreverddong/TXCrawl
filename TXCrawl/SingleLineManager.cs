using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TXCrawl
{
    public delegate void _LogData(string data);
    public class SingleLineManager
    {
       
        public event _LogData logData = null;
        public string source;
        public string destination;
        public DateTime date;
        public List<DirectTicket> ticketsToday = new List<DirectTicket>();
        public Cabin cabin;
        public bool headless = true;

        public string GenerateURL()
        {
            var head = @"https://www.tianxun.com/transport/flights/";
            var sd = source + @"/" + destination + @"/";
            var datestring = this.date.ToString("yyMMdd") + @"/";
            var passenger = @"?adultsv2=1&childrenv2=";
            var cabStr = @"&cabinclass=" + ((this.cabin == Cabin.BUSINESS) ? "BUSINESS" : "ECONOMY");
            var tail = @"&rtn=0&preferdirects=true&outboundaltsenabled=false&inboundaltsenabled=false";
            string res = String.Join(@"",head,sd,datestring,passenger,cabStr,tail);
            return res;
        }

        //NOTE: This function will change the internal state of the object
        public void QueryTickets(string url)
        {
            ChromeOptions option = new ChromeOptions();
            if(headless) option.AddArguments("--headless");
            //ChromeDriver driver = new ChromeDriver(option);
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(this.GenerateURL());
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//span[contains(@class, 'SummaryInfo_itineraryCountContainer')]")));
            var html = driver.PageSource;
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            var validNode = doc.DocumentNode.SelectSingleNode(@"//input[contains(@name, 'direct')]");
            var valid = validNode.Attributes.Contains("checked");
            if (!valid) {
                logData?.Invoke($"No direct flights found for {this.source}->{this.destination} on {this.date.ToShortDateString()}");
                driver.Quit();
                return;
            }
            var ticketNodes = doc.DocumentNode.SelectNodes(@"//div[contains(@class, 'FlightsTicket_container__3yvwg')]");
            logData?.Invoke($"Direct flight(s) found for {this.source}->{this.destination} on {this.date.ToShortDateString()}");
            foreach (HtmlNode node in ticketNodes)
            {
                var priceNode = node.SelectSingleNode(@".//div[contains(@class,'Price_mainPriceContainer__1dqsw')]").ChildNodes[0];
                string detailLink = @"https://www.tianxun.com" + node.FirstChild.Attributes["href"].Value;
                ChromeDriver detailDriver = new ChromeDriver();
                detailDriver.Navigate().GoToUrl(detailLink);
                var detailWait = new WebDriverWait(detailDriver, TimeSpan.FromSeconds(20));
                detailWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"//span[contains(@class,'localTimeNotice')]")));
                detailDriver.FindElementByClassName("LegSummary_chevron__1pbHt").Click();
                System.Threading.Thread.Sleep(100);
                HtmlDocument detailDoc = new HtmlDocument();
                detailDoc.LoadHtml(detailDriver.PageSource);
                bool plusone = detailDoc.DocumentNode.SelectSingleNode(@"//span[contains(@class,'TimeWithOffsetTooltip')]") != null;
                var timeNodeList = detailDoc.DocumentNode.SelectSingleNode(@"//div[contains(@class,'LegInfo_legInfo__3kbZa')]").SelectNodes(@".//span[contains(@class,'BpkText_bpk-text__2NHsO BpkText_bpk-text--lg__3vAKN')]");
                var generalNode = detailDoc.DocumentNode.SelectSingleNode(@"//div[contains(@class,'AirlineLogoTitle_container__2k6xV')]");
                var numNode = generalNode.ChildNodes[2];
                var nameNode = generalNode.ChildNodes[0].ChildNodes[1];
                DirectTicket ticket = new DirectTicket
                {
                    carrier = nameNode.InnerText.Replace("&nbsp;", ""),
                    flightNum = numNode.InnerText,
                    source = this.source,
                    destination = this.destination,
                    price = int.Parse(priceNode.InnerText.Replace("¥", "").Replace(",", "")),
                    targetLink = detailLink
                };
                logData?.Invoke($"Ticket {ticket.carrier} from {ticket.source} to {ticket.destination} carrier {ticket.carrier} found.");
                int hourDepart = int.Parse(timeNodeList[1].InnerText.Split(':')[0]);
                int minuteDepart = int.Parse(timeNodeList[1].InnerText.Split(':')[1]);
                int hourArrival = int.Parse(timeNodeList[3].InnerText.Split(':')[0]);
                int minuteArrival = int.Parse(timeNodeList[3].InnerText.Split(':')[1]);
                DateTime DepartDT = this.date + new TimeSpan(hourDepart, minuteDepart, 0);
                DateTime ArriveDT = this.date + new TimeSpan(hourArrival, minuteArrival, 0);
                if (plusone) ArriveDT = ArriveDT.AddDays(1);
                ticket.departure = DepartDT; ticket.arrival = ArriveDT;
                Console.WriteLine(detailLink);
                this.ticketsToday.Add(ticket);
                detailDriver.Quit();
            }
            driver.Quit();
        }

        public override string ToString()
        {
            return $"{this.date.ToShortDateString()} {this.source}->{this.destination}";
        }
    }


    public class DirectTicket
    {
        public string carrier;
        public string flightNum;
        public DateTime departure;
        public DateTime arrival;
        public string source;
        public string destination;
        public int price;
        public string targetLink;

        public override string ToString()
        {
            return $"{this.flightNum} {this.departure.ToShortDateString()} {this.departure.ToShortTimeString()} {this.source}->{this.destination}";
        }
    }

    public enum Cabin
    { 
        ECONOMY,
        BUSINESS
    }

}
