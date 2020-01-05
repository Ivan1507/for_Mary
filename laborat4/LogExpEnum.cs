using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class LogExpEnum
    {
        public List<Filter> filters;
        public void add_filter(Filter new_filter)
        {
            filters.Add(new_filter);
        }

        public LogExpEnum()
        {
            filters = new List<Filter>();
        }
    }
}
