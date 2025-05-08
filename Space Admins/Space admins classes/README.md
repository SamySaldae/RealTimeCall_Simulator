The "MESSAGE_RANSMISSION_FORM" is triggered within the SpaceAdmins form. This form is responsible for transmitting messages to the main broadcast, via two files:
1. PIVOTDATA.txt:
This file is the main means of communication between the three parties involved: SpaceAdmins, Broadcast, and VoiceCaller. It is used to transmit the command to be executed.
2. MSG_CONX_.txt:
This is the file that records the message entered by the admin (for backup purposes) and is simultaneously retrieved from the main form for broadcast.
