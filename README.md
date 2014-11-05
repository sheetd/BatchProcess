#BatchProcess#

##Version##
BatchProcess v1.0  
2014-11-05 by Neil Meredith <neil@sheetd.com>  

##Requirements##
Digital Project V1R5 or CATIA V5-6R2012 (aka R22) or higher

##Description##
BatchProcess is a CATIA/Digital Project tool that performs batch file operations on CATDrawings such as saving PDFs or DWG exports. As a framework, other sub-routines (such as updating text or content of CATDrawings) can be easily added on in the future.

![Interface](Documentation/Interface_Drawings.png)
![Interface](Documentation/Interface_Parts.png)

##Usage##
- Open CATIA/Digital Project  
- Open BatchProcess application  
- Select a Source and Destination folder to your files. Examples are provided in "SampleFiles" folder. To save to the same folder (overwritng the originals) select the "Overwrite files in place" option
- Select file processing options for either Drawings (*.CATDrawing files) or Part files (*.CATPart)
- Run the program

##Limitations##
- Functionality for processing *.CATProduct files has not been implemented yet
- 2D Drawing exports cannot currently be saved in the same folder yet as the source file