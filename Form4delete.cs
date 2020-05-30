using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace bookstore
{
    public partial class Form4delete : Form
    {
        public Form4delete()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string constr = "user id= ;password= ;data source=ORCL";
            OracleConnection nect = new OracleConnection(constr);
            nect.Open();

            string delid = textBox1.Text;
            string del = "delete from books where book_id = " + delid + " ";
            OracleCommand mand = new OracleCommand(del, nect);
            mand.CommandType = CommandType.Text;
            mand.ExecuteNonQuery();
            textBox1.Text = "";
            string show = "select * from books order by book_id";
            OracleCommand sh = new OracleCommand(show, nect);
            sh.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter oda = new OracleDataAdapter(sh);
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            nect.Dispose();
        }

        private void Form4delete_Load(object sender, EventArgs e)
        {

        }
    }
}
