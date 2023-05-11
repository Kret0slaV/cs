using System.Security.Cryptography.X509Certificates;

namespace oncczejńdż
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int licz1 = (int)numericUpDown1.Value;
            int licz2 = (int)numericUpDown2.Value;
            int suuma = licz1 + licz2;
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            suma.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            suma.Text = suuma.ToString();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            numericUpDown2.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            numericUpDown1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int licz1 = (int)numericUpDown1.Value;
            int licz2 = (int)numericUpDown2.Value;
            int suuma = licz1 + licz2;
            suma.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            suma.Text = suuma.ToString();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            numericUpDown2.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            numericUpDown1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}