using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poduszki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddButtonsToList();
            AddCheckers();
        }

        Game game = new Game();
        List<Button> buttons = new List<Button>();
        List<Button> blue = new List<Button>();
        List<Button> green = new List<Button>();
        List<Button> red = new List<Button>();
        List<Button> yellow = new List<Button>();
        List<Button> pushbuttons = new List<Button>();
        Stopwatch stopwatch = new Stopwatch();

        private void AddButtonsToList()
        {
            foreach (Button b in groupBox1.Controls.OfType<Button>())
            {
                buttons.Add(b);
            }
        }

        private void AddCheckers()
        {
            blue.Add(button1_1);
            blue.Add(button1_2);
            blue.Add(button1_3);
            blue.Add(button2_1);
            blue.Add(button2_2);
            blue.Add(button2_3);
            blue.Add(button3_1);
            blue.Add(button3_2);
            blue.Add(button3_3);

            green.Add(button1_4);
            green.Add(button1_5);
            green.Add(button1_6);
            green.Add(button2_4);
            green.Add(button2_5);
            green.Add(button2_6);
            green.Add(button3_4);
            green.Add(button3_5);
            green.Add(button3_6);

            red.Add(button4_1);
            red.Add(button4_2);
            red.Add(button4_3);
            red.Add(button5_1);
            red.Add(button5_2);
            red.Add(button5_3);
            red.Add(button6_1);
            red.Add(button6_2);
            red.Add(button6_3);

            yellow.Add(button4_4);
            yellow.Add(button4_5);
            yellow.Add(button4_6);
            yellow.Add(button5_4);
            yellow.Add(button5_5);
            yellow.Add(button5_6);
            yellow.Add(button6_4);
            yellow.Add(button6_5);
            yellow.Add(button6_6);

            pushbuttons.Add(push1);
            pushbuttons.Add(push2);
            pushbuttons.Add(push3);
            pushbuttons.Add(push4);
            pushbuttons.Add(push5);
            pushbuttons.Add(push6);
            pushbuttons.Add(push7);
            pushbuttons.Add(push8);
            pushbuttons.Add(push9);
            pushbuttons.Add(push10);
            pushbuttons.Add(push11);
            pushbuttons.Add(push12);
        }



        private void push1_Click(object sender, EventArgs e)
        {
            game.Push(button1_1, button2_1, button3_1, button4_1, button5_1, button6_1, container1Button, container2Button);
            CheckResult();
        }

        private void push2_Click(object sender, EventArgs e)
        {
            game.Push(button1_2, button2_2, button3_2, button4_2, button5_2, button6_2, container1Button, container2Button);
            CheckResult();
        }

        private void push3_Click(object sender, EventArgs e)
        {
            game.Push(button1_3, button2_3, button3_3, button4_3, button5_3, button6_3, container1Button, container2Button);
            CheckResult();
        }

        private void push4_Click(object sender, EventArgs e)
        {
            game.Push(button1_4, button2_4, button3_4, button4_4, button5_4, button6_4, container1Button, container2Button);
            CheckResult();
        }

        private void push5_Click(object sender, EventArgs e)
        {
            game.Push(button1_5, button2_5, button3_5, button4_5, button5_5, button6_5, container1Button, container2Button);
            CheckResult();
        }

        private void push6_Click(object sender, EventArgs e)
        {
            game.Push(button1_6, button2_6, button3_6, button4_6, button5_6, button6_6, container1Button, container2Button);
            CheckResult();
        }

        private void push7_Click(object sender, EventArgs e)
        {
            game.Push(button1_1, button1_2, button1_3, button1_4, button1_5, button1_6, container1Button, container2Button);
            CheckResult();
        }

        private void push8_Click(object sender, EventArgs e)
        {
            game.Push(button2_1, button2_2, button2_3, button2_4, button2_5, button2_6, container1Button, container2Button);
            CheckResult();
        }

        private void push9_Click(object sender, EventArgs e)
        {
            game.Push(button3_1, button3_2, button3_3, button3_4, button3_5, button3_6, container1Button, container2Button);
            CheckResult();
        }

        private void push10_Click(object sender, EventArgs e)
        {
            game.Push(button4_1, button4_2, button4_3, button4_4, button4_5, button4_6, container1Button, container2Button);
            CheckResult();
        }

        private void push11_Click(object sender, EventArgs e)
        {
            game.Push(button5_1, button5_2, button5_3, button5_4, button5_5, button5_6, container1Button, container2Button);
            CheckResult();
        }

        private void push12_Click(object sender, EventArgs e)
        {
            game.Push(button6_1, button6_2, button6_3, button6_4, button6_5, button6_6, container1Button, container2Button);
            CheckResult();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            foreach (var push in pushbuttons)
            {
                push.Enabled = true;
            }
            game.ResetColors();
            foreach (var b in buttons)
            {
                game.InitializeGame(b);
            }
            startButton.Enabled = false;
            stopwatch.Start();
            timer1.Start();
        }

        private void CheckResult()
        {
            bool blue = CheckBlue();
            bool green = CheckGreen();
            bool red = CheckRed();
            bool yellow = CheckYellow();

            if (blue == true && green == true && red == true && yellow == true)
            {
                
                
                foreach (var push in pushbuttons)
                {
                    push.Enabled = false;
                }
                startButton.Enabled = true;
                stopwatch.Stop();
                stopwatch.Reset();
                timer1.Stop();
                MessageBox.Show("Gratulacje, wygrałeś!");
            }
        }


        private bool CheckBlue()
        {
            int check = 0;
            foreach (var b in blue)
            {
                if (b.BackColor == Color.Blue)
                {
                    check++;
                }
            }
            if (check == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckRed()
        {
            int check = 0;
            foreach (var b in red)
            {
                if (b.BackColor == Color.DarkRed)
                {
                    check++;
                }
            }
            if (check == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckGreen()
        {
            int check = 0;
            foreach (var b in green)
            {
                if (b.BackColor == Color.Green)
                {
                    check++;
                }
            }
            if (check == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckYellow()
        {
            int check = 0;
            foreach (var b in yellow)
            {
                if (b.BackColor == Color.Yellow)
                {
                    check++;
                }
            }
            if (check == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
        }

        

        
       
    }
}
