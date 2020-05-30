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
    public partial class Form2find : Form
    {
        public Form2find()
        {
            InitializeComponent();
            comboBox1.Items.Add("1.fantasy");
            comboBox1.Items.Add("2.soul");
            comboBox1.Items.Add("3.literature");
            comboBox1.Items.Add("4.marketing");
            comboBox1.Items.Add("5.atr");
            comboBox1.Items.Add("6.social science");
            comboBox1.Items.Add("7.food");
            comboBox1.Items.Add("8.puzzle");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string constr = "";
            OracleConnection con = new OracleConnection(constr);
            con.Open();
            string sql = "select BOOK_ID, BOOK_NAME , AUTHOR , PUBLISHER , PUBLISH_DATE , a.CATEGORY_ID , PRICE , b.bookcase , b.CATEGORY_NAME from books a join CATEGORY b  on a.CATEGORY_ID = b.CATEGORY_ID";
                //"select * from books";



            //搜尋作者
            if (radioButton1.TabStop == true)
            {
                string textAuthor = textBox1.Text;
                sql = sql + " where author = '" +textAuthor+ "'";
            }
            else
            {
                //搜尋書名
            if (radioButton3.TabStop == true)
                {
                    string textBookName = textBox2.Text;
                    sql = sql + " where book_name = '" + textBookName + "'";
                }
             else {

             if (radioButton2.TabStop == true) {
                        string tmp = comboBox1.SelectedItem.ToString();
                        string tempid = tmp.Substring(0,1);
                        int classid = Convert.ToInt32(tempid);
                        sql = sql + " where a.category_id = "+classid+" ";
                    }
                        
                            }
            }
            
           
            OracleCommand cmd = new OracleCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Dispose();


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
