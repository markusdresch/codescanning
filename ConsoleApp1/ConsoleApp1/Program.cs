using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;

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


            // endless loop
            var i = 0;
            while (true)
            {
                i++;
            }

        }
    }
}
