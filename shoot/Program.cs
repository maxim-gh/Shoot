using System;

namespace shoot
{
    class Program
    {
        static void Main(string[] args)
        {
            var ak47 = new Ak47();
            var m4a1 = new M4a1();
            var m4a4 = new M4a4();
            var scar = new Scar();
            var famas = new Famas();


            var visitor = new Visitor[4]
            {
                new Military
                {
                    FullName = "Павлов Павел Павлович",
                    Dob = 27,
                    Gender = true,
                    Military = true,
                    Tow = "m4a1"
                },
                new Civil
                {
                    FullName = "Владимиров Владимир Владимирович",
                    Dob = 19,
                    Gender = true,
                    Tow = "m4a4",
                    GunLicense = false
                },
                new Civil
                {
                    FullName = "Иванов Иван Иванович",
                    Dob = 16,
                    Gender = true,
                    Tow = "ak47",
                    GunLicense = false
                },
                new Military
                {
                    FullName = "Петрова Петра Петровна",
                    Dob = 35,
                    Gender = false,
                    Military = true,
                    Tow = "scar"
                }
            };

            foreach(var element in visitor)
            {
                Console.WriteLine($"{element.FullName} запросил оружие");
                if (element.Dob >= 18 && ( element.Military == true|| element.GunLicense == true))
                {
                    Console.WriteLine($"{element.FullName} получил {element.Tow}");
                    Console.WriteLine($"{element.FullName} начинает стрелять");
                    if (element.Tow == "ak47")
                    {
                        ak47.Shoot();
                        ak47.Name();
                    }
                    if (element.Tow == "m4a1")
                    {
                        m4a1.Shoot();
                        m4a1.Name();
                    }
                    if (element.Tow == "m4a4")
                    {
                        m4a4.Shoot();
                        m4a4.Name();
                    }
                    if (element.Tow == "scar")
                    {
                        scar.Shoot();
                        scar.Name();
                    }
                    if (element.Tow == "famas")
                    {
                        famas.Shoot();
                        famas.Name();
                    }
                }
                else if (element.Dob < 18)
                {
                    Console.WriteLine($"{element.FullName} не может стрелять в тире. Причина - несовершеннолетний.");
                    Console.WriteLine();
                }
                else if (element.GunLicense == false )
                {
                    Console.WriteLine($"{element.FullName} не может стрелять в тире. Причина - отсутсвие лицензии.");
                    Console.WriteLine();
                }
            }
        }
    }
}
