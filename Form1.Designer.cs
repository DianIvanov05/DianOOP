namespace TestWin_DIan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEgn = new System.Windows.Forms.Label();
            this.txtEgn = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CheckMale = new System.Windows.Forms.CheckBox();
            this.checkWoman = new System.Windows.Forms.CheckBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.grpJob = new System.Windows.Forms.GroupBox();
            this.rbJobless = new System.Windows.Forms.RadioButton();
            this.rbPrivate = new System.Windows.Forms.RadioButton();
            this.rbCountryServicer = new System.Windows.Forms.RadioButton();
            this.rbStudying = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.grpJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Име";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 34);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Презиме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фамилия";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(245, 117);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(180, 34);
            this.txtSecondName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(461, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 34);
            this.txtLastName.TabIndex = 2;
            // 
            // lblEgn
            // 
            this.lblEgn.AutoSize = true;
            this.lblEgn.Location = new System.Drawing.Point(24, 165);
            this.lblEgn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEgn.Name = "lblEgn";
            this.lblEgn.Size = new System.Drawing.Size(48, 28);
            this.lblEgn.TabIndex = 1;
            this.lblEgn.Text = "ЕГН";
            this.lblEgn.Click += new System.EventHandler(this.lblEgn_Click);
            // 
            // txtEgn
            // 
            this.txtEgn.Location = new System.Drawing.Point(23, 196);
            this.txtEgn.Name = "txtEgn";
            this.txtEgn.Size = new System.Drawing.Size(180, 34);
            this.txtEgn.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 123);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Въведи";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CheckMale
            // 
            this.CheckMale.AutoSize = true;
            this.CheckMale.Location = new System.Drawing.Point(6, 33);
            this.CheckMale.Name = "CheckMale";
            this.CheckMale.Size = new System.Drawing.Size(83, 32);
            this.CheckMale.TabIndex = 6;
            this.CheckMale.Text = "Мъж";
            this.CheckMale.UseVisualStyleBackColor = true;
            // 
            // checkWoman
            // 
            this.checkWoman.AutoSize = true;
            this.checkWoman.Location = new System.Drawing.Point(6, 71);
            this.checkWoman.Name = "checkWoman";
            this.checkWoman.Size = new System.Drawing.Size(88, 32);
            this.checkWoman.TabIndex = 7;
            this.checkWoman.Text = "Жена";
            this.checkWoman.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.CheckMale);
            this.grpGender.Controls.Add(this.checkWoman);
            this.grpGender.Location = new System.Drawing.Point(24, 249);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(250, 125);
            this.grpGender.TabIndex = 8;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Пол";
            // 
            // grpJob
            // 
            this.grpJob.Controls.Add(this.rbJobless);
            this.grpJob.Controls.Add(this.rbPrivate);
            this.grpJob.Controls.Add(this.rbCountryServicer);
            this.grpJob.Controls.Add(this.rbStudying);
            this.grpJob.Location = new System.Drawing.Point(377, 177);
            this.grpJob.Name = "grpJob";
            this.grpJob.Size = new System.Drawing.Size(291, 217);
            this.grpJob.TabIndex = 9;
            this.grpJob.TabStop = false;
            this.grpJob.Text = "Сфера на работа";
            // 
            // rbJobless
            // 
            this.rbJobless.AutoSize = true;
            this.rbJobless.Location = new System.Drawing.Point(14, 143);
            this.rbJobless.Name = "rbJobless";
            this.rbJobless.Size = new System.Drawing.Size(145, 32);
            this.rbJobless.TabIndex = 1;
            this.rbJobless.TabStop = true;
            this.rbJobless.Text = "безработен";
            this.rbJobless.UseVisualStyleBackColor = true;
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Location = new System.Drawing.Point(13, 105);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(288, 32);
            this.rbPrivate.TabIndex = 1;
            this.rbPrivate.TabStop = true;
            this.rbPrivate.Text = "работник в частна фирма";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // rbCountryServicer
            // 
            this.rbCountryServicer.AutoSize = true;
            this.rbCountryServicer.Location = new System.Drawing.Point(13, 67);
            this.rbCountryServicer.Name = "rbCountryServicer";
            this.rbCountryServicer.Size = new System.Drawing.Size(234, 32);
            this.rbCountryServicer.TabIndex = 1;
            this.rbCountryServicer.TabStop = true;
            this.rbCountryServicer.Text = "държавен служител";
            this.rbCountryServicer.UseVisualStyleBackColor = true;
            // 
            // rbStudying
            // 
            this.rbStudying.AutoSize = true;
            this.rbStudying.Location = new System.Drawing.Point(14, 37);
            this.rbStudying.Name = "rbStudying";
            this.rbStudying.Size = new System.Drawing.Size(85, 32);
            this.rbStudying.TabIndex = 0;
            this.rbStudying.TabStop = true;
            this.rbStudying.Text = "учащ";
            this.rbStudying.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(409, 416);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 130);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 609);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpJob);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtEgn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEgn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpJob.ResumeLayout(false);
            this.grpJob.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion      

        private Label label1;
        private Label lblName;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtSecondName;
        private TextBox txtLastName;
        private Label lblEgn;
        private TextBox txtEgn;
        private Button btnAdd;
        private CheckBox CheckMale;
        private CheckBox checkWoman;
        private GroupBox grpGender;
        private GroupBox grpJob;
        private RadioButton rbCountryServicer;
        private RadioButton rbStudying;
        private RadioButton rbJobless;
        private RadioButton rbPrivate;
        private Button btnClear;
    }
}