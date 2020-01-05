using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
    public class FieldTypeCol
    {
        static private List<Field> Field;
        static public List<Field> getValue()
        {
            List<Field> new_fields = new List<Field>();

            new_fields.Add(new NameField());
            new_fields.Add(new TownField());
            new_fields.Add(new StreetField());
            new_fields.Add(new CountryField());
            new_fields.Add(new KolMarokField());
            new_fields.Add(new DateOtkrField());
            new_fields.Add(new WebsaitField());
            new_fields.Add(new SrednStoimField());
            new_fields.Add(new RegionField());
            new_fields.Add(new IndexField());


            return new_fields;
        }

        static public int getS()
        {
            return Field.Count;
        }


        static FieldTypeCol()
        {
            Field = getValue();
        }
    }
}
