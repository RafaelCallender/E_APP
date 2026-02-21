using Fileprompt;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Win32;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
namespace E_APP.SERVICES.FILE_SERVICES.FILE_PICKER
{
    internal class File_Picker01
    {

  



        public void FilePickerExamples()
        {


            Filepicker.Select(); //current location as starting point
            Filepicker.Select(new string[] { "xml", "json" }); //force select filetype
            Filepicker.Select(@"C:\Location"); //selects location as starting point
            Filepicker.Select(@"C:\Location", new string[] { "xml", "json" }); //select location + force select filetype


        }


        public string Filepicker_photo01()
        {

    





            string selectedFile = Filepicker.Select(
    @"C:\Users\calle\OneDrive\Desktop\PROJECTS\E_APP\E_APP\FILES\IMAGES\IMAGES_EMBEDDED",
    new string[] { "jpg", "jpeg", "png", "bmp" }
);
            return selectedFile;    


        }

    }
}
