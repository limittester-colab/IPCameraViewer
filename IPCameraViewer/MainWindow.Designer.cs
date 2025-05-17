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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.VLCPlayer = new Vlc.DotNet.Forms.VlcControl();
			this.input_RTSP = new System.Windows.Forms.TextBox();
			this.button_Connect = new System.Windows.Forms.Button();
			this.groupbox_rtsp = new System.Windows.Forms.GroupBox();
			this.groupbox_Actions = new System.Windows.Forms.GroupBox();
			this.button_VideoRecording = new System.Windows.Forms.Button();
			this.button_TakeSnapshot = new System.Windows.Forms.Button();
			this.VLCPlayer2 = new Vlc.DotNet.Forms.VlcControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRecord2 = new System.Windows.Forms.Button();
			this.btn_SnapShot2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.inputRTSP2 = new System.Windows.Forms.TextBox();
			this.btnConnect2 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tbStatus = new System.Windows.Forms.TextBox();
			this.btnStartTimer = new System.Windows.Forms.Button();
			this.btnStopTimer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).BeginInit();
			this.groupbox_rtsp.SuspendLayout();
			this.groupbox_Actions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VLCPlayer2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// VLCPlayer
			// 
			this.VLCPlayer.BackColor = System.Drawing.Color.Black;
			this.VLCPlayer.Location = new System.Drawing.Point(21, 23);
			this.VLCPlayer.Name = "VLCPlayer";
			this.VLCPlayer.Size = new System.Drawing.Size(389, 270);
			this.VLCPlayer.Spu = -1;
			this.VLCPlayer.TabIndex = 0;
			this.VLCPlayer.Text = "VLC";
			this.VLCPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("VLCPlayer.VlcLibDirectory")));
			this.VLCPlayer.VlcMediaplayerOptions = null;
			// 
			// input_RTSP
			// 
			this.input_RTSP.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.input_RTSP.Location = new System.Drawing.Point(13, 24);
			this.input_RTSP.Name = "input_RTSP";
			this.input_RTSP.Size = new System.Drawing.Size(157, 23);
			this.input_RTSP.TabIndex = 1;
			this.input_RTSP.Text = "rtsp://192.168.88.249";
			// 
			// button_Connect
			// 
			this.button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_Connect.Location = new System.Drawing.Point(185, 24);
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
			this.groupbox_rtsp.Size = new System.Drawing.Size(276, 60);
			this.groupbox_rtsp.TabIndex = 3;
			this.groupbox_rtsp.TabStop = false;
			this.groupbox_rtsp.Text = "RTSP stream address of your IP camera 1:";
			// 
			// groupbox_Actions
			// 
			this.groupbox_Actions.Controls.Add(this.button_VideoRecording);
			this.groupbox_Actions.Controls.Add(this.button_TakeSnapshot);
			this.groupbox_Actions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupbox_Actions.Location = new System.Drawing.Point(21, 408);
			this.groupbox_Actions.Name = "groupbox_Actions";
			this.groupbox_Actions.Size = new System.Drawing.Size(276, 64);
			this.groupbox_Actions.TabIndex = 5;
			this.groupbox_Actions.TabStop = false;
			this.groupbox_Actions.Text = "Actions:";
			// 
			// button_VideoRecording
			// 
			this.button_VideoRecording.BackColor = System.Drawing.Color.LemonChiffon;
			this.button_VideoRecording.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.button_VideoRecording.Location = new System.Drawing.Point(126, 19);
			this.button_VideoRecording.Name = "button_VideoRecording";
			this.button_VideoRecording.Size = new System.Drawing.Size(117, 32);
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
			this.button_TakeSnapshot.Size = new System.Drawing.Size(107, 32);
			this.button_TakeSnapshot.TabIndex = 3;
			this.button_TakeSnapshot.Text = "Take snapshot";
			this.button_TakeSnapshot.UseVisualStyleBackColor = false;
			this.button_TakeSnapshot.Click += new System.EventHandler(this.button_TakeSnapshot_Click);
			// 
			// VLCPlayer2
			// 
			this.VLCPlayer2.BackColor = System.Drawing.Color.Black;
			this.VLCPlayer2.ImeMode = System.Windows.Forms.ImeMode.On;
			this.VLCPlayer2.Location = new System.Drawing.Point(437, 23);
			this.VLCPlayer2.Name = "VLCPlayer2";
			this.VLCPlayer2.Size = new System.Drawing.Size(389, 270);
			this.VLCPlayer2.Spu = -1;
			this.VLCPlayer2.TabIndex = 6;
			this.VLCPlayer2.Text = "VLC";
			this.VLCPlayer2.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("VLCPlayer2.VlcLibDirectory")));
			this.VLCPlayer2.VlcMediaplayerOptions = null;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRecord2);
			this.groupBox1.Controls.Add(this.btn_SnapShot2);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(437, 404);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(276, 64);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actions:";
			// 
			// btnRecord2
			// 
			this.btnRecord2.BackColor = System.Drawing.Color.LemonChiffon;
			this.btnRecord2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnRecord2.Location = new System.Drawing.Point(126, 19);
			this.btnRecord2.Name = "btnRecord2";
			this.btnRecord2.Size = new System.Drawing.Size(117, 32);
			this.btnRecord2.TabIndex = 4;
			this.btnRecord2.Text = "Start recording";
			this.btnRecord2.UseVisualStyleBackColor = false;
			this.btnRecord2.Click += new System.EventHandler(this.btnRecord2_Click);
			// 
			// btn_SnapShot2
			// 
			this.btn_SnapShot2.BackColor = System.Drawing.Color.Lavender;
			this.btn_SnapShot2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btn_SnapShot2.Location = new System.Drawing.Point(13, 19);
			this.btn_SnapShot2.Name = "btn_SnapShot2";
			this.btn_SnapShot2.Size = new System.Drawing.Size(107, 32);
			this.btn_SnapShot2.TabIndex = 3;
			this.btn_SnapShot2.Text = "Take snapshot";
			this.btn_SnapShot2.UseVisualStyleBackColor = false;
			this.btn_SnapShot2.Click += new System.EventHandler(this.btn_SnapShot2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.inputRTSP2);
			this.groupBox2.Controls.Add(this.btnConnect2);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox2.Location = new System.Drawing.Point(437, 338);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 60);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "RTSP stream address of your IP camera 2:";
			// 
			// inputRTSP2
			// 
			this.inputRTSP2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.inputRTSP2.Location = new System.Drawing.Point(13, 24);
			this.inputRTSP2.Name = "inputRTSP2";
			this.inputRTSP2.Size = new System.Drawing.Size(157, 23);
			this.inputRTSP2.TabIndex = 1;
			this.inputRTSP2.Text = "rtsp://192.168.88.235";
			// 
			// btnConnect2
			// 
			this.btnConnect2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnConnect2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnConnect2.Location = new System.Drawing.Point(185, 24);
			this.btnConnect2.Name = "btnConnect2";
			this.btnConnect2.Size = new System.Drawing.Size(70, 25);
			this.btnConnect2.TabIndex = 2;
			this.btnConnect2.Text = "Connect";
			this.btnConnect2.UseVisualStyleBackColor = false;
			this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 30000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tbStatus
			// 
			this.tbStatus.Location = new System.Drawing.Point(34, 527);
			this.tbStatus.Name = "tbStatus";
			this.tbStatus.Size = new System.Drawing.Size(523, 20);
			this.tbStatus.TabIndex = 9;
			// 
			// btnStartTimer
			// 
			this.btnStartTimer.Location = new System.Drawing.Point(594, 524);
			this.btnStartTimer.Name = "btnStartTimer";
			this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
			this.btnStartTimer.TabIndex = 10;
			this.btnStartTimer.Text = "Start Timer";
			this.btnStartTimer.UseVisualStyleBackColor = true;
			this.btnStartTimer.Click += new System.EventHandler(this.StartTimer);
			// 
			// btnStopTimer
			// 
			this.btnStopTimer.Location = new System.Drawing.Point(692, 524);
			this.btnStopTimer.Name = "btnStopTimer";
			this.btnStopTimer.Size = new System.Drawing.Size(75, 23);
			this.btnStopTimer.TabIndex = 11;
			this.btnStopTimer.Text = "Stop Timer";
			this.btnStopTimer.UseVisualStyleBackColor = true;
			this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 571);
			this.Controls.Add(this.btnStopTimer);
			this.Controls.Add(this.btnStartTimer);
			this.Controls.Add(this.tbStatus);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.VLCPlayer2);
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
			((System.ComponentModel.ISupportInitialize)(this.VLCPlayer2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl VLCPlayer;
        private System.Windows.Forms.TextBox input_RTSP;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupbox_rtsp;
        private System.Windows.Forms.GroupBox groupbox_Actions;
        private System.Windows.Forms.Button button_VideoRecording;
        private System.Windows.Forms.Button button_TakeSnapshot;
		private Vlc.DotNet.Forms.VlcControl VLCPlayer2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRecord2;
		private System.Windows.Forms.Button btn_SnapShot2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox inputRTSP2;
		private System.Windows.Forms.Button btnConnect2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox tbStatus;
		private System.Windows.Forms.Button btnStartTimer;
		private System.Windows.Forms.Button btnStopTimer;
	}
}

