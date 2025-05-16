namespace StopwatchApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstLaps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(100, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(400, 70);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00.0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(43, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Snimi";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(313, 150);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 40);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Učitaj";
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(436, 150);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(100, 40);
            this.btnLap.TabIndex = 4;
            this.btnLap.Text = "Krug";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(561, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            // 
            // lstLaps
            // 
            this.lstLaps.FormattingEnabled = true;
            this.lstLaps.Location = new System.Drawing.Point(100, 210);
            this.lstLaps.Name = "lstLaps";
            this.lstLaps.Size = new System.Drawing.Size(460, 95);
            this.lstLaps.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstLaps);
            this.Name = "Form1";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstLaps;

        #endregion
    }
}

