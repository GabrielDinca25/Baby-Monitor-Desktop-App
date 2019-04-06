namespace BabyMonitor
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
            this.connect = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.openLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.write = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.connect.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connect.Location = new System.Drawing.Point(284, 83);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(197, 61);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect to Baby Monitor";
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Green;
            this.start.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(284, 181);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(93, 36);
            this.start.TabIndex = 1;
            this.start.Text = "Start ";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Crimson;
            this.stop.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop.Location = new System.Drawing.Point(388, 181);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(93, 36);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop ";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // openLog
            // 
            this.openLog.Location = new System.Drawing.Point(284, 262);
            this.openLog.Name = "openLog";
            this.openLog.Size = new System.Drawing.Size(197, 46);
            this.openLog.TabIndex = 3;
            this.openLog.Text = "Open log file";
            this.openLog.UseVisualStyleBackColor = true;
            this.openLog.Click += new System.EventHandler(this.openLog_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(284, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Not connected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(284, 223);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(197, 23);
            this.write.TabIndex = 7;
            this.write.Text = "Write to file";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.write);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openLog);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.connect);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button openLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button write;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

