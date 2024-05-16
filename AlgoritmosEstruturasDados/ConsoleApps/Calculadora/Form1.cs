using System.Reflection;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindos a super Calculadora!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult respostaForm;
            respostaForm = MessageBox.Show("Queres mesmo sair?", "!!ATENÇÃO!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respostaForm == DialogResult.Yes)
                Application.Exit();
        }

        private void firstNumbertxtBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNumbertxtBox.Text == "" || secondNumbertxtBox.Text == "")
            {
                btnPlus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSubtract.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
                btnDivide.Enabled = true;
                btnMultiply.Enabled = true;
                btnSubtract.Enabled = true;
            }
        }

        private void secondNumbertxtBox_TextChanged(object sender, EventArgs e)
        {

            if (firstNumbertxtBox.Text == "" || secondNumbertxtBox.Text == "")
            {
                btnPlus.Enabled = false;
                btnDivide.Enabled = false;
                btnMultiply.Enabled = false;
                btnSubtract.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
                btnDivide.Enabled = true;
                btnMultiply.Enabled = true;
                btnSubtract.Enabled = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int result = 0;

            string unparsedValueFirstNumber = firstNumbertxtBox.Text;
            string unparsedValueSecondNumber = secondNumbertxtBox.Text;

            bool canParseFirstNumber = int.TryParse(unparsedValueFirstNumber, out int parsedValueFirstValue);
            bool canParseSecondNumber = int.TryParse(unparsedValueSecondNumber, out int parsedValueSecondValue);
            
            if (canParseFirstNumber && canParseSecondNumber)
            {
                    
                result = parsedValueFirstValue + parsedValueSecondValue;
            }
            else
            {
                MessageBox.Show("Error", "!!Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            resultTextBox.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = Convert.ToString(Convert.ToInt32(firstNumbertxtBox.Text) - Convert.ToInt32(secondNumbertxtBox.Text));

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = Convert.ToString(Convert.ToInt32(firstNumbertxtBox.Text) * Convert.ToInt32(secondNumbertxtBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex}");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try 
            { 
                resultTextBox.Text = Convert.ToString(Convert.ToInt32(firstNumbertxtBox.Text) / Convert.ToInt32(secondNumbertxtBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex}");
            }
        }
    }
}
