using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Dolinay;

namespace BackUp
{
    public partial class Frm_Backup : Form
    {
        private DriveDetector driveDetector = null; //init a drivedetector
        string path = @"C:\Users\Public\Documents\Copy.bat"; //path of batch file that completes Move operation (system.io can copy files, but not folders; it can move directories though..)

        public Frm_Backup()
        {
            InitializeComponent(); //Minor construction
            driveDetector = new DriveDetector(); //give value to the drive detector
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrive); //Create a new event handler for device arrive event for method OnDeviceArrive
        }

        private void OnDriveArrive(object sender, DriveDetectorEventArgs e) //method using event handler
        {
            Fbd_Dest.SelectedPath = e.Drive + "BackUp"; //set filebrowser to detected drive
            Txt_Dest.Text = e.Drive + "BackUp";//update label
        }

        private void Btn_Source_Click(object sender, EventArgs e)
        {
            //select/update filebrowser's source
            Fbd_Source.ShowDialog(); 
            Txt_Source.Text = Fbd_Source.SelectedPath;
        }

        private void Btn_Dest_Click(object sender, EventArgs e)
        {
            //select/update filebrowser's Dest
            Fbd_Dest.ShowDialog();
            Txt_Dest.Text = Fbd_Dest.SelectedPath;
        }

        private void Btn_Backup_Click(object sender, EventArgs e)
        {
            //Just a little EULA 
            MessageBox.Show("By Using this program, you acknowledge that it could destroy your computer and I take NO RESPONSIBILITY for anything broken by it");
            string[] batchlines = { //if a string array & .WriteAllLines are used, each string is its own line
                                          "@echo off",
                                          "title Don't Close - Moving Files",
                                          "color a",
                                          "@echo on",
                                          "cls",
                                          "Xcopy \"" + Fbd_Source.SelectedPath + "\" \"" + Fbd_Dest.SelectedPath + "\" /w /g /s /r /-y /z /j /d /v"//add /v to verify
                                      };
            if (File.Exists(path)) //if the temp file already exists, delete it
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path, 1024)) { } //create the file
            System.IO.File.WriteAllLines(path, batchlines); //write to the file
            Process.Start(path); //start the file
        }

        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            //Restarts previously generated File
            if (File.Exists(path)) //if the file exists
            {
                MessageBox.Show("It appears that a copy was previously Ran, if this was unsuccessful You can restart it!", "WARNING: Experimental");
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("This Program Has Not Ran here before or the Copy File has been deleted");
            }
        }
    }
}
