using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace _7KotOleksiiHomeWorkADO.net
{
    public partial class frmAdd : Form
    {
        string fieldView;
        string fieldSeries;
        string fieldNumber;

        SqlConnection connection;
        DataSet set = null;
        SqlDataAdapter adapter = null;

        public frmAdd()
        {
            InitializeComponent();

            string connString = ConfigurationManager
                .ConnectionStrings["localDbCS"]
                .ConnectionString;

            connection = new SqlConnection(connString);
            set = new DataSet();
            adapter = new SqlDataAdapter();

            fieldView = "Вид *";
            fieldSeries = "Серія";
            fieldNumber = "Номер *";

            txtFirstName.Text = "Ім`я *";
            txtSecondName.Text =  "Прізвище *";
            txtMidName.Text = "По-батькові";

            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "Дата народження *";
            
            cbxGender.Text = "Стать *";
            cbxNationality.Text = "Ukraine";

            cbxDocument.Text = fieldView;
            txtSeriesDocument.Text = fieldSeries;
            txtNumberDocument.Text = fieldNumber;
            txtIssued.Text = "Ким видано";

            cbxEducDocument.Text = fieldView;
            txtEducSeries.Text = fieldSeries;
            txtEducNumber.Text = fieldNumber;
            txtEducIssue.Text = "ЗО, що видав документ *";

            dtpEducDocument.Format = DateTimePickerFormat.Custom;
            dtpEducDocument.CustomFormat = "Дата видачі *";

            txtCode.Text = "Номер";

            cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEducDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            if(dtpBirthday.Checked)
                dtpBirthday.Format = DateTimePickerFormat.Short;     
        }

        private void dtpEducDocument_ValueChanged(object sender, EventArgs e)
        {
            if(dtpEducDocument.Checked)
                dtpEducDocument.Format = DateTimePickerFormat.Short;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Ім`я *")
                txtFirstName.Text = "";
        }

        private void txtSecondName_Leave(object sender, EventArgs e)
        {
            if (txtSecondName.Text == "")
                txtSecondName.Text = "Прізвище *";
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
                txtFirstName.Text = "Ім`я *";
        }

        private void txtSecondName_Enter(object sender, EventArgs e)
        {
            if (txtSecondName.Text == "Прізвище *")
                txtSecondName.Text = "";
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

        private void txtMidName_Enter(object sender, EventArgs e)
        {
            if (txtMidName.Text == "По-батькові")
                txtMidName.Text = "";
        }

        private void txtMidName_Leave(object sender, EventArgs e)
        {
            if (txtMidName.Text == "")
                txtMidName.Text = "По-батькові";
        }

        private void cbxGender_Enter(object sender, EventArgs e)
        {
            if (cbxGender.Text == "Стать *")
                cbxGender.Text = "";
        }

        private void cbxGender_Leave(object sender, EventArgs e)
        {
            if (cbxGender.Text == "")
                cbxGender.Text = "Стать *";
        }

        private void txtSeriesDocument_Enter(object sender, EventArgs e)
        {
            if (txtSeriesDocument.Text == fieldSeries)
                txtSeriesDocument.Text = "";
        }

        private void txtSeriesDocument_Leave(object sender, EventArgs e)
        {
            if (txtSeriesDocument.Text == "")
                txtSeriesDocument.Text = fieldSeries;
        }

        private void txtNumberDocument_Enter(object sender, EventArgs e)
        {
            if (txtNumberDocument.Text == fieldNumber)
                txtNumberDocument.Text = "";
        }

        private void txtNumberDocument_Leave(object sender, EventArgs e)
        {
            if (txtNumberDocument.Text == "")
                txtNumberDocument.Text = fieldNumber;
        }

        private void cbxDocument_Enter(object sender, EventArgs e)
        {
            if (cbxDocument.Text == fieldView)
                cbxDocument.Text = "";
        }

        private void cbxDocument_Leave(object sender, EventArgs e)
        {
            if (cbxDocument.Text == "")
                cbxDocument.Text = fieldView;
        }

        private void txtIssued_Enter(object sender, EventArgs e)
        {
            if (txtIssued.Text == "Ким видано")
                txtIssued.Text = "";
        }

        private void txtIssued_Leave(object sender, EventArgs e)
        {
            if (txtIssued.Text == "")
                txtIssued.Text = "Ким видано";
        }

        private void cbxEducDocument_Enter(object sender, EventArgs e)
        {
            if (cbxEducDocument.Text == fieldView)
                cbxEducDocument.Text = "";
        }

        private void cbxEducDocument_Leave(object sender, EventArgs e)
        {
            if (cbxEducDocument.Text == "")
                cbxEducDocument.Text = fieldView;
        }

        private void txtEducSeries_Enter(object sender, EventArgs e)
        {
            if (txtEducSeries.Text == fieldSeries)
                txtEducSeries.Text = "";
        }

        private void txtEducSeries_Leave(object sender, EventArgs e)
        {
            if (txtEducSeries.Text == "")
                txtEducSeries.Text = fieldSeries;
        }

        private void txtEducNumber_Enter(object sender, EventArgs e)
        {
            if (txtEducNumber.Text == fieldNumber)
                txtEducNumber.Text = "";
        }

        private void txtEducNumber_Leave(object sender, EventArgs e)
        {
            if (txtEducNumber.Text == "")
                txtEducNumber.Text = fieldNumber;
        }

        private void txtEducIssue_Enter(object sender, EventArgs e)
        {
            if (txtEducIssue.Text == "ЗО, що видав документ *")
                txtEducIssue.Text = "";
        }

        private void txtEducIssue_Leave(object sender, EventArgs e)
        {
            if (txtEducIssue.Text == "")
                txtEducIssue.Text = "ЗО, що видав документ *";
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text == "Номер")
                txtCode.Text = "";
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
                txtCode.Text = "Номер";          
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMidName.Text == "По-батькові")
                    txtMidName.Text = "";

            try
            {
                await connection.OpenAsync();

                SqlCommand cmd = new SqlCommand("InsertStudentsAdapterCommand", connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 3
                };

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

                adapter.InsertCommand = cmd;

                using (new CenterWinDialog(this))
                    MessageBox.Show("Student added!");

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
