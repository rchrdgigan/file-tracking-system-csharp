using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTrackingSystem
{
    public partial class UserControlArchiveHistory : UserControl
    {
        RSBSAClass rsbsa = new RSBSAClass();
        User user = new User();
        FarmerClass far = new FarmerClass();
        FisheriesClass fsh = new FisheriesClass();
        CalamityDamageClass cdc = new CalamityDamageClass();

        private string far_cat = "";
        private string fsh_cat = "";
        private string cal_cat = "";

        private string[] far_tab_page = { "tabPageMRF", "tabPageHU", "tabPageCSU", "tabPageFU" };
        private string[] fsh_tab_page = { "tabPageCF", "tabPageMF", "tabPageIF", "tabPageCR" };
        private string[] cal_tab_page = { "tabPageFlood", "tabPageTyphoon", "tabPageDrought", "tabPageAsh", "tabPageSalt" };

        private static string file_name;
        private static string source_path;
        private static string destin_path;

        private string data_id;
        private string file_exten;
        private string columnName;

        private static string archive_morf_path = Application.StartupPath + @"\Archive\Farmers\Masterlist of Rice Farmers\";
        private static string archive_hu_path = Application.StartupPath + @"\Archive\Farmers\Hybrid Users\";
        private static string archive_csu_path = Application.StartupPath + @"\Archive\Farmers\Certified Seeds User\";
        private static string archive_fu_path = Application.StartupPath + @"\Archive\Farmers\Fertilizer Users\";

        private string[] far_path = { archive_morf_path, archive_hu_path, archive_csu_path, archive_fu_path };

        private string[] id = { "FileID", "hu_id", "csu_id", "fu_id" };
        private string[] col_dl = { "colDownload", "hu_download", "csu_download", "fu_download" };
        private string[] col_del = { "colMRFDel", "hu_del", "csu_del", "fu_del" };

        private static string archive_cf_path = Application.StartupPath + @"\Archive\Fisheries\Capture Fishery\";
        private static string archive_cr_path = Application.StartupPath + @"\Archive\Fisheries\Coastal Resources\";
        private static string archive_ilf_path = Application.StartupPath + @"\Archive\Fisheries\Illegal Fishing\";
        private static string archive_mf_path = Application.StartupPath + @"\Archive\Fisheries\Mariculture Fishing\";

        private string[] fsh_path = { archive_cf_path, archive_cr_path, archive_ilf_path, archive_mf_path };

        private string[] fsh_id = { "cf_id", "cr_id", "if_id", "mf_id" };
        private string[] fsh_col_dl = { "cf_download", "cr_download", "if_download", "mf_download" };
        private string[] fsh_col_del = { "cf_del", "cr_del", "if_del", "mf_del" };

        private string[] cal_category = { "Flood", "Typhoon", "Drought", "Ash Fall", "Salf intrusion" };
        private string[] cal_col_del = { "flood_del", "typhoon_del", "drought_del", "ash_del", "salf_del" };
        private string[] cal_col_arc = { "flood_arc", "typhoon_arc", "drought_arc", "ash_arc", "salf_arc" };


        public UserControlArchiveHistory()
        {
            InitializeComponent();
        }

        private void loadDataArchive()
        {
            //show rsbsa
            rsbsa.showArchive();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rsbsa.dtable;

            //show farmer
            far.archiveList(far_cat);
            if(far_cat == "Masterlist of Rice Farmers")
            {
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = far.dtable;
            }
            else if(far_cat == "Hybrid Users")
            {
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = far.dtable;
            }
            else if (far_cat == "Certified Seeds User")
            {
                dataGridView4.AutoGenerateColumns = false;
                dataGridView4.DataSource = far.dtable;
            }
            else if (far_cat == "Fertilizer Users")
            {
                dataGridView5.AutoGenerateColumns = false;
                dataGridView5.DataSource = far.dtable;
            }

            //show fisheries
            fsh.archiveList(fsh_cat);
            if (fsh_cat == "Capture Fishery")
            {
                dataGridView6.AutoGenerateColumns = false;
                dataGridView6.DataSource = fsh.dtable;
            }
            else if (fsh_cat == "Mariculture Fishing")
            {
                dataGridView7.AutoGenerateColumns = false;
                dataGridView7.DataSource = fsh.dtable;
            }
            else if (fsh_cat == "Illegal Fishing")
            {
                dataGridView8.AutoGenerateColumns = false;
                dataGridView8.DataSource = fsh.dtable;
            }
            else if (fsh_cat == "Coastal Resources")
            {
                dataGridView9.AutoGenerateColumns = false;
                dataGridView9.DataSource = fsh.dtable;
            }

            cdc.archiveList(cal_cat);
            if(cal_cat == "Flood")
            {
                dataGridView10.AutoGenerateColumns = false;
                dataGridView10.Rows.Clear();
                foreach (DataRow item in cdc.dtable.Rows)
                {
                    int n = dataGridView10.Rows.Add();
                    var fullName = item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                    dataGridView10.Rows[n].Cells[2].Value = fullName;
                    dataGridView10.Rows[n].Cells[3].Value = item[5];
                    dataGridView10.Rows[n].Cells[4].Value = item[6];
                    dataGridView10.Rows[n].Cells[5].Value = item[7];
                    dataGridView10.Rows[n].Cells[6].Value = item[8];
                    dataGridView10.Rows[n].Cells[7].Value = item[9];
                    dataGridView10.Rows[n].Cells[8].Value = item[10];
                    dataGridView10.Rows[n].Cells[9].Value = item[11];
                    dataGridView10.Rows[n].Cells[10].Value = item[12];
                    dataGridView10.Rows[n].Cells[11].Value = item[13];
                    dataGridView10.Rows[n].Cells[12].Value = item[14];
                    dataGridView10.Rows[n].Cells[13].Value = item[15];
                    dataGridView10.Rows[n].Cells[14].Value = item[0];
                }
            }
            else if (cal_cat == "Typhoon")
            {
                dataGridView11.AutoGenerateColumns = false;
                dataGridView11.Rows.Clear();
                foreach (DataRow item in cdc.dtable.Rows)
                {
                    int n = dataGridView11.Rows.Add();
                    var fullName = item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                    dataGridView11.Rows[n].Cells[2].Value = fullName;
                    dataGridView11.Rows[n].Cells[3].Value = item[5];
                    dataGridView11.Rows[n].Cells[4].Value = item[6];
                    dataGridView11.Rows[n].Cells[5].Value = item[7];
                    dataGridView11.Rows[n].Cells[6].Value = item[8];
                    dataGridView11.Rows[n].Cells[7].Value = item[9];
                    dataGridView11.Rows[n].Cells[8].Value = item[10];
                    dataGridView11.Rows[n].Cells[9].Value = item[11];
                    dataGridView11.Rows[n].Cells[10].Value = item[12];
                    dataGridView11.Rows[n].Cells[11].Value = item[13];
                    dataGridView11.Rows[n].Cells[12].Value = item[14];
                    dataGridView11.Rows[n].Cells[13].Value = item[15];
                    dataGridView11.Rows[n].Cells[14].Value = item[0];
                }
            }
            else if (cal_cat == "Drought")
            {
                dataGridView12.AutoGenerateColumns = false;
                dataGridView12.Rows.Clear();
                foreach (DataRow item in cdc.dtable.Rows)
                {
                    int n = dataGridView12.Rows.Add();
                    var fullName = item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                    dataGridView12.Rows[n].Cells[2].Value = fullName;
                    dataGridView12.Rows[n].Cells[3].Value = item[5];
                    dataGridView12.Rows[n].Cells[4].Value = item[6];
                    dataGridView12.Rows[n].Cells[5].Value = item[7];
                    dataGridView12.Rows[n].Cells[6].Value = item[8];
                    dataGridView12.Rows[n].Cells[7].Value = item[9];
                    dataGridView12.Rows[n].Cells[8].Value = item[10];
                    dataGridView12.Rows[n].Cells[9].Value = item[11];
                    dataGridView12.Rows[n].Cells[10].Value = item[12];
                    dataGridView12.Rows[n].Cells[11].Value = item[13];
                    dataGridView12.Rows[n].Cells[12].Value = item[14];
                    dataGridView12.Rows[n].Cells[13].Value = item[15];
                    dataGridView12.Rows[n].Cells[14].Value = item[0];
                }
            }
            else if (cal_cat == "Ash Fall")
            {
                dataGridView13.AutoGenerateColumns = false;
                dataGridView13.Rows.Clear();
                foreach (DataRow item in cdc.dtable.Rows)
                {
                    int n = dataGridView13.Rows.Add();
                    var fullName = item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                    dataGridView13.Rows[n].Cells[2].Value = fullName;
                    dataGridView13.Rows[n].Cells[3].Value = item[5];
                    dataGridView13.Rows[n].Cells[4].Value = item[6];
                    dataGridView13.Rows[n].Cells[5].Value = item[7];
                    dataGridView13.Rows[n].Cells[6].Value = item[8];
                    dataGridView13.Rows[n].Cells[7].Value = item[9];
                    dataGridView13.Rows[n].Cells[8].Value = item[10];
                    dataGridView13.Rows[n].Cells[9].Value = item[11];
                    dataGridView13.Rows[n].Cells[10].Value = item[12];
                    dataGridView13.Rows[n].Cells[11].Value = item[13];
                    dataGridView13.Rows[n].Cells[12].Value = item[14];
                    dataGridView13.Rows[n].Cells[13].Value = item[15];
                    dataGridView13.Rows[n].Cells[14].Value = item[0];
                }
            }
            else if (cal_cat == "Salf intrusion")
            {
                dataGridView14.AutoGenerateColumns = false;
                dataGridView14.Rows.Clear();
                foreach (DataRow item in cdc.dtable.Rows)
                {
                    int n = dataGridView14.Rows.Add();
                    var fullName = item[1].ToString() + " " + item[2].ToString() + " " + item[3].ToString() + " " + item[4].ToString();
                    dataGridView14.Rows[n].Cells[2].Value = fullName;
                    dataGridView14.Rows[n].Cells[3].Value = item[5];
                    dataGridView14.Rows[n].Cells[4].Value = item[6];
                    dataGridView14.Rows[n].Cells[5].Value = item[7];
                    dataGridView14.Rows[n].Cells[6].Value = item[8];
                    dataGridView14.Rows[n].Cells[7].Value = item[9];
                    dataGridView14.Rows[n].Cells[8].Value = item[10];
                    dataGridView14.Rows[n].Cells[9].Value = item[11];
                    dataGridView14.Rows[n].Cells[10].Value = item[12];
                    dataGridView14.Rows[n].Cells[11].Value = item[13];
                    dataGridView14.Rows[n].Cells[12].Value = item[14];
                    dataGridView14.Rows[n].Cells[13].Value = item[15];
                    dataGridView14.Rows[n].Cells[14].Value = item[0];
                }
            }
        }

        private void selectDelOrDL()
        {
            try
            {
                for (int x = 0; x < id.Length; x++)
                {
                    if (columnName == col_del[x])
                    {
                        DialogResult result = MessageBox.Show("Are you sure want to delete this file?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            far.delete(int.Parse(data_id));
                            loadDataArchive();

                            File.Delete(destin_path + file_exten);
                            MessageBox.Show("File successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Removed farmers file archived in " + far_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                    else if (columnName == col_dl[x])
                    {
                        SaveFileDialog o = new SaveFileDialog();
                        o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        //o.Filter = "Word Document (.docx)|*.docx| Microsoft Word document before Word 2007 (.doc)|*.doc| Microsoft Excel Worksheet (.xlsx)|*.xlsx|Microsoft Excel 97-2003 Worksheet (.xls)|*.xls|All Files (*.*)|*.*";
                        o.Title = "Save As";
                        file_name = Path.GetFileName(destin_path + file_exten);
                        o.FileName = file_name;
                        if (o.ShowDialog() == DialogResult.OK)
                        {
                            source_path = o.FileName;
                            File.Copy(far_path[x] + file_name, source_path, true);
                            MessageBox.Show("File successfully download!", "" + source_path, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Downloaded farmers file archived in " + far_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fshDelOrDL()
        {
            try
            {
                for (int x = 0; x < fsh_id.Length; x++)
                {
                    if (columnName == fsh_col_del[x])
                    {
                        DialogResult result = MessageBox.Show("Are you sure want to delete this file?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            fsh.delete(int.Parse(data_id));
                            loadDataArchive();

                            File.Delete(destin_path + file_exten);
                            MessageBox.Show("File successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Removed fisheries file archived in " + fsh_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                    else if (columnName == fsh_col_dl[x])
                    {
                        SaveFileDialog o = new SaveFileDialog();
                        o.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        //o.Filter = "Word Document (.docx)|*.docx| Microsoft Word document before Word 2007 (.doc)|*.doc| Microsoft Excel Worksheet (.xlsx)|*.xlsx|Microsoft Excel 97-2003 Worksheet (.xls)|*.xls|All Files (*.*)|*.*";
                        o.Title = "Save As";
                        file_name = Path.GetFileName(destin_path + file_exten);
                        o.FileName = file_name;
                        if (o.ShowDialog() == DialogResult.OK)
                        {
                            source_path = o.FileName;
                            File.Copy(fsh_path[x] + file_name, source_path, true);
                            MessageBox.Show("File successfully download!", "" + source_path, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Downloaded fisheries file archived in " + fsh_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calDelOrUnarchive()
        {
            try
            {
                for (int x = 0; x < cal_category.Length; x++)
                {
                    if (columnName == cal_col_del[x])
                    {
                        DialogResult result = MessageBox.Show("Are you sure want to delete this data?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            cdc.delete(int.Parse(data_id));
                            loadDataArchive();
                            MessageBox.Show("Data was successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Removed  calamity damaged archived data in " + cal_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                    else if (columnName == cal_col_arc[x])
                    {
                        DialogResult result = MessageBox.Show("Are you sure want to unarchive this data?", "Unarchive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            cdc.unarchived(data_id);
                            loadDataArchive();
                            MessageBox.Show("Successfully unarchived!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //History Log
                            user.activity = "Unarchive calamity damaged data in " + cal_cat + " category...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControlArchiveHistory_Load(object sender, EventArgs e)
        {
            loadDataArchive();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string data_id = row.Cells["rsbsa_id"].Value.ToString();

                if (columnName == "colDel")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to delete this file?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        rsbsa.delRSBSA(data_id);
                        loadDataArchive();
                        MessageBox.Show("Successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //History Log
                        user.activity = "Delete archived data RSBSA...";
                        user.user_id = loginfrm._log_id;
                        user.createLog();
                        //End Log
                    }
                }
                else if (columnName == "colUnarchive")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to unarchive this data?", "Unarchive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        rsbsa.unarchiveRSBSA(data_id);
                        loadDataArchive();
                        MessageBox.Show("Successfully unarchive!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //History Log
                        user.activity = "Unarchive data RSBSA...";
                        user.user_id = loginfrm._log_id;
                        user.createLog();
                        //End Log
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < far_tab_page.Length; i++)
            {
                if (tabControl2.SelectedTab == tabControl2.TabPages[far_tab_page[i]])//your farmer tabname
                {
                    far_cat = tabControl2.TabPages[far_tab_page[i]].Text;
                    destin_path = far_path[i];
                    loadDataArchive();
                }
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            {
                for (int i = 0; i < far_tab_page.Length; i++)
                {
                    if (tabControl2.SelectedTab == tabControl2.TabPages[far_tab_page[i]])//your farmer tabname
                    {
                        far_cat = tabControl2.TabPages[far_tab_page[i]].Text;
                        destin_path = far_path[i];
                        loadDataArchive();
                    }
                }
            }
            else if(tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                for (int i = 0; i < fsh_tab_page.Length; i++)
                {
                    if (tabControl3.SelectedTab == tabControl3.TabPages[fsh_tab_page[i]])//your fisheries tabname
                    {
                        fsh_cat = tabControl3.TabPages[fsh_tab_page[i]].Text;
                        destin_path = fsh_path[i];
                        loadDataArchive();
                    }
                }
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                for (int i = 0; i < cal_tab_page.Length; i++)
                {
                    if (tabControl4.SelectedTab == tabControl4.TabPages[cal_tab_page[i]])//your calamity tabname
                    {
                        cal_cat = tabControl4.TabPages[cal_tab_page[i]].Text;
                        loadDataArchive();
                    }
                }
            }
        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < fsh_tab_page.Length; i++)
            {
                if (tabControl3.SelectedTab == tabControl3.TabPages[fsh_tab_page[i]])//your fisheries tabname
                {
                    fsh_cat = tabControl3.TabPages[fsh_tab_page[i]].Text;
                    destin_path = fsh_path[i];
                    loadDataArchive();
                }
            }
             
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cal_tab_page.Length; i++)
            {
                if (tabControl4.SelectedTab == tabControl4.TabPages[cal_tab_page[i]])//your calamity tabname
                {
                    cal_cat = tabControl4.TabPages[cal_tab_page[i]].Text;
                    loadDataArchive();
                }
            }
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView5.CurrentCell.ColumnIndex;
            columnName = dataGridView5.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView5.Rows[e.RowIndex];
            data_id = row.Cells["fu_id"].Value.ToString();
            file_exten = row.Cells["fu_fwe"].Value.ToString();

            selectDelOrDL();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView2.CurrentCell.ColumnIndex;
            columnName = dataGridView2.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            data_id = row.Cells["FileID"].Value.ToString();
            file_exten = row.Cells["FileWithExtension"].Value.ToString();

            selectDelOrDL();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView3.CurrentCell.ColumnIndex;
            columnName = dataGridView3.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
            data_id = row.Cells["hu_id"].Value.ToString();
            file_exten = row.Cells["hu_fwe"].Value.ToString();

            selectDelOrDL();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView4.CurrentCell.ColumnIndex;
            columnName = dataGridView4.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView4.Rows[e.RowIndex];
            data_id = row.Cells["csu_id"].Value.ToString();
            file_exten = row.Cells["csu_fwe"].Value.ToString();

            selectDelOrDL();
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView6.CurrentCell.ColumnIndex;
            columnName = dataGridView6.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView6.Rows[e.RowIndex];
            data_id = row.Cells["cf_id"].Value.ToString();
            file_exten = row.Cells["cf_fwe"].Value.ToString();

            fshDelOrDL();
        }
     
        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView7.CurrentCell.ColumnIndex;
            columnName = dataGridView7.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView7.Rows[e.RowIndex];
            data_id = row.Cells["mf_id"].Value.ToString();
            file_exten = row.Cells["mf_fwe"].Value.ToString();

            fshDelOrDL();
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView8.CurrentCell.ColumnIndex;
            columnName = dataGridView8.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView8.Rows[e.RowIndex];
            data_id = row.Cells["if_id"].Value.ToString();
            file_exten = row.Cells["if_fwe"].Value.ToString();

            fshDelOrDL();
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView9.CurrentCell.ColumnIndex;
            columnName = dataGridView9.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView9.Rows[e.RowIndex];
            data_id = row.Cells["cr_id"].Value.ToString();
            file_exten = row.Cells["cr_fwe"].Value.ToString();

            fshDelOrDL();
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView10.CurrentCell.ColumnIndex;
            columnName = dataGridView10.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView10.Rows[e.RowIndex];
            data_id = row.Cells["flood_id"].Value.ToString();

            calDelOrUnarchive();
        }

        private void dataGridView11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView11.CurrentCell.ColumnIndex;
            columnName = dataGridView11.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView11.Rows[e.RowIndex];
            data_id = row.Cells["typhoon_id"].Value.ToString();

            calDelOrUnarchive();
        }

        private void dataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView12.CurrentCell.ColumnIndex;
            columnName = dataGridView12.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView12.Rows[e.RowIndex];
            data_id = row.Cells["drought_id"].Value.ToString();

            calDelOrUnarchive();
        }

        private void dataGridView13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView13.CurrentCell.ColumnIndex;
            columnName = dataGridView13.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView13.Rows[e.RowIndex];
            data_id = row.Cells["ash_id"].Value.ToString();

            calDelOrUnarchive();
        }

        private void dataGridView14_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView14.CurrentCell.ColumnIndex;
            columnName = dataGridView14.Columns[columnIndex].Name;

            DataGridViewRow row = this.dataGridView14.Rows[e.RowIndex];
            data_id = row.Cells["salf_id"].Value.ToString();

            calDelOrUnarchive();
        }
    }
}
