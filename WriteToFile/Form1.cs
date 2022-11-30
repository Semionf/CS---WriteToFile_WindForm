using System;
using System.Windows.Forms;

namespace WriteToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum WorkDays
        {
            Sunday,
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
        }
        public WorkDays wd;
        public static int num = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("PersonData.txt");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.Close();
            textBox1.Text = "Please enter name";
            textBox2.Text = "Please enter age";
            textBox3.Text = "Please enter day";
            num = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextClicked(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox2_TextClicked(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox3_TextClicked(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            textBox1.Text = File.ReadLines("PersonData.txt").Skip(num).Take(1).First();
            num++;
            textBox2.Text = File.ReadLines("PersonData.txt").Skip(num).Take(1).First();
            num++;
            textBox3.Text = File.ReadLines("PersonData.txt").Skip(num).Take(1).First();
            num++;
            wd = (WorkDays)Enum.Parse(typeof(WorkDays), textBox3.Text);
            }catch(InvalidOperationException ex)
            {

            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0) {
                textBox1.Text = "Please enter name";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "Please enter age";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                textBox3.Text = "Please enter day";
            }
        }
    }
}