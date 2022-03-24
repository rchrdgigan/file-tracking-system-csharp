using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTrackingSystem
{
    public partial class CalamityDamageForm : Form
    {
        CalamityDamageClass cdc = new CalamityDamageClass();

        public static string _category;
        private static string _flood = "Flood";
        private static string _typhon = "Typhoon";
        private static string _drought = "Drought";
        private static string _ashfall = "Ash Fall";
        private static string _salfintrusion = "Salf intrusion";

        private string[] value = { _flood, _typhon, _drought, _ashfall, _salfintrusion };

        public CalamityDamageForm()
        {
            InitializeComponent();
        }

        private void loadDataCat()
        {
            cdc.calamityList(_category);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in cdc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                var fullName = item[1].ToString() + ", " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                dataGridView1.Rows[n].Cells[3].Value = fullName;
                dataGridView1.Rows[n].Cells[4].Value = item[5];
                dataGridView1.Rows[n].Cells[5].Value = item[6];
                dataGridView1.Rows[n].Cells[6].Value = item[7];
                dataGridView1.Rows[n].Cells[7].Value = item[8];
                dataGridView1.Rows[n].Cells[8].Value = item[9];
                dataGridView1.Rows[n].Cells[9].Value = item[10];
                dataGridView1.Rows[n].Cells[10].Value = item[11];
                dataGridView1.Rows[n].Cells[11].Value = item[12];
                dataGridView1.Rows[n].Cells[12].Value = item[13];
                dataGridView1.Rows[n].Cells[13].Value = item[14];
                dataGridView1.Rows[n].Cells[14].Value = item[15];
                dataGridView1.Rows[n].Cells[15].Value = item[0];
            }
        }

        private void loadData()
        {
            string v = "";
            cdc.calamityList(v);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in cdc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                var fullName = item[1].ToString() + ", " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                dataGridView1.Rows[n].Cells[3].Value = fullName;
                dataGridView1.Rows[n].Cells[4].Value = item[5];
                dataGridView1.Rows[n].Cells[5].Value = item[6];
                dataGridView1.Rows[n].Cells[6].Value = item[7];
                dataGridView1.Rows[n].Cells[7].Value = item[8];
                dataGridView1.Rows[n].Cells[8].Value = item[9];
                dataGridView1.Rows[n].Cells[9].Value = item[10];
                dataGridView1.Rows[n].Cells[10].Value = item[11];
                dataGridView1.Rows[n].Cells[11].Value = item[12];
                dataGridView1.Rows[n].Cells[12].Value = item[13];
                dataGridView1.Rows[n].Cells[13].Value = item[14];
                dataGridView1.Rows[n].Cells[14].Value = item[15];
                dataGridView1.Rows[n].Cells[15].Value = item[0];
            }
        }

        public void formClose()
        {
            this.Close();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
        }

        private void defaultDisplay()
        {
            button11.Enabled = false;
            buttonCancel.Enabled = false;
            textBoxFullName.Clear();
            textBoxAddress.Clear();
            textBoxOccupation.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            formClose();
        }

        private void CalamityDamageForm_Load(object sender, EventArgs e)
        {
            TransitionsAPI.AnimateWindow(this.Handle, 100, TransitionsAPI.fadeIN);
            defaultDisplay();
            LblHeader.Text = UserControlCalamityDamage.header_category;

            for (int i = 0; i < value.Length; i++)
            {
                if (UserControlCalamityDamage.header_category == value[i])
                {
                    _category = value[i];
                    dataGridView1.Columns["CalamityType"].Visible = false;
                    loadDataCat();
                }
                else if (UserControlCalamityDamage.header_category == "All Category")
                {
                    loadData();
                    _category = "";
                    comboBoxCatFil.Visible = true;
                    labelCatFil.Visible = true;
                    dataGridView1.Columns["colEdit"].Visible = false;
                    loadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            GenerateCalamityForm gcf = new GenerateCalamityForm();
            gcf.Show();
        }
    }
}
