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
    public partial class Form0test : Form
    {
        public Form0test()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Please replace the connection string attribute settings
                string constr = "";
                OracleConnection con = new OracleConnection(constr);
                con.Open();

                // SQL Statement
                string test = "select * from books order by book_id";
                //"select a.book_id , a.book_name , b.category_name from BOOKS a join CATEGORY b on a.BOOK_ID = 1";

                OracleCommand cmd = new OracleCommand(test, con);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
