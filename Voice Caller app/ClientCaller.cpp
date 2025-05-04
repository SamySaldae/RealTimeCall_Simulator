#include<iostream>
#include<string>
#include<fstream>
#include<vector>

using namespace std;

string NumberToText(int Number)
{
    if (Number == 0)
        return "";
    if (Number > 0 && Number < 20)
    {
        string Tab[] = { "","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve",
        "thirteen" ,"fourteen","fiveteen","seventeen","eighteen","nineteen" };
        return Tab[Number] + " ";
    }
    if (Number >= 19 && Number < 100)
    {
        string Tab[] = { "","","twenty","thirty","fourty","fivety","sixty","seventy","eighty","ninety" };
        return Tab[Number / 10] + " " + NumberToText(Number % 10);
    }
    if (Number > 99 && Number < 200)
    {
        return "One hundred " + NumberToText(Number % 100);
    }
    if (Number > 199 && Number < 1000)
    {
        return NumberToText(Number / 100) + " hundreds " + NumberToText(Number % 100);
    }
    if (Number > 999 && Number < 2000)
    {
        return "one thousand " + NumberToText(Number % 10000);
    }
    if (Number > 1999 && Number < 10000)
    {
        return NumberToText(Number / 1000) + " thousands " + NumberToText(Number % 1000);
    }
    if (Number > 9999 && Number < 1000000)
    {
        return NumberToText(Number / 1000) + " thousands " + NumberToText(Number % 1000);
    }
    if (Number > 999999 && Number < 2000000)
    {
        return "One million " + NumberToText(Number % 1000000);
    }
    if (Number > 1999999 && Number < 1000000000)
    {
        return NumberToText(Number / 1000000) + " millions " + NumberToText(Number % 1000000);
    }
    if (Number >= 1000000000 && Number < 2000000000)
    {
        return "One billion " + NumberToText(Number % 1000000000);
    }
    if (Number >= 2000000000 && Number < 1000000000000)
    {
        return NumberToText(Number / 1000000000) + " billions " + NumberToText(Number % 1000000000);
    }
}
int GetNumber(string message)
{
    int number;
    cout << message;
    cin >> number;
    return number;
}
string ajust_path(string local_path)
{
    for (int i = 0; i < local_path.size(); i++)
    {
        if (local_path[i] == '/')
            local_path[i] = char(92);
    }
    return local_path;
}
string ajust_path(string local_path, bool double_slash)
{
    string newpath;
    for (int i = 0; i < local_path.size(); i++)
    {
        if (local_path[i] != '/')
            newpath += local_path[i];
        else
        {
            newpath += "\\\\";
        }
    }
    return newpath;
}
string GetLanguage()
{
    fstream LangFile;
    string path = "C:/Users/khodi/OneDrive/Desktop/Projets/ticket call system/DB files/Voice Language.txt";
    LangFile.open(path, ios::in);
    if (LangFile.is_open())
    {
        string Language;
        while (getline(LangFile, Language))
        {
            if (Language != "")
            {
                return Language;
            }
        }
        LangFile.close();
    }
}
vector<string> splitFunction(string sentence, char delim)
{
    vector<string> vWords;
    string word = "";
    for (int i = 0; i < sentence.size(); i++)
    {
        if (sentence[i] != delim)
            word += sentence[i];
        else
        {
            vWords.push_back(word);
            word = "";
        }
    }
    if (word != "")
        vWords.push_back(word);
    return vWords;
}
void read_vector(vector<string> vect)
{
    for (string& word : vect)
    {
        cout << word << endl;
    }
}
#include <windows.h>
#include <mmsystem.h>
#pragma comment(lib, "winmm.lib")
#include <tlhelp32.h>
#include <string>
#include <thread>
#include <chrono>

void MinimizeFoobarWindow() {
    HWND hwnd = NULL;

    // Attendre quelques instants que la fenêtre apparaisse
    std::this_thread::sleep_for(std::chrono::milliseconds(500));

    // Essayer de la trouver sur 3 secondes
    for (int i = 0; i < 30; ++i) {
        hwnd = FindWindowA("ninety  [foobar2000]", NULL); // recherche par **classe**
        if (hwnd) {
            cout << "Found" << endl;
            ShowWindow(hwnd, SW_MINIMIZE);
            return;
        }
        std::this_thread::sleep_for(std::chrono::milliseconds(200));
    }
}

void PlayAudio(const std::string& filePath) {

    // Convertir std::string en const char*
    ShellExecuteA(NULL, "open", filePath.c_str(), NULL, NULL, SW_MINIMIZE);
    ShowWindow(GetConsoleWindow(), SW_MINIMIZE);
}

void wait_(int miliseconds)
{
    Sleep(miliseconds);
}
string GetCalledClient()
{
    fstream File;
    string path = ("C:/Users/khodi/OneDrive/Desktop/Projets/ticket call system/DB files/Called Client.txt");
    path = ajust_path(path);
    File.open(path, ios::in);
    if (File.is_open())
    {
        string line;
        while (getline(File, line))
        {
            if (line != "")
                return line;
        }
        File.close();
    }
    return "";
}
void VoiceReader(string TxTnumber)
{
    string base_path = "C:/Users/khodi/OneDrive/Desktop/Projets/ticket call system/DB files/Audio File/Audio numbers/";
    base_path += GetLanguage();
    base_path += "/";
    base_path += TxTnumber;
    base_path += ".m4a";
    base_path = ajust_path(base_path, 1);
    cout << base_path << endl;
    string temp_path = "C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Audio File\\Audio numbers\\ENGLISH\\three.m4a";
    PlayAudio(base_path);
    //PlayAudio();
}
void StartPlaying(int number)
{
    string txtNumber = NumberToText(number);
    vector<string> vNumber = splitFunction(txtNumber, ' ');
    int iterator = 0;
    for (string& word : vNumber)
    {
        if (word != "")
            VoiceReader(word);
        if (iterator == 3)
            wait_(1800);
        else
        wait_(1100);
        iterator++;
    }
}
void StartPlaying(string Counter, int time_waiting)
{
    VoiceReader(Counter);
    wait_(time_waiting);
}
bool MinimiserFenetreFoobar() {
    HWND hWnd = FindWindowA(NULL, "foobar2000 v2.24.3"); // Remplace par le titre exact de ta fenêtre si besoin

    if (hWnd == NULL) {
        std::cerr << "Fenêtre Foobar2000 non trouvée.\n";
        return false;
    }

    ShowWindow(hWnd, SW_MINIMIZE); // <- Minimiser au lieu de masquer
    return true;
}
void ReadVoiceFromFile()
{
    string code = GetCalledClient();
    vector<string> vCode = splitFunction(code, '/');
    string txtCounter = vCode[0];

    StartPlaying("NowServing", 2500);
    MinimiserFenetreFoobar();
    int num = stoi(vCode[1]);
    StartPlaying(num);
    StartPlaying("AtCounter", 2000);
    StartPlaying(txtCounter, 1500);

}
int main()
{
    ReadVoiceFromFile();
    return 0;
}
