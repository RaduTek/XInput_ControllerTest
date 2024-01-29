using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        private void LogPrintLine(string s)
        {
            LogBox.Text += s + "\r\n";
            LogBox.Select(LogBox.Text.Length - 1, 0);
            LogBox.ScrollToCaret();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FindAndLoadController();
        }


        private void FindAndLoadController()
        {
            for (int i = 1; i <= 4; i++)
            {
                if (LoadController(i, true))
                {
                    SelectedControllerIndex.Value = i;
                    return;
                }
            }

            LogPrintLine("No connected controllers found!");
        }


        private bool LoadController(decimal index, bool noFailAlert = false)
        {
            EnablePolling.Checked = TestVibration.Checked = false;

            UserIndex userIndex = UserIndex.One;

            if (index == 1) userIndex = UserIndex.One;
            else if (index == 2) userIndex = UserIndex.Two;
            else if (index == 3) userIndex = UserIndex.Three;
            else if (index == 4) userIndex = UserIndex.Four;

            controller = new Controller(userIndex);

            EnablePolling.Enabled = TestVibration.Enabled = MainTabControl.Enabled = controller.IsConnected;
            ReconnectBtn.Visible = !controller.IsConnected;

            if (!controller.IsConnected)
            {
                if (noFailAlert) return false;
                LogPrintLine("Controller " + index.ToString() + " is not connected!");
                SystemSounds.Exclamation.Play();
                return false;
            }

            LogPrintLine("Controller " + index.ToString() + " is connected!");

            Capabilities capabilities = controller.GetCapabilities(DeviceQueryType.Any);

            if (capabilities.Flags.HasFlag(CapabilityFlags.Wireless))
            {
                LogPrintLine("  -> Is wireless");
            }
            if (capabilities.Flags.HasFlag(CapabilityFlags.FfbSupported))
            {
                LogPrintLine("  -> Supports vibration");
                
            }

            VibrationSupported.Checked = capabilities.Flags.HasFlag(CapabilityFlags.FfbSupported);

            EnablePolling.Checked = true;

            return true;
        }

        private int MapInt(int x, int iA, int iB, int dA, int dB)
        {
            if (iB == iA || dB == dA)
            {
                throw new ArgumentException("Invalid input or output range: width of range cannot be zero.");
            }

            x = Math.Max(iA, Math.Min(x, iB));

            double ratio = (double)(x - iA) / (iB - iA);
            double mappedValue = dA + ratio * (dB - dA);

            if (mappedValue > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (mappedValue < int.MinValue)
            {
                return int.MinValue;
            }
            else
            {
                return (int)mappedValue;
            }
        }



        private void PollingTimer_Tick(object sender, EventArgs e)
        {
            if (!controller.IsConnected)
            {
                PollingTimer.Enabled = false;
                LogPrintLine("Controller disconnected!");
                SystemSounds.Exclamation.Play();
                ReconnectBtn.Visible = true;
                return;
            }

            Gamepad g = controller.GetState().Gamepad;

            LeftTrigger.Value = g.LeftTrigger;
            LeftX.Value = g.LeftThumbX + 32768;
            LeftY.Value = g.LeftThumbY + 32768;
            
            LeftTriggerVal.Text = g.LeftTrigger.ToString();
            LeftXVal.Text = g.LeftThumbX.ToString();
            LeftYVal.Text = g.LeftThumbY.ToString();

            RightTrigger.Value = g.RightTrigger;
            RightX.Value = g.RightThumbX + 32768;
            RightY.Value = g.RightThumbY + 32768;

            RightTriggerVal.Text = g.RightTrigger.ToString();
            RightXVal.Text = g.RightThumbX.ToString();
            RightYVal.Text = g.RightThumbY.ToString();

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

            LeftThumbView.Refresh();
            RightThumbView.Refresh();
        }

        private void EnablePolling_CheckedChanged(object sender, EventArgs e)
        {
            PollingRateValue.Enabled = !EnablePolling.Checked;
            
            PollingTimer.Interval = (int)PollingRateValue.Value;
            PollingTimer.Enabled = EnablePolling.Checked;
            
            if (EnablePolling.Checked)
                LogPrintLine("Start polling at " + PollingRateValue.Value.ToString() + "ms!");
            else
                LogPrintLine("Stop polling timer!");
        }

        private void TestVibration_CheckedChanged(object sender, EventArgs e)
        {
            UpdateVibration();
            LogPrintLine("Controller vibration test " + (TestVibration.Checked ? "on" : "off"));
        }

        private void UpdateVibration()
        {
            bool isVibrating = TestVibration.Checked;

            Vibration v = new Vibration
            {
                LeftMotorSpeed = (ushort)(isVibrating ? LeftVibration.Value : 0),
                RightMotorSpeed = (ushort)(isVibrating ? RightVibration.Value : 0)
            };

            controller.SetVibration(v);
        }

        private void SelectedControllerIndex_ValueChanged(object sender, EventArgs e)
        {
            LoadController(SelectedControllerIndex.Value);
        }

        private void ReconnectBtn_Click(object sender, EventArgs e)
        {
            LoadController(SelectedControllerIndex.Value);
        }

        private void LeftVibration_Scroll(object sender, EventArgs e)
        {
            LeftVibrationValue.Text = LeftVibration.Value.ToString();
            UpdateVibration();
        }

        private void RightVibration_Scroll(object sender, EventArgs e)
        {
            RightVibrationValue.Text = RightVibration.Value.ToString();
            UpdateVibration();
        }

        private void LeftThumbView_Paint(object sender, PaintEventArgs e)
        {
            if (controller.IsConnected)
            {
                Gamepad g = controller.GetState().Gamepad;

                int markerX = MapInt(g.LeftThumbX, -32768, 32767, 0, 200);
                int markerY = 200 - MapInt(g.LeftThumbY, -32768, 32767, 0, 200);

                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillEllipse(brush, markerX - 2, markerY - 2, 4, 4);
                }
            }
        }

        private void RightThumbView_Paint(object sender, PaintEventArgs e)
        {
            if (controller.IsConnected)
            {
                Gamepad g = controller.GetState().Gamepad;

                int markerX = MapInt(g.RightThumbX, -32768, 32767, 0, 200);
                int markerY = 200 - MapInt(g.RightThumbY, -32768, 32767, 0, 200);

                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillEllipse(brush, markerX - 2, markerY - 2, 4, 4);
                }
            }
        }
    }
}
