﻿using System;
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
    public partial class FarmerFilesForm : Form
    {
        FarmerClass fc = new FarmerClass();
        private static string file_name;
        private static string fname_without_extension;
        private static string _category;
        private static string source_path;
        private static string destin_path;
        private static string up_id;
        private static string morf = "Masterlist of Rice Farmers";
        private static string hu = "Hybrid Users";
        private static string csu = "Certified Seeds User";
        private static string fu = "Fertilizer Users";

        private static string morf_path = Application.StartupPath + @"\Farmers\Masterlist of Rice Farmers\";
        private static string hu_path = Application.StartupPath + @"\Farmers\Hybrid Users\";
        private static string csu_path = Application.StartupPath + @"\Farmers\Certified Seeds User\";
        private static string fu_path = Application.StartupPath + @"\Farmers\Fertilizer Users\";

        public FarmerFilesForm()
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
            button6.Enabled = true;
            button11.Enabled = false;
            buttonCancel.Enabled = false;
            textBoxFileName.Clear();
            txtBoxChooseFile.Clear();
        }

        private void loadDataByCat()
        {
            fc.list(_category);
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

        private void button9_Click(object sender, EventArgs e)
        {
            formClose();
        }

        private void FarmerFilesForm_Load(object sender, EventArgs e)
        {
            defaultDisplay();
            LblHeader.Text = UserControlFarmers.header_category;
            if (UserControlFarmers.header_category == morf)
            {
                _category = morf;
                destin_path = morf_path;
                loadDataByCat();
            }
            else if (UserControlFarmers.header_category == hu)
            {
                _category = hu;
                destin_path = hu_path;
                loadDataByCat();
            }
            else if (UserControlFarmers.header_category == csu)
            {
                _category = csu;
                destin_path = csu_path;
                loadDataByCat();
            }
            else if (UserControlFarmers.header_category == fu)
            {
                _category = fu;
                destin_path = fu_path;
                loadDataByCat();
            }
            else
            {
                _category = "";
                loadDataByCat();
                comboBoxCat.Visible = true;
                labelCat.Visible = true;
                comboBoxCatFil.Visible = true;
                labelCatFil.Visible = true;
                dataGridView1.Columns["colEdit"].Visible = false;
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
                            MessageBox.Show("" + fc.message, "Save Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string data_id = row.Cells["FileID"].Value.ToString();
            string file_del = row.Cells["FileWithExtension"].Value.ToString();
            string cat = row.Cells["Category"].Value.ToString();

            if (columnName == "colDel")
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this file?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    fc.delete(int.Parse(data_id));
                    loadDataByCat();
                    defaultDisplay();
                    if (cat == morf)
                    {
                        destin_path = morf_path;
                    }
                    else if (cat == hu)
                    {
                        destin_path = hu_path;
                    }
                    else if (cat == csu)
                    {
                        destin_path = csu_path;
                    }
                    else if (cat == fu)
                    {
                        destin_path = fu_path;
                    }
                    File.Delete(destin_path + file_del);
                    MessageBox.Show("File successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(columnName == "colEdit")
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

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            defaultDisplay();
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
                MessageBox.Show("Please choose file!");
            }
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCat.Text == "Masterlist of Rice Farmers")
            {
                _category = comboBoxCat.Text;
                destin_path = morf_path;
            }
            else if (comboBoxCat.Text == "Hybrid Users")
            {
                _category = comboBoxCat.Text;
                destin_path = hu_path;

            }
            else if (comboBoxCat.Text == "Certified Seeds User")
            {
                _category = comboBoxCat.Text;
                destin_path = csu_path;

            }
            else if (comboBoxCat.Text == "Fertilizer Users")
            {
                _category = comboBoxCat.Text;
                destin_path = fu_path;

            }
            else
            {
                MessageBox.Show("Please select an specific category!");
            }
        }

    }
}
