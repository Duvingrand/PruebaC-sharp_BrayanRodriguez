using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Vehicule
{
    public int Idnum { get; private set; }
    private int IdCounter { get; set; }=0;
    public string? Placa { get; set; }
    public string? Tipo { get; set; }
    public string? EngineNumber { get; set; }
    public string? SerialNumber{ get; set; }
    public byte PeopleCapacity { get; set; }


    public Vehicule(string placa, string tipo, string engineNum, string serialNum, byte peopleCapacity)
    {
        IdCounter++;
        Idnum=IdCounter;
        Placa=placa;
        Tipo=tipo;
        EngineNumber=engineNum;
        SerialNumber=serialNum;
        PeopleCapacity=peopleCapacity;
    }



}
