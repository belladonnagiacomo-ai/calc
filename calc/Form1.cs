namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, somma;
            n1 = Convert.ToInt32(num1txt.Text);
            n2 = Convert.ToInt32(num2txt.Text);
            somma = n1 + n2;
            lblris.Text = "Risultato: " + somma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, sottrazione;
            n1 = Convert.ToInt32(num1txt.Text);
            n2 = Convert.ToInt32(num2txt.Text);
            sottrazione = n1 - n2;
            lblris.Text = "Risultato: " + sottrazione;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2, molt;
            n1 = Convert.ToInt32(num1txt.Text);
            n2 = Convert.ToInt32(num2txt.Text);
            molt = n1 * n2;
            lblris.Text = "Risultato: " + molt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, div;
            n1 = Convert.ToInt32(num1txt.Text);
            n2 = Convert.ToInt32(num2txt.Text);
            if (n2 == 0)
            {
                lblris.Text = "impossibile ";
            }
            else
            {
                div = n1 / n2;
                lblris.Text = "Risultato: " + div;
            }
        }
    }
}
