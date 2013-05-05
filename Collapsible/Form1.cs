using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Collapsible
{
    public partial class CP : Form
    {
       
        //ClassVariablesTobe used FI this is called
        //forTextBoxText

        private string strRichBoxText = string.Empty;

        public string StrRichBoxText
        {
            get {
                return strRichBoxText;
            }
            set {
                strRichBoxText = value;
            }
        }//StrRichBoxText

        private bool isCollapsed = true;

        public bool ISCollapsed
        {
            get
            {
                return isCollapsed;
            }
            set
            {
                isCollapsed = value;
            }
        }//ISCollapsed

        private bool isBWColplete = false;

        public bool ISBWColplete
        {
            get
            {
                return isBWColplete;
            }
            set
            {
                isBWColplete = value;
            }
        }//ISBWColplete
        
        
        //all label Values like lblUpdateFile



        bool btnCollapseClicked = true;
        public CP()
        {
            InitializeComponent();
            this.Size = new Size(702, 131);
            backgroundWorker1.RunWorkerAsync("Hello to worker");

            
        }//CP()

        private void btnCollapse_Click(object sender, EventArgs e)
        {
           
           //panel expanded
            if(this.btnCollapseClicked == true)
            {
                this.isCollapsed = false;
                this.toolTip1.SetToolTip(this.btnCollapse, "Fewer Details");
                this.Details.Text = string.Empty;
                this.Size = new Size(702, 347);
            this.btnCollapse.Image = Properties.Resources.uparrowfw;
            this.btnCollapseClicked = false;


            }//if
            
                //panel collapsed
            else 
            {
                this.isCollapsed = true;
                this.toolTip1.SetToolTip(this.btnCollapse, "More Details");
                this.Details.Text = "More Details";
                this.Size = new Size(702, 131 );
                this.btnCollapse.Image = Properties.Resources.downarrowfw;
                this.btnCollapseClicked = true;

                if (this.ISBWColplete == true)
                {
                    this.Close();
                    Application.Exit();
                }



            }//else
        }//btnCollapse_Click

        private void btnCollapse_MouseEnter(object sender, EventArgs e)
        {
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
        }//btnCollapse_MouseEnter

        private void btnCollapse_MouseLeave(object sender, EventArgs e)
        {
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Default;
        }//btnCollapse_MouseLeave

        
           
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           ////for (int i = 0; i <= 100; i += 20)
           ////{
            //backgroundWorker1.ReportProgress(10,"10");
            ////System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(20,"20");
            ////System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(30,"30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(40, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(50, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(60, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(70, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(80, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(90, "30");
            //System.Threading.Thread.Sleep(500);
            //backgroundWorker1.ReportProgress(100, "30");
            //System.Threading.Thread.Sleep(500);
           ////} 

            DirSize _dir = new DirSize();
            System.IO.DirectoryInfo directory =
            new System.IO.DirectoryInfo(System.IO.Path.GetTempPath());
          

           int fileEnumPRogress = (int)uint.MinValue;
            foreach (System.IO.FileInfo file in directory.GetFiles())
            {
                try
                {
                    if (fileEnumPRogress < 99)
                    {
                        fileEnumPRogress++;
                    }


                    System.Threading.Thread.Sleep(500);
                        file.Delete();
                        
                        backgroundWorker1.ReportProgress(fileEnumPRogress, "Deleting...     " + file.FullName + "");
                        System.Diagnostics.Debug.WriteLine(file + "");

                   
                    

                }
                ///file in use
                catch (System.IO.IOException)
                {
                    //if (fileEnumPRogress < 99)
                    //{
                    //    fileEnumPRogress++;
                    //}
                    System.Diagnostics.Debug.WriteLine(file.FullName + "" + "");
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "file in use...      " + file.FullName + "");

                }
                ///no rights to access the file
                catch (System.UnauthorizedAccessException)
                {
                    //if (fileEnumPRogress < 99)
                    //{
                    //    fileEnumPRogress++;
                    //}
                    System.Diagnostics.Debug.WriteLine(file.FullName + "" + "");
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "no rights to access the file...     " + file.FullName + "");
                }
            }


            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories())
            {
                try
                {
                    //if (fileEnumPRogress < 99)
                    //{
                    //    fileEnumPRogress++;
                    //}
                    System.Threading.Thread.Sleep(500);
                    
                    subDirectory.Delete(true);
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "Deleting...     " + subDirectory.FullName + "");
                    System.Diagnostics.Debug.WriteLine(subDirectory + "");
                    
                }

                catch (System.UnauthorizedAccessException)
                {
                    ///no rights to access the file
                    //if (fileEnumPRogress < 99)
                    //{
                    //    fileEnumPRogress++;
                    //}
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "no rights to access the directory...     " + subDirectory.FullName + "");
                    System.Diagnostics.Debug.WriteLine(subDirectory.FullName + "" + "");
                }

                catch (System.IO.IOException)
                {
                    ///directory in use
                    if (fileEnumPRogress < 99)
                    //{
                    //    fileEnumPRogress++;
                    //}
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "directory in use...     " + subDirectory.FullName + "");
                    System.Diagnostics.Debug.WriteLine(subDirectory.FullName + "" + "");
                }
            }




            backgroundWorker1.ReportProgress(100, "");



           e.Result = fileEnumPRogress;
        }//backgroundWorker1_DoWork

   
        private void backgroundWorker1_ProgressChanged(object sender, 
            ProgressChangedEventArgs e)
        {
            
                this.labelProgressPercentage.Text = 
                    e.ProgressPercentage.ToString() + " % ";
                this.progressBar1.Value = 
                    e.ProgressPercentage;
                //this.textBoxDetail.Text = 
                //    e.ProgressPercentage.ToString() + " % ";
                //this.textBoxDetail.Refresh();

                if (e.ProgressPercentage == 100)
                {
                    this.ImgScrollBell.Image = null;
                   
                }

                this.lblUpdateFile.Text = e.UserState.ToString();
                this.textBoxDetail.Text += (e.UserState.ToString() + "\r");
            //autoscroll TextBox    
            this.textBoxDetail.Refresh();    
                this.textBoxDetail.SelectionStart = this.textBoxDetail.Text.Length;
                this.textBoxDetail.ScrollToCaret();

            
                
        }//backgroundWorker1_ProgressChanged

        

        

        private void backgroundWorker1_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                Console.WriteLine("You canceled!");
            else if (e.Error != null)
                Console.WriteLine("Worker exception: " + e.Error.ToString());
            else
                Console.WriteLine("Complete: " + e.Result); //result returns the number of files

            this.lblUpdateFile.Text = "Number of Files : " + e.Result;

            //if panel collapsed then exit

            if (this.ISCollapsed == true)//collapsed
            {
                this.Close();
                Application.Exit();
            }

            this.ISBWColplete = true;
        }//backgroundWorker1_RunWorkerCompleted
    
    }//class CP
}//namespace Collapsible
