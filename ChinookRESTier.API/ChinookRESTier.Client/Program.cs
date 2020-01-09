using System;
using System.Threading.Tasks;
using ChinookRESTier.Client.Models;
using Simple.OData.Client;

namespace ChinookRESTier.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new ODataClient("https://localhost:44330/");

            var artists = await client.FindEntriesAsync("Artists");
            foreach (var artist in artists)
            {
                Console.WriteLine(artist["Name"]);
            }

            Console.ReadKey();

            Console.Clear();

            var albums = await client
                .For<Album>()
                .Filter(x => x.Title == "Nevermind")
                .Expand("Tracks")
                .OrderBy(a => a.Tracks)
                .FindEntriesAsync();
            foreach (var album in albums)
            {
                foreach (var track in album.Tracks)
                {
                    Console.WriteLine(track.Name);
                }
            }

            Console.ReadKey();
        }
    }
}