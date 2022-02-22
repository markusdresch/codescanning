using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        private int _x;

        public int X
        {
            get { return _x; }
            // no setter
            set { }
        }

        static void Main(string[] args)
        {
            var password = "abc";

            if (password == "abc")
            {
                Console.WriteLine("Hello World!");
            }

            // no server cert validation
            ServicePointManager.DefaultConnectionLimit = 100;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            // tempfile instead of randomfile
            var tempFileName = Path.GetTempFileName();


            // command injection
            var p = new Process();
            p.StartInfo.FileName = "exportLegacy.exe";
            p.StartInfo.Arguments = " -user " + args[0] + " -role user";
            p.Start();


            // xpath injection
            var doc = new XmlDocument { XmlResolver = null };
            doc.Load("/config.xml");
            var results = doc.SelectNodes("/Config/Devices/Device[id='" + args[0] + "']");


            // weak hash
            var hashProvider = new SHA1CryptoServiceProvider();
            var hash = hashProvider.ComputeHash(Encoding.UTF8.GetBytes(args[0]));



            // endless loop
            var i = 0;
            while (true)
            {
                i++;
            }

        }
    }
}
