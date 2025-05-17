using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IPCameraViewer
{
    // Simple example of IP Camera Viewer - playing, snapshoting and recording IP camera stream with RTSP protocol and VLC Library.
    // Created by Jakub Szep, Czech Republic, www.szep.cz
    // updated 14 June 2024
    public partial class MainWindow : Form
    {
        bool IsRecording1;
        bool IsRecording2;

        private int hour;
        private int minute;
        private int second;
        private int day, month;
		private DateTime now;

        public MainWindow()
        {
            InitializeComponent();
            // For testing you can use my demo IP camera RTSP stream:
            // rtsp://stream.szep.cz/user=test_password=test_channel=1_stream=1
            // Remember that you must have VLC Media Player already installed on computer where you want to execute
            // this application. All VLC Controls needs to use vlclib.dll located in VLC installation folder, in my
            // case 'C:\Program Files (x86)\VideoLAN\VLC'. Path must be always set in 'VLCLibDirectory' property
            // (you can easily set this property in designer). In this project, 'VLCLibDirectory' is already set.
            // If you want to use VLCControl in your own project, you must install NuGet package 'VLC.DotNet.Forms'.
            // 1. Project > Manage NuGet Packages > Browse > Type 'VLC.DotNet.Forms' > Install
            // 2. Designer > Toolbox > VLCControl > drop VLCControl somewhere into your form
            // This method checks if you have installed VLC Media Player 32 bit on your computer.
            // If not, it will direct you to download VLC setup.
            CheckIfInstalled();
            // Optional settings example:
            // You can mute the audio...
//            VLCPlayer.Audio.IsMute = true;
            VLCPlayer.Audio.IsMute = false;
          // You can set the volume...
            VLCPlayer.Audio.Volume = 69; // 0 is min, 100 is max
            // You can force aspect ratio...
            VLCPlayer.Video.AspectRatio = "16:9"; // 4:3 , 0:0 ...
			btnStartTimer.Enabled = true;
			btnStopTimer.Enabled = false;

        }

        public void CheckIfInstalled()
        {
            if (!File.Exists("C:\\Program Files\\VideoLAN\\VLC\\libvlc.dll"))
            {
                DialogResult dialogResult = MessageBox.Show("VLC installation was not detected. Do you want to install VLC now?", "VLC is missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("https://get.videolan.org/vlc/3.0.21/win32/vlc-3.0.21-win32.exe");
                    Process.GetCurrentProcess().Kill();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Application can't work without VLC installed.", "Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.GetCurrentProcess().Kill();
                }
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            VLCPlayer.Stop();
            VLCPlayer.SetMedia(new Uri(input_RTSP.Text), string.Empty);
            VLCPlayer.Play();
            // Or you can use:
            // VLCPlayer.Play(new Uri(input_RTSP.Text));
            // VLCPlayer.Play(new Uri(input_RTSP.Text), string.Empty);
        }
		private void btnConnect2_Click(object sender, EventArgs e)
		{
            VLCPlayer2.Stop();
            VLCPlayer2.SetMedia(new Uri(inputRTSP2.Text), string.Empty);
            VLCPlayer2.Play();
		}

        private void button_TakeSnapshot_Click(object sender, EventArgs e)
        {
            if (VLCPlayer.IsPlaying)
            {
                try
                {
                    // Define path where do you want to save the snapshot.
                    // Note: You have to use double backslash, otherways this bad ass bitch doesn't work.
                    //string path = $@"c:\\Users\\{Environment.UserName}\\Desktop\\{Guid.NewGuid()}.png";
					string path = $@"c:\\Users\\Daniel\\Recordings\\SnapShot_{Guid.NewGuid()}.png";
					// Basic:
					VLCPlayer.TakeSnapshot(path);
                    // Or you can specify output image size in pixels (for example 400x300):
                    // VLCPlayer.TakeSnapshot(path, 400, 300);
                    //MessageBox.Show("Snapshot is successfully saved on your desktop!", "Snapshot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("An error occurred while trying to take the snapshot.", "Aah fuck", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You cannot take a snapshot if there is no video available.", "No no no", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
		private void btn_SnapShot2_Click(object sender, EventArgs e)
		{
            if (VLCPlayer2.IsPlaying)
            {
                try
                {
                    // Define path where do you want to save the snapshot.
                    // Note: You have to use double backslash, otherways this bad ass bitch doesn't work.
                    //string path = $@"c:\\Users\\{Environment.UserName}\\Desktop\\{Guid.NewGuid()}.png";
					string path = $@"c:\\Users\\Daniel\\Recordings\\SnapShot_{Guid.NewGuid()}.png";
					// Basic:
					VLCPlayer2.TakeSnapshot(path);
                    // Or you can specify output image size in pixels (for example 400x300):
                    // VLCPlayer.TakeSnapshot(path, 400, 300);
                    //MessageBox.Show("Snapshot is successfully saved on your desktop!", "Snapshot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("An error occurred while trying to take the snapshot.", "Aah fuck", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You cannot take a snapshot if there is no video available.", "No no no", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
		}

        private void button_VideoRecording_Click(object sender, EventArgs e)
        {
            if (!IsRecording1)
            {
                // Start recording
                if (VLCPlayer.IsPlaying)
                {
                    try
                    {
                        // Define path where do you want to save the snapshot.
                        // Note: You have to use double backslash, otherways this bad ass bitch doesn't work.

                        //string path = $@"c:\\Users\\{Environment.UserName}\\Desktop\\{Guid.NewGuid()}.mp4";
                        //string path = $@"c:\\Users\\Daniel\\Recordings\\Video_{Guid.NewGuid()}.mp4";
						string path = $@"c:\\Users\\Daniel\\Recordings\\Video1_{interval++}.mp4";
						// Magic option string that creates recording:
						var mediaOptions = new[] { ":sout=#duplicate{dst=display,dst=std{access=file,mux=mp4,dst=\"" + path + "\"}" };
                        VLCPlayer.SetMedia(new Uri(input_RTSP.Text), mediaOptions);
                        VLCPlayer.Play();
                        IsRecording1 = true;
                        button_VideoRecording.Text = "Stop recording";
                        button_VideoRecording.BackColor = Color.Pink;

                    }
                    catch
                    {
                        MessageBox.Show("There was some fucked up error while trying to record the video.", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("You can record video after connecting to the IP camera stream.", "No no no", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            else
            {
                // Stop recording
                IsRecording1 = false;
                VLCPlayer.Stop();
                VLCPlayer.SetMedia(new Uri(inputRTSP2.Text), string.Empty);
                VLCPlayer.Play();
                button_VideoRecording.Text = "Start recording";
                button_VideoRecording.BackColor = Color.LemonChiffon;
                //MessageBox.Show("Video record is successfully saved on your desktop!", "Video record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

		private void btnRecord2_Click(object sender, EventArgs e)
		{
            if (!IsRecording2)
            {
                // Start recording
                if (VLCPlayer2.IsPlaying)
                {
                    try
                    {
                        // Define path where do you want to save the snapshot.
                        // Note: You have to use double backslash, otherways this bad ass bitch doesn't work.

                        //string path = $@"c:\\Users\\{Environment.UserName}\\Desktop\\{Guid.NewGuid()}.mp4";
                        //string path = $@"c:\\Users\\Daniel\\Recordings\\Video_{Guid.NewGuid()}.mp4";
						string path = $@"c:\\Users\\Daniel\\Recordings\\Video2_{interval++}.mp4";
						
						// Magic option string that creates recording:
						var mediaOptions = new[] { ":sout=#duplicate{dst=display,dst=std{access=file,mux=mp4,dst=\"" + path + "\"}" };
                        VLCPlayer2.SetMedia(new Uri(inputRTSP2.Text), mediaOptions);
                        VLCPlayer2.Play();
                        IsRecording2 = true;
                        btnRecord2.Text = "Stop recording";
                        btnRecord2.BackColor = Color.Pink;
                    }
                    catch
                    {
                        MessageBox.Show("There was some fucked up error while trying to record the video.", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You can record video after connecting to the IP camera stream.", "No no no", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                // Stop recording
                IsRecording2 = false;
                VLCPlayer2.Stop();
                VLCPlayer2.SetMedia(new Uri(inputRTSP2.Text), string.Empty);
                VLCPlayer2.Play();
                btnRecord2.Text = "Start recording";
                btnRecord2.BackColor = Color.LemonChiffon;
                //MessageBox.Show("Video record is successfully saved on your desktop!", "Video record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}

		int interval = 0;

		private void timer1_Tick(object sender, EventArgs e)
		{
			
			now = DateTime.Now;
			hour = now.Hour;
			minute = now.Minute;
			second = now.Second;
            day = now.Day;
            month = now.Month;
			string str = String.Format("{0,-2}-{1,-2}-{2,-2}-{3,-2}-{4,-2}",month,day,hour,minute,second);
            tbStatus.Text = str;
			VLCPlayer.Stop();
			string path1 = $@"f:\\Recordings\\Video1_" + str + ".mp4";
			var mediaOptions1 = new[] { ":sout=#duplicate{dst=display,dst=std{access=file,mux=mp4,dst=\"" + path1 + "\"}" };
			VLCPlayer.SetMedia(new Uri(input_RTSP.Text), mediaOptions1);
			VLCPlayer.Play();
			IsRecording1 = true;

			VLCPlayer2.Stop();
			string path2 = $@"f:\\Recordings\\Video2_" + str + ".mp4";
			var mediaOptions2 = new[] { ":sout=#duplicate{dst=display,dst=std{access=file,mux=mp4,dst=\"" + path2 + "\"}" };
			VLCPlayer2.SetMedia(new Uri(inputRTSP2.Text), mediaOptions2);
			VLCPlayer2.Play();
			IsRecording2 = true;
		}

		private void StartTimer(object sender, EventArgs e)
		{
			btnStartTimer.Enabled = false;
			btnStopTimer.Enabled = true;
            btnRecord2.Enabled = false;
            button_VideoRecording.Enabled = false;
            timer1.Enabled = true;
			button_Connect.Enabled = false;
			btnConnect2.Enabled = false;
			timer1_Tick(new object(), new EventArgs());
		}

		private void btnStopTimer_Click(object sender, EventArgs e)
		{
			btnStartTimer.Enabled = true;
			btnStopTimer.Enabled = false;
			timer1.Enabled = false;
			VLCPlayer2.Stop();
			VLCPlayer.Stop();
			IsRecording1 = false;
			IsRecording2 = false;
			btnRecord2.Enabled = true;
            button_VideoRecording.Enabled = true;
			button_Connect.Enabled = true;
			btnConnect2.Enabled = true;
		}
	}
}
