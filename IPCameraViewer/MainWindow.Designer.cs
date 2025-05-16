namespace IPCameraViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.VLCPlayer = new Vlc.DotNet.Forms.VlcControl();
            this.input_RTSP = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupbox_rtsp = new System.Windows.Forms.GroupBox();
            this.groupbox_Actions = new System.Windows.Forms.GroupBox();
            this.button_VideoRecording = new System.Windows.Forms.Button();
            this.button_TakeSnapshot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).BeginInit();
            this.groupbox_rtsp.SuspendLayout();
            this.groupbox_Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // VLCPlayer
            // 
            this.VLCPlayer.BackColor = System.Drawing.Color.Black;
            this.VLCPlayer.Location = new System.Drawing.Point(21, 23);
            this.VLCPlayer.Name = "VLCPlayer";
            this.VLCPlayer.Size = new System.Drawing.Size(532, 299);
            this.VLCPlayer.Spu = -1;
            this.VLCPlayer.TabIndex = 0;
            this.VLCPlayer.Text = "VLC";
			//this.VLCPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("VlcLibDirectory")));
			/*
						System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("C:\\Program Files\\VideoLAN\\VLC");
						if (di.Exists)
							this.VLCPlayer.VlcLibDirectory = di;
			*/
			this.VLCPlayer.VlcLibDirectory = new System.IO.DirectoryInfo("C:\\Program Files\\VideoLAN\\VLC");

			this.VLCPlayer.VlcMediaplayerOptions = null;
            // 
            // input_RTSP
            // 
            this.input_RTSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.input_RTSP.Location = new System.Drawing.Point(13, 23);
            this.input_RTSP.Name = "input_RTSP";
            this.input_RTSP.Size = new System.Drawing.Size(430, 23);
            this.input_RTSP.TabIndex = 1;
            //this.input_RTSP.Text = "rtsp://stream.szep.cz/user=test_password=test_channel=1_stream=1";
			this.input_RTSP.Text = "rtsp://192.168.88.249";
			// 
			// button_Connect
			// 
			this.button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Connect.Location = new System.Drawing.Point(449, 22);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(70, 25);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupbox_rtsp
            // 
            this.groupbox_rtsp.Controls.Add(this.input_RTSP);
            this.groupbox_rtsp.Controls.Add(this.button_Connect);
            this.groupbox_rtsp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupbox_rtsp.Location = new System.Drawing.Point(21, 338);
            this.groupbox_rtsp.Name = "groupbox_rtsp";
            this.groupbox_rtsp.Size = new System.Drawing.Size(532, 60);
            this.groupbox_rtsp.TabIndex = 3;
            this.groupbox_rtsp.TabStop = false;
            this.groupbox_rtsp.Text = "RTSP stream address of your IP camera:";
            // 
            // groupbox_Actions
            // 
            this.groupbox_Actions.Controls.Add(this.button_VideoRecording);
            this.groupbox_Actions.Controls.Add(this.button_TakeSnapshot);
            this.groupbox_Actions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupbox_Actions.Location = new System.Drawing.Point(21, 408);
            this.groupbox_Actions.Name = "groupbox_Actions";
            this.groupbox_Actions.Size = new System.Drawing.Size(532, 64);
            this.groupbox_Actions.TabIndex = 5;
            this.groupbox_Actions.TabStop = false;
            this.groupbox_Actions.Text = "Actions:";
            // 
            // button_VideoRecording
            // 
            this.button_VideoRecording.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_VideoRecording.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_VideoRecording.Location = new System.Drawing.Point(159, 19);
            this.button_VideoRecording.Name = "button_VideoRecording";
            this.button_VideoRecording.Size = new System.Drawing.Size(137, 32);
            this.button_VideoRecording.TabIndex = 4;
            this.button_VideoRecording.Text = "Start recording";
            this.button_VideoRecording.UseVisualStyleBackColor = false;
            this.button_VideoRecording.Click += new System.EventHandler(this.button_VideoRecording_Click);
            // 
            // button_TakeSnapshot
            // 
            this.button_TakeSnapshot.BackColor = System.Drawing.Color.Lavender;
            this.button_TakeSnapshot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_TakeSnapshot.Location = new System.Drawing.Point(13, 19);
            this.button_TakeSnapshot.Name = "button_TakeSnapshot";
            this.button_TakeSnapshot.Size = new System.Drawing.Size(140, 32);
            this.button_TakeSnapshot.TabIndex = 3;
            this.button_TakeSnapshot.Text = "Take snapshot";
            this.button_TakeSnapshot.UseVisualStyleBackColor = false;
            this.button_TakeSnapshot.Click += new System.EventHandler(this.button_TakeSnapshot_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 490);
            this.Controls.Add(this.groupbox_Actions);
            this.Controls.Add(this.groupbox_rtsp);
            this.Controls.Add(this.VLCPlayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTSP IP Camera Viewer Example • Jakub Szep • www.szep.cz";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).EndInit();
            this.groupbox_rtsp.ResumeLayout(false);
            this.groupbox_rtsp.PerformLayout();
            this.groupbox_Actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl VLCPlayer;
        private System.Windows.Forms.TextBox input_RTSP;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupbox_rtsp;
        private System.Windows.Forms.GroupBox groupbox_Actions;
        private System.Windows.Forms.Button button_VideoRecording;
        private System.Windows.Forms.Button button_TakeSnapshot;
    }
}

