using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
   public class FirmMngr
    {
        private List<Firm> firms;

        public void add_avtosalon(Firm firm)
        {
            firms.Add(firm);
        }

        public List<Firm> get_firms()
        {
            return firms;
        }

        public FirmMngr()
        {
            firms = new List<Firm>();
        }
    }
}
