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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //我要找書的按鈕跳出我要找書的視窗
            Form2find find = new Form2find();
            find.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {    
            //我要新增的按鈕跳出新增資料的視窗
            Form3add add = new Form3add();
            add.Show();

        }

        private void Test_Click(object sender, EventArgs e)
        {
            Form0test test = new Form0test();
            test.Show(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4delete delete = new Form4delete();
            delete.Show(this);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5recods buy = new Form5recods();
            buy.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form6rank rank = new Form6rank();
            rank.Show();

        }
    }
}
