using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_sevenSegmentClock
{
    public partial class sevensegmentclock : Form
    {
        public sevensegmentclock()
        {
            InitializeComponent();
        }

        // initialize table layout panels on a list
        // var panels = new List<TableLayoutPanel>() {h1, h2, m1, m2, s1, s2};

        private void loadTime(object sender, EventArgs e)
        {
            // string current = DateTime.Now.ToShortTimeString();
            // char[] time = current.Remove(all letters & symbols).Split();

            // for (int i = 0; i < time.length; i++)
            //      printSegment(panels[i], time[i]);
        }

        private void printSegment(TableLayoutPanel tlp, char val)
        {
            // Button[7] buttons;

            // foreach (var button in tlp.Controls.TypeOf<Button>)
                // buttons[Int32.parse(button.Text[2])] = button;

            // bool[] segments;
            // switch (val)
                // case '1':
                    // segments = {true, true, true, true, ...}; break;
                // case '2':
                    // segments = {false, true, true, false, ...}; break;
                // ...

            // for (int i = 0, n = buttons.length; i < n; i++)
                // if segments[i]
                    // buttons[i].Color = black;
                // else 
                    // buttons[i].Color = white;
        }
    }
}
