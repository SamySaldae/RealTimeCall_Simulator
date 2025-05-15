# RealTimeCall_Simulator
Traditional call systems rely on heavy APIs/databases. This simulator uses lightweight file-based IPC for modularity
Here's a short demonstration of the ticket calling system I developed using the .NET Framework.

The system relies on four ticket-generating console applications. I deliberately kept them as CMD interfaces, as they can easily be replaced later by physical inputs like ESP32 or Arduino buttons.

Here’s a quick code snippet: each time the spacebar is pressed, a ticket is generated (across 4 different ticket windows). Since they're lightweight, they were built in C++.

Each generated ticket is saved into a file called QUEUE.txt, which acts as the central queue.

On the administrator's side, a ticket agent can call the next ticket at any time. When this happens, the ticket is removed from QUEUE.txt and transferred into PIVOT.txt.

This is where polling comes in: the main display system constantly monitors PIVOT.txt for any new ticket or command to execute.

When a new ticket is detected, the Diffusion.frm window displays the number on screen and launches an application named ClientCaller.exe, which reads two files:

LANGUAGE.txt, to determine whether to speak English or French;

PIVOT.txt, to retrieve the customer's ticket number.

Next, a recursive algorithm is used to generate the voice message, such as:
“Number 24, counter 3.”

Once the announcement is complete, ClientCaller.exe writes "RECEIVED" into PIVOT.txt, marking the end of the process.

But the system goes further:
PIVOT.txt can also transmit client data or admin commands to Diffusion.frm, such as displaying text messages, triggering a background video, or broadcasting real-time audio messages.

Display settings can be modified by updating SETTINGS.txt and simultaneously sending a "SETTINGS" command to PIVOT.txt. Once applied, the "RECEIVED" message is written again to indicate that no commands are currently pending.

A simple, yet powerful and fully modular system.

