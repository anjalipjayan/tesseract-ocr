using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using Tesseract.Extensions;

namespace TesseractOCR
{
    public class Utility
    {
        #region OCR 
        [SecurityCritical]
        public static string OcrProcess(string image, string language = "eng")
        {
            //training data
            string tessdataPath = ConfigurationManager.AppSettings["TessdataPath"];
            
            string text;
            TessBaseAPI tEngine = new TessBaseAPI(tessdataPath, language, OcrEngineMode.DEFAULT);

            tEngine.Process(image);
            text = tEngine.GetUTF8Text().ToString();
            tEngine.Clear();
            tEngine.Dispose();
            return text;

        }
        #endregion
    }
}
