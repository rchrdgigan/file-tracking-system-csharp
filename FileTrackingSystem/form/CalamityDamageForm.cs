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
        private static string _id;
        private static string cedula_date;
        private static string date_from;
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

        private void loadSearch()
        {
            cdc.search(_category);
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
            comboBoxBudgetFrom.Text = "";
            textBoxAmountPaid.Clear();
            textBoxCNumber.Clear();
            cedula_date = "";
            textBoxCPlaceIssued.Clear();
            comboBoxBudgetFrom.Text ="";
            date_from = "";
            dateTimePickerCDate.ResetText();
            dateTimePickerDateFrom.ResetText();

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

        private void comboBoxFillBudgetFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdc.budget_from = comboBoxFillBudgetFrom.Text;
            loadSearch();
        }

        private void comboBoxCatFil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cdc.type_calamity = comboBoxCatFil.Text;
            loadSearch();
        }

        private void textBoxFilFullName_TextChanged(object sender, EventArgs e)
        {
            cdc.full_name = textBoxFilFullName.Text;
            loadSearch();
        }

        private void dateTimePickerFilDate_ValueChanged(object sender, EventArgs e)
        {
            string dts = dateTimePickerFilDate.Value.ToString("yyyy-MM-dd");
            cdc.date_from = dts;
            loadSearch();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string dts = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            cdc.date_to = dts;
            loadSearch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string data_id = row.Cells["CalamityID"].Value.ToString();

                if (columnName == "colDel")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cdc.delete(int.Parse(data_id));
                        loadDataCat();
                        defaultDisplay();
                        MessageBox.Show("Data successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (columnName == "colEdit")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to edit/update this data?", "Editing Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _id = data_id;
                        button11.Enabled = true;
                        buttonCancel.Enabled = true;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            //Move data to text input
                            textBoxFullName.Text = item.Cells[3].Value.ToString();
                            textBoxOccupation.Text = item.Cells[4].Value.ToString();
                            textBoxAddress.Text = item.Cells[5].Value.ToString();
                            textBoxAmountPaid.Text = item.Cells[6].Value.ToString();
                            textBoxCNumber.Text = item.Cells[7].Value.ToString();
                            dateTimePickerCDate.Text = item.Cells[8].Value.ToString();
                            cedula_date = item.Cells[8].Value.ToString();
                            textBoxCPlaceIssued.Text = item.Cells[9].Value.ToString();
                            comboBoxBudgetFrom.Text = item.Cells[12].Value.ToString();
                            dateTimePickerDateFrom.Text = item.Cells[13].Value.ToString();
                            date_from = item.Cells[13].Value.ToString();
                        }
                    }
                }
                else if (columnName == "colArchive")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to archive this data?", "Archive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cdc.archive(int.Parse(data_id));
                        loadDataCat();
                        defaultDisplay();
                        MessageBox.Show("Data successfully archive!", "Archived Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePickerCDate_ValueChanged(object sender, EventArgs e)
        {
            string ctc_d = dateTimePickerCDate.Value.ToString("yyyy-MM-dd");
            cedula_date = ctc_d;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            defaultDisplay();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAmountPaid.Text))
            {
                if (!string.IsNullOrEmpty(textBoxCNumber.Text))
                {
                    if (!string.IsNullOrEmpty(cedula_date))
                    {
                        if (!string.IsNullOrEmpty(comboBoxBudgetFrom.Text))
                        {
                            cdc.budget_from = comboBoxBudgetFrom.Text;
                            cdc.amount_paid = textBoxAmountPaid.Text;
                            cdc.ctc_no = textBoxCNumber.Text;
                            cdc.ctc_date_issued = cedula_date;
                            cdc.ctc_place_issued = textBoxCPlaceIssued.Text;
                            cdc.date_from = date_from;
                            cdc.update(_id);
                            MessageBox.Show("" + cdc.message, "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            defaultDisplay();
                            loadData();
                        }
                        else
                        {
                            MessageBox.Show("Budget From is required!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cedula Date is required!");
                    }
                }
                else
                {
                    MessageBox.Show("Cedula Number is required!");
                }
            }
            else
            {
                MessageBox.Show("Amount Paid is required!");
            }
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            string d_from = dateTimePickerCDate.Value.ToString("yyyy-MM-dd");
            date_from = d_from;
        }
    }
}
