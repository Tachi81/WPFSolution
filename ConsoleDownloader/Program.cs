using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ConsoleDownloader
{
    class Program
    {



        static void Main(string[] args)
        {
            List<string> listaLinkow = new List<string>();
            Console.WriteLine("Podaj ścieżkę");
            var path = Console.ReadLine();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    listaLinkow.AddRange(reader.ReadToEnd().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                }

                using (var client = new WebClient())
                {
                    foreach (var link in listaLinkow)
                    {
                        var lastSlashIndex = link.LastIndexOf("/", StringComparison.Ordinal);
                        Console.WriteLine($"Pobieram plik z adresu: {link}");
                        client.DownloadFile(new Uri(link), link.Substring(lastSlashIndex + 1, link.Length - lastSlashIndex - 1));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik nie został znaleziony");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.ReadKey();
        }
    }
}
