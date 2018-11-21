using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOStart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kommune> hentetKommuner = DAL.GetAllMunicipalities();
            //DAL.InsertKommune("DownTownSkive", 1500);
            //DAL.InsertKommune("DownTownVinderup", 750);
            //DAL.InsertKommune("DownTownHolstebro", 2500);
            //DAL.InsertKommuneSafe("DownTownHobro", 3750);
            DAL.InsertKommuneSafe("Kasper", 23);
            DAL.InsertKommuneSafe("Kasper", 23);
            //DAL.UpdatePerson();
            //DAL.DeletePerson();
            
        }
    }
}
