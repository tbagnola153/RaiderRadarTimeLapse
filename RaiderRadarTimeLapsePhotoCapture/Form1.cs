using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace RaiderRadarTimeLapsePhotoCapture
{
    public partial class Form1 : Form
    {
        private Thread _imageGrabber;
        private Thread _imageDelete;
        private String _drive = "H:";
        private volatile bool _shouldStop = false;
        private string _path = "\\Public.www\\RaiderRadar\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _imageGrabber = new Thread(CaptureImages);
            //_imageDelete = new Thread(CleanOldImages);
            txtLog.Text = "Please select a drive to store photos.";
        }

        private void CaptureImages()
        {
            AppendTextBox("Initialization of CaptureImages() complete.");
            Console.Out.WriteLine("Initialization of CaptureImages() complete.");

            while (!_shouldStop)
            {
                try
                {
                    if (DateTime.Now.Second == 0)
                    {
                        string year = DateTime.Now.Year.ToString();
                        string month = DateTime.Now.Month.ToString();
                        string day = DateTime.Now.Day.ToString();
                        string hour = DateTime.Now.Hour.ToString();
                        string min = DateTime.Now.Minute.ToString();
                        string time = hour + "_" + min;
                        string fileName = year + "_" + month + "_" + day + "_" + time;

                        string filename = year + "_" + month + "_" + day + "_" + time;
                        try
                        {
                            WebClient webClient = new WebClient();
                            webClient.DownloadFile("http://10.18.32.100/jpg/1/image.jpg?timestamp=1458760596638", _drive + _path + filename + ".jpg");

                            AppendTextBox("captured: " + fileName);
                            Console.Out.WriteLine("captured: " + fileName);
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                            AppendTextBox("*** ERROR TRYING TO CREATE FILE: " + filename + " ***");
                        }

                    }
                }
                catch (Exception)
                {
                    AppendTextBox("*** ERROR IN CaptureImages() ***");
                    Console.Out.WriteLine("*** ERROR IN CaptureImages() ***");
                }

            }
        }

        private void CleanOldImages()
        {
            while (!_shouldStop)
            {
                try
                {
                    if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0)
                    {
                        if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0)
                        {
                            ClearTextBox();

                            DateTime today = DateTime.Now;
                            DateTime twoDaysAgo = today.AddDays(-2);

                            string year = twoDaysAgo.Year.ToString();
                            string month = twoDaysAgo.Month.ToString();
                            string day = twoDaysAgo.Day.ToString();
                            string fileNameStart = year + "_" + month + "_" + day + "_";

                            AppendTextBox("Deleting files in: " + _drive + _path + " from " + day + "/" + month + "/" + year);

                            for (int hour = 0; hour < 24; hour++)
                            {
                                for (int min = 0; min < 60; min++)
                                {
                                    string searchFileName = fileNameStart + hour + "_" + min + ".jpg";

                                    if (hour == 0 && min == 0)
                                    {
                                        min++;
                                    }
                                    else if (hour == 6 && min == 0)
                                    {
                                        min++;
                                    }
                                    else if (hour == 12 && min == 0)
                                    {
                                        min++;
                                    }
                                    else if (hour == 18 && min == 0)
                                    {
                                        min++;
                                    }
                                    try
                                    {
                                        File.Delete(_drive + _path + searchFileName);
                                        AppendTextBox("Deleted file: " + searchFileName);
                                    }
                                    catch (DirectoryNotFoundException)
                                    {
                                        AppendTextBox("Could not find file: " + _drive + _path + searchFileName);
                                    }
                                    catch (Exception)
                                    {
                                        AppendTextBox("*** ERROR TRYING TO DELETE FILE: " + _drive + _path + searchFileName);
                                    }
                                }
                            }

                            AppendTextBox("*** CLEAN UP COMPLETE ***");
                            Thread.Sleep(60000);
                        }
                    }
                }
                catch (Exception)
                {
                    AppendTextBox("*** ERROR IN CleanOldImages() ***");
                    Console.Out.WriteLine("*** ERROR IN CleanOldImages() ***");
                }
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtLog.Text += value + Environment.NewLine;
        }

        public void ClearTextBox()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(AppendTextBox));
                    return;
                }
                txtLog.Text = "";
            }
            catch (Exception)
            {
                AppendTextBox("Could not clear text box.");
                Console.Out.WriteLine("Could not clear text box.");
            }

        }

        private void cmbDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_imageGrabber.IsAlive)
            {
                _shouldStop = true;
                _imageGrabber.Join();
            }
            //if (_imageDelete.IsAlive)
            //{
            //    _shouldStop = true;
            //    _imageGrabber.Join();
            //}
            _drive = cmbDrive.Text;
            AppendTextBox("Storing images to drive: " + _drive);
            Console.Out.WriteLine("Storing images to drive: " + _drive);
            AppendTextBox("FILE PATH IS: " + _drive + _path);
            Console.Out.WriteLine("FILE PATH IS: " + _drive + _path);
            AppendTextBox("Initializing CaptureImages()" + Environment.NewLine);
            Console.Out.WriteLine("Initializing CaptureImages()");
            _shouldStop = false;
            _imageGrabber = new Thread(CaptureImages);
            _imageGrabber.Start();
            //_imageDelete = new Thread(CleanOldImages);
            //_imageDelete.Start();
        }

    }
}

