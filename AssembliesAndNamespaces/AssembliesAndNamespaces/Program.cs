using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This text came from AssembliesAndNamespace solution";

            System.IO.File.WriteAllText(@"C:\Users\abelm\Desktop\c-sharp-basics\WriteText.txt",text);


            WebClient client=new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");
            Console.WriteLine(reply);
            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
