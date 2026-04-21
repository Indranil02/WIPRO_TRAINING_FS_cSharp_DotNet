using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace StopwatchApp
{
    public partial class Form1 : Form
    {
        // Logic Objects
        private Stopwatch _stopwatch = new Stopwatch();
        private Timer tmrClock = new Timer();

        // UI Controls
        private Label lblTime = new Label();
        private Button btnStartStop = new Button();
        private Button btnLap = new Button();
        private Button btnReset = new Button();
        private Button btnSave = new Button();
        private ListBox lstLaps = new ListBox();

        public Form1()
        {
            SetupUI();
            
            // Timer Setup (Step 1)
            tmrClock.Interval = 1000;
            tmrClock.Tick += TmrClock_Tick;
        }

        private void SetupUI()
        {
            this.Text = "C# Stopwatch - Bhattacharjee";
            this.Size = new Size(350, 450);

            // Label Styling
            lblTime.Text = "00:00:00";
            lblTime.Font = new Font("Arial", 30, FontStyle.Bold);
            lblTime.Location = new Point(50, 30);
            lblTime.Size = new Size(250, 50);
            lblTime.TextAlign = ContentAlignment.MiddleCenter;

            // Buttons Styling
            btnStartStop.Text = "Start";
            btnStartStop.Location = new Point(30, 100);
            btnStartStop.Click += BtnStartStop_Click;

            btnLap.Text = "Lap";
            btnLap.Location = new Point(120, 100);
            btnLap.Click += BtnLap_Click;

            btnReset.Text = "Reset";
            btnReset.Location = new Point(210, 100);
            btnReset.Click += BtnReset_Click;

            // ListBox & Save Button
            lstLaps.Location = new Point(30, 150);
            lstLaps.Size = new Size(270, 150);

            btnSave.Text = "Save Laps to File";
            btnSave.Location = new Point(30, 320);
            btnSave.Size = new Size(270, 30);
            btnSave.Click += BtnSave_Click;

            // Add controls to the Form
            this.Controls.AddRange(new Control[] { lblTime, btnStartStop, btnLap, btnReset, lstLaps, btnSave });
        }

        // --- LOGIC METHODS ---

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = _stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
                tmrClock.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                _stopwatch.Stop();
                tmrClock.Stop();
                btnStartStop.Text = "Start";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _stopwatch.Reset();
            tmrClock.Stop();
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            lstLaps.Items.Clear();
        }

        private void BtnLap_Click(object sender, EventArgs e)
        {
            if (_stopwatch.ElapsedTicks > 0)
            {
                lstLaps.Items.Add($"Lap {lstLaps.Items.Count + 1}: {lblTime.Text}");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lstLaps.Items.Count == 0) return;

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Laps.txt");
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in lstLaps.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            MessageBox.Show($"Saved to Desktop as Laps.txt");
        }
    }
}