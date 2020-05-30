using Oracle.ManagedDataAccess.Client;
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
    public partial class Form6rank : Form
    {
        public Form6rank()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Please replace the connection string attribute settings
            string constr = "user id= ;password= ;data source=ORCL";

            OracleConnection con = new OracleConnection(constr);
            con.Open();

            // SQL Statement
            string count = "銷售量";
            //缺銷售量
            string str = "select book_id , book_name , count(book_id) as 銷售量 from records group by book_id ,BOOK_NAME  order by COUNT(book_id) desc ";
            OracleCommand cmd = new OracleCommand(str, con);
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Dispose();
        }
    }
}
