using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class User
{
    protected Guid Id { get; private set; }
    protected string? Name { get; set; }
    protected string? LastName { get; set; }
    protected string? TypeDocument { get; set; }
    protected string? IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string? Email { get; set; }
    protected string? PhoneNumber { get; set; }
    protected string? Address { get; set; }

    protected User(string name, string lastn, string doc, string idnum, int year, byte month, byte day, string mail, string phone, string address)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastn;
        TypeDocument = doc;
        IdentificationNumber = idnum;
        BirthDate = new DateOnly(year, month, day);
        Email = mail;
        PhoneNumber = phone;
        Address = address;
    }

    protected void ShowDetails()
    {
        Console.Write(@$"
        Id: {Id}
        Nombre: {Name} {LastName}
        Numero Documento: {TypeDocument}. {IdentificationNumber}
        Edad: {CalculateAge()}
        Correo: {Email}
        Telefono: {PhoneNumber}
        Dirección {Address}
        ");

    }

 

    protected int CalculateAge()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        return today.Year - BirthDate.Year;
    }

    protected void ShowAge(){
        Console.Write(CalculateAge());
    }



}


