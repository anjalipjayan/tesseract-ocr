using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesseractOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string image = "image path\\yourimage.png";
            //eng for English ; spa for Spanish
            //other language code can be taken from tesseract website. 
            string text = Utility.OcrProcess(image,"eng");
        }
    }
}
