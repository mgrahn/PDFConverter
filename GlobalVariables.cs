using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTIFtoPDF
{
    class GlobalVariables
    {
        public static string gDLTextFilePath = "";

        public static List<string> DLList;

        public static Boolean OutputFlag;
        public static Boolean DLDeferDupeCheck;
        public static DateTime StartTime;
        public static int StartingBatchNumber;
        public static Boolean UseDefaultImageLocation;
        public static String DefaultImageLocation = @"C:\MedCerts\DocImages\Print2660to2664";
        public static String SourceSpreadsheet;
        public static String ElapsedTime;
    }
}
