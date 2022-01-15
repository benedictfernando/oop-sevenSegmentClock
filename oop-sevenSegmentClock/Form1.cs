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
        // Declare list of table layout panels
        List<TableLayoutPanel> panels = new List<TableLayoutPanel>();

        public sevensegmentclock()
        {
            InitializeComponent();

            // Add tables to global list
            panels.Add(h1); panels.Add(h2);
            panels.Add(m1); panels.Add(m2);
            panels.Add(s1); panels.Add(s2);
        }

        private void loadTime(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HHmmss");
            for (int i = 0, n = time.Length; i < n; i++)
                printSegment(panels[i], time[i]);
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
