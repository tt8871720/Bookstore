using System;

namespace bookstore
{
    partial class Form3add
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
            this.lebel1 = new System.Windows.Forms.Label();
            this.lebel2 = new System.Windows.Forms.Label();
            this.lebel3 = new System.Windows.Forms.Label();
            this.lebel4 = new System.Windows.Forms.Label();
            this.lebel6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.publishname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.writer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lebel0 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel1.Location = new System.Drawing.Point(46, 44);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(94, 20);
            this.lebel1.TabIndex = 0;
            this.lebel1.Text = "書籍編號:";
            // 
            // lebel2
            // 
            this.lebel2.AutoSize = true;
            this.lebel2.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel2.Location = new System.Drawing.Point(46, 106);
            this.lebel2.Name = "lebel2";
            this.lebel2.Size = new System.Drawing.Size(54, 20);
            this.lebel2.TabIndex = 1;
            this.lebel2.Text = "書名:";
            this.lebel2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lebel3
            // 
            this.lebel3.AutoSize = true;
            this.lebel3.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel3.Location = new System.Drawing.Point(46, 166);
            this.lebel3.Name = "lebel3";
            this.lebel3.Size = new System.Drawing.Size(54, 20);
            this.lebel3.TabIndex = 2;
            this.lebel3.Text = "作者:";
            this.lebel3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lebel4
            // 
            this.lebel4.AutoSize = true;
            this.lebel4.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel4.Location = new System.Drawing.Point(46, 232);
            this.lebel4.Name = "lebel4";
            this.lebel4.Size = new System.Drawing.Size(74, 20);
            this.lebel4.TabIndex = 3;
            this.lebel4.Text = "出版社:";
            this.lebel4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lebel6
            // 
            this.lebel6.AutoSize = true;
            this.lebel6.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel6.Location = new System.Drawing.Point(46, 359);
            this.lebel6.Name = "lebel6";
            this.lebel6.Size = new System.Drawing.Size(94, 20);
            this.lebel6.TabIndex = 5;
            this.lebel6.Text = "類別代碼:";
            this.lebel6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(477, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "新增一筆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // publishname
            // 
            this.publishname.Location = new System.Drawing.Point(146, 227);
            this.publishname.Name = "publishname";
            this.publishname.Size = new System.Drawing.Size(100, 25);
            this.publishname.TabIndex = 8;
            this.publishname.TextChanged += new System.EventHandler(this.Publishname_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 25);
            this.textBox3.TabIndex = 9;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("新細明體", 12F);
            this.id.Location = new System.Drawing.Point(146, 41);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 31);
            this.id.TabIndex = 12;
            this.id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // writer
            // 
            this.writer.Font = new System.Drawing.Font("新細明體", 12F);
            this.writer.Location = new System.Drawing.Point(146, 163);
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(100, 31);
            this.writer.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(405, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "價錢:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(405, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "架上幾本:";
            // 
            // lebel0
            // 
            this.lebel0.AutoSize = true;
            this.lebel0.Font = new System.Drawing.Font("新細明體", 12F);
            this.lebel0.Location = new System.Drawing.Point(405, 226);
            this.lebel0.Name = "lebel0";
            this.lebel0.Size = new System.Drawing.Size(94, 20);
            this.lebel0.TabIndex = 19;
            this.lebel0.Text = "庫存幾本:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(46, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "出版日:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox6.Location = new System.Drawing.Point(520, 226);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 31);
            this.textBox6.TabIndex = 38;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox7.Location = new System.Drawing.Point(520, 166);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 31);
            this.textBox7.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("新細明體", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox1.Location = new System.Drawing.Point(146, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 42;
            // 
            // Form3add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lebel0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writer);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.publishname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lebel6);
            this.Controls.Add(this.lebel4);
            this.Controls.Add(this.lebel3);
            this.Controls.Add(this.lebel2);
            this.Controls.Add(this.lebel1);
            this.Name = "Form3add";
            this.Text = "Form3add";
            this.Load += new System.EventHandler(this.Form3add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.Label lebel2;
        private System.Windows.Forms.Label lebel3;
        private System.Windows.Forms.Label lebel4;
        private System.Windows.Forms.Label lebel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox publishname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox writer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lebel0;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}