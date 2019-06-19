using System;
using System.Collections.Generic;

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            carLot cars = new carLot("main");
            cars.add(new Car("irjbf", "hyundai", "elantra", 1500, 4, "coop"));
            cars.add(new Car("huh", "hyundai", "sonata", 2000, 4, "small"));
            cars.add(new Truck("yes", "chevy", "silverado", 3000,10));
            cars.printLot();
        }
    }

    public class carLot
    {
        string name;
        List<Vehicle> vehicles = new List<Vehicle>();
        public carLot(string nam)
        {
            name = nam;
        }
        public void add(Vehicle thisVehicle)
        {
            vehicles.Add(thisVehicle);
        }
        public void printLot()
        {
            foreach(Vehicle car in vehicles)
            {
                Console.WriteLine(car.getDescription());
            }
        }
    }
    public abstract class Vehicle
    {
        string license;
        string make;
        string model;
        int price;
        public Vehicle(string lic, string mak, string mod, int pric)
        {
            license = lic;
            make = mak;
            model = mod;
            price = pric;
        }
        public string getDescription()
        {
            return "\nmake: " + make + "\nmodel: " + model + "\nLicense: " + license + "\nPrice: " + price; 
        }
    }

    public class Car : Vehicle
    {
        string type;
        int doors;
        public Car(string lic,string mak, string mod, int pric, int door, string typ):base(lic,mak,mod,pric)
        {
            type = typ;
            doors = door;
        }
    }
    public class Truck : Vehicle
    {
        int bedSize;
        public Truck(string lic, string mak, string mod, int pric, int bed) : base(lic, mak, mod, pric)
        {
            bedSize = bed;
        }
    }
}
