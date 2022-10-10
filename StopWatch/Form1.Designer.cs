namespace StopWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTime = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.LapButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ClearLapsButton = new System.Windows.Forms.Button();
            this.LapLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(185, 124);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(431, 131);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "00:00:00";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(25, 258);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(117, 61);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LapButton
            // 
            this.LapButton.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapButton.Location = new System.Drawing.Point(148, 258);
            this.LapButton.Name = "LapButton";
            this.LapButton.Size = new System.Drawing.Size(117, 61);
            this.LapButton.TabIndex = 2;
            this.LapButton.Text = "Lap";
            this.LapButton.UseVisualStyleBackColor = true;
            this.LapButton.Click += new System.EventHandler(this.LapButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(271, 258);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(117, 61);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(394, 258);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(163, 61);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ClearLapsButton
            // 
            this.ClearLapsButton.Font = new System.Drawing.Font("Digital-7", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLapsButton.Location = new System.Drawing.Point(563, 258);
            this.ClearLapsButton.Name = "ClearLapsButton";
            this.ClearLapsButton.Size = new System.Drawing.Size(209, 61);
            this.ClearLapsButton.TabIndex = 5;
            this.ClearLapsButton.Text = "Clear Laps";
            this.ClearLapsButton.UseVisualStyleBackColor = true;
            this.ClearLapsButton.Click += new System.EventHandler(this.ClearLapsButton_Click);
            // 
            // LapLabel
            // 
            this.LapLabel.AutoSize = true;
            this.LapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapLabel.Location = new System.Drawing.Point(713, 9);
            this.LapLabel.Name = "LapLabel";
            this.LapLabel.Size = new System.Drawing.Size(0, 24);
            this.LapLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LapLabel);
            this.Controls.Add(this.ClearLapsButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.LapButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LabelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StopWatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button LapButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ClearLapsButton;
        private System.Windows.Forms.Label LapLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

