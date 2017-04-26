# ic7100
Control Head Emultator for Icom IC7100

This project is for connecting a computer to the IC7100 radio instead of using its control head.

ic7100 shows Icons that are similar to the icons on the 7100 control head, in a similar layout, in order to make the program easy to use for anyone familiar with the control head of the radio.

This project is in its development phase, so it is not complete.  It is placed on Github for experimenters.  Please do not assume that all will work.

If you have suggestions or have noticed errors in the source code, you may communicate by opening an issue, or via email at NR6J@arrl.net.

IMPORTANT: I DO NOT ASSUME ANY RESPONSIBILITY FOR YOUR USE OF THIS SOFTWARE, AND I MAKE NO REPRESENTATIONS ABOUT ITS SAFETY, APPROPRIATENESS, OR USE FOR A PARTICULAR PURPOSE.  USE OF THIS SOFTWARE IS AS-IS.

To connect to the radio, I used a USB to serial converter set to 3 volts:

https://amazon.com/gp/product/B00IJXZQ7C/ref=oh_aui_detailpage_o07_s00?ie=UTF8&psc=1

TX of the interface should be connected to RX of the radio (with appropriate level conversion - see below), and RX of the interface should be connected to TX of the radio.  If you leave the control head connected, connect only RX of the interface to TX of the radio.  This will make both the control head and the computer program function in parallel.  If you try to connect TX of the interface to RX of the radio (with level conversion) while the control head is still connected, you should use a SPDT switch to select either the control head or the program.  They should not be in parallel to control the radio.

Level conversion:  Some ic7100's can be connected directly to the interface.  Some need additional components.  See the article at:

http://www.remoterig.com/wp/?page_id=2302

At this time, only the screen and touch screen emulation are done.  There is no provision for audio yet.

Hopefully, this program will be helpful for experimenters, and if you have additional contributions for the project, please contact me:

Dennis Engdahl
NR6J
(530) 926-2996
NR6J@arrl.net
engdahl@snowcrest.net

