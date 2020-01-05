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
    public partial class frmFilter : Form
    {
        FiltrContr filter_controler;
        LogExpFactory factory;
        public frmFilter(FiltrContr new_filter_controler)
        {
            InitializeComponent();
            filter_controler = new_filter_controler;
        }
        List<Field> fields;
        CheckBox[] enables;
        RadioButton[,] radio_buttons;
        Label[] names;
        TextBox[] text_boxs;
        Panel[] groupButtons;


        private void FrmFilter_Load(object sender, EventArgs e)
        {
            fields = FieldTypeCol.getValue();
            int n_fiel = fields.Count;
            int[] a_pos = { 20, 120, 250, 290 };
            int  b_pos = 30;

            names = new Label[n_fiel];
            text_boxs = new TextBox[n_fiel];
            enables = new CheckBox[n_fiel];
            radio_buttons = new RadioButton[n_fiel, 4];
            groupButtons = new Panel[n_fiel];

            for (int k = 0; k < n_fiel; ++k)
            {
                names[k] = new Label();
                text_boxs[k] = new TextBox();
                enables[k] = new CheckBox();
                for (int t = 0; t < 4; t++) radio_buttons[k, t] = new RadioButton();
                groupButtons[k] = new Panel();
            }

            for (int i = 0; i < n_fiel; ++i)
            {
                b_pos += 30;

                int index = 0;

                names[i].Text = fields[i].get_name(); names[i].Left = a_pos[index++]; names[i].Top = b_pos; names[i].Name = fields[i].get_type();
                text_boxs[i].Width = 120; text_boxs[i].Left = a_pos[index++]; text_boxs[i].Top = b_pos;
                enables[i].Text = "Нет"; enables[i].Left = a_pos[index++]; enables[i].Top = b_pos; enables[i].Width = 50; enables[i].Checked = true;


                groupButtons[i].Left = 300; groupButtons[i].Top = b_pos;
                groupButtons[i].Height = 30; groupButtons[i].Width = 400;
                radio_buttons[i, 0].Text = "="; radio_buttons[i, 0].Left = 10; radio_buttons[i, 0].Top = 0; radio_buttons[i, 0].Width = 50;
                radio_buttons[i, 1].Text = "!="; radio_buttons[i, 1].Left = 60; radio_buttons[i, 1].Top = 0; radio_buttons[i, 1].Width = 50;
                radio_buttons[i, 2].Left = 110; radio_buttons[i, 2].Top = 0; radio_buttons[i, 2].Width = 100;
                radio_buttons[i, 3].Left = 220; radio_buttons[i, 3].Top = 0; radio_buttons[i, 3].Width = 100;

                if (fields[i].get_type() == "string")
                {
                    radio_buttons[i, 2].Text = "Содержит";
                    radio_buttons[i, 3].Text = "Не содержит";
                }
                else if ( fields[i].get_type() == "int")
                {
                    radio_buttons[i, 2].Text = ">";
                    radio_buttons[i, 3].Text = "<";
                }
            }

            for (int k = 0; k < n_fiel; ++k)
            {
                this.Controls.Add(names[k]);
                this.Controls.Add(text_boxs[k]);
                this.Controls.Add(enables[k]);
                for (int t = 0; t < 4; ++t) groupButtons[k].Controls.Add(radio_buttons[k, t]);
                this.Controls.Add(groupButtons[k]);
            }
        }

        private void Primenit_Click(object sender, EventArgs e)
        {
            factory = new LogExpFactory();
            int n_fields = FieldTypeCol.getS();

            for (int i = 0; i < n_fields; ++i)
            {
                bool[] mark = new bool[4];
                int n_radio_but = -1;

                for (int k = 0; k < 4; ++k)
                {
                    mark[k] = radio_buttons[i, k].Checked;
                    if (mark[k]) n_radio_but = k + 1;
                }

                if (enables[i].Checked == false && (n_radio_but != -1))
                    factory.add_filter(names[i].Text, text_boxs[i].Text, names[i].Name, n_radio_but);
            }

            filter_controler.sort(factory.get_filters());
            this.Close();
        }
    }
}
