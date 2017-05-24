using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MultiDatabaseExecuter
{
    public partial class frmDatabaseExecuter : Form
    {
        public frmDatabaseExecuter()
        {
            InitializeComponent();
        }

        private void connectDatabase()
        {

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=" + txtServerName.Text.ToString() + ";Initial Catalog=master;User ID=" + txtLogin.Text.ToString() + ";Password=" + txtPassword.Text.ToString();
            cnn = new SqlConnection(connetionString);
            SqlCommand cmdGetDataBaseList = new SqlCommand();
            SqlDataReader reader;
            DataTable tblMyDatabaseList = new DataTable();
            try
            {
                cnn.Open();
                cmdGetDataBaseList.CommandText = "select * from master.sys.databases";
                cmdGetDataBaseList.CommandType = CommandType.Text;
                cmdGetDataBaseList.Connection = cnn;
                reader = cmdGetDataBaseList.ExecuteReader();
                tblMyDatabaseList.Load(reader);
                foreach (DataRow row in tblMyDatabaseList.Rows)
                {
                    chklsbxDBList.Items.Add(row["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + Environment.NewLine + ex.ToString());
            }
            cnn.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connectDatabase();
            }
            catch (Exception ex)
            {
                rchtxtLogs.Text = ex.ToString();
            }

        }
        private void queryExecute(string datanbaseName, string query)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=" + txtServerName.Text.ToString() + ";Initial Catalog=" + datanbaseName + ";User ID=" + txtLogin.Text.ToString() + ";Password=" + txtPassword.Text.ToString();
            cnn = new SqlConnection(connetionString);
            SqlCommand cmdGetDataBaseList = new SqlCommand();
            DataTable tblMyDatabaseList = new DataTable();
            try
            {
                cnn.Open();
                cmdGetDataBaseList.CommandText = query;
                cmdGetDataBaseList.CommandType = CommandType.Text;
                cmdGetDataBaseList.Connection = cnn;
                cmdGetDataBaseList.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            cnn.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsbxDBList.Items.Count; i++)
            {

                if (chklsbxDBList.GetItemChecked(i))
                {
                    try
                    {
                        queryExecute(chklsbxDBList.Items[i].ToString(), rchtxtLogs.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            MessageBox.Show("Your query've run for all Database that you checked");
        }
        private string getQueryString()
        {
            string executeQuery;
            OpenFileDialog requestFileDialog = new OpenFileDialog();
            DialogResult result = requestFileDialog.ShowDialog(); // Show the dialog.
            executeQuery = requestFileDialog.FileName;
            return executeQuery;
        }

        private void btnImportQuery_Click(object sender, EventArgs e)
        {
            try
            {
                rchtxtLogs.Text = File.ReadAllText(getQueryString());
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application will be closed !!!!!", "Exit confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void chklsbxDBList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < chklsbxDBList.Items.Count; i++)
                {
                    if (!chklsbxDBList.GetItemChecked(i))
                    {
                        chklsbxDBList.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void chklsbxDBList_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dbcheckState = chklsbxDBList.GetItemCheckState(chklsbxDBList.SelectedIndex) == CheckState.Checked ? true : false;
            chklsbxDBList.SetItemCheckState(chklsbxDBList.SelectedIndex, dbcheckState == true ? CheckState.Checked : CheckState.Unchecked);
        }

        private void chklsbxDBList_KeyUp(object sender, KeyEventArgs e)
        {
            bool dbcheckState = chklsbxDBList.GetItemCheckState(chklsbxDBList.SelectedIndex) == CheckState.Checked ? true : false;
            chklsbxDBList.SetItemCheckState(chklsbxDBList.SelectedIndex, dbcheckState == true ? CheckState.Checked : CheckState.Unchecked);
        }
    }
}

