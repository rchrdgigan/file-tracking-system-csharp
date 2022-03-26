using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTrackingSystem
{
    public partial class FisheriesFileForm : Form
    {
        FisheriesClass fc = new FisheriesClass();
        private static string file_name;
        private static string fname_without_extension;
        private static string _category;
        private static string source_path;
        private static string destin_path;
        private static string up_id;
        private static string cf = "Capture Fishery";
        private static string cr = "Coastal Resources";
        private static string ilf = "Illegal Fishing";
        private static string mf = "Mariculture Fishing";

        private static string cf_path = Application.StartupPath + @"\Fisheries\Capture Fishery\";
        private static string cr_path = Application.StartupPath + @"\Fisheries\Coastal Resources\";
        private static string ilf_path = Application.StartupPath + @"\Fisheries\Illegal Fishing\";
        private static string mf_path = Application.StartupPath + @"\Fisheries\Mariculture Fishing\";

        private static string archive_cf_path = Application.StartupPath + @"\Archive\Fisheries\Capture Fishery\";
        private static string archive_cr_path = Application.StartupPath + @"\Archive\Fisheries\Coastal Resources\";
        private static string archive_ilf_path = Application.StartupPath + @"\Archive\Fisheries\Illegal Fishing\";
        private static string archive_mf_path = Application.StartupPath + @"\Archive\Fisheries\Mariculture Fishing\";
        private string[] value = { cf, cr, ilf, mf };
        private string[] value_path = { cf_path, cr_path, ilf_path, mf_path };

        public FisheriesFileForm()
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

        private void loadDataByCat()
        {
            fc.list(_category);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = fc.dtable;
        }

        private void loadSearch()
        {
            fc.search(_category);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = fc.dtable;
        }

        private void loadData()
        {
            string n = "";
            fc.list(n);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = fc.dtable;
        }

        private void defaultDisplay()
        {
            button6.Enabled = true;
            button11.Enabled = false;
            buttonCancel.Enabled = false;
            textBoxFileName.Clear();
            txtBoxChooseFile.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formClose();
        }

        private void FisheriesFileForm_Load(object sender, EventArgs e)
        {
            TransitionsAPI.AnimateWindow(this.Handle, 100, TransitionsAPI.fadeIN);
            defaultDisplay();
            LblHeader.Text = UserControlFisheries.header_category;
            for (int i = 0; i < value.Length; i++)
            {
                if (UserControlFisheries.header_category == value[i])
                {
                    _category = value[i];
                    destin_path = value_path[i];
                    loadDataByCat();
                    dataGridView1.Columns["FileName"].Width = 350;
                    dataGridView1.Columns["Category"].Visible = false;
                }
                else if (UserControlFisheries.header_category == "All Category")
                {
                    _category = "";
                    loadData();
                    comboBoxCat.Visible = true;
                    labelCat.Visible = true;
                    comboBoxCatFil.Visible = true;
                    labelCatFil.Visible = true;
                    dataGridView1.Columns["colEdit"].Visible = false;
                }
            }
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                source_path = o.FileName;
                file_name = Path.GetFileName(source_path);
                fname_without_extension = Path.GetFileNameWithoutExtension(source_path);
                txtBoxChooseFile.Text = file_name;
                textBoxFileName.Text = fname_without_extension;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxChooseFile.Text))
            {
                if (!string.IsNullOrEmpty(textBoxFileName.Text))
                {
                    if (UserControlFarmers.header_category != "All Category")
                    {
                        if (!File.Exists(destin_path + file_name))
                        {
                            fc.file_name = textBoxFileName.Text;
                            fc.fname_extension = txtBoxChooseFile.Text;
                            fc.category = _category;
                            fc.create();
                            MessageBox.Show("" + fc.message, "Save Succeded" + _category, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Copy(source_path, destin_path + file_name, true);
                            loadDataByCat();
                            defaultDisplay();
                        }
                        else
                        {
                            MessageBox.Show("File already exists!");
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(comboBoxCat.Text))
                        {
                            if (!File.Exists(destin_path + file_name))
                            {
                                fc.file_name = textBoxFileName.Text;
                                fc.fname_extension = txtBoxChooseFile.Text;
                                fc.category = comboBoxCat.Text;
                                fc.create();
                                MessageBox.Show("" + fc.message, "Save Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                File.Copy(source_path, destin_path + file_name, true);
                                loadData();
                                defaultDisplay();
                            }
                            else
                            {
                                MessageBox.Show("File already exists!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Select category is required!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File name is required!");
                }
            }
            else
            {
                MessageBox.Show("Please choose file!");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string data_id = row.Cells["FileID"].Value.ToString();
                string file_exten = row.Cells["FileWithExtension"].Value.ToString();
                string cat = row.Cells["Category"].Value.ToString();

                if (columnName == "colDel")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to delete this file?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        fc.delete(int.Parse(data_id));
                        loadDataByCat();
                        defaultDisplay();
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (cat == value[i])
                            {
                                destin_path = value_path[i];
                            }
                        }
                        File.Delete(destin_path + file_exten);
                        MessageBox.Show("File successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (columnName == "colEdit")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to edit/update this file?", "Editing Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        up_id = data_id;
                        txtBoxChooseFile.Clear();
                        textBoxFileName.Text = row.Cells["FileName"].Value.ToString();
                        button6.Enabled = false;
                        button11.Enabled = true;
                        buttonCancel.Enabled = true;
                    }
                }
                else if (columnName == "colDownload")
                {
                    SaveFileDialog o = new SaveFileDialog();
                    o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    //o.Filter = "Word Document (.docx)|*.docx| Microsoft Word document before Word 2007 (.doc)|*.doc| Microsoft Excel Worksheet (.xlsx)|*.xlsx|Microsoft Excel 97-2003 Worksheet (.xls)|*.xls|All Files (*.*)|*.*";
                    o.Title = "Save As";
                    string fwe = row.Cells["FileWithExtension"].Value.ToString();
                    file_name = Path.GetFileName(destin_path + fwe);
                    o.FileName = file_name;

                    if (o.ShowDialog() == DialogResult.OK)
                    {
                        defaultDisplay();
                        source_path = o.FileName;
                        File.Copy(destin_path + file_name, source_path, true);
                        MessageBox.Show("File successfully download!", "" + source_path, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (columnName == "colArchive")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to archive this file?", "Archive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] value_archive_path = { archive_cf_path, archive_cr_path, archive_ilf_path, archive_mf_path };

                        for (int i = 0; i < value.Length; i++)
                        {
                            if (cat == value[i])
                            {
                                destin_path = value_path[i];
                                source_path = value_archive_path[i];
                            }
                        }
                        string fw = DateTime.Now.ToString("MM-dd-yyyy Hmmss-") + file_name;
                        string source = source_path + fw;
                        string fwe = Path.GetFileNameWithoutExtension(source);
                        File.Move(destin_path + file_exten, source);
                        fc.file_name = fwe;
                        fc.fname_extension = fw;
                        fc.archive(int.Parse(data_id));
                        loadDataByCat();
                        defaultDisplay();
                        MessageBox.Show("File successfully archive!", "" + source, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            defaultDisplay();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (comboBoxCat.Text == value[i])
                {
                    _category = comboBoxCat.Text;
                    destin_path = value_path[i];
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Update Method
            if (!string.IsNullOrEmpty(txtBoxChooseFile.Text))
            {
                if (!string.IsNullOrEmpty(textBoxFileName.Text))
                {
                    fc.file_name = textBoxFileName.Text;
                    fc.fname_extension = txtBoxChooseFile.Text;
                    fc.category = _category;
                    fc.update(up_id);
                    MessageBox.Show("" + fc.message, "Update Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(source_path, destin_path + file_name, true);
                    defaultDisplay();
                    loadDataByCat();
                }
                else
                {
                    MessageBox.Show("File name is required!");
                }
            }
            else
            {
                MessageBox.Show("Please choose updated file!");
            }
        }

        private void textBoxFilFileName_TextChanged(object sender, EventArgs e)
        {
            fc.file_name = textBoxFilFileName.Text;
            loadSearch();
        }

        private void dateTimePickerFilDate_ValueChanged(object sender, EventArgs e)
        {
            string dts = dateTimePickerFilDate.Value.ToString("yyyy-MM-dd");
            fc.date = dts;
            loadSearch();
        }

        private void comboBoxCatFil_SelectedIndexChanged(object sender, EventArgs e)
        {
            fc.category = comboBoxCatFil.Text;
            loadSearch();
        }
    }
}
