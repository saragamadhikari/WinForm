using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm;
using simp;

namespace register_form
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

        private void LoadFormInPanel(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Show();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            LoadFormInPanel(regForm);  // ✅ Load inside panel instead of popping up
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            LoadFormInPanel(loginForm);  // ✅ Load inside panel
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simplecalculator simpleCalculatorForm = new simplecalculator();
            LoadFormInPanel(simpleCalculatorForm);  // ✅ Load inside panel
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      

        
        

        private void startTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }

        private void stopTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;
        }
    }
}
