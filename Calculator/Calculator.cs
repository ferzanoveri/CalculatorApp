namespace Calculator
{
    public partial class Calculator : Form
    {

        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        private int operatorPicked = 0; // 0 belum memilih operator (default state) atau state setelah menenekan tombol "=" 
        private int firstValueInserted = 0; // nilai pertama sudah masuk ke variabel valueFirst
        private int doneCompute = 0; // selesai proses komputasi

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            TxtBox.Text = "0";
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            result = 0.0m;
            operators = "+";
            operatorPicked = 0;
            firstValueInserted = 0;
            doneCompute = 0;
        }

        private void computeState(int doneCompute) // sudah menjalankan proses komputasi
        {
            if (doneCompute == 1)
            {
                Reset();
            }
        }

        private void operaterClickedVariableStatus() // set status variabel setelah memilih operator
        {
            operatorPicked = 1;
            firstValueInserted = 1;
            doneCompute = 0;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (!TxtBox.Text.Equals("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            computeState(doneCompute);

            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void SubstractBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
          //  TxtBox.Text = "fIRST vALUE = " + valueFirst.ToString();
            operators = "-";
            operaterClickedVariableStatus();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
            operaterClickedVariableStatus();
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
            operaterClickedVariableStatus();
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "x";
            operaterClickedVariableStatus();
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            int repeatEqualBtn = 0;
            int equalBeforeOperation = 0;

            if (operatorPicked == 0)
            {
                /*decimal temp = decimal.Parse(TxtBox.Text);
                result = temp - 0;
                TxtBox.Text = result.ToString();*/
                repeatEqualBtn = 1;
            }

            if (firstValueInserted == 0) // cuma klik2 angka tanpa memilih operator
            {
                equalBeforeOperation = 1; 
            }
          
            switch (operators)
            {
                case "-":
                    if (string.IsNullOrEmpty(TxtBox.Text))
                    {
                        break;
                    }

                    if (repeatEqualBtn == 0)
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                    }
                    else
                    {
                        valueFirst = result;
                    } 
                    

                    result = valueFirst - valueSecond;
                    TxtBox.Text = result.ToString();
                   // TxtBox.Text = valueFirst.ToString() + " - " + valueSecond.ToString() + " = " + result.ToString();
                    operatorPicked = 0;
                    doneCompute = 1;
                    break;

                case "+":
                    if (equalBeforeOperation == 1)
                    {
                        break;
                    }

                    if (string.IsNullOrEmpty(TxtBox.Text))
                    {
                        break;
                    }

                    if (repeatEqualBtn == 0)
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                    }
                    else
                    {
                        valueFirst = result;
                    }
                    result = valueFirst + valueSecond;
                    TxtBox.Text = result.ToString();
                    operatorPicked = 0;
                    doneCompute = 1;
                    break;

                case "/":
                    if (string.IsNullOrEmpty(TxtBox.Text))
                    {
                        break;
                    }

                    if (repeatEqualBtn == 0)
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                    }
                    else
                    {
                        valueFirst = result;
                    }
                    result = valueFirst / valueSecond;
                    TxtBox.Text = result.ToString();
                    operatorPicked = 0;
                    doneCompute = 1;
                    break;

                case "x":
                    if (string.IsNullOrEmpty(TxtBox.Text))
                    {
                        break;
                    }

                    if (repeatEqualBtn == 0)
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                    }
                    else
                    {
                        valueFirst = result;
                    }
                    result = valueFirst * valueSecond;
                    TxtBox.Text = result.ToString();
                    operatorPicked = 0;
                    doneCompute = 1;
                    break;

            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ClearSegmentBtn_Click(object sender, EventArgs e)
        {
            if (operatorPicked != 0) // operator sudah dipilih 
            {
                if (TxtBox.Text != "0")
                {
                    TxtBox.Text = "0";
                }
                else if (TxtBox.Text == "0")
                {
                    Reset();
                }




                /* if (valueFirst != 0) // clear box nilai kedua (secondValue) posisi sudah memilih operator 
                {
                    TxtBox.Text = "0";
                    valueFirst = 0;
                    valueSecond = 0;
                    operators = "+";
                    result = 0;
                }
                else // delete nilai pertama
                {
                    TxtBox.Text = "0";
                }
            }
            else
            {
                if (valueFirst == 0) // blom memilih operator
                {
                    TxtBox.Text = "0";
                }
                else // sudah memilih operator
                {

                }
            } */

            }
            else
            { // state sebelum memilih operator atau state setelah menenekan tombol "=" 
                Reset();
            }
        }
    }
}