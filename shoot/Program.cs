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

            var civil = new Civil()
            {
                FullName = "Верзилов Максим Александрович",
                Dob = 19,
                Gender = true,
                Tow = "m4a4",
                GunLicense = true
            };
            var military = new Military()
            {
                FullName = "Воронцов Леонид Сергеевич",
                Dob = 27,
                Gender = false,
                Tow = "m4a1"
            };

            Console.WriteLine($"{civil.FullName} запросил оружие");
            if(civil.Dob >= 18 && civil.GunLicense == true)
            {
                Console.WriteLine($"{civil.FullName} получил {civil.Tow}");
                Console.WriteLine($"{civil.FullName} начинает стрелять");
                if(civil.Tow == "ak47")
                {
                    ak47.Shoot();
                    ak47.Name();
                }
                if(civil.Tow == "m4a1")
                {
                    m4a1.Shoot();
                    m4a1.Name();
                }
                if (civil.Tow == "m4a4")
                {
                    m4a4.Shoot();
                    m4a4.Name();
                }
                if (civil.Tow == "scar")
                {
                    scar.Shoot();
                    scar.Name();
                }
                if (civil.Tow == "famas")
                {
                    famas.Shoot();
                    famas.Name();
                }
            }
            else if (civil.Dob < 18)
            {
                Console.WriteLine($"{civil.FullName} не может стрелять в тире. Причина - несовершеннолетний.");
            }
            else if (civil.GunLicense == false)
            {
                Console.WriteLine($"{civil.FullName} не может стрелять в тире. Причина - отсутсвие лицензии.");
            }

            Console.WriteLine($"{military.FullName} запросил оружие");
            if (military.Dob >= 18)
            {
                Console.WriteLine($"{military.FullName} получил {military.Tow}");
                Console.WriteLine($"{military.FullName} начинает стрелять");
                if (military.Tow == "ak47")
                {
                    ak47.Shoot();
                    ak47.Name();
                }
                if (military.Tow == "m4a1")
                {
                    m4a1.Shoot();
                    m4a1.Name();
                }
                if (military.Tow == "m4a4")
                {
                    m4a4.Shoot();
                    m4a4.Name();
                }
                if (military.Tow == "scar")
                {
                    scar.Shoot();
                    scar.Name();
                }
                if (military.Tow == "famas")
                {
                    famas.Shoot();
                    famas.Name();
                }
            }
            else if (military.Dob < 18)
            {
                Console.WriteLine($"{military.FullName} не может стрелять в тире. Причина - несовершеннолетний.");
            }
        }
    }
}
