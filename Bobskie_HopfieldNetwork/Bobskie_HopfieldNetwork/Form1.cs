namespace Bobskie_HopfieldNetwork
{
    public partial class Form1 : Form
    {
        int[] input;

        public Form1()
        {
            InitializeComponent();
            input = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.White)
            {
                button1.BackColor = Color.Black;
                input[0] = 1;
            }
            else
            {
                button1.BackColor = Color.White;
                input[0] = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                button2.BackColor = Color.Black;
                input[1] = 1;
            }
            else
            {
                button2.BackColor = Color.White;
                input[1] = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.White)
            {
                button3.BackColor = Color.Black;
                input[2] = 1;
            }
            else
            {
                button3.BackColor = Color.White;
                input[2] = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                button4.BackColor = Color.Black;
                input[3] = 1;
            }
            else
            {
                button4.BackColor = Color.White;
                input[3] = -1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.White)
            {
                button5.BackColor = Color.Black;
                input[4] = 1;
            }
            else
            {
                button5.BackColor = Color.White;
                input[4] = -1;
            }
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.White)
            {
                button6.BackColor = Color.Black;
                input[5] = 1;
            }
            else
            {
                button6.BackColor = Color.White;
                input[5] = -1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.White)
            {
                button7.BackColor = Color.Black;
                input[6] = 1;
            }
            else
            {
                button7.BackColor = Color.White;
                input[6] = -1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.White)
            {
                button8.BackColor = Color.Black;
                input[7] = 1;
            }
            else
            {
                button8.BackColor = Color.White;
                input[7] = -1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                button9.BackColor = Color.Black;
                input[8] = 1;
            }
            else
            {
                button9.BackColor = Color.White;
                input[8] = -1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();
        }



        private void compute()
        {
            int[,] weight = new int[9, 9]
                     {
                        { 0, 0, 2, -2, -2, -2, 2, 0, 2 },
                        { 0, 0, 0, 0, 0, 0, 0, 2, 0  },
                        { 2, 0, 0, -2, -2, -2, 2, 0, 2 },
                        { 2, 0, -2, 0, 2, 2, -2, 0, -2 },
                        { 2, 0, -2, 2, 0, 2, -2, 0, -2 },
                        { 2, 0, -2, 2, 2, 0, -2, 0, -2 },
                        { 2, 0, 2, -2, -2, -2, 0, 0, 2 },
                        { 0, 2, 0, 0, 0, 0, 0, 0, 0  },
                        { 2, 0, 2, -2, -2, -2, 2, 0, 0 }
                     };

            int[] output = new int[9];

            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                {
                    output[i] += (weight[i,j] * input[j]);
                }
            }

            output = thresholdFunc(output);
            outputRes(output);

        }

        private int[] thresholdFunc(int[] output) 
        { 
            for(int i=0; i<9; i++)
            {
                output[i] = (output[i] > 0) ? 1 : -1;
            }
            return output;
        }

        private void outputRes(int[] output)
        {
            button10.BackColor = (output[0] > 0)? Color.Black: Color.White;
            button11.BackColor = (output[1] > 0) ? Color.Black : Color.White;
            button12.BackColor = (output[2] > 0) ? Color.Black : Color.White;
            button13.BackColor = (output[3] > 0) ? Color.Black : Color.White;
            button14.BackColor = (output[4] > 0) ? Color.Black : Color.White;
            button15.BackColor = (output[5] > 0) ? Color.Black : Color.White;
            button16.BackColor = (output[6] > 0) ? Color.Black : Color.White;
            button17.BackColor = (output[7] > 0) ? Color.Black : Color.White;
            button18.BackColor = (output[8] > 0) ? Color.Black : Color.White;
        }




    }
}