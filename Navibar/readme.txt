create your BARCODE 
(c) 2001/2005 by dagema eG  Willich-Germany
Prog.: Ralph Mayer mayer@m-edv-willich.de

ISBN
EAN 13
EAN 8
EAN 5
EAN 2
UPC A
Code 39
Code 25 interleaved
CodeBar
Code 25
Code 39 Extended
Code 128 A
Code 128 B
Code 128 C
Code 128
EAN 128
EAN 99
UPC E
PostNet
Royal Mail
MSI
Code 93
Code 93 Extended
PZN
None



########
Deutsch:
########

Das Barcode-Tool erzeugt eine BMP-Datei, die u.a. zum Beispiel in NAVISION über Import temporär eingelesen werden kann.

Der Aufruf erfolgt mit Übergabe der entsprechenden Parameter getrennt durch ein { - Zeichen (ASCII 123).

Syntax:

NAVIBAR Code{CodeTyp{CodeBreite in Pixel{CodeHöhe in Pixel{Zieldatei

NAVIBAR 1234567890128{01{120{60{c:\temp\bild.bmp[{false]

Hier wird ein EAN13-Barcode erzeugt; die Prüfziffer 8 wird vom Programm errechnet; der Barcode hat die 
Abmessung 120 Pixel breit und 60 Pixel hoch; gespeichert wird auf Laufwerk C:\temp in die Datei bild.bmp
Der optionale Paramter false gibt an, daß keine Klarschriftzeile gedruckt werden soll

Sofern die erforderliche Prüfziffer nicht mit übergeben wird, wird diese vom Programm errechnet.

Installation:

1. kopieren Sie die BARCODE.OCX in das Windows-Systemverzeichnis
2. REGSVR32 c:\windows\system\barcode.ocx

########
english:
########

This tool creates a bmp-file which you can import temporary into NAVISION Financials

You have to separate the paramters by the chararcter {  (ASCII-123)

Syntax:

NAVIBAR 1234567890128{01{120{60{c:\temp\bild.bmp[{false]

In this example i create a EAN13-Barcode with the width of 120 Pixel and the high of 60 Pixel.
The input of the check-digit is not necessary. The optional string false tells the program not to
print the barcodetext.

Installation:

1. copy the barcode.ocx into your windows-system directory
2. start regsvr32 c:\windows\system\barcode.ocx

