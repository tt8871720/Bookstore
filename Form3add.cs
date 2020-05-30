using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace bookstore
{
    public partial class Form3add : Form
    {
        public Form3add()
        {
            InitializeComponent();
       
            comboBox1.Items.Add("1fantasy");
            comboBox1.Items.Add("2soul");
            comboBox1.Items.Add("3literature");
            comboBox1.Items.Add("4marketing");
            comboBox1.Items.Add("5atr");
            comboBox1.Items.Add("6social science");
            comboBox1.Items.Add("7food");
            comboBox1.Items.Add("8puzzle");

        }

        private void Form3add_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }


        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int bookid = Convert.ToInt32(id.Text);
            string bookname = textBox1.Text;
            string author = writer.Text;
            string publisher = publishname.Text;
            int price = Convert.ToInt32(textBox2.Text);
            int stock = Convert.ToInt32(textBox6.Text);
            int shelf = Convert.ToInt32(textBox7.Text);



            //dateTimePicker1.CustomFormat = "0:dd-M月 -yy";
            DateTime publish_date = DateTime.Parse(dateTimePicker1.Text);
            //dateTimePicker1.Value.ToString();
            string r_date = String.Format("{0:dd-M月 -yy}", publish_date);
            //Console.WriteLine(r_date);
            string tmp = comboBox1.SelectedItem.ToString();
            string tempid = tmp.Substring(0,1);
            int classid = Convert.ToInt32(tempid);

            // Please replace the connection string attribute settings
            string constr = "";

            OracleConnection con = new OracleConnection(constr);
            con.Open();
            
            // SQL Statement
            string booksinsert = "insert into books values(" + bookid + ", '" + bookname + "', '" + author + "', '" + publisher + "'," + classid + "," + price + ",'" + r_date+"')";
            OracleCommand cmd = new OracleCommand(booksinsert, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            string sto = "insert into stocks values("+bookid+" , "+shelf+" , "+stock+")";
            OracleCommand storage = new OracleCommand(sto, con);
            storage.CommandType = CommandType.Text;
            storage.ExecuteNonQuery();
            id.Text = "";
            textBox1.Text = "";
            writer.Text = "";
            publishname.Text = "";
            textBox2.Text = "";
            //textBox4.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";

            
            //con.Close();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Publishname_TextChanged(object sender, EventArgs e)
        {

        }
    }

     } 