using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using excobj=Microsoft.Office.Core;
using System.IO;

namespace laborat4
{
    public partial class frmMain : Form
    {

        MainContr main_controler;
        public frmMain()
        {
            InitializeComponent();
            main_controler = new MainContr();

        }


        private void Filter_click(object sender, EventArgs e)
        {
            main_controler.create_frm_filter();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region
            /*string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marina Chebotova\source\repos\laborat4\laborat4\Database1.mdf;Integrated Security=True";
             sqlConnection = new SqlConnection(connectionString);
             await sqlConnection.OpenAsync();
             SqlDataReader sqlReader = null;
             SqlCommand command = new SqlCommand("SELECT * FROM [Avto]", sqlConnection);
             try{
                 sqlReader = await command.ExecuteReaderAsync();
                 while(await sqlReader.ReadAsync())
                 {
                     ListViewItem lvi = new ListViewItem();
                     ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi2 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi3 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi4 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi5 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi6 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi7 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi8 = new ListViewItem.ListViewSubItem();
                     ListViewItem.ListViewSubItem lvsi9 = new ListViewItem.ListViewSubItem();
                     lvi.Text = Convert.ToString(sqlReader["Name"]) + "";
                     lvsi.Text = Convert.ToString(sqlReader["Town"]) + "";
                     lvsi2.Text = Convert.ToString(sqlReader["Street"]) + "";
                     lvsi3.Text = Convert.ToString(sqlReader["Country"]) + "";
                     lvsi4.Text = Convert.ToString(sqlReader["KolMarok"]) + "";
                     lvsi5.Text = Convert.ToString(sqlReader["DataOtkr"]) + "";
                     lvsi6.Text = Convert.ToString(sqlReader["WebSait"]) + "";
                     lvsi7.Text = Convert.ToString(sqlReader["SrednStoim"]) + "";
                     lvsi8.Text = Convert.ToString(sqlReader["Region"]) + "";
                     lvsi9.Text = Convert.ToString(sqlReader["Index"])+ "";
                     lvi.SubItems.Add(lvsi);
                     lvi.SubItems.Add(lvsi2);
                     lvi.SubItems.Add(lvsi3);
                     lvi.SubItems.Add(lvsi4);
                     lvi.SubItems.Add(lvsi5);
                     lvi.SubItems.Add(lvsi6);
                     lvi.SubItems.Add(lvsi7);
                     lvi.SubItems.Add(lvsi8);
                     lvi.SubItems.Add(lvsi9);
                     listView1.Items.Add(lvi);
                     //listView1.Items.Add(Convert.ToString(sqlReader["Id"]) + "" + Convert.ToString(sqlReader["Name"]) + "" + Convert.ToString(sqlReader["Town"]) + "" + Convert.ToString(sqlReader["Street"]) + "" + Convert.ToString(sqlReader["Country"]) + "" + Convert.ToString(sqlReader["KolMarok"]) + "" + Convert.ToString(sqlReader["DataOtkr"]) + "" + Convert.ToString(sqlReader["WebSait"]) + "" + Convert.ToString(sqlReader["SrednStoim"]) + "" + Convert.ToString(sqlReader["Region"]) + "" + Convert.ToString(sqlReader["Index"]));
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 if (sqlReader != null)
                     sqlReader.Close();
             }
    */
            #endregion //  попытка подкл к Бд 
            int n = FieldTypeCol.getS();
            List<Field> fields = FieldTypeCol.getValue();
            this.listView1.View = View.Details;
        }


        private void Creator_click(object sender, EventArgs e)
        {
            frmCreator creater = new frmCreator();
            creater.Show();
        }

        public void display()
        {
            List<Firm> firms = main_controler.get_firms();

            foreach (Firm firm in firms)
            {
                ListViewItem str = null;
                foreach (Field field in firm.Field)
                {
                    if (str == null) { str = new ListViewItem(field.get_value()); continue; }
                    str.SubItems.Add(field.get_value());
                }
                listView1.Items.Add(str);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = listView1.Items.Count;
            for (int i = n - 1; i >= 0; --i)
            {
                listView1.Items.Clear();
            }
            display();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(sf.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Название,Город,Улица,Страна, Кол-во марок, Дата открытия, Веб-сайт, Средняя стоимость,Регион,Индекс");
                        foreach (ListViewItem item in listView1.Items)
                        {
                            sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text, item.SubItems[9].Text));
                        }
                        await sw.WriteLineAsync(sb.ToString());
                        MessageBox.Show("ok");
                    }
                }
            }




        }
    }
}
    

          
      
    
