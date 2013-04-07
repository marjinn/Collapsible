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
       
        bool btnCollapseClicked = true;
        public CP()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync("Hello to worker");

            
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
           
           //panel expanded
            if(this.btnCollapseClicked == true)
            {
                this.toolTip1.SetToolTip(this.btnCollapse, "Fewer Details");
                this.Details.Text = string.Empty;
             this.Size = new Size(702, 430);
            this.btnCollapse.Image = Properties.Resources.uparrowfw;
            this.btnCollapseClicked = false;

            }
            
                //panel collapsed
            else 
            {
                this.toolTip1.SetToolTip(this.btnCollapse, "More Details");
                this.Details.Text = "More Details";
                this.Size = new Size(702, 131 );
                this.btnCollapse.Image = Properties.Resources.downarrowfw;
                this.btnCollapseClicked = true;
            }
        }

        private void btnCollapse_MouseEnter(object sender, EventArgs e)
        {
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnCollapse_MouseLeave(object sender, EventArgs e)
        {
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Default;
        }

        
           
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           ////for (int i = 0; i <= 100; i += 20)
           ////{
            //backgroundWorker1.ReportProgress(10,"10");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(20,"20");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(30,"30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(40, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(50, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(60, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(70, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(80, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(90, "30");
            //System.Threading.Thread.Sleep(1000);
            //backgroundWorker1.ReportProgress(100, "30");
            //System.Threading.Thread.Sleep(1000);
           ////} 

            DirSize _dir = new DirSize();
            System.IO.DirectoryInfo directory =
            new System.IO.DirectoryInfo(System.IO.Path.GetTempPath());
          

           int fileEnumPRogress = (int)uint.MinValue;
            foreach (System.IO.FileInfo file in directory.GetFiles())
            {
                try
                {
                    fileEnumPRogress++;
                    if (fileEnumPRogress != 100)
                    {
                        
                        System.Threading.Thread.Sleep(1000);
                        backgroundWorker1.ReportProgress(fileEnumPRogress, "\nDeleting...\n"+ file.FullName + "\n");
                        file.Delete();
                        System.Diagnostics.Debug.WriteLine(file + "\n");

                    }
                    

                }
                ///\nfile in use
                catch (System.IO.IOException)
                {
                    fileEnumPRogress++;
                    System.Diagnostics.Debug.WriteLine(file.FullName + "\n" + "\n");
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "\nfile in use...\n" + file.FullName + "\n");

                }
                ///\nno rights to access the file
                catch (System.UnauthorizedAccessException)
                {
                    fileEnumPRogress++;
                    System.Diagnostics.Debug.WriteLine(file.FullName + "\n" + "\n");
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "\nno rights to access the file...\n" + file.FullName + "\n");
                }
            }


            foreach (System.IO.DirectoryInfo subDirectory in directory.GetDirectories())
            {
                try
                {
                    fileEnumPRogress++;
                    System.Threading.Thread.Sleep(1000);
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "\nDeleting...\n" + subDirectory.FullName + "\n");
                    subDirectory.Delete(true);
                    System.Diagnostics.Debug.WriteLine(subDirectory + "\n");
                    
                }

                catch (System.UnauthorizedAccessException)
                {
                    ///\nno rights to access the file
                    fileEnumPRogress++;
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "\nDeleting...\n" + subDirectory.FullName + "\n");
                    System.Diagnostics.Debug.WriteLine(subDirectory.FullName + "\n" + "\n");
                }

                catch (System.IO.IOException)
                {
                    ///directory in use
                    fileEnumPRogress++;
                    backgroundWorker1.ReportProgress(fileEnumPRogress, "\ndirectory in use...\n" + subDirectory.FullName + "\n");
                    System.Diagnostics.Debug.WriteLine(subDirectory.FullName + "\n" + "\n");
                }
            }




            backgroundWorker1.ReportProgress(100, "");

            








          
            

           e.Result = 1;
        }

   
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
                this.textBoxDetail.Text += (e.UserState.ToString() + "\r\n");
        }

        

        

        private void backgroundWorker1_RunWorkerCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                Console.WriteLine("You canceled!");
            else if (e.Error != null)
                Console.WriteLine("Worker exception: " + e.Error.ToString());
            else
                Console.WriteLine("Complete: " + e.Result); //
        }
    }
}
