using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FileTrackingSystem
{
    public partial class GenerateCalamityForm : Form
    {
        CalamityDamageClass cdc = new CalamityDamageClass();
        ConnectionClass cc = new ConnectionClass();

        private static string category;
        private static string _flood = "Flood";
        private static string _typhon = "Typhoon";
        private static string _drought = "Drought";
        private static string _ashfall = "Ash Fall";
        private static string _salfintrusion = "Salf intrusion";
        private static string _date_from;
        private static string _occupation;
        private string[] arr = { };

        private string[] value = { _flood, _typhon, _drought, _ashfall, _salfintrusion };

        public GenerateCalamityForm()
        {
            InitializeComponent();
        }

        private void closeForm()
        {
            this.Close();

            CalamityDamageForm cdf = new CalamityDamageForm();
            cdf.Show();
        }

        private void loadSearch()
        {
            cdc.searchGen();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in cdc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                var fullName = item[1].ToString() + ", " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();

                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = fullName;
                dataGridView1.Rows[n].Cells[2].Value = item[34].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[0].ToString();
            }
        }

        private void loadData()
        {
            MessageBox.Show("" + cdc.message, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cdc.listRSBSA();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in cdc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                var fullName = item[1].ToString() + ", " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
               
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = fullName;
                dataGridView1.Rows[n].Cells[2].Value = item[34].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[8].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[0].ToString();
            }
        }

        //Add checkbox to header
        CheckBox HeaderCheckbox = null;
        bool isHeaderCheckboxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckbox = new CheckBox();

            HeaderCheckbox.Size = new Size(15, 15);

            //Add Checkbox to datagridview
            this.dataGridView1.Controls.Add(HeaderCheckbox);
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            isHeaderCheckboxClicked = true;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["Selection"]).Value = HCheckBox.Checked;
            dataGridView1.RefreshEdit();
            //TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;
            isHeaderCheckboxClicked = false;
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }


        private void GenerateCalamityForm_Load(object sender, EventArgs e)
        {
            loadData();
            AddHeaderCheckBox();
            HeaderCheckbox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            TransitionsAPI.AnimateWindow(this.Handle, 100, TransitionsAPI.fadeIN);

            for (int i = 0; i < value.Length; i++)
            {
                if (CalamityDamageForm._category == value[i])
                {
                    LblHeader.Text = CalamityDamageForm._category + " Category";
                    category = value[i];
                }
                else if (string.IsNullOrEmpty(CalamityDamageForm._category))
                {
                    LblHeader.Text = "All Category";
                    category = "";
                    labelTypesOfCalamity.Visible = true;
                    comboBoxTypesOfCalamity.Visible = true;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(category))
            {
                if (!string.IsNullOrEmpty(_date_from))
                {
                    if (!string.IsNullOrEmpty(comboBoxBudgetF.Text))
                    {
                        if (!string.IsNullOrEmpty(_occupation))
                        {
                            foreach (DataGridViewRow item in dataGridView1.Rows)
                            {
                                if ((bool)item.Cells[0].Value == true)
                                {
                                    cdc.rsbsa_id = item.Cells[4].Value.ToString();
                                    cdc.date_from = _date_from;
                                    cdc.budget_from = comboBoxBudgetF.Text;
                                    cdc.type_calamity = category;
                                    cdc.amount_paid = "";
                                    cdc.ctc_no = "";
                                    cdc.ctc_date_issued = "";
                                    cdc.ctc_place_issued = "";
                                    cdc.generateCalamityList();
                                }
                            }
                            MessageBox.Show("" + cdc.message, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            closeForm();
                        }
                        else
                        {
                            MessageBox.Show("Select Budget From is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Budget From is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Calamity Start From is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (!string.IsNullOrEmpty(comboBoxBudgetF.Text))
                {
                    if (!string.IsNullOrEmpty(_date_from))
                    {
                        if (!string.IsNullOrEmpty(comboBoxTypesOfCalamity.Text))
                        {
                            foreach (DataGridViewRow item in dataGridView1.Rows)
                            {
                                if ((bool)item.Cells[0].Value == true)
                                {
                                    cdc.rsbsa_id = item.Cells[4].Value.ToString();
                                    cdc.date_from = _date_from;
                                    cdc.budget_from = comboBoxBudgetF.Text;
                                    cdc.type_calamity = comboBoxTypesOfCalamity.Text;
                                    cdc.amount_paid = "";
                                    cdc.ctc_no = "";
                                    cdc.ctc_date_issued = "";
                                    cdc.ctc_place_issued = "";
                                    cdc.generateCalamityList();
                                }
                            }
                            MessageBox.Show("" + cdc.message, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            closeForm();
                        }
                        else
                        {
                            MessageBox.Show("Types of Calamity is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Calamity Start From is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Select Budget From is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            _date_from = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            cdc.date_from = _date_from;
            loadData();
        }

        private void comboBoxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _occupation = comboBoxOccupation.Text;
            cdc.occupation = _occupation;
            loadData();
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            cdc.full_name = textBoxFullName.Text;
            loadSearch();
        }

        private void comboBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdc.address = comboBoxAddress.Text;
            loadSearch();
        }

    }
}
