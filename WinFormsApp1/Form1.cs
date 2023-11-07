using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("select item");
            comboBox1.SelectedItem = "select item";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtName = textBox1.Text.Trim();
            string combex = comboBox1.SelectedItem.ToString();

            if (listBox1.Items.Contains(txtName) || listBox2.Items.Contains(txtName) || listBox3.Items.Contains(txtName))
            {
                MessageBox.Show("This item already Saved");
                return;
            }

            if (txtName == "")
            {
                MessageBox.Show("Enter the Name");
                return;
            }

            if (combex == "Finished")
            {
                listBox1.Items.Add(txtName);
                textBox1.Clear();
            }
            else if (combex == "Pending")
            {
                listBox2.Items.Add(txtName);
            }
            else if (combex == "in Progress")
            {
                listBox3.Items.Add(txtName);
            }
            else
            {
                MessageBox.Show("Invalid Tesk Status");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string txtName = textBox1.Text;
            string combex = comboBox1.SelectedItem.ToString();

            if (txtName == "")
            {
                MessageBox.Show("enter the name");
                return;
            }

            if (listBox1.Items.Contains(txtName))
            {


                if (combex == "Finished")
                {
                    listBox1.Items.Add(txtName);

                    //textBox1.Clear();
                }
                else if (combex == "Pending")
                {
                    listBox2.Items.Add(txtName);
                }
                else if (combex == "in Progress")
                {
                    listBox3.Items.Add(txtName);
                }
                else
                {
                    MessageBox.Show("Invalid Tesk Status");
                }
                listBox1.Items.Remove(txtName);

            }
            else if (listBox2.Items.Contains(txtName))
            {
                listBox2.Items.Remove(txtName);


                if (combex == "Finished")
                {
                    listBox1.Items.Add(txtName);

                    //textBox1.Clear();
                }
                else if (combex == "Pending")
                {
                    listBox2.Items.Add(txtName);
                }
                else if (combex == "in Progress")
                {
                    listBox3.Items.Add(txtName);
                }
                else
                {
                    MessageBox.Show("Invalid Tesk Status");
                }

            }
            else if (listBox3.Items.Contains(txtName))
            {
                listBox3.Items.Remove(txtName);


                if (combex == "Finished")
                {
                    listBox1.Items.Add(txtName);

                    //textBox1.Clear();
                }
                else if (combex == "Pending")
                {
                    listBox2.Items.Add(txtName);
                }
                else if (combex == "in Progress")
                {
                    listBox3.Items.Add(txtName);
                }
                else
                {
                    MessageBox.Show("Invalid Tesk Status");
                }

            }
            else
            {
                MessageBox.Show("Mawalantahy adi ");
            }
        }
    }
}