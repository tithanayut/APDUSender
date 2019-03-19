# APDUSender
Simple application for sending and receiving APDU command/response

## Quick Overview
This software purpose is to send an APDU command to the smart card and receive the response APDU back.  
This software also includes a function of converting from ASCII byte to text string.

## Installing
If you are running a Windows base operating system, download the release at https://github.com/tithanayut/APDUSender/releases/, extract the zip file and launch the executable file inside. The software should work straight away.

In case that the software can't be launch, check that .Net Framework 4.0 is installed on your PC.

This software only support Windows operating system, doesn't support Android, macOS or Linux.

## Version
-(Release 1) Version 1.0.0 : Initial Release  

## Built With
This application is built using VB.Net on Visual Studio 2017 Community Edition. This software use PC/SC wrapper class for .NET developed by Daniel Mueller, for more information about this library see: https://github.com/danm-de/pcsc-sharp/

The default framework version is set to .Net Framework 4.0, but able to functioning correctly when newer version of .Net Framework is selected.

The program is tested with ACS ACR122U (contactless reader) and ACS ACR39U (contact reader).
According to the PC/SC Library, this software support all of PC/SC compatible reader.

## Authors
Code/project developed by Thanayut T.  
PC/SC wrapper classes for .NET developed by Daniel Mueller, see https://github.com/danm-de/pcsc-sharp/.

## License
This software and its sources license under BSD 2-Clause License. Feel free to use, modify, redistribute under the BSD 2-Clause License. For more information see: LICENSE file.

Note: This software use PC/SC wrapper classes for .NET developed by Daniel Mueller, for license see: https://github.com/danm-de/pcsc-sharp/blob/master/COPYING.


Keyword: APDU Sender, Send and Receive APDU, APDU Command Sender, Smart Card APDU Tool
