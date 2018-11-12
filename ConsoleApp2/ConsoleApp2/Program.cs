using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windmill
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"data.txt");
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                int year = 1977;
                foreach (string windmilldata in data[1].Split('\t'))
                {
                    if (windmilldata.Trim().Length > 0)
                    {                       
                        Console.WriteLine($"INSERT INTO Production(WindmillId, Year, ProducedKwH) " +
                                        $"VALUES( (SELECT ID FROM Windmill WHERE GSRN = {data[0]}), {year}, {windmilldata.Trim().Replace(",", "")});");                        
                    }
                    year++;
                }
            }
        }
    }
}
