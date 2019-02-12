namespace Race_simulator
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
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.bettingParlorBox = new System.Windows.Forms.GroupBox();
            this.alTextBox = new System.Windows.Forms.TextBox();
            this.bobTextBox = new System.Windows.Forms.TextBox();
            this.joeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startRaceButton = new System.Windows.Forms.Button();
            this.dogNumberNumerikUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.amountBettedNumerikUpDown = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.bettorNamelabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            this.bettingParlorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumerikUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBettedNumerikUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(776, 340);
            this.raceTrackPictureBox.TabIndex = 0;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // bettingParlorBox
            // 
            this.bettingParlorBox.Controls.Add(this.alTextBox);
            this.bettingParlorBox.Controls.Add(this.bobTextBox);
            this.bettingParlorBox.Controls.Add(this.joeTextBox);
            this.bettingParlorBox.Controls.Add(this.label3);
            this.bettingParlorBox.Controls.Add(this.startRaceButton);
            this.bettingParlorBox.Controls.Add(this.dogNumberNumerikUpDown);
            this.bettingParlorBox.Controls.Add(this.label2);
            this.bettingParlorBox.Controls.Add(this.amountBettedNumerikUpDown);
            this.bettingParlorBox.Controls.Add(this.betsButton);
            this.bettingParlorBox.Controls.Add(this.bettorNamelabel);
            this.bettingParlorBox.Controls.Add(this.alRadioButton);
            this.bettingParlorBox.Controls.Add(this.bobRadioButton);
            this.bettingParlorBox.Controls.Add(this.joeRadioButton);
            this.bettingParlorBox.Controls.Add(this.minimumBetLabel);
            this.bettingParlorBox.Location = new System.Drawing.Point(13, 359);
            this.bettingParlorBox.Name = "bettingParlorBox";
            this.bettingParlorBox.Size = new System.Drawing.Size(775, 176);
            this.bettingParlorBox.TabIndex = 1;
            this.bettingParlorBox.TabStop = false;
            this.bettingParlorBox.Text = "Betting Parlor";
            // 
            // alTextBox
            // 
            this.alTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alTextBox.Location = new System.Drawing.Point(199, 101);
            this.alTextBox.Name = "alTextBox";
            this.alTextBox.Size = new System.Drawing.Size(216, 20);
            this.alTextBox.TabIndex = 13;
            this.alTextBox.Text = "Al hasn\'t placed a bet";
            // 
            // bobTextBox
            // 
            this.bobTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobTextBox.Location = new System.Drawing.Point(199, 78);
            this.bobTextBox.Name = "bobTextBox";
            this.bobTextBox.Size = new System.Drawing.Size(216, 20);
            this.bobTextBox.TabIndex = 12;
            this.bobTextBox.Text = "Bob hasn\'t placed a bet";
            // 
            // joeTextBox
            // 
            this.joeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeTextBox.Location = new System.Drawing.Point(199, 55);
            this.joeTextBox.Name = "joeTextBox";
            this.joeTextBox.Size = new System.Drawing.Size(216, 20);
            this.joeTextBox.TabIndex = 11;
            this.joeTextBox.Text = "Joe hasn\'t placed a bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // startRaceButton
            // 
            this.startRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRaceButton.Location = new System.Drawing.Point(596, 25);
            this.startRaceButton.Name = "startRaceButton";
            this.startRaceButton.Size = new System.Drawing.Size(159, 122);
            this.startRaceButton.TabIndex = 9;
            this.startRaceButton.Text = "START!";
            this.startRaceButton.UseVisualStyleBackColor = true;
            this.startRaceButton.Click += new System.EventHandler(this.startRaceButton_Click);
            // 
            // dogNumberNumerikUpDown
            // 
            this.dogNumberNumerikUpDown.Location = new System.Drawing.Point(433, 134);
            this.dogNumberNumerikUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumerikUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumerikUpDown.Name = "dogNumberNumerikUpDown";
            this.dogNumberNumerikUpDown.Size = new System.Drawing.Size(63, 20);
            this.dogNumberNumerikUpDown.TabIndex = 8;
            this.dogNumberNumerikUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "bucks on dog number";
            // 
            // amountBettedNumerikUpDown
            // 
            this.amountBettedNumerikUpDown.Location = new System.Drawing.Point(183, 134);
            this.amountBettedNumerikUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.amountBettedNumerikUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountBettedNumerikUpDown.Name = "amountBettedNumerikUpDown";
            this.amountBettedNumerikUpDown.Size = new System.Drawing.Size(49, 20);
            this.amountBettedNumerikUpDown.TabIndex = 6;
            this.amountBettedNumerikUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(83, 131);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // bettorNamelabel
            // 
            this.bettorNamelabel.AutoSize = true;
            this.bettorNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettorNamelabel.Location = new System.Drawing.Point(6, 134);
            this.bettorNamelabel.Name = "bettorNamelabel";
            this.bettorNamelabel.Size = new System.Drawing.Size(35, 20);
            this.bettorNamelabel.TabIndex = 4;
            this.bettorNamelabel.Text = "Joe";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(6, 101);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(6, 78);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(6, 55);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 25);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(13, 90);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(79, 77);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(13, 173);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(79, 87);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(13, 266);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(80, 86);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog4.TabIndex = 5;
            this.dog4.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(13, 13);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(79, 71);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.bettingParlorBox);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            this.bettingParlorBox.ResumeLayout(false);
            this.bettingParlorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumerikUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBettedNumerikUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.GroupBox bettingParlorBox;
        private System.Windows.Forms.TextBox alTextBox;
        private System.Windows.Forms.TextBox bobTextBox;
        private System.Windows.Forms.TextBox joeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startRaceButton;
        private System.Windows.Forms.NumericUpDown dogNumberNumerikUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountBettedNumerikUpDown;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label bettorNamelabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.Timer timer1;
    }
}

