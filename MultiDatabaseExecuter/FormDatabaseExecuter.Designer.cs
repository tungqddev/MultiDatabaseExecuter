namespace MultiDatabaseExecuter
{
    partial class frmDatabaseExecuter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseExecuter));
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnImportQuery = new System.Windows.Forms.Button();
            this.rchtxtLogs = new System.Windows.Forms.RichTextBox();
            this.chklsbxDBList = new System.Windows.Forms.CheckedListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(99, 24);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(228, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(99, 50);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(228, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(22, 31);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(67, 13);
            this.lblServerName.TabIndex = 3;
            this.lblServerName.Text = "Sever name:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(22, 57);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(351, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(474, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImportQuery
            // 
            this.btnImportQuery.Location = new System.Drawing.Point(351, 57);
            this.btnImportQuery.Name = "btnImportQuery";
            this.btnImportQuery.Size = new System.Drawing.Size(105, 39);
            this.btnImportQuery.TabIndex = 8;
            this.btnImportQuery.Text = "IMPORT QUERY";
            this.btnImportQuery.UseVisualStyleBackColor = true;
            this.btnImportQuery.Click += new System.EventHandler(this.btnImportQuery_Click);
            // 
            // rchtxtLogs
            // 
            this.rchtxtLogs.Location = new System.Drawing.Point(25, 128);
            this.rchtxtLogs.Name = "rchtxtLogs";
            this.rchtxtLogs.Size = new System.Drawing.Size(302, 215);
            this.rchtxtLogs.TabIndex = 9;
            this.rchtxtLogs.Text = "";
            // 
            // chklsbxDBList
            // 
            this.chklsbxDBList.FormattingEnabled = true;
            this.chklsbxDBList.Location = new System.Drawing.Point(351, 129);
            this.chklsbxDBList.Name = "chklsbxDBList";
            this.chklsbxDBList.Size = new System.Drawing.Size(244, 214);
            this.chklsbxDBList.TabIndex = 11;
            this.chklsbxDBList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chklsbxDBList_KeyDown);
            this.chklsbxDBList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chklsbxDBList_KeyPress);
            this.chklsbxDBList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chklsbxDBList_KeyUp);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.Red;
            this.btnExecute.Location = new System.Drawing.Point(474, 57);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(121, 42);
            this.btnExecute.TabIndex = 12;
            this.btnExecute.Text = "EXECUTE";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // frmDatabaseExecuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 390);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.chklsbxDBList);
            this.Controls.Add(this.rchtxtLogs);
            this.Controls.Add(this.btnImportQuery);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatabaseExecuter";
            this.Text = "Database Executer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnImportQuery;
        private System.Windows.Forms.RichTextBox rchtxtLogs;
        private System.Windows.Forms.CheckedListBox chklsbxDBList;
        private System.Windows.Forms.Button btnExecute;
    }
}

