﻿using System.IO;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class EncodeQRCodEInECIMode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // initialize a BarCodeBuilder class object
            BarCodeBuilder builder = new BarCodeBuilder();
            
            // Set its Symbology
            builder.SymbologyType = Symbology.QR;
            
            // Set encoding mode
            builder.QREncodeMode = QREncodeMode.ECIEncoding;
            
            // Set ForceQR (default) for standard QR
            builder.QREncodeType = QREncodeType.ForceQR;
            
            // Set ECI encoding type
            builder.ECIEncoding = ECIEncodings.UTF8;
            
            // Set code text
            builder.CodeText = "12345TEXT";
            
            // Set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL;
            
            // Get barcode image Bitmap
            Bitmap lBmp = builder.GenerateBarCodeImage();

            // Save QR code
            lBmp.Save(dataDir + "EncodeQRCodEInECIMode_out.bmp", ImageFormat.Bmp);
        }
    }
}
