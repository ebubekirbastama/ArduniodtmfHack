These are the instructions for the use of the DTMF Dial software.

These instructions and the software itself are Copyright (c) 2000-2001
by Marck D. Pearlstone. All rights reserved.

Join the mailing list to keep up with updates, chat to other users and
report problems

mailto:listserv@silverstones.com?body=subscribe%20DTMFdial

If  you  want  to  build  DTMF  Dial  functionality  into a commercial
application,  write to me. I'm approachable and reasonable and make my
living from the code I write.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Purpose:
--------
The purpose of DTMF dial is to send DTMF dial tones out through the PC
speakers.  This  is done under user control with a simple yet flexible
option  set.  By  holding the microphone of a telephone handset to the
speaker this makes for a very simple and easy-to-use auto-dialer.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Use:
----
The  interface  is fairly obvious on the surface with 8 control icons,
the common dial keys and a ^ key to insert a pause into the sequence.

The software will emit the tones as you press the dial keys.
Just type the numbers, A-D, *, ^ and # keys for keyboard operation.
A ',' can also be used as a pause as well as a ^.
a '.' can also be used as a #.

The six control buttons are (with keyboard shortcuts).
	Trash  - SpaceBar    - Clear the current number
	Paste  - Ctrl-V      - Insert a number from the clipboard
	Back   - BackSpace   - Erase the last digit
	Play   - Enter,Space - Play the numbers as DTMF tones
	Memory - M           - Pop up the number memory / 
	                       Edit numbers (Right Click)
	Recall - R           - Pop up the redial memory
	Add    - Ctrl+Ins    - Add the number to the number memory
	                       (with the default name "New Entry").
	Tray   - Esc         - Go hide in the system tray

Also available:
	About  - F1          - Show the credits screen 
                               (and when you click on the logo).
	Exit   - Alt+F4      - Close the DTMF dial software

DTMFDial  also uses a tool tray icon. Left click the tool-tray icon to
show  or  hide  the  main  window. Right click the icon (with the main
window either showing or hidden) for quick access to the Recall number
menu. Or just ignore the tool-tray icon if you have no use for it.

Memory Editor
-------------
The  memory editor is a simple string grid - a bit like a spreadsheet.
It has names (descriptions) on the left and numbers on the right.

There are three tool buttons Add (+), Delete (X) and Close (Square).

Press Add when in the left column to "Add before"
Press Add when in the right column to "Add after"
Press F2 to switch from "Overtype" to "Edit" mode when focused on a cell.
Left click a column heading to sort that column in ascending order.
Right click a column heading to sort that column in descending order.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Command Line Operability:
-------------------------
DTMF Dial may be used from the command line in the following manner:

	  Dial 555 181 0739 /d 12345 /x

/d - Dial immediately, discard digits and prepare to receive
	  more digits.
/c - Add digits to be dialled from the Windows Clipboard
/x - Exit without using the push button interface.

I can't think of much of a use for /d, but /x is useful for making
DTMF dial a good quick dial shell for a number database.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Options:
--------
The program options are kept in the Dial.ini file which must be in the
same folder as the executable. These options appear as follows:

[Dial]
ToneLength=100
TonePause=40
PauseLength=500
Prefix=
Left=???
Top=???

[Dial]      - the section.
ToneLength  - the duration of the DTMF tones in milliseconds
              (up to 500ms).
