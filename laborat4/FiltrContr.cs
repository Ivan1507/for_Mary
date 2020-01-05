using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class FiltrContr
    {
        private FirmMngr firmManager;

        public void sort(LogExpEnum filters)
        {
            List<Firm> firms = FirmCol.get_firms();

            foreach (Firm firm in firms)
            {
                bool sort = true;
                foreach (Filter exp_filter in filters.filters)
                    if (!(sort = exp_filter.proverka(firm))) break;
                if (sort) firmManager.add_avtosalon(firm);
            }
        }

        public FirmMngr get_frm_manager()
        {
            return firmManager;
        }

        public FiltrContr(FirmMngr new_firm_manager)
        {
            firmManager = new_firm_manager;
        }
    }
}
