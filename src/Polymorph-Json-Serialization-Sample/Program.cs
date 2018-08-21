using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Album[] albums = ...
            
            Album[] albums =
                {
                    #region new AlbumM()

                    new AlbumM
                        {
                          Name = "M1", Start = DateTime.Now.AddMonths(-1), End = DateTime.Now.AddMonths(2),
                          M1 = DayOfWeek.Monday,
                          Sets = new []
                                    {
                                        new SetX
                                            {
                                                Name = "X." , X1 = "X1..",
                                                Items = new []
                                                {
                                                    new ItemA { Name = "A.", A1 = 1, A2 = 2, Picture = "http://picA." },
                                                    new ItemA { Name = "A..", A1 = 11, A2 = 22, Picture = "http://picA.." }
                                                },
                                            },
                                        new SetX
                                            {
                                                Name = "X..." , X1 = "X1....",
                                                Items = new []
                                                {
                                                    new ItemA { Name = "A...", A1 = 111, A2 = 222, Picture = "http://picA..." },
                                                    new ItemA { Name = "A....", A1 = 1111, A2 = 2222, Picture = "http://picA...." }
                                                },
                                            },
                                    }
                        },

                    #endregion // new AlbumM()

                    #region new AlbumN()

                    new AlbumN
                        {
                          Name = "N1", Start = DateTime.Now.AddMonths(-1), End = DateTime.Now.AddMonths(2),
                          N1 = 8, 
                          Sets = new []
                                    {
                                        new SetY
                                            {
                                                Name = "Y." ,  Y1 = ConsoleColor.Red,
                                                Items = new []
                                                {
                                                    new ItemB { Name = "B.", B1 = true, B2 = DateTime.Now, Picture = "http://picB." },
                                                    new ItemB { Name = "B..", B1 = false, B2 = DateTime.Today, Picture = "http://picB.." }
                                                },
                                            },
                                        new SetY
                                            {
                                                Name = "Y..." , Y1 = ConsoleColor.Blue,
                                                Items = new []
                                                {
                                                    new ItemB { Name = "B.,", B1 = true, B2 = DateTime.Now.AddYears(1), Picture = "http://picB.," },
                                                    new ItemB { Name = "B..,", B1 = true, B2 = DateTime.Today, Picture = "http://picB..," }
                                                },
                                            },
                                    }
                        },

                    #endregion // new AlbumN()

                    #region new AlbumM()

                    new AlbumM
                        {
                          Name = "M2", Start = DateTime.Now.AddMonths(-1), End = DateTime.Now.AddMonths(2),
                          M1 = DayOfWeek.Monday,
                          Sets = new []
                                    {
                                        new SetX
                                            {
                                                Name = "X.--" , X1 = "X1..--",
                                                Items = new []
                                                {
                                                    new ItemA { Name = "A.--", A1 = 1, A2 = 2, Picture = "http://picA.--" },
                                                    new ItemA { Name = "A.--.", A1 = 11, A2 = 22, Picture = "http://picA..--" }
                                                },
                                            },
                                        new SetX
                                            {
                                                Name = "X...--" , X1 = "X1....--",
                                                Items = new []
                                                {
                                                    new ItemA { Name = "A...--", A1 = 111, A2 = 222, Picture = "http://picA...--" },
                                                    new ItemA { Name = "A....--", A1 = 1111, A2 = 2222, Picture = "http://picA....--" }
                                                },
                                            },
                                    }
                        },

                    #endregion // new AlbumM()
                };

            #endregion // Album[] albums = ...

            var setting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
            };

            string json = JsonConvert.SerializeObject(albums, setting);
            albums = JsonConvert.DeserializeObject<Album[]>(json, setting);

            var b = albums.OfType<AlbumN>().ToArray();
            foreach (var album in albums)
            {
                switch (album)
                {
                    case AlbumM m:
                        Console.WriteLine($"Name = {m.Name}, M1={m.M1}, {m.Sets.First().X1}");
                        break;
                    case AlbumN n:
                        Console.WriteLine($"Name = {n.Name}, M1={n.N1}, {n.Sets.First().Y1}");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
