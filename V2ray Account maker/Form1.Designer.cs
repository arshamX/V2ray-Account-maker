namespace V2ray_Account_maker
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelPlace3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelPlace2 = new System.Windows.Forms.Panel();
            this.panelPlace1 = new System.Windows.Forms.Panel();
            this.panelBott = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelPlace5 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelPlace4 = new System.Windows.Forms.Panel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            this.timerPicture = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelPlace3.SuspendLayout();
            this.panelBott.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelPlace5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelPlace4.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelPlace3);
            this.panelTop.Controls.Add(this.panelPlace2);
            this.panelTop.Controls.Add(this.panelPlace1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 62);
            this.panelTop.TabIndex = 0;
            // 
            // panelPlace3
            // 
            this.panelPlace3.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlace3.Controls.Add(this.txtName);
            this.panelPlace3.Controls.Add(this.lblName);
            this.panelPlace3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlace3.Location = new System.Drawing.Point(0, 21);
            this.panelPlace3.Name = "panelPlace3";
            this.panelPlace3.Size = new System.Drawing.Size(484, 23);
            this.panelPlace3.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtName.Location = new System.Drawing.Point(101, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Account Name :";
            // 
            // panelPlace2
            // 
            this.panelPlace2.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlace2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlace2.Location = new System.Drawing.Point(0, 44);
            this.panelPlace2.Name = "panelPlace2";
            this.panelPlace2.Size = new System.Drawing.Size(484, 18);
            this.panelPlace2.TabIndex = 1;
            // 
            // panelPlace1
            // 
            this.panelPlace1.BackColor = System.Drawing.SystemColors.Control;
            this.panelPlace1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlace1.Location = new System.Drawing.Point(0, 0);
            this.panelPlace1.Name = "panelPlace1";
            this.panelPlace1.Size = new System.Drawing.Size(484, 21);
            this.panelPlace1.TabIndex = 0;
            // 
            // panelBott
            // 
            this.panelBott.Controls.Add(this.btnCreate);
            this.panelBott.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBott.Location = new System.Drawing.Point(0, 312);
            this.panelBott.Name = "panelBott";
            this.panelBott.Size = new System.Drawing.Size(484, 33);
            this.panelBott.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreate.Location = new System.Drawing.Point(409, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCenter.Controls.Add(this.panelRight);
            this.panelCenter.Controls.Add(this.panelLeft);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 62);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(484, 250);
            this.panelCenter.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRight.Controls.Add(this.panelPlace5);
            this.panelRight.Controls.Add(this.panelPlace4);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(270, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(214, 250);
            this.panelRight.TabIndex = 1;
            // 
            // panelPlace5
            // 
            this.panelPlace5.Controls.Add(this.pbLogo);
            this.panelPlace5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlace5.Location = new System.Drawing.Point(0, 20);
            this.panelPlace5.Name = "panelPlace5";
            this.panelPlace5.Size = new System.Drawing.Size(210, 226);
            this.panelPlace5.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::V2ray_Account_maker.Properties.Resources.a;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(210, 226);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelPlace4
            // 
            this.panelPlace4.Controls.Add(this.lblCounter);
            this.panelPlace4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlace4.Location = new System.Drawing.Point(0, 0);
            this.panelPlace4.Name = "panelPlace4";
            this.panelPlace4.Size = new System.Drawing.Size(210, 20);
            this.panelPlace4.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCounter.Location = new System.Drawing.Point(0, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(110, 16);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0 sec Remaining ";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeft.Controls.Add(this.pbQrCode);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(270, 250);
            this.panelLeft.TabIndex = 0;
            // 
            // pbQrCode
            // 
            this.pbQrCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQrCode.Location = new System.Drawing.Point(0, 0);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(266, 246);
            this.pbQrCode.TabIndex = 0;
            this.pbQrCode.TabStop = false;
            // 
            // timerPicture
            // 
            this.timerPicture.Interval = 1000;
            this.timerPicture.Tick += new System.EventHandler(this.timerPicture_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 345);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBott);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "V2ray Account Maker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelPlace3.ResumeLayout(false);
            this.panelPlace3.PerformLayout();
            this.panelBott.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelPlace5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelPlace4.ResumeLayout(false);
            this.panelPlace4.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelPlace3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelPlace2;
        private System.Windows.Forms.Panel panelPlace1;
        private System.Windows.Forms.Panel panelBott;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelPlace4;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbQrCode;
        private System.Windows.Forms.Panel panelPlace5;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer timerPicture;
    }
}

