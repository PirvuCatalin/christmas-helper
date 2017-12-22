namespace WindowsFormsApp3
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private IContainer components = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;

        public Form1()
        {
            this.InitializeComponent();
        }

        public void AddText(string Text)
        {
            this.textBox1.AppendText(Environment.NewLine + Text);
        }

        public void AddTextWait(string Text)
        {
            Thread.Sleep(0x7d0);
            this.textBox1.AppendText(Environment.NewLine + Text);
        }

        public void AllItemsList(string[] PresentsList, string[] ChildrenList, int CurrentNumber)
        {
            this.textBox1.AppendText(Environment.NewLine + PresentsList[CurrentNumber] + "  ---->  " + ChildrenList[CurrentNumber]);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            new MyClass().MyMethod(this, 1, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button8.Visible = true;
            this.textBox1.Clear();
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button7.Visible = false;
            new MyClass().MyMethod(this, 2, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button8.Visible = true;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.button7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (((((this.textBox2.Text == "catalin") && (this.textBox3.Text == "parolamea")) || ((this.textBox2.Text == "eduardo") && (this.textBox3.Text == "boss"))) || ((this.textBox2.Text == "student") && (this.textBox3.Text == "student"))) || ((this.textBox2.Text == "vreau sa intru") && (this.textBox3.Text == "chiar vreau")))
            {
                this.button5.Visible = true;
                this.button1.Visible = true;
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.button4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            new MyClass().MyMethod(this, 3, null);
            this.button5.Visible = false;
            this.textBox4.Visible = true;
            this.button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MyClass().MyMethod(this, 4, this.textBox4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button8.Visible = true;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button7.Visible = false;
            new MyClass().MyMethod(this, 5, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = true;
            this.textBox1.Clear();
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
        }

        public void ChangeText(string[] PresentsList, int PresentNumber)
        {
            this.textBox1.AppendText(Environment.NewLine + PresentsList[PresentNumber] + "---->");
        }

       // protected override void Dispose(bool disposing)
       // {
        //    if (disposing && (this.components > null))
        //    {
       //         this.components.Dispose();
       //     }
      //      base.Dispose(disposing);
     //   }

        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.button5 = new Button();
            this.textBox4 = new TextBox();
            this.button6 = new Button();
            this.button7 = new Button();
            this.button8 = new Button();
            base.SuspendLayout();
            this.button1.Location = new Point(0x2a, 0xd6);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x15c, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show all gifts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox1.Location = new Point(40, 0x15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            this.textBox1.Size = new Size(0x355, 0x9f);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.button2.Location = new Point(0x18a, 0x11d);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0x87, 0x4a);
            this.button2.TabIndex = 2;
            this.button2.Text = "How is a normal day\r\nat the\r\n North Pole?\r\n(Warning: they are long)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button3.Location = new Point(0x8a, 0x11d);
            this.button3.Name = "button3";
            this.button3.Size = new Size(0x93, 0x4a);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sign In";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.Location = new Point(0x196, 0x125);
            this.button4.Name = "button4";
            this.button4.Size = new Size(0x71, 0x3a);
            this.button4.TabIndex = 4;
            this.button4.Text = "Enter System";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new EventHandler(this.button4_Click);
            this.textBox2.Location = new Point(0x110, 0xec);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x8b, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "username";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            this.textBox3.Location = new Point(520, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(0x8b, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "password";
            this.textBox3.Visible = false;
            this.button5.Location = new Point(0x217, 0xd6);
            this.button5.Name = "button5";
            this.button5.Size = new Size(0x15c, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Search a gift";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBox4.Location = new Point(0x18a, 0xba);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(0x87, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
            this.button6.Location = new Point(0x18c, 0xe3);
            this.button6.Name = "button6";
            this.button6.Size = new Size(0x85, 0x25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Search!";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new EventHandler(this.button6_Click);
            this.button7.Location = new Point(0x279, 0x11d);
            this.button7.Name = "button7";
            this.button7.Size = new Size(0x93, 0x4a);
            this.button7.TabIndex = 10;
            this.button7.Text = "How's the Christmas night\r\n going to be?\r\n(disclaimer: it will be \r\neven longer)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new EventHandler(this.button7_Click);
            this.button8.Location = new Point(0x328, 0x167);
            this.button8.Name = "button8";
            this.button8.Size = new Size(0x4b, 0x27);
            this.button8.TabIndex = 11;
            this.button8.Visible = false;
            this.button8.Text = "Go to main page";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new EventHandler(this.button8_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x39a, 420);
            base.Controls.Add(this.button8);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button1);
            base.Name = "Form1";
            this.Text = "Christmas Utility";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        public void UpdateSuggestions(string[] PresentsList)
        {
            this.textBox4.AutoCompleteCustomSource.AddRange(PresentsList);
        }
    }
}

