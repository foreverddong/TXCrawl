using System;

namespace TXCrawl
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            SingleLineManager testm = new SingleLineManager
            {
                source = "JFK",
                destination = "ICN",
                date = DateTime.Today.AddDays(16),
                cabin = Cabin.BUSINESS
            };

            /* SingleLineManager testm = new SingleLineManager
            {
                source = "JFK",
                destination = "PEK",
                date = DateTime.Today.AddDays(2),
                cabin = Cabin.BUSINESS
            }; */

            

            testm.QueryTickets(testm.GenerateURL());

            Console.WriteLine(testm.GenerateURL());
        }
    }

    
}
