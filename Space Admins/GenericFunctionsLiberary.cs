using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ticket_call_system
{
    internal class GenericFunctionsLiberary
    {
       
        public const string MSGFILEpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\MSG_CONEX.txt";
        public const string PIVOTDATApath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\PIVOTDATA.txt";
        const string QUEUEpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Queue.txt";
        public string SETTINGSpath = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Settings.txt";

        public void GetListQUEUE(ref List<string> ltQUEUE)
        {
            
        }
        public List<string> GetListFromFile()
        {
            return File.ReadAllLines(GetQUEUEpath()).ToList();
        }
        public string GetQUEUEpath()
        {
            return QUEUEpath;
        }
        List<string> functions = new List<string>();
        public int  CountClients(List<string> Clientlist)
        {
            return Clientlist.Count();
        }
        public int GetFrequency(TrackBar TrkBar)
        {
            return TrkBar.Value;
        }
    
        public int AutomaticPolling(int WaitingClients)
        {
            if (WaitingClients < 20)
                return 1300;
            else if (WaitingClients > 20 && WaitingClients < 40)
                return 900;
            else
                return 700;
        }
        public string GenerateSetingsCode(string Str_Freq, string language, string tone, string video_path, char delim)
        {
            string Code = Str_Freq;
            Code += delim + language;
            Code += delim + tone;
            Code += delim + video_path;
            return Code;
        }
        public void SendToSettingFile(string Code)
        {
            File.WriteAllText(SETTINGSpath, Code);
        }
        public void SendToPIVOTDATAfile(string Code)
        {
            File.WriteAllText(PIVOTDATApath, "SETTINGS" + Environment.NewLine);
            File.AppendAllText(PIVOTDATApath, Code);
        }
        public void SendToPIVOTDATAfile(string FirstLine,string SecondLine)
        {
            File.WriteAllText(PIVOTDATApath, FirstLine + Environment.NewLine);
            File.AppendAllText(PIVOTDATApath, SecondLine);
        }
        public string GetComboxBoxValue(ComboBox cmbx)
        {
            return cmbx.SelectedIndex.ToString();
        }

    }
}
