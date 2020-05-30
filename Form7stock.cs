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
    public partial class Form7stock : Form
    {
        public Form7stock()
        {
            InitializeComponent();
            string constr = "user id= ;password= ;data source=ORCL";
            OracleConnection nect = new OracleConnection(constr);
            nect.Open();

            string see = "select a.book_id , b.book_name ,shelf_num , stock_num from stocks a join books b on a.book_id = b.book_id order by a.book_id";
            OracleCommand command = new OracleCommand(see, nect);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            DataSet dataset = new DataSet();
            OracleDataAdapter oda = new OracleDataAdapter(command);
            oda.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            nect.Dispose();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
