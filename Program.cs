//Лаба 2.8
using System;

class veh//车辆类别
{
    private int pri_passengers;

    public int Passengers
    {
        get { return pri_passengers; }
        set { pri_passengers = value; }
    }

    private int fuel;//燃料
    public int Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }

    private int mil;//每加仑里程
    public int Mil
    {
        get { return mil; }
        set { mil = value; }
    }

    public veh(int p, int f, int m)
    {
        Passengers = p;
        Fuel = f;
        Mil = m;
    }
}

class Truck : veh
{
    private int cargo;//载货量

    public int Cargo//载货量
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public Truck(int p, int f, int m, int c) : base(p, f, m)
    {
        Cargo = c;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Пожалуйста, введите расстояние:");//请输入行驶距离: 
        int distance = int.Parse(Console.ReadLine()); // 读取用户输入的行驶距离

        Truck cargoVan = new Truck(2, 100, 20, 500);
        Truck pickupTruck = new Truck(4, 120, 18, 1000);

        Console.WriteLine("Грузоподъемность грузовика:" + cargoVan.Cargo);//货车的承载能力: 
        Console.WriteLine("Грузоподъемность пикапа: " + pickupTruck.Cargo);//皮卡车的承载能力:
        //行驶x英里所需的燃油量:
        Console.WriteLine("Количество топлива, необходимое для проезда" + distance + "миль");

        Console.WriteLine("Грузовик: " + cargoVan.Fuel * cargoVan.Mil / distance);
        Console.WriteLine("Пикапы: " + pickupTruck.Fuel * pickupTruck.Mil / distance);
    }
}
