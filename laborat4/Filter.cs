using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class Filter
    {
        LogExp expression;
        string name_field;
        string filter_value;

        public Filter(LogExp new_expression, string new_name_field, string new_filter_value)
        {
            expression = new_expression;
            name_field = new_name_field;
            filter_value = new_filter_value;
        }
        public bool proverka(Firm firm)
        {
            for (int i = 0; i < firm.Field.Count; ++i)
            {
                if (firm.Field[i].get_name() == name_field)
                    return expression.proverka(filter_value, firm.Field[i].get_value());
            }
            return false;
        }

    }
}
