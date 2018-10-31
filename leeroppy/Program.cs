using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace leeroppy
{
    class Program
    {
        private const string IMAGE_BASE_URL = "https://postimg.cc/image/";
        private const string IMAGE_URL = "https://postimg.cc/image/5l1k4sryl";

        private const string BASE_URL = "https://postimg.cc/image/";
        private const string URL = "https://postimg.cc/image/5l1k4sryl";
        
        private const string FILE_PATH = @"D:\mines\leeroppy.txt";
        
        private static List<char> symbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
            'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static List<char> lowerSymbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
            'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private static List<char> digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        private static List<string> leeroppy;
        private static bool isBaseExist = true;

        static void Main(string[] args)
        {
            leeroppy = new List<string>();
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Check();
                }
                CheckBase();
            }
            while (isBaseExist);
            leeroppy.ForEach(x => WriteToFile(x));
            Console.ReadLine();
        }

        private static void Check()
        {
            var rnd = new Random();
            string urlPart = "";
            for (int k = 0; k < 8; k++)
            {
                urlPart += lowerSymbols[rnd.Next(0, lowerSymbols.Count)];
            }
            var url = BASE_URL + urlPart;
            var task = RequestAsync(url);
            task.Wait();
        }

        private static void CheckBase()
        {
            var task = RequestBaseAsync();
            task.Wait();
        }

        private static void WriteToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(FILE_PATH, true, Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }

        private static async Task RequestAsync(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    Console.WriteLine(url);
                    WriteToFile(url);
                    //leeroppy.Add(url);
                }
            }
            catch (WebException ex)
            {
                //if (ex.Status == WebExceptionStatus.ProtocolError)
                //{
                //    Console.WriteLine("УПС((" + " - " + url);
                //}
            }
        }
        
        private static async Task RequestBaseAsync()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    Console.WriteLine("Делаем флекс!!!");
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Больше не будет флекса(");
                    isBaseExist = false;
                }
            }
        }
    }
}
