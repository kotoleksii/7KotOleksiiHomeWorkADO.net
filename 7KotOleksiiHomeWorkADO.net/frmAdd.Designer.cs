
namespace _7KotOleksiiHomeWorkADO.net
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.cbxNationality = new System.Windows.Forms.ComboBox();
            this.cbxDocument = new System.Windows.Forms.ComboBox();
            this.txtSeriesDocument = new System.Windows.Forms.TextBox();
            this.txtNumberDocument = new System.Windows.Forms.TextBox();
            this.txtIssued = new System.Windows.Forms.TextBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblPersonalDocument = new System.Windows.Forms.Label();
            this.lblEducDocument = new System.Windows.Forms.Label();
            this.txtEducNumber = new System.Windows.Forms.TextBox();
            this.txtEducSeries = new System.Windows.Forms.TextBox();
            this.cbxEducDocument = new System.Windows.Forms.ComboBox();
            this.dtpEducDocument = new System.Windows.Forms.DateTimePicker();
            this.txtEducIssue = new System.Windows.Forms.TextBox();
            this.txtMidName = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(236, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(179, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TabStop = false;
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSecondName.Location = new System.Drawing.Point(27, 41);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(179, 26);
            this.txtSecondName.TabIndex = 0;
            this.txtSecondName.TabStop = false;
            this.txtSecondName.Enter += new System.EventHandler(this.txtSecondName_Enter);
            this.txtSecondName.Leave += new System.EventHandler(this.txtSecondName_Leave);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.CustomFormat = "";
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(27, 93);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(203, 26);
            this.dtpBirthday.TabIndex = 4;
            this.dtpBirthday.TabStop = false;
            this.dtpBirthday.Value = new System.DateTime(2020, 12, 17, 10, 4, 32, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.cbxGender.Location = new System.Drawing.Point(261, 91);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(154, 28);
            this.cbxGender.TabIndex = 3;
            this.cbxGender.Enter += new System.EventHandler(this.cbxGender_Enter);
            this.cbxGender.Leave += new System.EventHandler(this.cbxGender_Leave);
            // 
            // cbxNationality
            // 
            this.cbxNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxNationality.FormattingEnabled = true;
            this.cbxNationality.Location = new System.Drawing.Point(448, 91);
            this.cbxNationality.Name = "cbxNationality";
            this.cbxNationality.Size = new System.Drawing.Size(179, 28);
            this.cbxNationality.TabIndex = 4;
            this.cbxNationality.Enter += new System.EventHandler(this.cbxNationality_Enter);
            // 
            // cbxDocument
            // 
            this.cbxDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDocument.FormattingEnabled = true;
            this.cbxDocument.Items.AddRange(new object[] {
            "Військовий квиток",
            "Довідка",
            "Паспорт громадянина України з безконтактним електронним носієм",
            "Паспорт громадянина України, що не містить безконтактного електронного носія",
            "Посвідка на тимчасове проживання ",
            "Посвідка на постійне проживання"});
            this.cbxDocument.Location = new System.Drawing.Point(27, 177);
            this.cbxDocument.Name = "cbxDocument";
            this.cbxDocument.Size = new System.Drawing.Size(600, 28);
            this.cbxDocument.TabIndex = 5;
            this.cbxDocument.Enter += new System.EventHandler(this.cbxDocument_Enter);
            this.cbxDocument.Leave += new System.EventHandler(this.cbxDocument_Leave);
            // 
            // txtSeriesDocument
            // 
            this.txtSeriesDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSeriesDocument.Location = new System.Drawing.Point(27, 211);
            this.txtSeriesDocument.Name = "txtSeriesDocument";
            this.txtSeriesDocument.Size = new System.Drawing.Size(100, 26);
            this.txtSeriesDocument.TabIndex = 6;
            this.txtSeriesDocument.Enter += new System.EventHandler(this.txtSeriesDocument_Enter);
            this.txtSeriesDocument.Leave += new System.EventHandler(this.txtSeriesDocument_Leave);
            // 
            // txtNumberDocument
            // 
            this.txtNumberDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumberDocument.Location = new System.Drawing.Point(156, 211);
            this.txtNumberDocument.Name = "txtNumberDocument";
            this.txtNumberDocument.Size = new System.Drawing.Size(100, 26);
            this.txtNumberDocument.TabIndex = 7;
            this.txtNumberDocument.Enter += new System.EventHandler(this.txtNumberDocument_Enter);
            this.txtNumberDocument.Leave += new System.EventHandler(this.txtNumberDocument_Leave);
            // 
            // txtIssued
            // 
            this.txtIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIssued.Location = new System.Drawing.Point(27, 243);
            this.txtIssued.Name = "txtIssued";
            this.txtIssued.Size = new System.Drawing.Size(600, 26);
            this.txtIssued.TabIndex = 8;
            this.txtIssued.Enter += new System.EventHandler(this.txtIssued_Enter);
            this.txtIssued.Leave += new System.EventHandler(this.txtIssued_Leave);
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonal.Location = new System.Drawing.Point(23, 18);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(128, 18);
            this.lblPersonal.TabIndex = 10;
            this.lblPersonal.Text = "Персональні дані";
            // 
            // lblPersonalDocument
            // 
            this.lblPersonalDocument.AutoSize = true;
            this.lblPersonalDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalDocument.Location = new System.Drawing.Point(23, 154);
            this.lblPersonalDocument.Name = "lblPersonalDocument";
            this.lblPersonalDocument.Size = new System.Drawing.Size(224, 18);
            this.lblPersonalDocument.TabIndex = 11;
            this.lblPersonalDocument.Text = "Документ, що посвідчує особу";
            // 
            // lblEducDocument
            // 
            this.lblEducDocument.AutoSize = true;
            this.lblEducDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEducDocument.Location = new System.Drawing.Point(23, 302);
            this.lblEducDocument.Name = "lblEducDocument";
            this.lblEducDocument.Size = new System.Drawing.Size(153, 18);
            this.lblEducDocument.TabIndex = 15;
            this.lblEducDocument.Text = "Документ про освіту";
            // 
            // txtEducNumber
            // 
            this.txtEducNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEducNumber.Location = new System.Drawing.Point(156, 368);
            this.txtEducNumber.Name = "txtEducNumber";
            this.txtEducNumber.Size = new System.Drawing.Size(100, 26);
            this.txtEducNumber.TabIndex = 14;
            this.txtEducNumber.Enter += new System.EventHandler(this.txtEducNumber_Enter);
            this.txtEducNumber.Leave += new System.EventHandler(this.txtEducNumber_Leave);
            // 
            // txtEducSeries
            // 
            this.txtEducSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEducSeries.Location = new System.Drawing.Point(27, 368);
            this.txtEducSeries.Name = "txtEducSeries";
            this.txtEducSeries.Size = new System.Drawing.Size(100, 26);
            this.txtEducSeries.TabIndex = 13;
            this.txtEducSeries.Enter += new System.EventHandler(this.txtEducSeries_Enter);
            this.txtEducSeries.Leave += new System.EventHandler(this.txtEducSeries_Leave);
            // 
            // cbxEducDocument
            // 
            this.cbxEducDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxEducDocument.FormattingEnabled = true;
            this.cbxEducDocument.Items.AddRange(new object[] {
            "Свідоцтво про здобуття базової загальної середньої освіти (з 2019)",
            "Свідоцтво про здобуття повної загальної середньої освіти (з 2019)",
            "Атестат про повну загальну середню освіту (до 2019)",
            "Диплом бакалавра",
            "Диплом спеціаліста",
            "Диплом магістра"});
            this.cbxEducDocument.Location = new System.Drawing.Point(27, 325);
            this.cbxEducDocument.Name = "cbxEducDocument";
            this.cbxEducDocument.Size = new System.Drawing.Size(600, 28);
            this.cbxEducDocument.TabIndex = 12;
            this.cbxEducDocument.Enter += new System.EventHandler(this.cbxEducDocument_Enter);
            this.cbxEducDocument.Leave += new System.EventHandler(this.cbxEducDocument_Leave);
            // 
            // dtpEducDocument
            // 
            this.dtpEducDocument.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEducDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEducDocument.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEducDocument.Location = new System.Drawing.Point(448, 368);
            this.dtpEducDocument.Name = "dtpEducDocument";
            this.dtpEducDocument.Size = new System.Drawing.Size(179, 26);
            this.dtpEducDocument.TabIndex = 16;
            this.dtpEducDocument.ValueChanged += new System.EventHandler(this.dtpEducDocument_ValueChanged);
            // 
            // txtEducIssue
            // 
            this.txtEducIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEducIssue.Location = new System.Drawing.Point(27, 409);
            this.txtEducIssue.Name = "txtEducIssue";
            this.txtEducIssue.Size = new System.Drawing.Size(600, 26);
            this.txtEducIssue.TabIndex = 17;
            this.txtEducIssue.Enter += new System.EventHandler(this.txtEducIssue_Enter);
            this.txtEducIssue.Leave += new System.EventHandler(this.txtEducIssue_Leave);
            // 
            // txtMidName
            // 
            this.txtMidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMidName.Location = new System.Drawing.Point(448, 41);
            this.txtMidName.Name = "txtMidName";
            this.txtMidName.Size = new System.Drawing.Size(179, 26);
            this.txtMidName.TabIndex = 2;
            this.txtMidName.TabStop = false;
            this.txtMidName.Enter += new System.EventHandler(this.txtMidName_Enter);
            this.txtMidName.Leave += new System.EventHandler(this.txtMidName_Leave);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(445, 77);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(87, 13);
            this.lblNationality.TabIndex = 19;
            this.lblNationality.Text = "Громадянство *";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(24, 469);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 13);
            this.lblCode.TabIndex = 24;
            this.lblCode.Text = "РНОКПП";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Location = new System.Drawing.Point(27, 485);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(229, 26);
            this.txtCode.TabIndex = 23;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(391, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "ЗБЕРЕГТИ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(509, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 29);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "ВІДМІНИТИ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 526);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.txtMidName);
            this.Controls.Add(this.txtEducIssue);
            this.Controls.Add(this.dtpEducDocument);
            this.Controls.Add(this.lblEducDocument);
            this.Controls.Add(this.txtEducNumber);
            this.Controls.Add(this.txtEducSeries);
            this.Controls.Add(this.cbxEducDocument);
            this.Controls.Add(this.lblPersonalDocument);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.txtIssued);
            this.Controls.Add(this.txtNumberDocument);
            this.Controls.Add(this.txtSeriesDocument);
            this.Controls.Add(this.cbxDocument);
            this.Controls.Add(this.cbxNationality);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення фізичної особи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ComboBox cbxNationality;
        private System.Windows.Forms.ComboBox cbxDocument;
        private System.Windows.Forms.TextBox txtSeriesDocument;
        private System.Windows.Forms.TextBox txtNumberDocument;
        private System.Windows.Forms.TextBox txtIssued;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblPersonalDocument;
        private System.Windows.Forms.Label lblEducDocument;
        private System.Windows.Forms.TextBox txtEducNumber;
        private System.Windows.Forms.TextBox txtEducSeries;
        private System.Windows.Forms.ComboBox cbxEducDocument;
        private System.Windows.Forms.DateTimePicker dtpEducDocument;
        private System.Windows.Forms.TextBox txtEducIssue;
        private System.Windows.Forms.TextBox txtMidName;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

