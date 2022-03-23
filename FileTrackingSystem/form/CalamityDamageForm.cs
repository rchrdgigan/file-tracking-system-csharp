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
                }
                else if (UserControlCalamityDamage.header_category == "All Category")
                {
                    _category = "";
                    comboBoxCatFil.Visible = true;
                    labelCatFil.Visible = true;
                    dataGridView1.Columns["colEdit"].Visible = false;
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
