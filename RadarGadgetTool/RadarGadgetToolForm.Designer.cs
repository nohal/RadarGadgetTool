namespace RadarGadgetTool
{
    partial class RadarGadgetToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadarGadgetToolForm));
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.btnSetMode = new System.Windows.Forms.Button();
            this.rbModeC50 = new System.Windows.Forms.RadioButton();
            this.rbModeC40 = new System.Windows.Forms.RadioButton();
            this.rbModeC30 = new System.Windows.Forms.RadioButton();
            this.rbModeC20 = new System.Windows.Forms.RadioButton();
            this.rbModeC10 = new System.Windows.Forms.RadioButton();
            this.rbModeB = new System.Windows.Forms.RadioButton();
            this.rbModeA = new System.Windows.Forms.RadioButton();
            this.gbDemod = new System.Windows.Forms.GroupBox();
            this.btnSetDemod = new System.Windows.Forms.Button();
            this.rbDemodZ = new System.Windows.Forms.RadioButton();
            this.rbDemodY = new System.Windows.Forms.RadioButton();
            this.rbDemodX = new System.Windows.Forms.RadioButton();
            this.rbDemodW = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCom = new System.Windows.Forms.TextBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnReadSettings = new System.Windows.Forms.Button();
            this.gbMode.SuspendLayout();
            this.gbDemod.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.btnSetMode);
            this.gbMode.Controls.Add(this.rbModeC50);
            this.gbMode.Controls.Add(this.rbModeC40);
            this.gbMode.Controls.Add(this.rbModeC30);
            this.gbMode.Controls.Add(this.rbModeC20);
            this.gbMode.Controls.Add(this.rbModeC10);
            this.gbMode.Controls.Add(this.rbModeB);
            this.gbMode.Controls.Add(this.rbModeA);
            this.gbMode.Location = new System.Drawing.Point(12, 12);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(231, 216);
            this.gbMode.TabIndex = 0;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // btnSetMode
            // 
            this.btnSetMode.Location = new System.Drawing.Point(6, 180);
            this.btnSetMode.Name = "btnSetMode";
            this.btnSetMode.Size = new System.Drawing.Size(75, 23);
            this.btnSetMode.TabIndex = 7;
            this.btnSetMode.Text = "Set";
            this.btnSetMode.UseVisualStyleBackColor = true;
            this.btnSetMode.Click += new System.EventHandler(this.btnSetMode_Click);
            // 
            // rbModeC50
            // 
            this.rbModeC50.AutoSize = true;
            this.rbModeC50.Location = new System.Drawing.Point(6, 157);
            this.rbModeC50.Name = "rbModeC50";
            this.rbModeC50.Size = new System.Drawing.Size(200, 17);
            this.rbModeC50.TabIndex = 6;
            this.rbModeC50.TabStop = true;
            this.rbModeC50.Text = "Alternate channels every 50 seconds";
            this.rbModeC50.UseVisualStyleBackColor = true;
            // 
            // rbModeC40
            // 
            this.rbModeC40.AutoSize = true;
            this.rbModeC40.Location = new System.Drawing.Point(6, 134);
            this.rbModeC40.Name = "rbModeC40";
            this.rbModeC40.Size = new System.Drawing.Size(200, 17);
            this.rbModeC40.TabIndex = 5;
            this.rbModeC40.TabStop = true;
            this.rbModeC40.Text = "Alternate channels every 40 seconds";
            this.rbModeC40.UseVisualStyleBackColor = true;
            // 
            // rbModeC30
            // 
            this.rbModeC30.AutoSize = true;
            this.rbModeC30.Location = new System.Drawing.Point(6, 111);
            this.rbModeC30.Name = "rbModeC30";
            this.rbModeC30.Size = new System.Drawing.Size(200, 17);
            this.rbModeC30.TabIndex = 4;
            this.rbModeC30.TabStop = true;
            this.rbModeC30.Text = "Alternate channels every 30 seconds";
            this.rbModeC30.UseVisualStyleBackColor = true;
            // 
            // rbModeC20
            // 
            this.rbModeC20.AutoSize = true;
            this.rbModeC20.Location = new System.Drawing.Point(6, 88);
            this.rbModeC20.Name = "rbModeC20";
            this.rbModeC20.Size = new System.Drawing.Size(200, 17);
            this.rbModeC20.TabIndex = 3;
            this.rbModeC20.TabStop = true;
            this.rbModeC20.Text = "Alternate channels every 20 seconds";
            this.rbModeC20.UseVisualStyleBackColor = true;
            // 
            // rbModeC10
            // 
            this.rbModeC10.AutoSize = true;
            this.rbModeC10.Location = new System.Drawing.Point(6, 65);
            this.rbModeC10.Name = "rbModeC10";
            this.rbModeC10.Size = new System.Drawing.Size(200, 17);
            this.rbModeC10.TabIndex = 2;
            this.rbModeC10.TabStop = true;
            this.rbModeC10.Text = "Alternate channels every 10 seconds";
            this.rbModeC10.UseVisualStyleBackColor = true;
            // 
            // rbModeB
            // 
            this.rbModeB.AutoSize = true;
            this.rbModeB.Location = new System.Drawing.Point(6, 42);
            this.rbModeB.Name = "rbModeB";
            this.rbModeB.Size = new System.Drawing.Size(137, 17);
            this.rbModeB.TabIndex = 1;
            this.rbModeB.TabStop = true;
            this.rbModeB.Text = "Channel B only (default)";
            this.rbModeB.UseVisualStyleBackColor = true;
            // 
            // rbModeA
            // 
            this.rbModeA.AutoSize = true;
            this.rbModeA.Location = new System.Drawing.Point(6, 19);
            this.rbModeA.Name = "rbModeA";
            this.rbModeA.Size = new System.Drawing.Size(96, 17);
            this.rbModeA.TabIndex = 0;
            this.rbModeA.TabStop = true;
            this.rbModeA.Text = "Channel A only";
            this.rbModeA.UseVisualStyleBackColor = true;
            // 
            // gbDemod
            // 
            this.gbDemod.Controls.Add(this.btnSetDemod);
            this.gbDemod.Controls.Add(this.rbDemodZ);
            this.gbDemod.Controls.Add(this.rbDemodY);
            this.gbDemod.Controls.Add(this.rbDemodX);
            this.gbDemod.Controls.Add(this.rbDemodW);
            this.gbDemod.Location = new System.Drawing.Point(249, 12);
            this.gbDemod.Name = "gbDemod";
            this.gbDemod.Size = new System.Drawing.Size(361, 216);
            this.gbDemod.TabIndex = 1;
            this.gbDemod.TabStop = false;
            this.gbDemod.Text = "Demodulator settings";
            // 
            // btnSetDemod
            // 
            this.btnSetDemod.Location = new System.Drawing.Point(6, 180);
            this.btnSetDemod.Name = "btnSetDemod";
            this.btnSetDemod.Size = new System.Drawing.Size(75, 23);
            this.btnSetDemod.TabIndex = 8;
            this.btnSetDemod.Text = "Set";
            this.btnSetDemod.UseVisualStyleBackColor = true;
            this.btnSetDemod.Click += new System.EventHandler(this.btnSetDemod_Click);
            // 
            // rbDemodZ
            // 
            this.rbDemodZ.AutoSize = true;
            this.rbDemodZ.Location = new System.Drawing.Point(6, 127);
            this.rbDemodZ.Name = "rbDemodZ";
            this.rbDemodZ.Size = new System.Drawing.Size(252, 17);
            this.rbDemodZ.TabIndex = 3;
            this.rbDemodZ.TabStop = true;
            this.rbDemodZ.Text = "Correlator Demod standard BW - (IF filter 12kHz)";
            this.rbDemodZ.UseVisualStyleBackColor = true;
            // 
            // rbDemodY
            // 
            this.rbDemodY.AutoSize = true;
            this.rbDemodY.Location = new System.Drawing.Point(6, 91);
            this.rbDemodY.Name = "rbDemodY";
            this.rbDemodY.Size = new System.Drawing.Size(326, 30);
            this.rbDemodY.TabIndex = 2;
            this.rbDemodY.TabStop = true;
            this.rbDemodY.Text = "Linear Demod - (IF filter 25kHz) largest frequency error tolerance\r\nLowest sensit" +
                "ivity";
            this.rbDemodY.UseVisualStyleBackColor = true;
            // 
            // rbDemodX
            // 
            this.rbDemodX.AutoSize = true;
            this.rbDemodX.Location = new System.Drawing.Point(6, 55);
            this.rbDemodX.Name = "rbDemodX";
            this.rbDemodX.Size = new System.Drawing.Size(318, 30);
            this.rbDemodX.TabIndex = 1;
            this.rbDemodX.TabStop = true;
            this.rbDemodX.Text = "Linear Demod - (IF filter 18kHz) large frequency error tolerance\r\nLittle lower se" +
                "nsitivity";
            this.rbDemodX.UseVisualStyleBackColor = true;
            // 
            // rbDemodW
            // 
            this.rbDemodW.AutoSize = true;
            this.rbDemodW.Location = new System.Drawing.Point(6, 19);
            this.rbDemodW.Name = "rbDemodW";
            this.rbDemodW.Size = new System.Drawing.Size(252, 30);
            this.rbDemodW.TabIndex = 0;
            this.rbDemodW.TabStop = true;
            this.rbDemodW.Text = "Correlator Demod standard BW - (IF filter 18kHz)\r\nStandard Setting";
            this.rbDemodW.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReadSettings);
            this.groupBox3.Controls.Add(this.tbCom);
            this.groupBox3.Controls.Add(this.btnOpenPort);
            this.groupBox3.Controls.Add(this.cbPorts);
            this.groupBox3.Location = new System.Drawing.Point(12, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port";
            // 
            // tbCom
            // 
            this.tbCom.Location = new System.Drawing.Point(6, 46);
            this.tbCom.Multiline = true;
            this.tbCom.Name = "tbCom";
            this.tbCom.ReadOnly = true;
            this.tbCom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCom.Size = new System.Drawing.Size(586, 99);
            this.tbCom.TabIndex = 3;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(133, 19);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(100, 23);
            this.btnOpenPort.TabIndex = 1;
            this.btnOpenPort.Text = "Open";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 19);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // btnReadSettings
            // 
            this.btnReadSettings.Location = new System.Drawing.Point(239, 19);
            this.btnReadSettings.Name = "btnReadSettings";
            this.btnReadSettings.Size = new System.Drawing.Size(100, 23);
            this.btnReadSettings.TabIndex = 4;
            this.btnReadSettings.Text = "Read settings";
            this.btnReadSettings.UseVisualStyleBackColor = true;
            this.btnReadSettings.Click += new System.EventHandler(this.btnReadSettings_Click);
            // 
            // RadarGadgetToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDemod);
            this.Controls.Add(this.gbMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RadarGadgetToolForm";
            this.Text = "RadarGadgetTool";
            this.Load += new System.EventHandler(this.RadarGadgetToolForm_Load);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbDemod.ResumeLayout(false);
            this.gbDemod.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbModeC50;
        private System.Windows.Forms.RadioButton rbModeC40;
        private System.Windows.Forms.RadioButton rbModeC30;
        private System.Windows.Forms.RadioButton rbModeC20;
        private System.Windows.Forms.RadioButton rbModeC10;
        private System.Windows.Forms.RadioButton rbModeB;
        private System.Windows.Forms.RadioButton rbModeA;
        private System.Windows.Forms.Button btnSetMode;
        private System.Windows.Forms.GroupBox gbDemod;
        private System.Windows.Forms.RadioButton rbDemodZ;
        private System.Windows.Forms.RadioButton rbDemodY;
        private System.Windows.Forms.RadioButton rbDemodX;
        private System.Windows.Forms.RadioButton rbDemodW;
        private System.Windows.Forms.Button btnSetDemod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCom;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnReadSettings;
    }
}

