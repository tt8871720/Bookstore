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
    public partial class Form5recods : Form

    {
       
        public Form5recods()
        {
           
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

              string constr = "user id= ;password= ;data source=ORCL";
              OracleConnection con = new OracleConnection(constr);
              con.Open();

              int bookid = Convert.ToInt32(textBox3.Text);
              string bookname = textBox2.Text;
              DateTime buy = DateTime.Parse(dateTimePicker1.Text);
              string buydate = String.Format("{0:dd-M月- yy}", buy);

            //新增購買紀錄
            string buying = "insert into records values ("+ bookid +" , '" + bookname + "' , '"+buydate+"')";
            OracleCommand cmd = new OracleCommand(buying, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            

            //顯示目前購買紀錄
            string show = "select * from records order by book_id";
            OracleCommand sh = new OracleCommand(show, con);
            sh.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(sh);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Dispose();
            MessageBox.Show("已同時更新書目庫存");
            


            //扣一本架上的書
            string ss = "user id=store;password=store;data source=ORCL";
            OracleConnection nect = new OracleConnection(ss);
            nect.Open();
            string changestock = "update stocks set shelf_num = (select shelf_num from stocks where BOOK_ID = book_id) -1 where BOOK_ID = book_id";
            OracleCommand minus = new OracleCommand(changestock, nect);
            minus.CommandType = CommandType.Text;
            minus.ExecuteNonQuery();
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            Form7stock seestock = new Form7stock();
            seestock.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
