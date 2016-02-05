using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poduszki
{
    class Game
    {

        public Random r = new Random();

        private int bluepillows = 0;
        private int yellowpillows = 0;
        private int redpillows = 0;
        private int greenpillows = 0;

        public void InitializeGame(Button button)
        {
            int i = 0;
            while(i < 1)
            {
                int pillowGenerated = r.Next(0, 4);
                if (pillowGenerated == 0)
                {
                    if (bluepillows < 9)
                    {
                        button.BackColor = Color.Blue;
                        bluepillows++;
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else if (pillowGenerated == 1)
                {
                    if (greenpillows < 9)
                    {
                        button.BackColor = Color.Green;
                        greenpillows++;
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else if (pillowGenerated == 2)
                {
                    if (redpillows < 9)
                    {
                        button.BackColor = Color.DarkRed;
                        redpillows++;
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else if (pillowGenerated == 3)
                {
                    if (yellowpillows < 9)
                    {
                        button.BackColor = Color.Yellow;
                        yellowpillows++;
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                }
            }
           
               

        }

        public void ResetColors()
        {
            bluepillows = 0;
            yellowpillows = 0;
            redpillows = 0;
            greenpillows = 0;
        }

        public void Push(Button first, Button second, Button third, Button fourth, Button fifth, Button sixth, Button container1, Button container2)
        {
            container1.BackColor = first.BackColor;
            first.BackColor = sixth.BackColor;
            container2.BackColor = second.BackColor;
            second.BackColor = container1.BackColor;
            container1.BackColor = third.BackColor;
            third.BackColor = container2.BackColor;
            container2.BackColor = fourth.BackColor;
            fourth.BackColor = container1.BackColor;
            container1.BackColor = fifth.BackColor;
            fifth.BackColor = container2.BackColor;
            sixth.BackColor = container1.BackColor;

        }
    }
}
