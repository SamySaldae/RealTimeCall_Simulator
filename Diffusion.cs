using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // For WindowsMediaPlayer
using AxWMPLib;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Media;


/// <summary>
/// Features:
/// - Real-time display of called tickets (via CALLEDCLIENT.txt)
/// - Automatic playback of audio announcements (via ClientCaller.exe)
/// - Media management (intro video, sound effects)
/// - Active monitoring of the CalledClient.txt file
///
/// Dependencies:
/// - ClientCaller.exe (text-to-speech plugin)
/// - SoundPlayer (sound effects)
/// - WindowsMediaPlayer (video)
/// </summary>


namespace ticket_call_system
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();        
        }
      
            private void ChargeCounterPicture(string strCounter)
            {
            pbCounter.Image = Image.FromFile(COUNTERPICSpath+strCounter+".JPG");
            pbCounter.SizeMode = PictureBoxSizeMode.Zoom;
            }
        List<string> ltCalledCient;
        //All path of files and sound are here 
        const string CALLEDCLIENTpath = @"C:\Users\khodi\OneDrive\Desktop\Projets\ticket call system\DB files\Called Client.txt";
        const string COUNTERPICSpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Pics\\";
        const string VOICECALLERpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Audio File\\ClientCaller\\x64\\Release\\ClientCaller.exe";
        const string SOUNDpath = @"C:\Users\khodi\OneDrive\Desktop\Projets\ticket call system\DB files\Audio File\Sound effets\Next sound effect 1.wav";

        private void ChargeListFromFile()
        {
            ltCalledCient = File.ReadAllLines(CALLEDCLIENTpath).ToList();
        }
        string precedent_code = "";
        string Counter;
        string strNumber;
        
        void prepare_code(string lcoal_code)
        {
           
            //Divide the string using the caracter '/' as a delimiter
            string[] code = lcoal_code.Split('/');
            Counter = code[0];  
            strNumber = code[1];    
        }
    
        void PrintOnScreen(string string_number,string string_counter)
        {
            lbNumber.Text= string_number;
            ChargeCounterPicture(string_counter);
           // MessageBox.Show("Message has been printed .");
            this.Refresh();
        }
        void PlaySoundEffect()
        {
            SoundPlayer player = new SoundPlayer(SOUNDpath);
            player.Play();
        }
        private async void VoiceCall()
        {
            //Call the cpp app should be here
            PlaySoundEffect();
            await Task.Delay(2000);
            Process.Start(VOICECALLERpath);
        }
        private void check()     //Check if a new client has been added on file
        {
            if (ltCalledCient[0] != precedent_code)
            {
                precedent_code = ltCalledCient[0];
                prepare_code(precedent_code);
                PrintOnScreen(strNumber,Counter);
                VoiceCall();
            }
        }
        private void PlayVideo()
        {
            string videoPath = @"C:\Users\khodi\OneDrive\Desktop\Projets\ticket call system\DB files\Videos\Intro.mp4";
            WMP1.URL = videoPath; // Load the vidéo
            WMP1.settings.setMode("loop", true); // Activate loop mode for video
            WMP1.settings.autoStart = true; // Start playing video automaticly
        }
        private async Task WaitOneSecondAsync(int seconds)
        {
            await Task.Delay(seconds);
        }
        async private Task  loop() //Poling technic
        {
            while (stopLoop==false) 
            {
                ChargeListFromFile();
                check();
                await WaitOneSecondAsync(1000);
            }
        }
        private void Form1_Load(object sender, EventArgs e) //Start of diffusion
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.Image = Properties.Resources.liquid_marbling_paint_texture_background_fluid_painting_abstract_texture_intensive_color_mix_wallpaper;
            this.BackgroundImage = pictureBox.Image;
            Form form = new SpaceAdmins();
            PlayVideo();
            form.Show();
            if(loop()==null)
            {
                MessageBox.Show("Diffusion END");
            }

        }
        bool stopLoop = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopLoop = true;
        }
    }
}
