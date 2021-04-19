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
    }
}
public class M4a1 : Weapon
{
    public void Name()
    {
        Console.WriteLine("m4a1.");
    }
}
public class M4a4 : Weapon
{
    public void Name()
    {
        Console.WriteLine("m4a4.");
    }
}
public class Scar : Weapon
{
    public void Name()
    {
        Console.WriteLine("scar.");
    }
}
public class Famas : Weapon
{
    public void Name()
    {
        Console.WriteLine("famas.");
    }
}