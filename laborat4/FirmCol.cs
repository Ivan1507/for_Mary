using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laborat4
{
    public class FirmCol
    {
        static private List<Firm> firms;

        static public void add_avtosalon(Firm firm)
        {
            firms.Add(firm);
        }

        static public List<Firm> get_firms()
        {
            return firms;
        }

        static public void addFile()
        {
            firms = new List<Firm>();
            FileStream file = new FileStream("sal.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            string str;
            Firm new_firm;
            while ((str = reader.ReadLine()) != null)
            {
                new_firm = new Firm();
                string[] elements = str.Split(';');

                for (int i = 0; i < elements.Count<string>(); ++i)
                {
                    new_firm.Field[i].set_value(elements[i]);
                }
                firms.Add(new_firm);
            }
        }
    }
}

