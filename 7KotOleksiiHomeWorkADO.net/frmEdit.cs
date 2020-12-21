using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7KotOleksiiHomeWorkADO.net
{
    public struct Parameters
    {
        public string txtSecondName { get; set; }
        public string txtFirstName { get; set; }
        public string txtMidName { get; set; }
        public string dtpBirthday { get; set; }
        public string cbxGender { get; set; }
        public string cbxNationality { get; set; }
    }

    public partial class frmEdit : Form
    {
        static public Parameters parameters;

        public frmEdit()
        {
            InitializeComponent();

            cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //cbxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEducDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            enteredData();
        }

        private void btnLooked_Click(object sender, EventArgs e)
        {
            enteredData();
        }

        private void enteredData()
        {
            txtSecondName.Text = parameters.txtSecondName;
            txtFirstName.Text = parameters.txtFirstName;
            txtMidName.Text = parameters.txtMidName;
            dtpBirthday.Text = parameters.dtpBirthday;
            cbxGender.Text = parameters.cbxGender;
            cbxNationality.Text = parameters.cbxNationality;
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
    }
}
