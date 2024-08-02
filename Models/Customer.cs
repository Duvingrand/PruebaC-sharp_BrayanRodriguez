using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Customer:User
{
    public string? MembershipLevel { get; set; }
    public string? PreferredPaymentMethod { get; set; }
    public Customer(string name, string lastn, string doc, string idnum, byte year, byte month, byte day, string mail, string phone, string address, string membership, string payMethod):base(name,lastn,doc,idnum,year,month,day,mail,phone,address)
    {
        MembershipLevel=membership;
        PreferredPaymentMethod=payMethod;
    }

    public void UpdateMembershipLevel(string NewMembership){
        MembershipLevel=NewMembership;
    }

}
