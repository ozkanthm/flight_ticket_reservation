namespace uçak_bilet_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Güzergah = " + comboBox1.Text + " -> " + comboBox2.Text + "  Tarih = " + dateTimePicker1.Text + "Saat = " + maskedTextBox1.Text
                +" Yolcu Bilgileri :::> Ad =  "+textBox1.Text+" TC = "+maskedTextBox2.Text+" Telefon = "+maskedTextBox3.Text);
            MessageBox.Show("Bilgileriniz kaydoldu...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ykalkis = comboBox1.Text;
            string yvaris = comboBox2.Text;
            comboBox2.Text = ykalkis;
            comboBox1.Text = yvaris;
        }
    }
}