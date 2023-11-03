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
            string txtName = textBox1.Text;
            string combex = comboBox1.SelectedItem.ToString();

            if (txtName == "")
            {
                MessageBox.Show("Enter the Name");
                return;
            }

            if (listBox1.Items.Contains(txtName) || listBox2.Items.Contains(txtName) || listBox3.Items.Contains(txtName))
            {
                MessageBox.Show("This Task Name already Saved ");
                return;
            }


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
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}