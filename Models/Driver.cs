using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Driver : User
{
    public string? LicenseNumber { get; set; }
    public string? LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }
    public Vehicule? Vehicule { get; set; }

    public Driver(string name, string lastn, string doc, string idnum, int year, byte month, byte day, string mail, string phone, string address, string lic, string licc, int drivingExp) : base(name, lastn, doc, idnum, year, month, day, mail, phone, address)
    {
        LicenseNumber = lic;
        LicenseCategory = licc;
        DrivingExperience = drivingExp;
    }

    public void UpdateLicenseCategory(string newCategory)
    {
        LicenseCategory = newCategory;
    }

    public void UpdateExperience(int years)
    {
        DrivingExperience = years;
    }

    public void AddVehicle(int idVehicule)
    {
        var settingVehicule = Storage.Vehicules.Find(v => v.Idnum == idVehicule);
    }



    public void LetShowDetails()
    {
        ShowDetails();
    }

}
