using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_4
{
    static class Run
    {
        public static void RunLogic()
        {
            ClubMember brad = new ClubMember();
            ClubMember darryl = new ClubMember();
            ClubMember madhan = new ClubMember();
            ClubMember norbert = new ClubMember();
            ClubMember sean = new ClubMember();
                                                                                                                                                                                
            brad.SetAllData("Brad", "Kajganich",
                "Kajganich6321@conestogac.on.ca", new DateTime(1991, 12, 25));

            UI.Display(brad.GetName() + "\n" + "ID: " + brad.memberID.ToString()
                + "\nAge: " + brad.CalculateAge().ToString() + "\n" +  brad.memberEmail + "\n");

            darryl.SetAllData("Darryl", "Powoowzywaowowozk", 
                "DPowoowowozk@conestogac.on.ca", new DateTime(1964, 4, 7));

            UI.Display(darryl.GetName() + "\n" + "ID: " + darryl.memberID.ToString()
                + "\nAge: " + darryl.CalculateAge().ToString() + "\n" + darryl.memberEmail + "\n");

            madhan.SetAllData("Madhan", "Changarakansheshan", 
                "mchandrasekaran@conestogac.on.ca", new DateTime(1960, 2, 12));
            UI.Display(madhan.GetName() + "\n" + "ID: " + madhan.memberID.ToString()
                + "\nAge: " + madhan.CalculateAge().ToString() + "\n" + madhan.memberEmail + "\n");

            sean.SetAllData("Sean", "Clarke", 
                "sfclarke@conestogac.on.ca", new DateTime(1933, 11, 13));
            UI.Display(sean.GetName() + "\n" + "ID: " + sean.memberID.ToString()
                + "\nAge: " + sean.CalculateAge().ToString() + "\n" + sean.memberEmail + "\n");

            norbert.SetAllData("Norbert", "Mika", 
                "[FACILITATOR EMAIL GOES HERE]", new DateTime(1975, 8, 30));
            UI.Display(norbert.GetName() + "\n" + "ID: " + norbert.memberID.ToString()
                + "\nAge: " + norbert.CalculateAge().ToString() + "\n" + norbert.memberEmail + "\n");
        }

    }
}
