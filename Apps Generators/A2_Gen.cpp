#include<iostream>
#include<string>
#include<fstream>
#include <windows.h>

using namespace std;

int LocalTicket=1;
enum enLbl {A1,A2,B1,B2};
enum enColor {Blue,Cyan,Red,Green};

#include <sstream> // supported

string ToString(int number) {
    stringstream ss;
    ss << number;
    return ss.str();
}
void Change_Color(enColor Color)
{
	    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		switch(Color)
		{
			case Blue:
			SetConsoleTextAttribute(hConsole, FOREGROUND_BLUE);
			break;
			case Cyan:
			SetConsoleTextAttribute(hConsole, FOREGROUND_BLUE | FOREGROUND_GREEN);
			break;
			case Red:
			SetConsoleTextAttribute(hConsole, FOREGROUND_RED);
			break;
			case Green:
			SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN);
			break;
			default:
		    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		}
}
void SEND_INTO_QUEUE(string Ticket) //put number into file A1 for this app
{
	fstream File;
    File.open("C:\\Users\\khodi\\OneDrive\\Desktop\\Projets\\ticket call system\\DB files\\Queue.txt", ios::app);
	if(File.is_open())
	{
		File<<Ticket<<endl;
		File.close();
	}
}
void Label(string lb)
{

}
void PrintUI(enColor Color,string Label,int TicketNumber)
{
	Change_Color(Color);
	cout<<"Ticket -> "<<TicketNumber<<"  <<<  ["<<Label<<"]"<<endl;
}

int main()
{

	do{
		PrintUI(Cyan,"A2",::LocalTicket);
		SEND_INTO_QUEUE("A2/"+ToString(LocalTicket));
		::LocalTicket++;
		system("pause");
		system("cls");

	}while(true);
	system("pause>0");
}

