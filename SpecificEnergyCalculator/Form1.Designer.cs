namespace SpecificEnergyCalculator
{
    partial class formCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculator));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbMinScreen = new System.Windows.Forms.Label();
            this.lblMaxScreen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbChooseMachine = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.lblSpecificEnergy = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTorque = new System.Windows.Forms.TextBox();
            this.txtRatedMotor = new System.Windows.Forms.TextBox();
            this.txtMaxRPM = new System.Windows.Forms.TextBox();
            this.txtRunningRPM = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlHeader.Controls.Add(this.pictureBox2);
            this.pnlHeader.Controls.Add(this.lbMinScreen);
            this.pnlHeader.Controls.Add(this.lblMaxScreen);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(944, 56);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(851, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 24);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbMinScreen
            // 
            this.lbMinScreen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMinScreen.AutoSize = true;
            this.lbMinScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinScreen.ForeColor = System.Drawing.Color.Gray;
            this.lbMinScreen.Location = new System.Drawing.Point(891, 4);
            this.lbMinScreen.Name = "lbMinScreen";
            this.lbMinScreen.Size = new System.Drawing.Size(20, 24);
            this.lbMinScreen.TabIndex = 4;
            this.lbMinScreen.Text = "_";
            this.lbMinScreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMinScreen.Click += new System.EventHandler(this.lbMinScreen_Click);
            // 
            // lblMaxScreen
            // 
            this.lblMaxScreen.AutoSize = true;
            this.lblMaxScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxScreen.Image = ((System.Drawing.Image)(resources.GetObject("lblMaxScreen.Image")));
            this.lblMaxScreen.Location = new System.Drawing.Point(432, 0);
            this.lblMaxScreen.Name = "lblMaxScreen";
            this.lblMaxScreen.Size = new System.Drawing.Size(0, 24);
            this.lblMaxScreen.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 56);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Gray;
            this.lblClose.Location = new System.Drawing.Point(917, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 24);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(332, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specific  Energy Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 45);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(220, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Developer : Archana Lohani : archana.lohani330@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose the Machine";
            // 
            // cbChooseMachine
            // 
            this.cbChooseMachine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseMachine.FormattingEnabled = true;
            this.cbChooseMachine.Items.AddRange(new object[] {
            "27 Max",
            "27 Micro",
            "LabTech26mm",
            "40 Max"});
            this.cbChooseMachine.Location = new System.Drawing.Point(409, 9);
            this.cbChooseMachine.Name = "cbChooseMachine";
            this.cbChooseMachine.Size = new System.Drawing.Size(138, 26);
            this.cbChooseMachine.TabIndex = 3;
            this.cbChooseMachine.SelectedIndexChanged += new System.EventHandler(this.cbChooseMachine_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbChooseMachine);
            this.panel3.Location = new System.Drawing.Point(153, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 46);
            this.panel3.TabIndex = 4;
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInput.Controls.Add(this.txtEnergy);
            this.pnlInput.Controls.Add(this.lblSpecificEnergy);
            this.pnlInput.Controls.Add(this.btnClear);
            this.pnlInput.Controls.Add(this.btnCalculate);
            this.pnlInput.Controls.Add(this.txtTorque);
            this.pnlInput.Controls.Add(this.txtRatedMotor);
            this.pnlInput.Controls.Add(this.txtMaxRPM);
            this.pnlInput.Controls.Add(this.txtRunningRPM);
            this.pnlInput.Controls.Add(this.txtRate);
            this.pnlInput.Controls.Add(this.label9);
            this.pnlInput.Controls.Add(this.label8);
            this.pnlInput.Controls.Add(this.label7);
            this.pnlInput.Controls.Add(this.Label6);
            this.pnlInput.Controls.Add(this.lblRate);
            this.pnlInput.Location = new System.Drawing.Point(153, 156);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(640, 357);
            this.pnlInput.TabIndex = 5;
            // 
            // txtEnergy
            // 
            this.txtEnergy.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergy.Location = new System.Drawing.Point(409, 224);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(138, 32);
            this.txtEnergy.TabIndex = 14;
            // 
            // lblSpecificEnergy
            // 
            this.lblSpecificEnergy.AutoSize = true;
            this.lblSpecificEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecificEnergy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecificEnergy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSpecificEnergy.Location = new System.Drawing.Point(18, 224);
            this.lblSpecificEnergy.Name = "lblSpecificEnergy";
            this.lblSpecificEnergy.Size = new System.Drawing.Size(265, 24);
            this.lblSpecificEnergy.TabIndex = 13;
            this.lblSpecificEnergy.Text = "Specific Energy kW-Hr/Kg :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(352, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(126, 295);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 33);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTorque
            // 
            this.txtTorque.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorque.Location = new System.Drawing.Point(409, 182);
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.Size = new System.Drawing.Size(138, 32);
            this.txtTorque.TabIndex = 9;
            this.txtTorque.Validating += new System.ComponentModel.CancelEventHandler(this.txtTorque_Validating);
            // 
            // txtRatedMotor
            // 
            this.txtRatedMotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRatedMotor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatedMotor.Location = new System.Drawing.Point(409, 140);
            this.txtRatedMotor.Name = "txtRatedMotor";
            this.txtRatedMotor.Size = new System.Drawing.Size(138, 32);
            this.txtRatedMotor.TabIndex = 8;
            // 
            // txtMaxRPM
            // 
            this.txtMaxRPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaxRPM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxRPM.Location = new System.Drawing.Point(409, 98);
            this.txtMaxRPM.Name = "txtMaxRPM";
            this.txtMaxRPM.Size = new System.Drawing.Size(138, 32);
            this.txtMaxRPM.TabIndex = 7;
            // 
            // txtRunningRPM
            // 
            this.txtRunningRPM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningRPM.Location = new System.Drawing.Point(409, 56);
            this.txtRunningRPM.Name = "txtRunningRPM";
            this.txtRunningRPM.Size = new System.Drawing.Size(138, 32);
            this.txtRunningRPM.TabIndex = 6;
            this.txtRunningRPM.Validating += new System.ComponentModel.CancelEventHandler(this.txtRunningRPM_Validating);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(409, 14);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(138, 32);
            this.txtRate.TabIndex = 5;
            this.txtRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtRate_Validating);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(18, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Running Torque %             :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(18, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rated Motor kW                :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(18, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max. Screw RPM              :";
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Blue;
            this.Label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Label6.Location = new System.Drawing.Point(18, 56);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(265, 24);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Running RPM                    :";
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Blue;
            this.lblRate.Location = new System.Drawing.Point(18, 14);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(265, 24);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Feed Rate  lbs/hr            :    ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 586);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCalculator";
            this.Text = "Specific Energy Calculator";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbChooseMachine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtTorque;
        private System.Windows.Forms.TextBox txtRatedMotor;
        private System.Windows.Forms.TextBox txtMaxRPM;
        private System.Windows.Forms.TextBox txtRunningRPM;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMaxScreen;
        private System.Windows.Forms.Label lbMinScreen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSpecificEnergy;
        private System.Windows.Forms.TextBox txtEnergy;
    }
}

