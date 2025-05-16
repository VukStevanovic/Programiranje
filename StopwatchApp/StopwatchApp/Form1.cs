using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private TimeSpan elapsed;
        private DateTime startTime;
        private bool running;
        private List<TimeSpan> laps;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100; // 0.1 second
            timer.Tick += Timer_Tick;

            elapsed = TimeSpan.Zero;
            running = false;
            laps = new List<TimeSpan>();

            lblTime.Text = "00:00:00.0";
            btnStart.Text = "Start";
            btnSave.Text = "Snimi";
            btnLoad.Text = "Učitaj";
            btnLap.Text = "Krug";

            btnStart.Click += BtnStart_Click;
            btnSave.Click += BtnSave_Click;
            btnLoad.Click += BtnLoad_Click;
            btnLap.Click += BtnLap_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed = DateTime.Now - startTime;
            lblTime.Text = elapsed.ToString(@"hh\:mm\:ss\.f");
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                startTime = DateTime.Now - elapsed;
                timer.Start();
                btnStart.Text = "Stop";
                running = true;
            }
            else
            {
                timer.Stop();
                elapsed = DateTime.Now - startTime;
                btnStart.Text = "Start";
                running = false;
            }
        }

        private void BtnLap_Click(object sender, EventArgs e)
        {
            if (running)
            {
                laps.Add(elapsed);
                lstLaps.Items.Insert(0, $"Lap {laps.Count}: {elapsed.ToString(@"hh\:mm\:ss\.f")}");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine(elapsed.ToString());
                        foreach (var lap in laps)
                        {
                            sw.WriteLine(lap.ToString());
                        }
                    }
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    if (lines.Length > 0 && TimeSpan.TryParse(lines[0], out TimeSpan loaded))
                    {
                        elapsed = loaded;
                        lblTime.Text = elapsed.ToString(@"hh\:mm\:ss\.f");
                        if (running)
                        {
                            startTime = DateTime.Now - elapsed;
                        }
                        laps.Clear();
                        lstLaps.Items.Clear();
                        for (int i = 1; i < lines.Length; i++)
                        {
                            if (TimeSpan.TryParse(lines[i], out TimeSpan lap))
                            {
                                laps.Add(lap);
                                lstLaps.Items.Add($"Lap {i}: {lap.ToString(@"hh\:mm\:ss\.f")}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid file format.");
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            elapsed = TimeSpan.Zero;
            lblTime.Text = "00:00:00.0";
            btnStart.Text = "Start";
            running = false;
            laps.Clear();
            lstLaps.Items.Clear();
        }
    }
}
