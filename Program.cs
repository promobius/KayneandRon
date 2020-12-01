using System;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace KayneandRon
{
    class Program
    {
        static void Main(string[] args)
        {
        


            for(int i = 0; i < 10; i++)
            {
                QuoteGenerator.KanyeQuote();
                Thread.Sleep(3000);
                QuoteGenerator.RonQuote();
                Thread.Sleep(3000);
            }
         
         
        }
       
            
    }
}
