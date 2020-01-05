using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class LogExpFactory
    {
        LogExpEnum filters;

        public void add_filter(string field_name, string value, string type, int n_radio_but)
        {
            LogExp new_expression;

            if (n_radio_but == 1) new_expression = new equalper();
            else if (n_radio_but == 2) new_expression = new notequalper();
            else if (n_radio_but == 3)
            {
                if (type == "string") new_expression = new containsper();
                else if (type == "int") new_expression = new moreint();
                else new_expression = new moredate();
            }
            else
            {
                if (type == "string") new_expression = new notontainsper();
                else if (type == "int") new_expression = new lessint();
                else new_expression = new lessdate();
            }

            filters.add_filter(new Filter(new_expression, field_name, value));
        }

        public LogExpEnum get_filters()
        {
            return filters;
        }



        public LogExpFactory()
        {
            filters = new LogExpEnum();
        }
    }
}
