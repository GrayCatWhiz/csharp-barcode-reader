namespace ReadQR
{
    partial class MainWin
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
            this.DeviceList = new System.Windows.Forms.ComboBox();
            this.QrScreen = new System.Windows.Forms.PictureBox();
            this.OpenCameraBtn = new System.Windows.Forms.Button();
            this.VideoUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QrScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceList
            // 
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.Location = new System.Drawing.Point(29, 12);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(307, 21);
            this.DeviceList.TabIndex = 0;
            // 
            // QrScreen
            // 
            this.QrScreen.Location = new System.Drawing.Point(66, 39);
            this.QrScreen.Name = "QrScreen";
            this.QrScreen.Size = new System.Drawing.Size(250, 250);
            this.QrScreen.TabIndex = 1;
            this.QrScreen.TabStop = false;
            // 
            // OpenCameraBtn
            // 
            this.OpenCameraBtn.Location = new System.Drawing.Point(66, 295);
            this.OpenCameraBtn.Name = "OpenCameraBtn";
            this.OpenCameraBtn.Size = new System.Drawing.Size(250, 23);
            this.OpenCameraBtn.TabIndex = 2;
            this.OpenCameraBtn.Text = "Open Camera";
            this.OpenCameraBtn.UseVisualStyleBackColor = true;
            this.OpenCameraBtn.Click += new System.EventHandler(this.OpenCameraBtn_Click);
            // 
            // VideoUpdater
            // 
            this.VideoUpdater.Tick += new System.EventHandler(this.VideoUpdater_Tick);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(this.OpenCameraBtn);
            this.Controls.Add(this.QrScreen);
            this.Controls.Add(this.DeviceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "Qr Decoder";
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QrScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DeviceList;
        private System.Windows.Forms.PictureBox QrScreen;
        private System.Windows.Forms.Button OpenCameraBtn;
        private System.Windows.Forms.Timer VideoUpdater;
    }
}

