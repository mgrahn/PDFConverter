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


namespace ConvertTIFtoPDF
{
    public partial class frmImages : Form
    {
        string imagesFolder;
        string gImagesFolder = "";
        public frmImages()
        {
            InitializeComponent();
            imagesFolder = GlobalVariables.DefaultImageLocation;
        }

        private void btnSelectExcelOutputPath_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            folderBrowserDialog1.SelectedPath = @"c:\";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagesFolder = folderBrowserDialog1.SelectedPath;
                lblImagesFolder.Text = "Selected Path for Images Output Files: " + imagesFolder;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            lblTimeElapsed.Text = "";
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            
            //Convert many TIFF files to PDF files in the same folder
            SautinSoft.PdfVision v = new SautinSoft.PdfVision();

            string tiffPath = imagesFolder;
           //string[] tiffFiles = Directory.GetFiles(tiffPath, "*.tif");
            
            var fileNames = new List<String>();
            foreach(string f in Directory.GetFiles(tiffPath, "*.tif"))
            {
                fileNames.Add(f);
            }
            fileNames.Sort();
            foreach (string tiffFile in fileNames)
            {
                v.ConvertImageFileToPDFFile(tiffFile, Path.ChangeExtension(tiffFile, "pdf"));
            }
            //Open the folder with PDF
            //System.Diagnostics.Process.Start(tiffPath);
            //merge 4 PDF files
            string[] pdfFiles = Directory.GetFiles(tiffPath, "*.pdf");
            int x = 0;
            foreach (string pdfFile in pdfFiles)
            {
                pdfFiles[x] = @pdfFile;
                x++;
            }


            //int ret = v.MergePDFFileArrayToPDFFile(pdfFiles, @"C:\Development\CDLIS\DocImages\AllRows\mergedfiles.pdf");
            gImagesFolder = tiffPath + "\\MergedPDF";
            Directory.CreateDirectory(gImagesFolder);
            int ret = v.MergePDFFileArrayToPDFFile(pdfFiles, gImagesFolder + "\\MergedPDFs.pdf");

            DirectoryInfo di = new DirectoryInfo(@tiffPath);
            FileInfo[] files = di.GetFiles("*.pdf").Where(p => p.Extension == ".pdf").ToArray();
            foreach (FileInfo file in files)
                try
                {
                    file.Attributes = FileAttributes.Normal;
                    File.Delete(file.FullName);
                }
                catch { }

            //0 - merged successfully
            //1 - error, can't merge PDF documents
            //2 - error, can't create output file, probably it used by another application
            //3 - merging failed
            //4 - merged successfully, but some files were not merged
            //if (ret == 0)
            //{
            //    System.Diagnostics.Process.Start(tiffPath + "\\mergedfiles.pdf");
            //}
            watch.Stop();
            TimeSpan ts = watch.Elapsed;

            GlobalVariables.ElapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            lblTimeElapsed.Text = GlobalVariables.ElapsedTime;
        }
    }
}
