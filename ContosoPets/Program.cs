using System;
using System.Linq;
using MusicShare.Data;
using MusicShare.Models;

namespace MusicShare
{
    class Program
    {
        static void Main(string[] args)
        {
            using MusicShareContext context = new MusicShareContext();

            Song p1 = new Song() { Name = "Squeaky Dog Bone", ArtistId = 6 };
            context.Songs.Add(p1);

            Song p2 = new Song() { Name = "Tennis Ball", ArtistId = 3 };
            context.Songs.Add(p2);


            context.SaveChanges();


            var products = context.Songs
                .Where(p => p.ArtistId >= 3);

            foreach (var p in products)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.ArtistId}");
                Console.WriteLine(new string('-', 20));
            }


            var editp = context.Songs
                .Where(p => p.Name == "Tennis Ball")
                .FirstOrDefault();

            if (editp is Song)
            {
                editp.ArtistId = 10;
            }
            context.SaveChanges();

            products = context.Songs
    .Where(p => p.ArtistId >= 3);

            foreach (var p in products)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Price: {p.ArtistId}");
                Console.WriteLine(new string('-', 20));
            }

            context.Songs.RemoveRange(products);
            context.SaveChanges();


        }
    }
}
