using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Media;




namespace ticket_call_system
{
    //Message has been
    public partial class SpaceAdmins : Form
    {
        const string QUEUEpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Queue.txt";
        const string SOUNDpath = @"C:\Users\khodi\OneDrive\Desktop\Projets\ticket call system\DB files\Audio File\Sound effets\Next sound effect 1.wav";
        const string CALLEDCLIENTpath = @"C:\Users\khodi\OneDrive\Desktop\Projets\ticket call system\DB files\Called Client.txt";
        public SpaceAdmins()
        {
            InitializeComponent();
        }
        int[] CounterTAB_Variables=new int[4]; //Index of coloms |0->A1|1->A2|2->B1|3->B2|
        enum enCounters { A1 = 0,A2 = 1,B1 = 2,B2 = 3 };
        void initialise_CounterTab()
        {
            for(int i=0;i<4;i++)
                CounterTAB_Variables[i]=1;
        }

       
        List<string> ltQUEUE;
        int WaitingClients;
        private void GetListFromFile()
        {
            ltQUEUE = File.ReadAllLines(QUEUEpath).ToList();
        }
        private Label FindLabel(string TagNeeded)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label label && label.Tag != null && label.Tag.ToString() == TagNeeded)
                {
                    return label;
                }
            }
            // If is not found 
            return null;
        }
        private void Increment_By_Index(int index)
        {
            CounterTAB_Variables[index]++;
        }
        private bool DeleteOnFile(string TxtToDelete)
        {
            bool deleted = ltQUEUE.Remove(TxtToDelete);
            if (deleted)
            {
                File.WriteAllLines(QUEUEpath, ltQUEUE);
                //MessageBox.Show("Next");
            }
            return deleted;
        }
        private bool CodeISinQUEUE(string code)
        {
            if (ltQUEUE.Contains(code))
                return true;
            return false;
        }
        private string FromTagToCounters(string Tag)
        {
            switch(Tag)
            {
                case "0": return "A1";
                case "1": return "A2";
                case "2": return "B1";
                case "3": return "B2";
                default: return "A1";
            }
        }
        private void Execute_NEXT_Sound_EFFECT()
        {
            if (!File.Exists(SOUNDpath))
            {
                //MessageBox.Show("Fichier introuvable: " + SOUNDpath);
                return;
            }
            SoundPlayer player = new SoundPlayer(SOUNDpath);
            player.Play();
        }
        private void SendToCALLEDCLIENT(string Text)
        {
            File.WriteAllText(CALLEDCLIENTpath, Text);
        }
        private void UpdateCounter(string Str_Counter)
        {

        }
        private bool UpdateLabelFromButton(Button Btn)
        {
            // Parse the button tag once and store the value
            int index = int.Parse(Btn.Tag.ToString());

            
            // Find the corresponding label based on the enum value
            Label label = FindLabel(index.ToString());
            if (label != null)
            { 
                // Update the label's text
                string Str_number = CounterTAB_Variables[index].ToString();
                label.Text = Str_number;   //Actual number of Counter
                string Str_Counter = FromTagToCounters(index.ToString());  //Counter Sign (exemple : A1)
                
                string TextToDeleteOnQueue = Str_Counter + '/' + Str_number;
                GetListFromFile();

                if (!CodeISinQUEUE(Str_Counter+'/'+ Str_number))
                {
                    MessageBox.Show(Str_number+'/'+Str_Counter);
                    return false;
                }
                Increment_By_Index(index);

                if (DeleteOnFile(TextToDeleteOnQueue))
                {
                    //MessageBox.Show("Next is executed ");
                    Gen.SendToPIVOTDATAfile("CALLEDCLIENT",TextToDeleteOnQueue);
                   // SendToCALLEDCLIENT(TextToDeleteOnQueue);
                    return true;
                }
                else
                {
                   // MessageBox.Show("Number to delete was not found .");
                }
                // Refresh the form
                this.Refresh();
                return false;
            }
            else
            {
                //MessageBox.Show("Error , Label was not found !");
            }
            return false;
        }
        private void Button_Incrementation(Button Btn)
        {
            if (UpdateLabelFromButton(Btn))
            {
                //Execute_NEXT_Sound_EFFECT();
            }
        }
        private void ClickOnNextButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Button_Incrementation(btn);
            }
            else
                MessageBox.Show("The next code is not already added on QUEUE.txt");
        }

        private void SpaceAdmins_Load(object sender, EventArgs e)
        {
            initialise_CounterTab();
            Gen = new GenericFunctionsLiberary();
            
        }
        enum enBackImage { Image,none};
        void ChangeBackImage(Button btn,enBackImage Back)
        {
            if (Back == enBackImage.Image)
                btn.BackgroundImage = Properties.Resources.liquid_marbling_paint_texture_background_fluid_painting_abstract_texture_intensive_color_mix_wallpaper;
            else
                btn.BackgroundImage = null;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ChangeBackImage(btn,enBackImage.none);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ChangeBackImage(btn, enBackImage.Image);
        }

        string DIFFUSEVIDEOpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Videos\\Intro.mp4";
        string Language = "ENGLISH";
        string Tone = "Tone 1";
        string Str_Frequency_Value = "1000";
        GenericFunctionsLiberary Gen;
        private void LoadingVideoPath()
        {
            FilaDialogLoad.InitialDirectory = @"C:\Users\khodi\OneDrive\";
            FilaDialogLoad.Title = "Loading a new video ";
            FilaDialogLoad.DefaultExt = "avi"; //|mp4|mov
            FilaDialogLoad.Filter = "avi files (*.avi)|*.avi|Mp4 files (*.mp4)|*.mp4|Movies files (*.mov)|*.mov";
            if(FilaDialogLoad.ShowDialog()==DialogResult.OK)
            {
                DIFFUSEVIDEOpath=FilaDialogLoad.FileName;
            }
        }
        Form MessageForm = new MESSAGE_TRANSMISSION_FORM();
        private void ClickParametersButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                if (btn.Tag.ToString() == "Message")
                {
                    MessageForm.ShowDialog();
                }
                else if(btn.Tag.ToString() =="Done")
                {
                    //string Code = "d";
                    string Code = Gen.GenerateSetingsCode(Str_Frequency_Value, Language, Tone, DIFFUSEVIDEOpath, '/');
                    Gen.SendToSettingFile(Code);
                    //Send to PIVOTDATA
                    Gen.SendToPIVOTDATAfile(Code);
                }
                else if(btn.Tag.ToString() =="Load")
                {
                    LoadingVideoPath();
                }
            }
        }

        private void trk_PollingFrequency_Scroll(object sender, EventArgs e)
        {
            lbl_FrequencyValue.Text=trk_PollingFrequency.Value.ToString();
            TrackBar Trk = sender as TrackBar;
            Str_Frequency_Value = lbl_FrequencyValue.Text;
           // MessageBox.Show(Str_Frequency_Value);
        }

        private void chk_AutoMatic_CheckedChanged(object sender, EventArgs e)
        {
            trk_PollingFrequency.Enabled = !chk_AutoMatic.Checked;
            if (chk_AutoMatic.Checked)
            {
                if(ltQUEUE!=null)
                { 
                    WaitingClients = ltQUEUE.Count;
                    Str_Frequency_Value = Gen.AutomaticPolling(WaitingClients).ToString();
                }   
                else
                { 
                     Str_Frequency_Value = "1000";
                    MessageBox.Show("The Queue is empty right now .\n It will be functional after first (swipe next) actioned by admin \n Actual frequency = 1 (second)");
                }
            }
            else
                Str_Frequency_Value = trk_PollingFrequency.Value.ToString();
        }

        private void cmb_Language_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            switch(cmb.Tag.ToString())
            {
                case "Language":Language=Gen.GetComboxBoxValue(cmb); break;
                case "Tone":Tone=Gen.GetComboxBoxValue(cmb);break;
            }
        }
    }
}
