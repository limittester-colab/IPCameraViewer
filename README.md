using AMB52-MINI cameras to stream RTSP to windows app with 2 screens - 1 for each cameras
originally created by Jakub Szep, Czech Republic, www.szep.cz

1st cam 192.168.88.249 - Ameba_12D2B0
2nd cam 192.168.88.235 - Ameba_12DD51

For testing you can use my demo IP camera RTSP stream:
rtsp://stream.szep.cz/user=test_password=test_channel=1_stream=1
Remember that you must have VLC Media Player already installed on computer where you want to execute
this application. All VLC Controls needs to use vlclib.dll located in VLC installation folder, in my
case 'C:\Program Files (x86)\VideoLAN\VLC'. Path must be always set in 'VLCLibDirectory' property
(you can easily set this property in designer). In this project, 'VLCLibDirectory' is already set.
If you want to use VLCControl in your own project, you must install NuGet package 'VLC.DotNet.Forms'.
1. Project > Manage NuGet Packages > Browse > Type 'VLC.DotNet.Forms' > Install
2. Designer > Toolbox > VLCControl > drop VLCControl somewhere into your form
This method checks if you have installed VLC Media Player 32 bit on your computer.
If not, it will direct you to download VLC setup.
