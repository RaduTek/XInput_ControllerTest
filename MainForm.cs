using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;

namespace ControllerTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Controller controller = null;

        private void logPrintLine(string s)
        {
            logBox.Text += s + "\r\n";
            logBox.Select(logBox.Text.Length - 1, 0);
            logBox.ScrollToCaret();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadController(1);
        }


        private void loadController(decimal index)
        {
            enablePolling.Checked = testVibration.Checked = false;

            UserIndex userIndex = UserIndex.One;

            if (index == 1) userIndex = UserIndex.One;
            else if (index == 2) userIndex = UserIndex.Two;
            else if (index == 3) userIndex = UserIndex.Three;
            else if (index == 4) userIndex = UserIndex.Four;

            controller = new Controller(userIndex);

            enablePolling.Enabled = testVibration.Enabled = analogGroup.Enabled = buttonsGroup.Enabled = controller.IsConnected;
            reconnectBtn.Visible = !controller.IsConnected;

            if (!controller.IsConnected)
            {
                logPrintLine("Controller " + index.ToString() + " is not connected!");
                return;
            }

            logPrintLine("Controller " + index.ToString() + " is connected!");

            enablePolling.Checked = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controller.IsConnected)
            {
                pollingTimer.Enabled = false;
                logPrintLine("Controller disconnected!");
                reconnectBtn.Visible = true;
                return;
            }

            Gamepad g = controller.GetState().Gamepad;

            LeftTrigger.Value = g.LeftTrigger;
            LeftX.Value = g.LeftThumbX + 32768;
            LeftY.Value = g.LeftThumbY + 32768;

            RightTrigger.Value = g.RightTrigger;
            RightX.Value = g.RightThumbX + 32768;
            RightY.Value = g.RightThumbY + 32768;

            BackBtn.Checked = (g.Buttons & GamepadButtonFlags.Back) != 0;
            StartBtn.Checked = (g.Buttons & GamepadButtonFlags.Start) != 0;
            
            ABtn.Checked = (g.Buttons & GamepadButtonFlags.A) != 0;
            BBtn.Checked = (g.Buttons & GamepadButtonFlags.B) != 0;
            XBtn.Checked = (g.Buttons & GamepadButtonFlags.X) != 0;
            YBtn.Checked = (g.Buttons & GamepadButtonFlags.Y) != 0;

            LeftBumper.Checked = (g.Buttons & GamepadButtonFlags.LeftShoulder) != 0;
            RightBumper.Checked = (g.Buttons & GamepadButtonFlags.RightShoulder) != 0;

            LeftThumb.Checked = (g.Buttons & GamepadButtonFlags.LeftThumb) != 0;
            RightThumb.Checked = (g.Buttons & GamepadButtonFlags.RightThumb) != 0;

            UpBtn.Checked = (g.Buttons & GamepadButtonFlags.DPadUp) != 0;
            DownBtn.Checked = (g.Buttons & GamepadButtonFlags.DPadDown) != 0;
            LeftBtn.Checked = (g.Buttons & GamepadButtonFlags.DPadLeft) != 0;
            RightBtn.Checked = (g.Buttons & GamepadButtonFlags.DPadRight) != 0;
        }

        private void enablePolling_CheckedChanged(object sender, EventArgs e)
        {
            pollingTimer.Enabled = enablePolling.Checked;

            logPrintLine((enablePolling.Checked ? "Start" : "Stop") + " polling timer!");
        }

        private void testVibration_CheckedChanged(object sender, EventArgs e)
        {
            bool isVibrating = testVibration.Checked;

            Vibration v = new Vibration();

            v.LeftMotorSpeed = (ushort)(isVibrating ? 32767 : 0);
            v.RightMotorSpeed = (ushort)(isVibrating ? 32767 : 0);

            controller.SetVibration(v);

            logPrintLine("Controller vibration test " + (isVibrating ? "on" : "off"));
        }

        private void selectedController_ValueChanged(object sender, EventArgs e)
        {
            loadController(selectedController.Value);
        }

        private void reconnectBtn_Click(object sender, EventArgs e)
        {
            loadController(selectedController.Value);
        }
    }
}
