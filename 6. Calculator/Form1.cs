using System;
using System.Windows.Forms;

namespace _6.Calculator
{
    public partial class FormMain : Form
    {
        private double dResult;
        private char cOperator;
        private double MemVal = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ValueEnterEvent(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //Skip normal operation of text box. We will add text via a function call instead.
            ValueEnter(e.KeyChar);
        }

        private void ValueEnter(char key)
        {
            if (key.ToString().IndexOfAny("+-*/".ToCharArray()) > -1)
            {
                Evaluate();
                ChangeOperator(key);
                tbMain.Clear();
                return;
            }
            else if (key == '=' || key == (char)13)
            {
                Evaluate();
                ChangeOperator(' ');
                tbMain.Clear();
                return;
            }
            else if (Char.IsControl(key))
            {
                //Allows things like backspace
                return;
            }

            try
            {
                //Try to convert the resulting text into a double
                Convert.ToDouble(tbMain.Text + key.ToString());
                tbMain.Text += key;
            }
            catch (FormatException) //If it cannot do so
            {
                //Don't add this character to the existing string
                return;
            }
        }

        private void Evaluate()
        {
            double dTextBoxValue = 0;
            try
            {
                dTextBoxValue = Convert.ToDouble(tbMain.Text);
            }
            catch (FormatException)
            {
                //If the text box isn't a valid number, don't do anything
                return;
            }
            switch (cOperator)
            {
                case '+':
                    ChangeOperator(' ');
                    dResult = dResult + dTextBoxValue;
                    break;

                case '-':
                    ChangeOperator(' ');
                    dResult = dResult - dTextBoxValue;
                    break;

                case '*':
                    ChangeOperator(' ');
                    dResult = dResult * dTextBoxValue;
                    break;

                case '/':
                    ChangeOperator(' ');
                    dResult = dResult / dTextBoxValue;
                    break;

                default:
                    dResult = dTextBoxValue;
                    lResult.Text = dResult.ToString();
                    break;
            }

            lResult.Text = dResult.ToString();

            return;
        }

        private void ChangeOperator(char op)
        {
            cOperator = op;
            lOperator.Text = cOperator.ToString();
        }

        #region Numeric Buttons

        private void bZero_Click(object sender, EventArgs e)
        {
            ValueEnter('0');
        }

        private void bOne_Click(object sender, EventArgs e)
        {
            ValueEnter('1');
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            ValueEnter('2');
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            ValueEnter('3');
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            ValueEnter('4');
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            ValueEnter('5');
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            ValueEnter('6');
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            ValueEnter('7');
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            ValueEnter('8');
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            ValueEnter('9');
        }

        private void bRadix_Click(object sender, EventArgs e)
        {
            ValueEnter('.');
        }

        #endregion Numeric Buttons

        #region Functional Buttons

        private void bEquals_Click(object sender, EventArgs e)
        {
            ValueEnter('=');
        }

        private void bAns_Click(object sender, EventArgs e)
        {
            tbMain.Text = lResult.Text;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbMain.Clear();
            ChangeOperator(' ');
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            ValueEnter('/');
        }

        private void bTimes_Click(object sender, EventArgs e)
        {
            ValueEnter('*');
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            ValueEnter('-');
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            ValueEnter('+');
        }

        #endregion Functional Buttons

        #region Memory Buttons

        private void bMC_Click(object sender, EventArgs e)
        {
            MemVal = 0;
            lMemVal.Text = MemVal.ToString();
        }

        private void bMR_Click(object sender, EventArgs e)
        {
            tbMain.Text = MemVal.ToString();
        }

        private void bMMinus_Click(object sender, EventArgs e)
        {
            MemVal -= Convert.ToDouble(tbMain.Text);
            lMemVal.Text = MemVal.ToString();
        }

        private void mMPlus_Click(object sender, EventArgs e)
        {
            MemVal += Convert.ToDouble(lResult.Text);
            lMemVal.Text = MemVal.ToString();
        }

        #endregion Memory Buttons
    }
}