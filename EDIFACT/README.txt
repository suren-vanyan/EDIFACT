------------------------------
EdiFabric Examples
------------------------------



1. CONTENTS
------------------------------
All example solutions use the EdiFabric trial packages from NuGet.org. The following packages will be installed/restored from NuGet.org:

------------------------------
Main library
------------------------------
ediFabric.Core
ediFabric.Framework
EdiFabric.Plugins.Ack.Edifact
EdiFabric.Plugins.Ack.X12

------------------------------
Trial Templates
------------------------------
EdiFabric.Templates.Edifact
EdiFabric.Templates.Hipaa
EdiFabric.Templates.Padis
EdiFabric.Templates.Vda
EdiFabric.Templates.X12




2. INSTALLATION
------------------------------
Four different example solutions are included in four separate folders for EDI Translator Demo, X12/HIPAA, EDIFACT/EANCOM/PNRGOV, and Flat Files/VDA.
Open the Visual Studio solution in each folder and rebuild it. Ensure that all dependent packages are restored/installed correctly (requires internet connection).



3. USE
------------------------------
Use the Visual Studio solutions in the following folders for:

------------------------------
- EdiFabric.Translator.Demo
------------------------------

A quick translation from your EDI files to .NET objects. The demo translator supports all transactions across X12 4010, EDIFACT D96A, and X12 HIPAA 5010 versions. 
If you need to test with another version, please contact us at support@edifabric.com. Translator projects are provided for both .NET Core 2.0 and .NET Framework 4.5.

------------------------------
- EdiFabric.Examples.X12
------------------------------

Full usage of the EDI library and example EDI templates for HIPAA 837P, X12 810 and 850.
The examples cover EDI parsing, EDI generation, EDI validation, EDI splitting, EDI acknowledgments, EDI template customization, using external EDI codes, EDI mapping, EDI export/import to/from XML, JSON, CSV, EDI to/from database, etc.

Parsing and generation are also available for the following transactions: 

------------------------------
- For X12 4010
------------------------------
210
214
404
810
824
832
850
855
856
857
861
945

------------------------------
- For X12 HIPAA 5010
------------------------------
270
271
276
277
278
820
834
835
837 I
837 D
837 P

------------------------------
- EdiFabric.Examples.EDIFACT
------------------------------

Full usage of the EDI library and example EDI templates for EDIFACT INVOIC and ORDERS, or IATA PNRGOV.
The examples cover EDI parsing, EDI generation, EDI validation, EDI splitting, EDI acknowledgments, EDI template customization, using external EDI codes, EDI mapping, EDI export/import to/from XML, JSON, CSV, EDI to/from database, etc.

Parsing and generation are also available for the following transactions: 

------------------------------
- For EDIFACT/EANCOM/SMDG/ACE/PNRGOV
------------------------------
BAPLIE
CUSCAR
DESADV
IFTMIN
IFTSTA
INVOIC
ORDERS
ORDRSP
PAXLST
PNRGOV
PRICAT

------------------------------
- EdiFabric.Examples.FlatFile
------------------------------

Full usage of the EDI library and example EDI templates for flat files (positional, delimited, or a mix) and VDA.
The examples cover parsing, generation, EDI validation, EDI template customization, EDI export/import to/from XML, JSON, etc.

Parsing and generation are also available for the following transactions: 
------------------------------
- For VDA
------------------------------
4905



4. DOCUMENTATION
------------------------------
Quickstart guide to using the Translator Demo:
https://support.edifabric.com/hc/en-us/articles/360000280532-Quickstart-Translate-EDI-file

Tutorial covering all examples:
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base:
https://support.edifabric.com

List of all supported EDI Templates:
https://support.edifabric.com/hc/en-us/categories/360001758952



5. SUPPORT
------------------------------
Raise support questions here:
https://support.edifabric.com/hc/en-us/requests/new




