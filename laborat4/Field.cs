using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborat4
{
   abstract public class Field
    {
        protected string NameField;
        protected string FieldType;
        protected string Value;
        virtual public string get_name()
        {
            return NameField;
        }
        virtual public string get_value()
        {
            return Value;
        }
        virtual public void set_value(string new_value)
        {
            Value = new_value;
        }
        virtual public string get_type()
        {
            return FieldType;
        }
    }
    class NameField : Field
    {
        public NameField()
        {
            NameField = "Название";
            FieldType = "string";
        }
    }
     class TownField : Field
        {
            public TownField()
            {
                NameField = "Город";
                FieldType = "string";
            }
        }
        class StreetField : Field
        {
            public StreetField()
            {
                NameField = "Улица";
                FieldType = "string";
            }
        }
        class CountryField : Field
        {
            public CountryField()
            {
                NameField = "Страна";
                FieldType = "string";
            }
        }
        class KolMarokField : Field
        {
            public KolMarokField()
            {
                NameField = "КолвоМарок";
                FieldType = "int";
            }
        }
        class DateOtkrField : Field
        {
            public DateOtkrField()
            {
                NameField = "ДатаОткр";
                FieldType = "int";
            }
        }
        class WebsaitField : Field
        {
            public WebsaitField()
            {
                NameField = "ВебСайт";
                FieldType = "string";
            }
        }
        class SrednStoimField : Field
        {
            public SrednStoimField()
            {
                NameField = "СредняяСтоим";
                FieldType = "int";
            }
        }
        class RegionField : Field
        {
            public RegionField()
            {
                NameField = "Регион";
                FieldType = "int";
            }
        }
        class IndexField : Field
        {
            public IndexField()
            {
                NameField = "Индекс";
                FieldType = "int";
            }
        }
    }

