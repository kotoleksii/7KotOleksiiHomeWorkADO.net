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
                //string selectQuery = "select s.id, s.lastname as 'прізвище', s.firstname as 'ім`я', s.midname as 'по-батькові', s.birthday as 'народження', s.gender as 'стать', s.nationality as 'національність', i_d.id as 'id докум', i_d.type as 'тип', i_d.series as 'серія', i_d.number as 'номер', i_d.issued as 'ким видано', e_d.id as 'id освіт докум', e_d.type as 'тип освіт докум', e_d.series as 'серія освіт докум', e_d.number as 'номер освіт докум', e_d.issue_date as 'дата видачі освіт докум', e_d.issued_org as 'ким видано освіт докум' from students as s JOIN identity_documents as i_d ON s.id = i_d.student_id JOIN education_documents as e_d ON s.id = e_d.student_id";

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

                string txtSecondName = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
                string txtFirstName = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
                string txtMidName = dgvMain.SelectedRows[0].Cells[3].Value.ToString();
                string dtpBirthday = dgvMain.SelectedRows[0].Cells[4].Value.ToString();
                string cbxGender = dgvMain.SelectedRows[0].Cells[5].Value.ToString();
                string cbxNationality = dgvMain.SelectedRows[0].Cells[6].Value.ToString();


                frmEdit.parameters.txtSecondName = txtSecondName;
                frmEdit.parameters.txtFirstName = txtFirstName;
                frmEdit.parameters.txtMidName = txtMidName;
                frmEdit.parameters.dtpBirthday = dtpBirthday;
                frmEdit.parameters.cbxGender = cbxGender;
                frmEdit.parameters.cbxNationality = cbxNationality;


                //showData();

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