TonePause   - the duration of the pause between DTMF tones in
              milliseconds (no maximum, but let's not be silly!).
PauseLength - the duration of the pause introduced by using ',' in
              a dial string.
Prefix      - Always dial these digits before the main number.
Left        - Left coordinate of the main window.
Top         - Top coordinate of the main window.

NB: I have found the above values pretty good for UK DTMF.

    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

[Memory]
Count=?
Mem?=00000...xxxxxxxx
Left=???
Top=???
Width=???
Height=???
NameColWidth=???
NmColWidth=???

[Memory]    - The number memory section
Count       - Number of entries in the memory
Mem?        - Memory ? (1,2,3...?) as 'number...description'
Left,Top,
Width,Height,
NameColWidth,
NumColWidth - Various recorded screen layout settings
SortOrder   - The sort order setting for the memory editor

    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

[Recall]
Count=?
Num?=00000...xxxxxxxx

[Recall]    - The number quick recall memory section
Count       - Number of entries in the quick recall memory (up to 16)
Num?        - Number 1,2,3...?

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Revision History.
----------------
+ = New
- = Fixed
* = Enhanced

V1.0.0.14 2-Jul-2003
---------
[-] Number memory could be corrupted when saving a blank name
[+] Add Recall list editor on Right click of recall list
[*] Recall list is now saved as 'MemN' instead of 'NumN'
[*] Consolidation of editor code

V1.0.0.13 22-Jan-2001 (two in one day?)
---------
[*] Complete change to internal WAV preload. Now wavs are pulled on-the
    fly to a single media player component. This prevents conflicts when
    trying to open multiple player instances (which it did before). It
    probably decreases the runtime memory requirements too.

V1.0.0.12 22-Jan-2001
---------
[*] Any error that occurs during startup is now identified and reported
    explicitly.
[-] Startup errors should result in an exit - they didn't.
[-] Startup errors caused crashes on close which prevented exit.

V1.0.0.11 19-Nov-2001
---------
[+] Prefix option added to allow things like "9" for outside line or
    calling card numbers.
[+] All new configuration dialog box to provide a UI for the main settings
    It's behind the key icon.

V1.0.0.10 26-May-2001
---------
[-] /x command line parameter was not working properly
[+] Removed "Exit" and "Help" buttons as being superfluous
[*] Recall memory now moves recently dialled numbers to the bottom
    which provides much better cycling of frequently used numbers
[+] Single window execution. Command lines are passed to any
    previously running copy.
[-] All numbers are now added to the recall menu much more
    consistently.

V1.0.0.9  12-Mar-2001
--------
[+] Added (+) button to transfer a number from display to Memory
[+] Added (->) icon to hide the front end in the tool tray
[*] Added sorting for Memory numbers
[-] Tidied up Memory editor to get rid of blanks
[*] Added window size/shape/position storage for Memory editor
[-] Recalling from tray now brings the window to foreground properly
[*] Rearranged icons to improve layout and appearance

V1.0.0.8  21-Feb-2001
--------
[+] # key now also maps to '.' for US keyboards
[+] M and R buttons for Memory and Recall dialling
[+] New number memory editor
[+] Memory dialling - pop up menu for numbers with descriptions
[+] Recall memory dialling - pop up menu remembers the last 16 numbers
    dialled
[-] Resource leak plugged
[*] Improved / smaller tool buttons
[*] Paste now strips out non-dial characters and changes text to uppercase
[*] Missing dial.ini will now be rebuilt from defaults - delete to reset
[*] Removed minimise icon from caption bar
[+] Added Tray Icon with Recall memory menu on right click and show/hide on left.

V1.0.0.7  28-Jan-2001 (not released).
--------
[*] Improved the "About" screen

V1.0.0.6  23-Jan-2001
--------
[+] A, B, C and D tones added
[*] Improved program icon
[+] Added system menu and minimise icons to main window
[*] Changed layout of control buttons to add "Help" button
[+] About page added
[+] Web link on about page
[+] Mailto to join the mailing list on about page

V1.0.0.5
--------
[-] Tool-tip hints not working
[-] Default tone duration / pause length increased by 10ms

V1.0.0.4
--------
[+] Make the on-screen position sticky (Top and Left in the INI file).
[*] Streamline the display.
[*] Reduced the maximum tone length to 500ms to save space.

V1.0.0.3
--------
[-] Make '^' and ',' work as keystrokes
[+] Add VersionInfo and use VersionInfo to create version Caption to
    make current version identifiable.

V1.0.0.2
--------
[+] Add configurable pause as '^' and ',' with a default length of 500ms
[+] Add PauseLength keyword to ini file
[*] Re-jig display to make room for the ^ key

V1.0.0.1
--------
[+] New Clipboard functionality
[+] Added Paste button to main dialog
[+] New command line parameter for clipboard dial
[*] Improved hover tip hints for all tool buttons
[+] Added hover tip for number display to overcome long number
    display issues

V1.0.0.0
--------

Initial release.
