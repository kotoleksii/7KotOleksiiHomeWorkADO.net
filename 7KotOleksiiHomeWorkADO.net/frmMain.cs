using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _7KotOleksiiHomeWorkADO.net
{
    public partial class frmMain : Form
    {
        static public Parameters parameters;
        SqlConnection connection;
        DataSet set = null;
        SqlDataAdapter adapter = null;

        public frmMain()
        {
            InitializeComponent();

            string connString = ConfigurationManager
               .ConnectionStrings["localDbCS"]
               .ConnectionString;

            connection = new SqlConnection(connString);
            set = new DataSet();
            adapter = new SqlDataAdapter();

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            showData();
        }

        public void showData()
        {
            try
            {
                adapter = new SqlDataAdapter("selectStudentAdapterCommand", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

                set.Tables.Clear();
                adapter.Fill(set, "buf_table");
                dgvMain.DataSource = set.Tables["buf_table"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        public void shareData()
        {
            int selectedIndex = dgvMain.SelectedRows[0].Index;
            int rowId = int.Parse(dgvMain[0, selectedIndex].Value.ToString());

            string txtSecondName = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            string txtFirstName = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            string txtMidName = dgvMain.SelectedRows[0].Cells[3].Value.ToString();
            string dtpBirthday = dgvMain.SelectedRows[0].Cells[4].Value.ToString();
            string cbxGender = dgvMain.SelectedRows[0].Cells[5].Value.ToString();
            string cbxNationality = dgvMain.SelectedRows[0].Cells[6].Value.ToString();
            string cbxDocument = dgvMain.SelectedRows[0].Cells[8].Value.ToString();
            string txtSeriesDocument = dgvMain.SelectedRows[0].Cells[9].Value.ToString();
            string txtNumberDocument = dgvMain.SelectedRows[0].Cells[10].Value.ToString();
            string txtIssued = dgvMain.SelectedRows[0].Cells[11].Value.ToString();
            string cbxEducDocument = dgvMain.SelectedRows[0].Cells[13].Value.ToString();
            string txtEducSeries = dgvMain.SelectedRows[0].Cells[14].Value.ToString();
            string txtEducNumber = dgvMain.SelectedRows[0].Cells[15].Value.ToString();
            string dtpEducDocument = dgvMain.SelectedRows[0].Cells[16].Value.ToString();
            string txtEducIssue = dgvMain.SelectedRows[0].Cells[17].Value.ToString();
            string txtCode = dgvMain.SelectedRows[0].Cells[19].Value.ToString();

            frmEdit.parameters.txtSecondName = txtSecondName;
            frmEdit.parameters.txtFirstName = txtFirstName;
            frmEdit.parameters.txtMidName = txtMidName;
            frmEdit.parameters.dtpBirthday = dtpBirthday;
            frmEdit.parameters.cbxGender = cbxGender;
            frmEdit.parameters.cbxNationality = cbxNationality;
            frmEdit.parameters.cbxDocument = cbxDocument;
            frmEdit.parameters.txtSeriesDocument = txtSeriesDocument;
            frmEdit.parameters.txtNumberDocument = txtNumberDocument;
            frmEdit.parameters.txtIssued = txtIssued;
            frmEdit.parameters.cbxEducDocument = cbxEducDocument;
            frmEdit.parameters.txtEducSeries = txtEducSeries;
            frmEdit.parameters.txtEducNumber = txtEducNumber;
            frmEdit.parameters.dtpEducDocument = dtpEducDocument;
            frmEdit.parameters.txtEducIssue = txtEducIssue;
            frmEdit.parameters.txtCode = txtCode;
            frmEdit.parameters.id = rowId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit();

            if (dgvMain.SelectedCells.Count == 1)
            {
                using (new CenterWinDialog(this))
                    MessageBox.Show("You must select the entire line to edit the entry!");
            }

            if (dgvMain.SelectedRows.Count > 0)
            {
                shareData();

                frmEdit.Show();
            }        
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedCells.Count == 1)
            {
                using (new CenterWinDialog(this))
                    MessageBox.Show("You must select the entire line to delete the entry!");       
            }

            if (dgvMain.SelectedRows.Count > 0)
            {
                using (new CenterWinDialog(this))
                {
                    DialogResult dr = MessageBox.Show("Do you really want to delete this entry?",
                      "Warning!", MessageBoxButtons.YesNo);

                    switch (dr)
                    {
                        case DialogResult.Yes:
                            int selectedIndex = dgvMain.SelectedRows[0].Index;
                            int rowId = int.Parse(dgvMain[0, selectedIndex].Value.ToString());

                            await connection.OpenAsync();

                            SqlCommand cmd = new SqlCommand("deleteStudentAdapterCommand", connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            cmd.Parameters.Add("@id", SqlDbType.Int, 0, "id").Value = rowId;
                        
                            await cmd.ExecuteNonQueryAsync();
                            adapter.DeleteCommand = cmd;
                            connection.Close();

                            showData();
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            frmAdd add = new frmAdd();
            add.Show();
        }
    }
}
