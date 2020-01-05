using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public interface LogExp
    {
        bool proverka(string FilterVal, string FirmVal);
    }
    public class equalper : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return FilterVal== FirmVal;
        }
    }

    public class notequalper : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return FilterVal != FirmVal;
        }
    }

    public class containsper : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return FirmVal.Contains(FilterVal);
        }
    }

    public class notontainsper : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return !FirmVal.Contains(FilterVal);
        }
    }

    public class moreint : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return Convert.ToInt32(FilterVal) < Convert.ToInt32(FirmVal);
        }
    }

    public class lessint : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            return Convert.ToInt32(FilterVal) > Convert.ToInt32(FirmVal);
        }
    }

    public class moredate : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            char separator = '.';
            string[] filter = FilterVal.Split(separator);
            string[] firm = FirmVal.Split(separator);

            if (filter.Length != firm.Length || filter.Length != 3) return false;

            if (Convert.ToInt32(filter[2]) < Convert.ToInt32(firm[2])) return true;
            else if (Convert.ToInt32(filter[2]) > Convert.ToInt32(firm[2])) return false;
            else if (Convert.ToInt32(filter[1]) < Convert.ToInt32(firm[1])) return true;
            else if (Convert.ToInt32(filter[1]) > Convert.ToInt32(firm[1])) return false;
            else if (Convert.ToInt32(filter[0]) < Convert.ToInt32(firm[0])) return true;
            else if (Convert.ToInt32(filter[0]) > Convert.ToInt32(firm[0])) return false;

            return false;
        }
    }

    public class lessdate : LogExp
    {
        public bool proverka(string FilterVal, string FirmVal)
        {
            char separator = '.';
            string[] filter = FilterVal.Split(separator);
            string[] firm =  FirmVal.Split(separator);

            if (filter.Length != firm.Length || filter.Length != 3) return false;

            if (Convert.ToInt32(filter[2]) > Convert.ToInt32(firm[2])) return true;
            else if (Convert.ToInt32(filter[2]) < Convert.ToInt32(firm[2])) return false;
            else if (Convert.ToInt32(filter[1]) > Convert.ToInt32(firm[1])) return true;
            else if (Convert.ToInt32(filter[1]) < Convert.ToInt32(firm[1])) return false;
            else if (Convert.ToInt32(filter[0]) > Convert.ToInt32(firm[0])) return true;
            else if (Convert.ToInt32(filter[0]) < Convert.ToInt32(firm[0])) return false;
            return false;
        }
    }
}
