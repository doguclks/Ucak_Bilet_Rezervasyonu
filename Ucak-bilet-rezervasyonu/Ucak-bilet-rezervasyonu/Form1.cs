namespace Ucak_bilet_rezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Track: " + comboBox1.Text + " - " + comboBox2.Text + " Date: " + dateTimePicker2.Text + " Time: " + maskedTextBox1.Text + "Passenger Information -- " + " Name-Surname:" + textBox1.Text + " TC" + maskedTextBox2.Text + " Phone: " + maskedTextBox3.Text);
            MessageBox.Show("Registration Sucessful");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp;
            temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
            
        }
    }
}