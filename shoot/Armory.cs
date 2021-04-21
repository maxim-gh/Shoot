using System;

public class Weapon
{
    public void Shoot()
    {
        Console.Write("Выстрел из автомата - ");
    }
}
public class Ak47 : Weapon
{
    public void Name()
    {
        Console.WriteLine("Ak47.");
        Console.WriteLine();
    }
}
public class M4a1 : Weapon
{
    public void Name()
    {
        Console.WriteLine("m4a1.");
        Console.WriteLine();
    }
}
public class M4a4 : Weapon
{
    public void Name()
    {
        Console.WriteLine("m4a4.");
        Console.WriteLine();
    }
}
public class Scar : Weapon
{
    public void Name()
    {
        Console.WriteLine("scar.");
        Console.WriteLine();
    }
}
public class Famas : Weapon
{
    public void Name()
    {
        Console.WriteLine("famas.");
        Console.WriteLine();
    }
}