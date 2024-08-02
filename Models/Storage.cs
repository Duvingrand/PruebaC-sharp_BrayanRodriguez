using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Storage
{
    public static List<Driver>? Drivers { get; set; }=[];
    public static List<Vehicule>? Vehicules { get; set; }=[new Vehicule("AAA-000", "base", "0000", "0000", 0)];
    public static List<Customer>? Customers { get; set; }=[];



    public static void AddDriver(Driver driver) {
        Drivers.Add(driver);
     }
    public static void AddVehicle(Vehicule vehicule) {
        Vehicules.Add(vehicule);
     }
    public static void AddCustomer(Customer customer) {
        Customers.Add(customer);
     }



    public static void CreateDriver()
    {
        Console.Clear();
        Console.Write("Ingrese el nombre del conductor:");
        string name = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el apellido del conductor:");
        string lastName = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el tipo de documento del conductor:");
        string typeDoc = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el numero de documento del conductor:");
        string nDocument = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el año de nacimiento del conductor:");
        byte year = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el mes de nacimiento del conductor:");
        byte mount = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el dia de nacimiento del conductor:");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el correo del conductor:");
        string mail = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el numero de telefono del conductor:");
        string phone = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese la direccion del conductor:");
        string address = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el numero de licencia:");
        string licNum = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese la categoria de la licencia:");
        string licCat = Console.ReadLine() ?? "";

        var newDriver= new Driver(name,lastName,typeDoc,nDocument,year,mount,day,mail,phone,address,licNum,licCat, 0);
        AddDriver(newDriver);

    }
    public static void CreateVehicle() { }
    public static void CreateCustomer() { 
        Console.Clear();
        Console.Write("Ingrese el nombre del cliente:");
        string name = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el apellido del cliente:");
        string lastName = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el tipo de documento del cliente:");
        string typeDoc = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el numero de documento del cliente:");
        string nDocument = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el año de nacimiento del cliente:");
        byte year = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el mes de nacimiento del cliente:");
        byte mount = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el dia de nacimiento del cliente:");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Clear();
        Console.Write("Ingrese el correo del cliente:");
        string mail = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese el numero de telefono del cliente:");
        string phone = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese la direccion del cliente:");
        string address = Console.ReadLine() ?? "";

        Console.Clear();
        Console.Write("Ingrese metodo de pago del cliente:");
        string payMethod = Console.ReadLine() ?? "";


        var newCustomer= new Customer(name,lastName,typeDoc,nDocument,year,mount,day,mail,phone,address,"Basico", payMethod);
        AddCustomer(newCustomer);

    }



    public static void ReadAllDriver() { 
        foreach (var i in Drivers)
        {
            Console.WriteLine("------------------------------------------------------------");
            i.LetShowDetails();
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    public static void ReadAllVehicle() { 
                foreach (var i in Vehicules)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Id: {i.Idnum}");
            Console.WriteLine($"Placa: {i.Placa}");
            Console.WriteLine($"Tipo: {i.Tipo}");
            Console.WriteLine($"Capacidad: {i.PeopleCapacity} personas");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    public static void ReadAllCustomer() {
                foreach (var i in Customers)
        {
            Console.WriteLine("------------------------------------------------------------");
            i.LetShowDetails();
            Console.WriteLine("------------------------------------------------------------");
        }
     }


    public static void UpdateDriver() {
        
     }
    public static void UpdateVehicle() { }
    public static void UpdateCustomer() { }


    public static void DeleteDriver() { }
    public static void DeleteVehicle() { }
    public static void DeleteCustomer() { }






}
