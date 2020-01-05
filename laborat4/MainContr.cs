using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
   public class MainContr
    {
        FirmMngr Manager;

        public void create_frm_filter()
        {
            Manager = new FirmMngr();
            FiltrContr filter_controler = new FiltrContr(Manager);
            frmFilter frm_filter = new frmFilter(filter_controler);
            frm_filter.Show();
        }
        public MainContr()
        {
            Manager = new FirmMngr();
            FirmCol.addFile();
        }

        public List<Firm> get_firms()
        {
            return Manager.get_firms();
        }
    }
}
