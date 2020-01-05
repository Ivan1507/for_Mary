using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborat4
{
    public partial class frmCreator : Form
    {
        Label[] names;
        TextBox[] text_boxs;
        List<Field> fields;

        public frmCreator()
        {
            InitializeComponent();
        }

        private void FrmCreator_Load_1(object sender, EventArgs e)
        {
            fields = FieldTypeCol.getValue();
            int n_fields = fields.Count;
            int[] a_pos = { 10, 110 };
            int b_pos = 10;

            names = new Label[n_fields];
            text_boxs = new TextBox[n_fields];

            for (int k = 0; k < n_fields; ++k)
            {
                names[k] = new Label();
                text_boxs[k] = new TextBox();
            }

            for (int i = 0; i < n_fields; ++i)
            {
                b_pos += 30;
                int index = 0;

                names[i].Text = fields[i].get_name(); names[i].Left = a_pos[index++]; names[i].Top = b_pos; names[i].Name = fields[i].get_type();
                text_boxs[i].Width = 120; text_boxs[i].Left = a_pos[index++]; text_boxs[i].Top = b_pos;
            }

            for (int k = 0; k < n_fields; ++k)
            {
                this.Controls.Add(names[k]);
                this.Controls.Add(text_boxs[k]);
            }
        }

        static public void add_avtosalon(string[] str_from_box)
        {
            List<Field> new_fields = FieldTypeCol.getValue();
            for (int i = 0; i < str_from_box.Count<string>(); ++i)
                new_fields[i].set_value(str_from_box[i]);

            Firm new_firm = new Firm();
            new_firm.Field = new_fields;
            FirmCol.add_avtosalon(new_firm);
        }
        private void AddSalon_Click(object sender, EventArgs e)
        {
            int n = text_boxs.Count<TextBox>();

            string[] str_from_box = new string[n];
            for (int i = 0; i < n; ++i)
            {
                str_from_box[i] = text_boxs[i].Text;
            }

            add_avtosalon(str_from_box);
            this.Close();
        }

        
    }
}
