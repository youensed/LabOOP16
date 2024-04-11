using System.Net;

namespace LabOOP16
{
    public partial class Form1 : Form
    {
        Address address;
        public Form1()
        {

            InitializeComponent();
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                labelResult.Text = "Заповніть усі поля!";
                return;
            }
            address = new Address(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            labelResult.Text = $"Ваше місто: м.{address.City}, вул.{address.Street}, {address.Number}";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Address.Remove(address);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            labelResult.Text = "Об'єкт видалено ";
        }


    }
}