using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace _7KotOleksiiHomeWorkADO.net
{
    public partial class frmEdit : Form
    {
        static public Parameters parameters;
        SqlConnection connection;
        DataSet set = null;
        SqlDataAdapter adapter = null;

        public frmEdit()
        {
            InitializeComponent();

            string connString = ConfigurationManager
                .ConnectionStrings["localDbCS"]
                .ConnectionString;

            connection = new SqlConnection(connString);
            set = new DataSet();
            adapter = new SqlDataAdapter();

            cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmEdit_Load(object sender, EventArgs e) => enteredData();
        
        private void btnLooked_Click(object sender, EventArgs e) => enteredData();
       
        private void enteredData()
        {
            txtSecondName.Text = parameters.txtSecondName;
            txtFirstName.Text = parameters.txtFirstName;
            txtMidName.Text = parameters.txtMidName;
            dtpBirthday.Text = parameters.dtpBirthday;
            cbxGender.Text = parameters.cbxGender;
            cbxNationality.Text = parameters.cbxNationality;
            cbxDocument.Text = parameters.cbxDocument;
            txtSeriesDocument.Text = parameters.txtSeriesDocument;
            txtNumberDocument.Text = parameters.txtNumberDocument;
            txtIssued.Text = parameters.txtIssued;
            cbxEducDocument.Text = parameters.cbxEducDocument;
            txtEducSeries.Text = parameters.txtEducSeries;
            txtEducNumber.Text = parameters.txtEducNumber;
            dtpEducDocument.Text = parameters.dtpEducDocument;
            txtEducIssue.Text = parameters.txtEducIssue;
            txtCode.Text = parameters.txtCode;
        }

        private void cbxNationality_Enter(object sender, EventArgs e)
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            foreach (CultureInfo culture in cultures)
            {
                try
                {
                    RegionInfo region = new RegionInfo(culture.LCID);

                    if (!(cultureList.Contains(region.EnglishName)))
                    {
                        cultureList.Add(region.EnglishName);
                    }
                }
                catch (ArgumentException ex)
                {
                    //MessageBox.Show($"ERROR: {ex.Message}");
                    continue;
                }
            }

            cultureList.Sort();
            cultureList.Insert(0, "Ukraine");

            foreach (var country in cultureList)
            {
                cbxNationality.Items.Add(country);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try 
            { 
                await connection.OpenAsync();

                SqlCommand cmd = new SqlCommand("updateStudentsAdapterCommand", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 3
                };

                cmd.Parameters.Add("@id", SqlDbType.Int, 0, "id").Value = parameters.id;
                cmd.Parameters.Add("@firstname", SqlDbType.NVarChar, 50, "firstname").Value = txtFirstName.Text;
                cmd.Parameters.Add("@lastname", SqlDbType.NVarChar, 50, "lastname").Value = txtSecondName.Text;
                cmd.Parameters.Add("@midname", SqlDbType.NVarChar, 50, "midname").Value = txtMidName.Text;
                cmd.Parameters.Add("@birthday", SqlDbType.SmallDateTime).Value = dtpBirthday.Value.ToShortDateString();
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 10, "gender").Value = cbxGender.Text;
                cmd.Parameters.Add("@nationality", SqlDbType.NVarChar, 50, "nationality").Value = cbxNationality.Text;

                cmd.Parameters.Add("@Itype", SqlDbType.NVarChar, 50, "type").Value = cbxDocument.Text;
                cmd.Parameters.Add("@Iseries", SqlDbType.NVarChar, 50, "series").Value = txtSeriesDocument.Text;
                cmd.Parameters.Add("@Inumber", SqlDbType.NVarChar, 50, "number").Value = txtNumberDocument.Text;
                cmd.Parameters.Add("@Iissued", SqlDbType.NVarChar, 50, "issued").Value = txtIssued.Text;

                cmd.Parameters.Add("@Etype", SqlDbType.NVarChar, 50, "type").Value = cbxEducDocument.Text;
                cmd.Parameters.Add("@Eseries", SqlDbType.NVarChar, 50, "series").Value = txtEducSeries.Text;
                cmd.Parameters.Add("@Enumber", SqlDbType.NVarChar, 50, "number").Value = txtEducNumber.Text;
                cmd.Parameters.Add("@Eissue_date", SqlDbType.SmallDateTime).Value = dtpEducDocument.Value.ToShortDateString();
                cmd.Parameters.Add("@Eissued_org", SqlDbType.NVarChar, 50, "issued_org").Value = txtEducIssue.Text;

                cmd.Parameters.Add("@code", SqlDbType.NVarChar, 50, "code").Value = txtCode.Text;

                await cmd.ExecuteNonQueryAsync();

                adapter.UpdateCommand = cmd;

                //adapter.Update(set, "buf_table");

                using (new CenterWinDialog(this))
                    MessageBox.Show("The entry has been edited!");

                frmMain mainFrm = new frmMain();
                mainFrm.showData();
                Hide();
                mainFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }
    }
}
