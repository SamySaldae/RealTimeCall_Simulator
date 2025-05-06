using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ticket_call_system
{
    public partial class MESSAGE_TRANSMISSION_FORM : Form
    {
        public const string MSGFILEpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\MSG_CONEX.txt";
        public string PIVOTDATApath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\PIVOTDATA.txt";

        List<string> ltALLMESSAGE = new List<string>();
        public MESSAGE_TRANSMISSION_FORM()
        {
            InitializeComponent();
        }
        bool saved = false;
        private DialogResult DialogMessage(string MessageToShow,string Titel)
        {
            DialogResult Result = MessageBox.Show(MessageToShow,
                Titel, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return Result;
        }
        enum enDataSending { enVoiceToRead,enMessageToDiffuse }
        void sendToPivot(enDataSending Mode)
        {
            if(Mode == enDataSending.enMessageToDiffuse)
            {
                File.WriteAllText(PIVOTDATApath, "MESSAGE" + Environment.NewLine);
            }
            else
                File.WriteAllText(PIVOTDATApath, "VOICE_MESSAGE");
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            
            if (DialogMessage("Do you want to send this message to clients?", "Confirmation massage") == DialogResult.OK)
            {
                sendToPivot(enDataSending.enMessageToDiffuse);
                ltALLMESSAGE = txtMessage.Lines.ToList();
                File.WriteAllLines(MSGFILEpath, ltALLMESSAGE); // Erase the last saved file 
                File.AppendAllLines(PIVOTDATApath, ltALLMESSAGE); //Below "MESSAGE"
            }
        }
        const string FormBaseText = "MESSAGE_TRANSMISSION_FORM";
        private void SetUIUnsavedStatus()
        {
            this.Text = FormBaseText.ToString().Insert(FormBaseText.Length, "*(unsaved)*");
        }
        private void SetUISavedStatus()
        {
            string FormBaseText = "MESSAGE_TRANSMISSION_FORM";
            this.Text = FormBaseText;
        }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            saved = false;
            SetUIUnsavedStatus();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!saved)
            {
                if (DialogMessage("Do you want to write a new text ?\n Actual text will be lost .", "New text") == DialogResult.OK)
                    txtMessage.Text = "";
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saved = true;
            SetUISavedStatus();
            File.WriteAllLines(MSGFILEpath, ltALLMESSAGE); // Erase the last saved file 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!saved)
            {
                if (DialogMessage("This text is unsaved , if you exit you'll loose " +
                    "this current text .", "Are you sure ?")==DialogResult.Cancel)
                {
                    //Do nothing :D
                    return;
                }
            }
            //if saved==true or admin choosed OK on dialog result this form will be closed
            this.Close();
        }
    }
}
