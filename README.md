# MDL-Network-Chat
This code is for a simple network chat using NAudio.

When the program starts the user will be presented with a small form showing the localhost IP address. The user will also be able to choose the bit depth and rate for the audio quality. Once the user knows the IP address of their friend they will enter the address into the form and click the start button. A listener will start and NAudio will begin to record and send audio data over the network.

The desired friend will need to have a form sending data to the original caller in order for the two parties to talk. There is no notification (yet) if someone is trying to call you. Codecs are also not utilized in this program to keep it a simple as possible since the project is more of a proof of concept then production code. It was originally meant as a learning tool for network programming and using audio data. 
