using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class Firm
    {
        public List<Field> Field;

        public Firm()
        {
            Field = FieldTypeCol.getValue();
        }
    }
}
