using System.Xml.Linq;

namespace register_form
{
    public partial class Register : Form

    {
        // Declare the Province ➔ District mapping dictionary here
        private Dictionary<string, string[]> provinceDistricts;
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Populate Provinces
            //comboBox1.Items.AddRange(new string[] { "Bagmati", "Lumbini", "Province 1", "Gandaki", "Karnali", "Sudurpashchim", "Madhesh" });

            //// Populate Districts
            //comboBox2.Items.AddRange(new string[] { "Kathmandu", "Lalitpur", "Bhaktapur", "Chitwan", "Pokhara" });

            // Populate Skills (Java, JS)
            checkedListBox1.Items.Add("Java");
            checkedListBox1.Items.Add("JavaScript");
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                return;
            }

            // Validate Age
            int age = (int)numericUpDown1.Value;
            if (age <= 16 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 16 and 120.");
                numericUpDown1.Focus();
                return;
            }

            // Validate Province
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a province.");
                comboBox1.Focus();
                return;
            }

            // Validate District
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a district.");
                comboBox2.Focus();
                return;
            }

            // Validate Skills (at least one selected)
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one skill.");
                checkedListBox1.Focus();
                return;
            }

            // If all validations pass
            MessageBox.Show("Registration Successful!");


            //// Clear textboxes
            //textBox1.Clear();

            //// Reset NumericUpDown
            //numericUpDown1.Value = numericUpDown1.Minimum;

            //// Reset ComboBoxes
            //comboBox1.SelectedIndex = -1;
            //comboBox2.SelectedIndex = -1;

            //// Uncheck all in CheckedListBox
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, false);
            //}

            //// Optionally clear any message labels
            //// label9.Text = "";

            //MessageBox.Show("Form has been reset!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();
            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the text fields
            textBox1.Clear();

            // Reset the numeric up-down control
            numericUpDown1.Value = numericUpDown1.Minimum;

            // Reset combo boxes
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Uncheck all items in the checked list box
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
    }

