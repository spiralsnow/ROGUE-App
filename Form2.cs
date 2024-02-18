using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ROGUE_App
{
    public partial class Form2 : Form
    {
        private bool isListening = false;
        private System.Windows.Forms.Timer simulationTimer = new System.Windows.Forms.Timer();
        private Random random = new Random();
        private int simulationInterval = 1000; // Default interval in milliseconds
        private Keys selectedKey = Keys.None;
        private MouseButtons selectedMouseButton = MouseButtons.None;

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        public Form2()
        {
            InitializeComponent();
            label4.Visible = false;
            currentDirectory = Directory.GetCurrentDirectory();
            pluginsDirectory = Path.Combine(currentDirectory, "plugins");

            // Set KeyPreview property to true
            this.KeyPreview = true;

            // Set up the Timer for simulation
            simulationTimer.Interval = simulationInterval;
            simulationTimer.Tick += SimulationTimer_Tick;

            // Set up the TrackBar for adjusting simulation interval
            trackBar1.Minimum = 50;
            trackBar1.Maximum = 1000;
            trackBar1.Value = simulationInterval; // Set the initial value
            trackBar1.ValueChanged += TrackBar1_ValueChanged;
        }

        public string currentDirectory;
        public string pluginsDirectory;

        private void label3_Click(object sender, EventArgs e) //begin
        {
            button4.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            // Start simulating key presses when "Begin" button is clicked
            simulationTimer.Start();
        }

        private void label4_Click(object sender, EventArgs e) //stop
        {
            label4.Visible = false;
            // Stop simulating key presses when "Stop" button is clicked
            simulationTimer.Stop();
        }

        private void button4_Click(object sender, EventArgs e) //listen
        {
            button4.Visible = false;
            button2.Visible = true;

            // Start listening when "Listen" button is clicked
            isListening = true;

            // Subscribe to KeyDown and MouseClick events
            this.KeyDown += Form2_KeyDown;
            this.MouseClick += Form2_MouseClick;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if we are currently listening
            if (isListening)
            {
                // Stop listening
                StopListening();

                // Set button3 text to the pressed key
                button3.Text = e.KeyCode.ToString();

                // Store the selected key
                selectedKey = e.KeyCode;
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if we are currently listening
            if (isListening)
            {
                // Stop listening
                StopListening();

                // Set button3 text to the pressed mouse button
                button3.Text = $"Mouse {e.Button.ToString()}";

                // Store the selected mouse button
                selectedMouseButton = e.Button;
            }
        }

        private void StopListening()
        {
            // Stop listening by unsubscribing from events
            isListening = false;
            this.KeyDown -= Form2_KeyDown;
            this.MouseClick -= Form2_MouseClick;

            // Hide button2 and show button1 again
            button4.Visible = true;
            button2.Visible = false;
            label3.Visible = true;
        }

        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            // Simulate key press or mouse click using the selected input
            if (selectedKey != Keys.None)
            {
                SimulateKeyPress(selectedKey);
            }
            else if (selectedMouseButton != MouseButtons.None)
            {
                SimulateMouseClick(selectedMouseButton);
            }

            // Adjust the timer interval for variability
            simulationTimer.Interval = simulationInterval + random.Next(-50, 50);
        }

        private void SimulateKeyPress(Keys key)
        {
            // Simulate a key press using SendKeys
            SendKeys.SendWait("{" + key.ToString() + "}");
        }

        private void SimulateMouseClick(MouseButtons button)
        {
            // Simulate a mouse click using mouse_event
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            switch (button)
            {
                case MouseButtons.Left:
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                    break;
                case MouseButtons.Right:
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                    break;
                    // Add handling for other mouse buttons if needed
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            // Adjust the simulation interval based on the value of trackBar1
            simulationInterval = trackBar1.Value;
        }
    }
}
