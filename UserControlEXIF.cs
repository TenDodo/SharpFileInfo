using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExifLib;



namespace Sharp_File_Info
{
    public partial class UserControlEXIF : UserControl
    {
        public UserControlEXIF()
        {

            InitializeComponent();

        }

        private void getExifButton_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;

            bool isOk = false;
            if (myParent.fileName != "None")
            {
                try
                {
                    ExifReader testreader = new ExifReader(myParent.fileName);
                    isOk = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid File");

                }

            }
            else
            {
                MessageBox.Show("Please select file");
            }

            if (isOk)
            {
                try
                {


                    ExifReader reader = new ExifReader(myParent.fileName);

                    String make, model, lensMake, lensModel, lensSerialNumber, dateTime, gPSDateStamp, gPSDestBearingRef, gPSDestDistanceRef, gPSLatitudeRef, gPSLongitudeRef, gPSMapDatum, gPSSatellites, artist, bodySerialNumber, cameraOwnerName, copyright, dateTimeDigitized, dateTimeOriginal, imageDescription, imageUniqueID, relatedSoundFile, software, spectralSensitivity, subsecTime, subsecTimeDigitized, subsecTimeOriginal, gPSDestLatitudeRef, gPSDestLongitudeRef, gPSImgDirectionRef, gPSMeasureMode, gPSSpeedRef, gPSStatus, gPSTrackRef, gPSProcessingMethodString, exifVersionString;
                    double gPSAltitude, apertureValue, brightnessValue, exposureTime, fNumber, focalLength, focalPlaneXResolution, focalPlaneYResolution, shutterSpeedValue, xResolution, yResolution, gPSDestBearing, gPSDestDistance, gPSDOP, gPSHPositioningError, gPSImgDirection, gPSSpeed, gPSTrack, compressedBitsPerPixel, digitalZoomRatio, exposureBiasValue, flashEnergy, maxApertureValue, subjectDistance;
                    double[] gPSLatitude, gPSLongitude, gPSTimestamp, lensSpecification, gPSDestLatitude, gPSDestLongitude, primaryChromaticities, referenceBlackWhite, whitePoint, yCbCrCoefficients;
                    UInt16 colorSpace, compression, exposureMode, exposureProgram, flash, focalLengthIn35mmFilm, focalPlaneResolutionUnit, gainControl, meteringMode, photographicSensitivity, photometricInterpretation, resolutionUnit, sceneCaptureType, sensingMethod, whiteBalance, yCbCrPositioning, gPSDifferential, contrast, customRendered, lightSource, orientation, planarConfiguration, samplesPerPixel, saturation, sensitivityType, sharpness, subjectDistanceRange, xPAuthor, xPComment, xPKeywords, xPSubject, xPTitle;
                    UInt32 iSOSpeed, iSOSpeedLatitudeyyy, iSOSpeedLatitudezzz, imageWidth, imageLength, recommendedExposureIndex, rowsPerStrip, standardOutputSensitivity;
                    UInt16[] yCbCrSubSampling, gPSVersionID, bitsPerSample, subjectArea, subjectLocation, transferFunction;
                    object pixelXDimension, pixelYDimension, iSOSpeedRatings, cFAPattern, deviceSettingDescription, exposureIndex, fileSource, jPEGInterchangeFormat, jPEGInterchangeFormatLength, makerNote, oECF, spatialFrequencyResponse, stripByteCounts, stripOffsets, userComment, lightSourceObject;
                    byte[] gPSProcessingMethod, componentsConfiguration, exifVersion, flashpixVersion, gPSAreaInformation;
                    Byte gPSAltitudeRef, sceneType;
                    if (reader.GetTagValue<String>(ExifTags.DateTime, out dateTime))
                    {
                        DateTimeLabel.Text = "DateTime (YYYY-MM-DD): " + dateTime.ToString();
                        if (dateTime.ToString() == String.Empty)
                        {
                            DateTimeLabel.Text += "No data";
                        }
                    }
                    else
                    {
                        DateTimeLabel.Text = "DateTime (YYYY-MM-DD): No data";
                    }

                    if (reader.GetTagValue<String>(ExifTags.Model, out model))
                    {
                        ModelLabel.Text = "Model: " + model.ToString();
                        if (reader.GetTagValue<String>(ExifTags.Make, out make))
                        {
                            ModelLabel.Text += " " + make.ToString();
                        }
                        if (ModelLabel.Text == "Model: -- --")
                        {
                            ModelLabel.Text = "Model: No data";
                        }
                    }
                    else if (reader.GetTagValue<String>(ExifTags.Make, out make))
                    {
                        ModelLabel.Text = "Model: " + make.ToString();
                    }
                    else
                    {
                        ModelLabel.Text = "Model: No data";
                    }

                    if (reader.GetTagValue<Double[]>(ExifTags.GPSLatitude, out gPSLatitude))
                    {
                        GPSLocationLabel.Text = "GPS Location: ";
                        for (int i = 0; i < gPSLatitude.Length; i++)
                        {
                            GPSLocationLabel.Text += gPSLatitude[i];
                            if (i == 0)
                            {
                                GPSLocationLabel.Text += "° ";
                            }
                            else if (i == 1)
                            {
                                GPSLocationLabel.Text += "′ ";
                            }
                            else if (i == 2)
                            {
                                GPSLocationLabel.Text += "\" ";
                            }
                        }
                        if (reader.GetTagValue<String>(ExifTags.GPSLatitudeRef, out gPSLatitudeRef))
                        {
                            if (gPSLatitudeRef == "N")
                            {
                                GPSLocationLabel.Text += " North";
                            }
                            else if (gPSLatitudeRef == "S")
                            {
                                GPSLocationLabel.Text += " South";
                            }

                        }
                        else
                        {
                            GPSLocationLabel.Text += " ???";
                        }
                        if (reader.GetTagValue<Double[]>(ExifTags.GPSLongitude, out gPSLongitude))
                        {
                            GPSLocationLabel.Text += "   ";
                            for (int i = 0; i < gPSLongitude.Length; i++)
                            {
                                GPSLocationLabel.Text += gPSLongitude[i];
                                if (i == 0)
                                {
                                    GPSLocationLabel.Text += "° ";
                                }
                                else if (i == 1)
                                {
                                    GPSLocationLabel.Text += "′ ";
                                }
                                else if (i == 2)
                                {
                                    GPSLocationLabel.Text += "\" ";
                                }
                            }
                            if (reader.GetTagValue<String>(ExifTags.GPSLongitudeRef, out gPSLongitudeRef))
                            {
                                if (gPSLongitudeRef == "E")
                                {
                                    GPSLocationLabel.Text += " East";
                                }
                                else if (gPSLongitudeRef == "W")
                                {
                                    GPSLocationLabel.Text += " West";
                                }
                            }
                            else
                            {
                                GPSLocationLabel.Text += " ???";
                            }
                        }
                        else
                        {
                            GPSLocationLabel.Text += " ???";
                        }
                    }
                    else if (reader.GetTagValue<Double[]>(ExifTags.GPSLongitude, out gPSLongitude))
                    {
                        GPSLocationLabel.Text = "GPS Location: ";
                        for (int i = 0; i < gPSLongitude.Length; i++)
                        {
                            GPSLocationLabel.Text += gPSLongitude[i];
                            if (i == 0)
                            {
                                GPSLocationLabel.Text += "° ";
                            }
                            else if (i == 1)
                            {
                                GPSLocationLabel.Text += "′ ";
                            }
                            else if (i == 2)
                            {
                                GPSLocationLabel.Text += "\" ";
                            }
                        }
                        if (reader.GetTagValue<String>(ExifTags.GPSLongitudeRef, out gPSLongitudeRef))
                        {
                            if (gPSLongitudeRef == "E")
                            {
                                GPSLocationLabel.Text += " East";
                            }
                            else if (gPSLongitudeRef == "W")
                            {
                                GPSLocationLabel.Text += " West";
                            }
                        }
                        else
                        {
                            GPSLocationLabel.Text += " ???";
                        }
                    }
                    else
                    {
                        GPSLocationLabel.Text = "GPS Location: No data";
                    }

                    if (reader.GetTagValue<double>(ExifTags.GPSAltitude, out gPSAltitude))
                    {
                        GPSAltitudeLabel.Text = "GPS Altitude: " + gPSAltitude.ToString() + " meters";
                        try
                        {
                            if (reader.GetTagValue<Byte>(ExifTags.GPSAltitudeRef, out gPSAltitudeRef))
                            {


                                if (gPSAltitudeRef == 1)
                                {
                                    GPSAltitudeLabel.Text += " below sea level";
                                }
                                else
                                {
                                    GPSAltitudeLabel.Text += " above sea level";
                                }
                            }
                        }
                        catch
                        {

                        }

                    }
                    else
                    {
                        GPSAltitudeLabel.Text = "GPS Altitude: No data";
                    }

                    if (reader.GetTagValue<Double>(ExifTags.FocalLength, out focalLength))
                    {
                        FocalLengthLabel.Text = "Lens (Focal Length): " + focalLength.ToString() + " mm";
                    }
                    else
                    {
                        FocalLengthLabel.Text = "Lens (Focal Length): No data";
                    }

                    if (reader.GetTagValue<object>(ExifTags.PixelXDimension, out pixelXDimension))
                    {
                        FileLabel.Text = "File: " + pixelXDimension.ToString();
                        if (reader.GetTagValue<object>(ExifTags.PixelYDimension, out pixelYDimension))
                        {
                            FileLabel.Text += " x " + pixelYDimension.ToString();
                        }
                        else
                        {
                            FileLabel.Text += " x ???";
                        }
                        if (reader.GetTagValue<UInt16>(ExifTags.Compression, out compression))
                        {
                            if (compression == 1)
                            {
                                FileLabel.Text += " Uncompressed";
                            }
                            else if (compression == 2)
                            {
                                FileLabel.Text += " CCITT 1D";
                            }
                            else if (compression == 3)
                            {
                                FileLabel.Text += " T4/Group 3 Fax";
                            }
                            else if (compression == 4)
                            {
                                FileLabel.Text += " T6/Group 4 Fax";
                            }
                            else if (compression == 5)
                            {
                                FileLabel.Text += " LZW";
                            }
                            else if (compression == 6)
                            {
                                FileLabel.Text += " JPEG (old-style)";
                            }
                            else if (compression == 7)
                            {
                                FileLabel.Text += " JPEG";
                            }
                            else if (compression == 8)
                            {
                                FileLabel.Text += " Adobe Deflate";
                            }
                            else if (compression == 9)
                            {
                                FileLabel.Text += " JBIG B&W";
                            }
                            else if (compression == 10)
                            {
                                FileLabel.Text += " JBIG Color";
                            }
                            else if (compression == 99)
                            {
                                FileLabel.Text += " JPEG";
                            }
                            else if (compression == 262)
                            {
                                FileLabel.Text += " Kodak 262";
                            }
                            else if (compression == 32766)
                            {
                                FileLabel.Text += " Next";
                            }
                            else if (compression == 32767)
                            {
                                FileLabel.Text += " Sony ARW Compressed";
                            }
                            else if (compression == 32769)
                            {
                                FileLabel.Text += " Packed RAW";
                            }
                            else if (compression == 32770)
                            {
                                FileLabel.Text += " Samsung SRW Compressed";
                            }
                            else if (compression == 32771)
                            {
                                FileLabel.Text += " CCIRLEW";
                            }
                            else if (compression == 32772)
                            {
                                FileLabel.Text += " Samsung SRW Compressed 2";
                            }
                            else if (compression == 32773)
                            {
                                FileLabel.Text += " PackBits";
                            }
                            else if (compression == 32809)
                            {
                                FileLabel.Text += " Thunderscan";
                            }
                            else if (compression == 32867)
                            {
                                FileLabel.Text += " Kodak KDC Compressed";
                            }
                            else if (compression == 32895)
                            {
                                FileLabel.Text += " IT8CTPAD";
                            }
                            else if (compression == 32896)
                            {
                                FileLabel.Text += " IT8LW";
                            }
                            else if (compression == 32897)
                            {
                                FileLabel.Text += " IT8MP";
                            }
                            else if (compression == 32898)
                            {
                                FileLabel.Text += " IT8BL";
                            }
                            else if (compression == 32908)
                            {
                                FileLabel.Text += " PixarFilm";
                            }
                            else if (compression == 32909)
                            {
                                FileLabel.Text += " PixarLog";
                            }
                            else if (compression == 32946)
                            {
                                FileLabel.Text += " Deflate";
                            }
                            else if (compression == 32947)
                            {
                                FileLabel.Text += " DCS";
                            }
                            else if (compression == 33003)
                            {
                                FileLabel.Text += " Aperio JPEG 2000 YCbCr";
                            }
                            else if (compression == 33005)
                            {
                                FileLabel.Text += " Aperio JPEG 2000 RGB";
                            }
                            else if (compression == 34661)
                            {
                                FileLabel.Text += " JBIG";
                            }
                            else if (compression == 34676)
                            {
                                FileLabel.Text += " SGILog";
                            }
                            else if (compression == 34677)
                            {
                                FileLabel.Text += " SGILog24";
                            }
                            else if (compression == 34712)
                            {
                                FileLabel.Text += " JPEG 2000";
                            }
                            else if (compression == 34713)
                            {
                                FileLabel.Text += " Nikon NEF Compressed";
                            }
                            else if (compression == 34715)
                            {
                                FileLabel.Text += " JBIG2 TIFF FX";
                            }
                            else if (compression == 34718)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Binary Level Codec";
                            }
                            else if (compression == 34719)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Progressive Transform Codec";
                            }
                            else if (compression == 34720)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Vector";
                            }
                            else if (compression == 34887)
                            {
                                FileLabel.Text += " ESRI Lerc";
                            }
                            else if (compression == 34892)
                            {
                                FileLabel.Text += " Lossy JPEG";
                            }
                            else if (compression == 34925)
                            {
                                FileLabel.Text += " LZMA2";
                            }
                            else if (compression == 34926)
                            {
                                FileLabel.Text += " Zstd";
                            }
                            else if (compression == 34927)
                            {
                                FileLabel.Text += " WebP";
                            }
                            else if (compression == 34933)
                            {
                                FileLabel.Text += " PNG";
                            }
                            else if (compression == 34934)
                            {
                                FileLabel.Text += " JPEG XR";
                            }
                            else if (compression == 65000)
                            {
                                FileLabel.Text += " Kodak DCR Compressed";
                            }
                            else if (compression == 65535)
                            {
                                FileLabel.Text += " Pentax PEF Compressed";
                            }
                            else
                            {
                                FileLabel.Text += " unknown " + compression.ToString();
                            }
                        }
                    }
                    else if (reader.GetTagValue<object>(ExifTags.PixelYDimension, out pixelYDimension))
                    {
                        FileLabel.Text = "File: ??? x " + pixelYDimension.ToString();
                        if (reader.GetTagValue<UInt16>(ExifTags.Compression, out compression))
                        {
                            if (compression == 1)
                            {
                                FileLabel.Text += " Uncompressed";
                            }
                            else if (compression == 2)
                            {
                                FileLabel.Text += " CCITT 1D";
                            }
                            else if (compression == 3)
                            {
                                FileLabel.Text += " T4/Group 3 Fax";
                            }
                            else if (compression == 4)
                            {
                                FileLabel.Text += " T6/Group 4 Fax";
                            }
                            else if (compression == 5)
                            {
                                FileLabel.Text += " LZW";
                            }
                            else if (compression == 6)
                            {
                                FileLabel.Text += " JPEG (old-style)";
                            }
                            else if (compression == 7)
                            {
                                FileLabel.Text += " JPEG";
                            }
                            else if (compression == 8)
                            {
                                FileLabel.Text += " Adobe Deflate";
                            }
                            else if (compression == 9)
                            {
                                FileLabel.Text += " JBIG B&W";
                            }
                            else if (compression == 10)
                            {
                                FileLabel.Text += " JBIG Color";
                            }
                            else if (compression == 99)
                            {
                                FileLabel.Text += " JPEG";
                            }
                            else if (compression == 262)
                            {
                                FileLabel.Text += " Kodak 262";
                            }
                            else if (compression == 32766)
                            {
                                FileLabel.Text += " Next";
                            }
                            else if (compression == 32767)
                            {
                                FileLabel.Text += " Sony ARW Compressed";
                            }
                            else if (compression == 32769)
                            {
                                FileLabel.Text += " Packed RAW";
                            }
                            else if (compression == 32770)
                            {
                                FileLabel.Text += " Samsung SRW Compressed";
                            }
                            else if (compression == 32771)
                            {
                                FileLabel.Text += " CCIRLEW";
                            }
                            else if (compression == 32772)
                            {
                                FileLabel.Text += " Samsung SRW Compressed 2";
                            }
                            else if (compression == 32773)
                            {
                                FileLabel.Text += " PackBits";
                            }
                            else if (compression == 32809)
                            {
                                FileLabel.Text += " Thunderscan";
                            }
                            else if (compression == 32867)
                            {
                                FileLabel.Text += " Kodak KDC Compressed";
                            }
                            else if (compression == 32895)
                            {
                                FileLabel.Text += " IT8CTPAD";
                            }
                            else if (compression == 32896)
                            {
                                FileLabel.Text += " IT8LW";
                            }
                            else if (compression == 32897)
                            {
                                FileLabel.Text += " IT8MP";
                            }
                            else if (compression == 32898)
                            {
                                FileLabel.Text += " IT8BL";
                            }
                            else if (compression == 32908)
                            {
                                FileLabel.Text += " PixarFilm";
                            }
                            else if (compression == 32909)
                            {
                                FileLabel.Text += " PixarLog";
                            }
                            else if (compression == 32946)
                            {
                                FileLabel.Text += " Deflate";
                            }
                            else if (compression == 32947)
                            {
                                FileLabel.Text += " DCS";
                            }
                            else if (compression == 33003)
                            {
                                FileLabel.Text += " Aperio JPEG 2000 YCbCr";
                            }
                            else if (compression == 33005)
                            {
                                FileLabel.Text += " Aperio JPEG 2000 RGB";
                            }
                            else if (compression == 34661)
                            {
                                FileLabel.Text += " JBIG";
                            }
                            else if (compression == 34676)
                            {
                                FileLabel.Text += " SGILog";
                            }
                            else if (compression == 34677)
                            {
                                FileLabel.Text += " SGILog24";
                            }
                            else if (compression == 34712)
                            {
                                FileLabel.Text += " JPEG 2000";
                            }
                            else if (compression == 34713)
                            {
                                FileLabel.Text += " Nikon NEF Compressed";
                            }
                            else if (compression == 34715)
                            {
                                FileLabel.Text += " JBIG2 TIFF FX";
                            }
                            else if (compression == 34718)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Binary Level Codec";
                            }
                            else if (compression == 34719)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Progressive Transform Codec";
                            }
                            else if (compression == 34720)
                            {
                                FileLabel.Text += " Microsoft Document Imaging (MDI) Vector";
                            }
                            else if (compression == 34887)
                            {
                                FileLabel.Text += " ESRI Lerc";
                            }
                            else if (compression == 34892)
                            {
                                FileLabel.Text += " Lossy JPEG";
                            }
                            else if (compression == 34925)
                            {
                                FileLabel.Text += " LZMA2";
                            }
                            else if (compression == 34926)
                            {
                                FileLabel.Text += " Zstd";
                            }
                            else if (compression == 34927)
                            {
                                FileLabel.Text += " WebP";
                            }
                            else if (compression == 34933)
                            {
                                FileLabel.Text += " PNG";
                            }
                            else if (compression == 34934)
                            {
                                FileLabel.Text += " JPEG XR";
                            }
                            else if (compression == 65000)
                            {
                                FileLabel.Text += " Kodak DCR Compressed";
                            }
                            else if (compression == 65535)
                            {
                                FileLabel.Text += " Pentax PEF Compressed";
                            }
                            else
                            {
                                FileLabel.Text += " unknown " + compression.ToString();
                            }
                        }
                    }
                    else if (reader.GetTagValue<UInt16>(ExifTags.Compression, out compression))
                    {
                        FileLabel.Text = "File: ";
                        if (compression == 1)
                        {
                            FileLabel.Text += "Uncompressed";
                        }
                        else if (compression == 2)
                        {
                            FileLabel.Text += "CCITT 1D";
                        }
                        else if (compression == 3)
                        {
                            FileLabel.Text += "T4/Group 3 Fax";
                        }
                        else if (compression == 4)
                        {
                            FileLabel.Text += "T6/Group 4 Fax";
                        }
                        else if (compression == 5)
                        {
                            FileLabel.Text += "LZW";
                        }
                        else if (compression == 6)
                        {
                            FileLabel.Text += "JPEG (old-style)";
                        }
                        else if (compression == 7)
                        {
                            FileLabel.Text += "JPEG";
                        }
                        else if (compression == 8)
                        {
                            FileLabel.Text += "Adobe Deflate";
                        }
                        else if (compression == 9)
                        {
                            FileLabel.Text += "JBIG B&W";
                        }
                        else if (compression == 10)
                        {
                            FileLabel.Text += "JBIG Color";
                        }
                        else if (compression == 99)
                        {
                            FileLabel.Text += "JPEG";
                        }
                        else if (compression == 262)
                        {
                            FileLabel.Text += "Kodak 262";
                        }
                        else if (compression == 32766)
                        {
                            FileLabel.Text += "Next";
                        }
                        else if (compression == 32767)
                        {
                            FileLabel.Text += "Sony ARW Compressed";
                        }
                        else if (compression == 32769)
                        {
                            FileLabel.Text += "Packed RAW";
                        }
                        else if (compression == 32770)
                        {
                            FileLabel.Text += "Samsung SRW Compressed";
                        }
                        else if (compression == 32771)
                        {
                            FileLabel.Text += "CCIRLEW";
                        }
                        else if (compression == 32772)
                        {
                            FileLabel.Text += "Samsung SRW Compressed 2";
                        }
                        else if (compression == 32773)
                        {
                            FileLabel.Text += "PackBits";
                        }
                        else if (compression == 32809)
                        {
                            FileLabel.Text += "Thunderscan";
                        }
                        else if (compression == 32867)
                        {
                            FileLabel.Text += "Kodak KDC Compressed";
                        }
                        else if (compression == 32895)
                        {
                            FileLabel.Text += "IT8CTPAD";
                        }
                        else if (compression == 32896)
                        {
                            FileLabel.Text += "IT8LW";
                        }
                        else if (compression == 32897)
                        {
                            FileLabel.Text += "IT8MP";
                        }
                        else if (compression == 32898)
                        {
                            FileLabel.Text += "IT8BL";
                        }
                        else if (compression == 32908)
                        {
                            FileLabel.Text += "PixarFilm";
                        }
                        else if (compression == 32909)
                        {
                            FileLabel.Text += "PixarLog";
                        }
                        else if (compression == 32946)
                        {
                            FileLabel.Text += "Deflate";
                        }
                        else if (compression == 32947)
                        {
                            FileLabel.Text += "DCS";
                        }
                        else if (compression == 33003)
                        {
                            FileLabel.Text += "Aperio JPEG 2000 YCbCr";
                        }
                        else if (compression == 33005)
                        {
                            FileLabel.Text += "Aperio JPEG 2000 RGB";
                        }
                        else if (compression == 34661)
                        {
                            FileLabel.Text += "JBIG";
                        }
                        else if (compression == 34676)
                        {
                            FileLabel.Text += "SGILog";
                        }
                        else if (compression == 34677)
                        {
                            FileLabel.Text += "SGILog24";
                        }
                        else if (compression == 34712)
                        {
                            FileLabel.Text += "JPEG 2000";
                        }
                        else if (compression == 34713)
                        {
                            FileLabel.Text += "Nikon NEF Compressed";
                        }
                        else if (compression == 34715)
                        {
                            FileLabel.Text += "JBIG2 TIFF FX";
                        }
                        else if (compression == 34718)
                        {
                            FileLabel.Text += "Microsoft Document Imaging (MDI) Binary Level Codec";
                        }
                        else if (compression == 34719)
                        {
                            FileLabel.Text += "Microsoft Document Imaging (MDI) Progressive Transform Codec";
                        }
                        else if (compression == 34720)
                        {
                            FileLabel.Text += "Microsoft Document Imaging (MDI) Vector";
                        }
                        else if (compression == 34887)
                        {
                            FileLabel.Text += "ESRI Lerc";
                        }
                        else if (compression == 34892)
                        {
                            FileLabel.Text += "Lossy JPEG";
                        }
                        else if (compression == 34925)
                        {
                            FileLabel.Text += "LZMA2";
                        }
                        else if (compression == 34926)
                        {
                            FileLabel.Text += "Zstd";
                        }
                        else if (compression == 34927)
                        {
                            FileLabel.Text += "WebP";
                        }
                        else if (compression == 34933)
                        {
                            FileLabel.Text += "PNG";
                        }
                        else if (compression == 34934)
                        {
                            FileLabel.Text += "JPEG XR";
                        }
                        else if (compression == 65000)
                        {
                            FileLabel.Text += "Kodak DCR Compressed";
                        }
                        else if (compression == 65535)
                        {
                            FileLabel.Text += "Pentax PEF Compressed";
                        }
                        else
                        {
                            FileLabel.Text += "unknown " + compression.ToString();
                        }
                    }
                    else
                    {
                        FileLabel.Text = "File: No data";
                    }

                    if (reader.GetTagValue<UInt16>(ExifTags.ColorSpace, out colorSpace))
                    {
                        if (colorSpace == 1)
                        {
                            ColorSpaceLabel.Text = "Color Space: sRGB";
                        }
                        else
                        {
                            ColorSpaceLabel.Text = "Color Space: " + colorSpace.ToString();
                        }

                    }
                    else
                    {
                        ColorSpaceLabel.Text = "Color Space: No data";
                    }



                    if (reader.GetTagValue<String>(ExifTags.LensModel, out lensModel))
                    {
                        LensModelLabel.Text = "Lens Model: " + lensModel.ToString();
                    }
                    else
                    {
                        LensModelLabel.Text = "Lens Model: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.LensMake, out lensMake))
                    {
                        LensMakeLabel.Text = "Lens Make: " + lensMake;
                    }
                    else
                    {
                        LensMakeLabel.Text = "Lens Make: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.LensSerialNumber, out lensSerialNumber))
                    {
                        LensSerialNumberLabel.Text = "Lens Serial Number: " + lensSerialNumber.ToString();
                    }
                    else
                    {
                        LensSerialNumberLabel.Text = "Lens Serial Number: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.LensSpecification, out lensSpecification))
                    {
                        LensSpecificationLabel.Text = "Lens Specification: ";
                        for (int i = 0; i < lensSpecification.Length; i++)
                        {
                            LensSpecificationLabel.Text += lensSpecification[i];
                            LensSpecificationLabel.Text += " ";
                        }
                    }
                    else
                    {
                        LensSpecificationLabel.Text = "Lens Specification: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.ImageWidth, out imageWidth))
                    {
                        ImageWidthLabel.Text = "Image Width: " + imageWidth.ToString();
                    }
                    else
                    {
                        ImageWidthLabel.Text = "Image Width: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.ImageLength, out imageLength))
                    {
                        ImageLengthLabel.Text = "Image Length: " + imageWidth.ToString();
                    }
                    else
                    {
                        ImageLengthLabel.Text = "Image Length: No data";
                    }


                    if (reader.GetTagValue<Byte[]>(ExifTags.GPSAreaInformation, out gPSAreaInformation))
                    {
                        GPSAreaInformationLabel.Text = "GPS Area Information: ";
                        for (int i = 0; i < gPSAreaInformation.Length; i++)
                        {
                            GPSAreaInformationLabel.Text += gPSAreaInformation[i];
                            GPSAreaInformationLabel.Text += " ";
                        }
                    }
                    else
                    {
                        GPSAreaInformationLabel.Text = "GPS Area Information: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSDateStamp, out gPSDateStamp))
                    {
                        GPSDateStampLabel.Text = "GPS Date Stamp: " + gPSDateStamp.ToString();

                    }
                    else
                    {
                        GPSDateStampLabel.Text = "GPS Date Stamp: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSDestBearing, out gPSDestBearing))
                    {
                        GPSDestBearingLabel.Text = "GPS Dest Bearing: " + gPSDestBearing.ToString();
                    }
                    else
                    {
                        GPSDestBearingLabel.Text = "GPS Dest Bearing: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSDestBearingRef, out gPSDestBearingRef))
                    {
                        GPSDestBearingRefLabel.Text = "GPS Dest Bearing Reference: " + gPSDestBearingRef.ToString();

                    }
                    else
                    {
                        GPSDestBearingRefLabel.Text = "GPS Dest Bearing Reference: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSDestDistance, out gPSDestDistance))
                    {
                        GPSDestDistanceLabel.Text = "GPS Dest Distance: " + gPSDestDistance.ToString();
                    }
                    else
                    {
                        GPSDestDistanceLabel.Text = "GPS Dest Distance: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSDestDistanceRef, out gPSDestDistanceRef))
                    {
                        GPSDestDistanceRefLabel.Text = "GPS Dest Distance Reference: " + gPSDestDistanceRef.ToString();
                    }
                    else
                    {
                        GPSDestDistanceRefLabel.Text = "GPS Dest Distance Reference: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.GPSDestLatitude, out gPSDestLatitude))
                    {
                        GPSDestLatitudeLabel.Text = "GPS Dest Latitude: ";
                        for (int i = 0; i < gPSDestLatitude.Length; i++)
                        {
                            GPSDestLatitudeLabel.Text += gPSDestLatitude[i];
                            GPSDestLatitudeLabel.Text += " ";
                        }
                    }
                    else
                    {
                        GPSDestLatitudeLabel.Text = "GPS Dest Latitude: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSDestLatitudeRef, out gPSDestLatitudeRef))
                    {
                        GPSDestLatitudeRefLabel.Text = "GPS Dest Latitude Reference: " + gPSDestLatitudeRef.ToString();

                    }
                    else
                    {
                        GPSDestLatitudeRefLabel.Text = "GPS Dest Latitude Reference: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.GPSDestLongitude, out gPSDestLongitude))
                    {
                        GPSDestLongitudeLabel.Text = "GPS Dest Longitude: ";
                        for (int i = 0; i < gPSDestLongitude.Length; i++)
                        {
                            GPSDestLongitudeLabel.Text += gPSDestLongitude[i];
                            GPSDestLongitudeLabel.Text += " ";
                        }
                    }
                    else
                    {
                        GPSDestLongitudeLabel.Text = "GPS Dest Longitude: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSDestLongitudeRef, out gPSDestLongitudeRef))
                    {
                        GPSDestLongitudeRefLabel.Text = "GPS Dest Longitude Reference: " + gPSDestLongitudeRef.ToString();

                    }
                    else
                    {
                        GPSDestLongitudeRefLabel.Text = "GPS Dest Longitude Reference: No data";
                    }

                    if (reader.GetTagValue<UInt16>(ExifTags.GPSDifferential, out gPSDifferential))
                    {
                        GPSDifferentialLabel.Text = "GPS Differential: ";
                        if (gPSDifferential == 0)
                        {
                            GPSDifferentialLabel.Text += "No Correction";
                        }
                        else if (gPSDifferential == 1)
                        {
                            GPSDifferentialLabel.Text += "Differential Corrected";
                        }
                    }
                    else
                    {
                        GPSDifferentialLabel.Text = "GPS Differential: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSDOP, out gPSDOP))
                    {
                        GPSDOPLabel.Text = "GPS DOP: " + gPSDOP.ToString();
                    }
                    else
                    {
                        GPSDOPLabel.Text = "GPS DOP: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSHPositioningError, out gPSHPositioningError))
                    {
                        GPSHPositioningErrorLabel.Text = "GPS HPositioning Error: " + gPSHPositioningError.ToString();
                    }
                    else
                    {
                        GPSHPositioningErrorLabel.Text = "GPS HPositioning Error: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSImgDirection, out gPSImgDirection))
                    {
                        GPSImgDirectionLabel.Text = "GPS Image Direction: " + gPSImgDirection.ToString();
                    }
                    else
                    {
                        GPSImgDirectionLabel.Text = "GPS Image Direction: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSImgDirectionRef, out gPSImgDirectionRef))
                    {
                        GPSImgDirectionRefLabel.Text = "GPS Image Direction Reference: " + gPSImgDirectionRef.ToString();
                    }
                    else
                    {
                        GPSImgDirectionRefLabel.Text = "GPS Image Direction Reference: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSMapDatum, out gPSMapDatum))
                    {
                        GPSMapDatumLabel.Text = "GPS Map Datum: " + gPSMapDatum.ToString();
                    }
                    else
                    {
                        GPSMapDatumLabel.Text = "GPS Map Datum: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSMeasureMode, out gPSMeasureMode))
                    {
                        GPSMeasureModeLabel.Text = "GPS Measure Mode: " + gPSMeasureMode;

                    }
                    else
                    {
                        GPSMeasureModeLabel.Text = "GPS Measure Mode: No data";
                    }
                    try
                    {
                        if (reader.GetTagValue<byte[]>(ExifTags.GPSProcessingMethod, out gPSProcessingMethod))
                        {
                            GPSProcessingMethodLabel.Text = "GPS Processing Method: ";
                            for (int i = 0; i < gPSProcessingMethod.Length; i++)
                            {
                                GPSProcessingMethodLabel.Text += gPSProcessingMethod[i];
                                GPSProcessingMethodLabel.Text += " ";
                            }
                        }
                        else
                        {
                            GPSProcessingMethodLabel.Text = "GPS Processing Method: No data";
                        }
                    }
                    catch
                    {

                        if (reader.GetTagValue<String>(ExifTags.GPSProcessingMethod, out gPSProcessingMethodString))
                        {
                            GPSProcessingMethodLabel.Text = "GPS Processing Method: " + gPSProcessingMethodString.ToString();

                        }
                        else
                        {
                            GPSProcessingMethodLabel.Text = "GPS Processing Method: No data";
                        }
                    }

                    if (reader.GetTagValue<String>(ExifTags.GPSSatellites, out gPSSatellites))
                    {
                        GPSSatellitesLabel.Text = "GPS Satellites: " + gPSSatellites.ToString();
                    }
                    else
                    {
                        GPSSatellitesLabel.Text = "GPS Satellites: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSSpeed, out gPSSpeed))
                    {
                        GPSSpeedLabel.Text = "GPS Speed: " + gPSSpeed.ToString();
                    }
                    else
                    {
                        GPSSpeedLabel.Text = "GPS Speed : No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSSpeedRef, out gPSSpeedRef))
                    {
                        GPSSpeedRefLabel.Text = "GPS Speed Reference: " + gPSSpeedRef.ToString();

                    }
                    else
                    {
                        GPSSpeedRefLabel.Text = "GPS Speed Reference: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSStatus, out gPSStatus))
                    {
                        GPSStatusLabel.Text = "GPS Status: " + gPSStatus.ToString();
                    }
                    else
                    {
                        GPSStatusLabel.Text = "GPS Status: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.GPSTimestamp, out gPSTimestamp))
                    {
                        GPSTimestampLabel.Text = "GPS Timestamp: ";
                        for (int i = 0; i < gPSTimestamp.Length; i++)
                        {
                            GPSTimestampLabel.Text += gPSTimestamp[i];
                            if (i < gPSTimestamp.Length - 1)
                            {
                                GPSTimestampLabel.Text += ":";
                            }

                        }
                    }
                    else
                    {
                        GPSTimestampLabel.Text = "GPS Timestamp: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.GPSTrack, out gPSTrack))
                    {
                        GPSTrackLabel.Text = "GPS Track: " + gPSTrack.ToString();
                    }
                    else
                    {
                        GPSTrackLabel.Text = "GPS Track: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.GPSTrackRef, out gPSTrackRef))
                    {
                        GPSTrackRefLabel.Text = "GPS Track Reference: " + gPSTrackRef.ToString();

                    }
                    else
                    {
                        GPSTrackRefLabel.Text = "GPS Track Reference: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.GPSVersionID, out gPSVersionID))
                    {
                        GPSVersionIDLabel.Text = "GPS Version ID: ";
                        for (int i = 0; i < gPSVersionID.Length; i++)
                        {
                            GPSVersionIDLabel.Text += gPSVersionID[i];
                            GPSVersionIDLabel.Text += " ";
                        }
                    }
                    else
                    {
                        GPSVersionIDLabel.Text = "GPS Version ID: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.ApertureValue, out apertureValue))
                    {
                        ApertureValueLabel.Text = "Aperture Value: " + apertureValue.ToString();
                    }
                    else
                    {
                        ApertureValueLabel.Text = "Aperture Value: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.Artist, out artist))
                    {
                        ArtistLabel.Text = "Artist: " + artist.ToString();
                    }
                    else
                    {
                        ArtistLabel.Text = "Artist: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.BitsPerSample, out bitsPerSample))
                    {
                        BitsPerSampleLabel.Text = "Bits Per Sample: ";
                        for (int i = 0; i < bitsPerSample.Length; i++)
                        {
                            BitsPerSampleLabel.Text += bitsPerSample[i];
                            BitsPerSampleLabel.Text += " ";
                        }
                    }
                    else
                    {
                        BitsPerSampleLabel.Text = "Bits Per Sample: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.BodySerialNumber, out bodySerialNumber))
                    {
                        BodySerialNumberLabel.Text = "Body Serial Number: " + bodySerialNumber.ToString();
                    }
                    else
                    {
                        BodySerialNumberLabel.Text = "Body Serial Number: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.BrightnessValue, out brightnessValue))
                    {
                        BrightnessValueLabel.Text = "Brightness Value: " + brightnessValue.ToString();
                    }
                    else
                    {
                        BrightnessValueLabel.Text = "Brightness Value: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.CameraOwnerName, out cameraOwnerName))
                    {
                        CameraOwnerNameLabel.Text = "Camera Owner Name: " + cameraOwnerName.ToString();
                    }
                    else
                    {
                        CameraOwnerNameLabel.Text = "Camera Owner Name: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.CFAPattern, out cFAPattern))
                    {
                        CFAPatternLabel.Text = "CFA Pattern: " + cFAPattern.ToString();
                    }
                    else
                    {
                        CFAPatternLabel.Text = "CFA Pattern: No data";
                    }
                    if (reader.GetTagValue<byte[]>(ExifTags.ComponentsConfiguration, out componentsConfiguration))
                    {
                        ComponentsConfigurationLabel.Text = "Components Configuration: ";
                        for (int i = 0; i < componentsConfiguration.Length; i++)
                        {
                            if (componentsConfiguration[i] == 0)
                            {
                                ComponentsConfigurationLabel.Text += "-";
                            }
                            else if (componentsConfiguration[i] == 1)
                            {
                                ComponentsConfigurationLabel.Text += "Y";
                            }
                            else if (componentsConfiguration[i] == 2)
                            {
                                ComponentsConfigurationLabel.Text += "Cb";
                            }
                            else if (componentsConfiguration[i] == 3)
                            {
                                ComponentsConfigurationLabel.Text += "Cr";
                            }
                            else if (componentsConfiguration[i] == 4)
                            {
                                ComponentsConfigurationLabel.Text += "R";
                            }
                            else if (componentsConfiguration[i] == 5)
                            {
                                ComponentsConfigurationLabel.Text += "G";
                            }
                            else if (componentsConfiguration[i] == 6)
                            {
                                ComponentsConfigurationLabel.Text += "B";
                            }
                            else
                            {
                                ComponentsConfigurationLabel.Text += "reserved";
                            }
                            if (i != componentsConfiguration.Length - 1)
                            {
                                ComponentsConfigurationLabel.Text += ", ";
                            }

                        }
                    }
                    else
                    {
                        ComponentsConfigurationLabel.Text = "Components Configuration: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.CompressedBitsPerPixel, out compressedBitsPerPixel))
                    {
                        CompressedBitsPerPixelLabel.Text = "Compressed Bits Per Pixel: " + compressedBitsPerPixel.ToString();
                    }
                    else
                    {
                        CompressedBitsPerPixelLabel.Text = "Compressed Bits Per Pixel: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.Contrast, out contrast))
                    {
                        ContrastLabel.Text = "Contrast: ";
                        if (contrast == 0)
                        {
                            ContrastLabel.Text += "Normal";
                        }
                        else if (contrast == 1)
                        {
                            ContrastLabel.Text += "Low";
                        }
                        else if (contrast == 2)
                        {
                            ContrastLabel.Text += "High";
                        }
                    }
                    else
                    {
                        ContrastLabel.Text = "Contrast: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.Copyright, out copyright))
                    {
                        CopyrightLabel.Text = "Copyright: " + copyright.ToString();
                    }
                    else
                    {
                        CopyrightLabel.Text = "Copyright: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.CustomRendered, out customRendered))
                    {
                        CustomRenderedLabel.Text = "Custom Rendered: ";
                        if (customRendered == 0)
                        {
                            CustomRenderedLabel.Text += "Normal";
                        }
                        else if (customRendered == 1)
                        {
                            CustomRenderedLabel.Text += "Custom";
                        }
                        else if (customRendered == 2)
                        {
                            CustomRenderedLabel.Text += "HDR (no original saved)";
                        }
                        else if (customRendered == 3)
                        {
                            CustomRenderedLabel.Text += "HDR (original saved)";
                        }
                        else if (customRendered == 4)
                        {
                            CustomRenderedLabel.Text += "Original (for HDR)";
                        }
                        else if (customRendered == 6)
                        {
                            CustomRenderedLabel.Text += "Panorama";
                        }
                        else if (customRendered == 7)
                        {
                            CustomRenderedLabel.Text += "Portrait HDR";
                        }
                        else if (customRendered == 8)
                        {
                            CustomRenderedLabel.Text += "Portrait";
                        }

                    }
                    else
                    {
                        CustomRenderedLabel.Text = "Custom Rendered: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.DateTimeDigitized, out dateTimeDigitized))
                    {
                        DateTimeDigitizedLabel.Text = "DateTime Digitized: " + dateTimeDigitized.ToString();
                    }
                    else
                    {
                        DateTimeDigitizedLabel.Text = "DateTime Digitized: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.DateTimeOriginal, out dateTimeOriginal))
                    {
                        DateTimeOriginalLabel.Text = "DateTime Original: " + dateTimeOriginal.ToString();
                    }
                    else
                    {
                        DateTimeOriginalLabel.Text = "DateTime Original: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.DeviceSettingDescription, out deviceSettingDescription))
                    {
                        DeviceSettingDescriptionLabel.Text = "Device Setting Description: " + deviceSettingDescription.ToString();
                    }
                    else
                    {
                        DeviceSettingDescriptionLabel.Text = "Device Setting Description: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.DigitalZoomRatio, out digitalZoomRatio))
                    {
                        DigitalZoomRatioLabel.Text = "Digital Zoom Ratio: " + digitalZoomRatio.ToString();
                    }
                    else
                    {
                        DigitalZoomRatioLabel.Text = "Digital Zoom Ratio: No data";
                    }
                    try
                    {
                        if (reader.GetTagValue<byte[]>(ExifTags.ExifVersion, out exifVersion))
                        {
                            ExifVersionLabel.Text = "Exif Version: ";
                            for (int i = 0; i < exifVersion.Length; i++)
                            {
                                ExifVersionLabel.Text += exifVersion[i];
                                ExifVersionLabel.Text += " ";
                            }
                        }
                        else
                        {
                            ExifVersionLabel.Text = "Exif Version: No data";
                        }
                    }
                    catch (Exception)
                    {
                        if (reader.GetTagValue<String>(ExifTags.ExifVersion, out exifVersionString))
                        {
                            ExifVersionLabel.Text = "Exif Version: " + exifVersionString.ToString();

                        }
                        else
                        {
                            ExifVersionLabel.Text = "Exif Version: No data";
                        }
                    }

                    if (reader.GetTagValue<Double>(ExifTags.ExposureBiasValue, out exposureBiasValue))
                    {
                        ExposureBiasValueLabel.Text = "Exposure Bias Value: " + exposureBiasValue.ToString();
                    }
                    else
                    {
                        ExposureBiasValueLabel.Text = "Exposure Bias Value: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.ExposureIndex, out exposureIndex))
                    {
                        ExposureIndexLabel.Text = "Exposure Index: " + exposureIndex.ToString();
                    }
                    else
                    {
                        ExposureIndexLabel.Text = "Exposure Index: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.ExposureMode, out exposureMode))
                    {
                        ExposureModeLabel.Text = "Exposure Mode: ";
                        if (exposureMode == 0)
                        {
                            ExposureModeLabel.Text += "Auto";
                        }
                        else if (exposureMode == 1)
                        {
                            ExposureModeLabel.Text += "Manual";
                        }
                        else if (exposureMode == 2)
                        {
                            ExposureModeLabel.Text += "Auto bracket";
                        }
                    }
                    else
                    {
                        ExposureModeLabel.Text = "Exposure Mode: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.ExposureProgram, out exposureProgram))
                    {
                        ExposureProgramLabel.Text = "Exposure Program: ";
                        if (exposureProgram == 0)
                        {
                            ExposureProgramLabel.Text += "Not Defined";
                        }
                        else if (exposureProgram == 1)
                        {
                            ExposureProgramLabel.Text += "Manual";
                        }
                        else if (exposureProgram == 2)
                        {
                            ExposureProgramLabel.Text += "Program AE";
                        }
                        else if (exposureProgram == 3)
                        {
                            ExposureProgramLabel.Text += "Aperture-priority AE";

                        }
                        else if (exposureProgram == 4)
                        {
                            ExposureProgramLabel.Text += "Shutter speed priority AE";

                        }
                        else if (exposureProgram == 5)
                        {
                            ExposureProgramLabel.Text += "Creative (Slow speed)";
                        }
                        else if (exposureProgram == 6)
                        {
                            ExposureProgramLabel.Text += "Action (High speed)";
                        }
                        else if (exposureProgram == 7)
                        {
                            ExposureProgramLabel.Text += "Portrait";
                        }
                        else if (exposureProgram == 8)
                        {
                            ExposureProgramLabel.Text += "Landscape";

                        }
                        else if (exposureProgram == 9)
                        {
                            ExposureProgramLabel.Text += "Bulb";

                        }

                    }
                    else
                    {
                        ExposureProgramLabel.Text = "Exposure Program: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.ExposureTime, out exposureTime))
                    {
                        ExposureTimeLabel.Text = "Exposure Time: " + exposureTime.ToString();
                    }
                    else
                    {
                        ExposureTimeLabel.Text = "Exposure Time: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.FileSource, out fileSource))
                    {
                        FileSourceLabel.Text = "File Source: " + fileSource.ToString();
                    }
                    else
                    {
                        FileSourceLabel.Text = "File Source: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.Flash, out flash))
                    {
                        FlashLabel.Text = "Flash: ";
                        if (flash == 0)
                        {
                            FlashLabel.Text += "Flash did not fire";
                        }
                        else if (flash == 1)
                        {
                            FlashLabel.Text += "Flash did fire";
                        }
                        else if (flash == 5)
                        {
                            FlashLabel.Text += "Strobe return light not detected";
                        }
                        else if (flash == 7)
                        {
                            FlashLabel.Text += "Strobe return light detected";
                        }
                        else if (flash == 9)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode";
                        }
                        else if (flash == 13)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode, return light not detected";
                        }
                        else if (flash == 15)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode, return light detected";
                        }
                        else if (flash == 16)
                        {
                            FlashLabel.Text += "Flash did not fire, compulsory flash mode";
                        }
                        else if (flash == 24)
                        {
                            FlashLabel.Text += "Flash did not fire, auto mode";
                        }
                        else if (flash == 25)
                        {
                            FlashLabel.Text += "Flash fired, auto mode";
                        }
                        else if (flash == 29)
                        {
                            FlashLabel.Text += "Flash fired, auto mode, return light not detected";
                        }
                        else if (flash == 31)
                        {
                            FlashLabel.Text += "Flash fired, auto mode, return light detected";
                        }
                        else if (flash == 32)
                        {
                            FlashLabel.Text += "No flash function";
                        }
                        else if (flash == 65)
                        {
                            FlashLabel.Text += "Flash fired, red-eye reduction mode";
                        }
                        else if (flash == 69)
                        {
                            FlashLabel.Text += "Flash fired, red-eye reduction mode, return light not detected";
                        }
                        else if (flash == 71)
                        {
                            FlashLabel.Text += "Flash fired, red-eye reduction mode, return light detected";
                        }
                        else if (flash == 73)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode, red-eye reduction mode";
                        }
                        else if (flash == 77)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode, red-eye reduction mode, return light not detected";
                        }
                        else if (flash == 79)
                        {
                            FlashLabel.Text += "Flash fired, compulsory flash mode, red-eye reduction mode, return light detected";
                        }
                        else if (flash == 89)
                        {
                            FlashLabel.Text += "Flash fired, auto mode, red-eye reduction mode";
                        }
                        else if (flash == 93)
                        {
                            FlashLabel.Text += "Flash fired, auto mode, return light not detected, red-eye reduction mode";
                        }
                        else if (flash == 95)
                        {
                            FlashLabel.Text += "Flash fired, auto mode, return light detected, red-eye reduction mode";
                        }
                        else
                        {
                            FlashLabel.Text += "Flash mode unknown";
                        }

                    }
                    else
                    {
                        FlashLabel.Text = "Flash: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.FlashEnergy, out flashEnergy))
                    {
                        FlashEnergyLabel.Text = "Flash Energy: " + flashEnergy.ToString();
                    }
                    else
                    {
                        FlashEnergyLabel.Text = "Flash Energy: No data";
                    }
                    if (reader.GetTagValue<byte[]>(ExifTags.FlashpixVersion, out flashpixVersion))
                    {
                        FlashpixVersionLabel.Text = "Flashpix Version: ";
                        for (int i = 0; i < flashpixVersion.Length; i++)
                        {
                            FlashpixVersionLabel.Text += flashpixVersion[i];
                            FlashpixVersionLabel.Text += " ";
                        }
                    }
                    else
                    {
                        FlashpixVersionLabel.Text = "Flashpix Version: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.FNumber, out fNumber))
                    {
                        FNumberLabel.Text = "FNumber: " + fNumber.ToString();
                    }
                    else
                    {
                        FNumberLabel.Text = "FNumber: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.FocalLengthIn35mmFilm, out focalLengthIn35mmFilm))
                    {
                        FocalLengthIn35mmFilmLabel.Text = "Focal Length In 35 mm Film: " + focalLengthIn35mmFilm.ToString();
                    }
                    else
                    {
                        FocalLengthIn35mmFilmLabel.Text = "Focal Length In 35 mm Film: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.FocalPlaneResolutionUnit, out focalPlaneResolutionUnit))
                    {
                        FocalPlaneResolutionUnitLabel.Text = "Focal Plane Resolution Unit: ";
                        if (focalPlaneResolutionUnit == 1)
                        {
                            FocalPlaneResolutionUnitLabel.Text += "None";
                        }
                        else if (focalPlaneResolutionUnit == 2)
                        {
                            FocalPlaneResolutionUnitLabel.Text += "inches";
                        }
                        else if (focalPlaneResolutionUnit == 3)
                        {
                            FocalPlaneResolutionUnitLabel.Text += "cm";
                        }
                        else if (focalPlaneResolutionUnit == 4)
                        {
                            FocalPlaneResolutionUnitLabel.Text += "mm";
                        }
                        else if (focalPlaneResolutionUnit == 5)
                        {
                            FocalPlaneResolutionUnitLabel.Text += "um";
                        }
                    }
                    else
                    {
                        FocalPlaneResolutionUnitLabel.Text = "Focal Plane Resolution Unit: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.FocalPlaneXResolution, out focalPlaneXResolution))
                    {
                        FocalPlaneXResolutionLabel.Text = "Focal Plane X Resolution: " + focalPlaneXResolution.ToString();
                    }
                    else
                    {
                        FocalPlaneXResolutionLabel.Text = "Focal Plane X Resolution: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.FocalPlaneYResolution, out focalPlaneYResolution))
                    {
                        FocalPlaneYResolutionLabel.Text = "Focal Plane Y Resolution: " + focalPlaneYResolution.ToString();
                    }
                    else
                    {
                        FocalPlaneYResolutionLabel.Text = "Focal Plane Y Resolution: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.GainControl, out gainControl))
                    {
                        GainControlLabel.Text = "Gain Control: ";
                        if (gainControl == 0)
                        {
                            GainControlLabel.Text += "None";
                        }
                        else if (gainControl == 1)
                        {
                            GainControlLabel.Text += "Low gain up";
                        }
                        else if (gainControl == 2)
                        {
                            GainControlLabel.Text += "High gain up";
                        }
                        else if (gainControl == 3)
                        {
                            GainControlLabel.Text += "Low gain down";
                        }
                        else if (gainControl == 4)
                        {
                            GainControlLabel.Text += "High gain down";
                        }
                    }
                    else
                    {
                        GainControlLabel.Text = "Gain Control: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.ImageDescription, out imageDescription))
                    {
                        ImageDescriptionLabel.Text = "Image Description: " + imageDescription.ToString();
                    }
                    else
                    {
                        ImageDescriptionLabel.Text = "Image Description: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.ImageUniqueID, out imageUniqueID))
                    {
                        ImageUniqueIDLabel.Text = "Image Unique ID: " + imageUniqueID.ToString();
                    }
                    else
                    {
                        ImageUniqueIDLabel.Text = "Image Unique ID: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.ISOSpeed, out iSOSpeed))
                    {
                        ISOSpeedLabel.Text = "ISO Speed: " + iSOSpeed.ToString();
                    }
                    else
                    {
                        ISOSpeedLabel.Text = "ISO Speed: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.ISOSpeedLatitudeyyy, out iSOSpeedLatitudeyyy))
                    {
                        ISOSpeedLatitudeyyyLabel.Text = "ISO Speed Latitude yyy: " + iSOSpeedLatitudeyyy.ToString();
                    }
                    else
                    {
                        ISOSpeedLatitudeyyyLabel.Text = "ISO Speed Latitude yyy: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.ISOSpeedLatitudezzz, out iSOSpeedLatitudezzz))
                    {
                        ISOSpeedLatitudezzzLabel.Text = "ISO Speed Latitude zzz: " + iSOSpeedLatitudezzz.ToString();
                    }
                    else
                    {
                        ISOSpeedLatitudezzzLabel.Text = "ISO Speed Latitude zzz: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.ISOSpeedRatings, out iSOSpeedRatings))
                    {
                        ISOSpeedRatingsLabel.Text = "ISO Speed Ratings: " + iSOSpeedRatings.ToString();
                    }
                    else
                    {
                        ISOSpeedRatingsLabel.Text = "ISO Speed Ratings: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.JPEGInterchangeFormat, out jPEGInterchangeFormat))
                    {
                        JPEGInterchangeFormatLabel.Text = "JPEG Interchange Formats: " + jPEGInterchangeFormat.ToString();
                    }
                    else
                    {
                        JPEGInterchangeFormatLabel.Text = "JPEG Interchange Format: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.JPEGInterchangeFormatLength, out jPEGInterchangeFormatLength))
                    {
                        JPEGInterchangeFormatLengthLabel.Text = "JPEG Interchange Format Length: " + jPEGInterchangeFormatLength.ToString();
                    }
                    else
                    {
                        JPEGInterchangeFormatLengthLabel.Text = "JPEG Interchange Format Length: No data";
                    }
                    try
                    {
                        if (reader.GetTagValue<UInt16>(ExifTags.LightSource, out lightSource))
                        {
                            LightSourceLabel.Text = "Light Source: ";
                            if (lightSource == 0)
                            {
                                LightSourceLabel.Text += "Unknown";
                            }
                            else if (lightSource == 1)
                            {
                                LightSourceLabel.Text += "Daylight";
                            }
                            else if (lightSource == 2)
                            {
                                LightSourceLabel.Text += "Fluorescent";
                            }
                            else if (lightSource == 3)
                            {
                                LightSourceLabel.Text += "Tungsten (Incandescent)";
                            }
                            else if (lightSource == 4)
                            {
                                LightSourceLabel.Text += "Flash";
                            }
                            else if (lightSource == 9)
                            {
                                LightSourceLabel.Text += "Fine Weather";
                            }
                            else if (lightSource == 10)
                            {
                                LightSourceLabel.Text += "Cloudy";
                            }
                            else if (lightSource == 11)
                            {
                                LightSourceLabel.Text += "Shade";
                            }
                            else if (lightSource == 12)
                            {
                                LightSourceLabel.Text += "Daylight Fluorescent";
                            }
                            else if (lightSource == 13)
                            {
                                LightSourceLabel.Text += "Day White Fluorescent";
                            }
                            else if (lightSource == 14)
                            {
                                LightSourceLabel.Text += "Cool White Fluorescent";
                            }
                            else if (lightSource == 15)
                            {
                                LightSourceLabel.Text += "White Fluorescent";
                            }
                            else if (lightSource == 16)
                            {
                                LightSourceLabel.Text += "Warm White Fluorescent";
                            }
                            else if (lightSource == 17)
                            {
                                LightSourceLabel.Text += "Standard Light A";
                            }
                            else if (lightSource == 18)
                            {
                                LightSourceLabel.Text += "Standard Light B";
                            }
                            else if (lightSource == 19)
                            {
                                LightSourceLabel.Text += "Standard Light C";
                            }
                            else if (lightSource == 20)
                            {
                                LightSourceLabel.Text += "D55";
                            }
                            else if (lightSource == 21)
                            {
                                LightSourceLabel.Text += "D65";
                            }
                            else if (lightSource == 22)
                            {
                                LightSourceLabel.Text += "D75";
                            }
                            else if (lightSource == 23)
                            {
                                LightSourceLabel.Text += "D50";
                            }
                            else if (lightSource == 24)
                            {
                                LightSourceLabel.Text += "ISO Studio Tungsten";
                            }
                            else if (lightSource == 255)
                            {
                                LightSourceLabel.Text += "Other";
                            }
                        }
                        else
                        {
                            LightSourceLabel.Text = "Light Source: No data";
                        }
                    }
                    catch
                    {
                        if (reader.GetTagValue<object>(ExifTags.LightSource, out lightSourceObject))
                        {
                            int lso = int.Parse(lightSourceObject.ToString());

                            LightSourceLabel.Text = "Light Source: ";
                            if (lso == 0)
                            {
                                LightSourceLabel.Text += "Unknown";
                            }
                            else if (lso == 1)
                            {
                                LightSourceLabel.Text += "Daylight";
                            }
                            else if (lso == 2)
                            {
                                LightSourceLabel.Text += "Fluorescent";
                            }
                            else if (lso == 3)
                            {
                                LightSourceLabel.Text += "Tungsten (Incandescent)";
                            }
                            else if (lso == 4)
                            {
                                LightSourceLabel.Text += "Flash";
                            }
                            else if (lso == 9)
                            {
                                LightSourceLabel.Text += "Fine Weather";
                            }
                            else if (lso == 10)
                            {
                                LightSourceLabel.Text += "Cloudy";
                            }
                            else if (lso == 11)
                            {
                                LightSourceLabel.Text += "Shade";
                            }
                            else if (lso == 12)
                            {
                                LightSourceLabel.Text += "Daylight Fluorescent";
                            }
                            else if (lso == 13)
                            {
                                LightSourceLabel.Text += "Day White Fluorescent";
                            }
                            else if (lso == 14)
                            {
                                LightSourceLabel.Text += "Cool White Fluorescent";
                            }
                            else if (lso == 15)
                            {
                                LightSourceLabel.Text += "White Fluorescent";
                            }
                            else if (lso == 16)
                            {
                                LightSourceLabel.Text += "Warm White Fluorescent";
                            }
                            else if (lso == 17)
                            {
                                LightSourceLabel.Text += "Standard Light A";
                            }
                            else if (lso == 18)
                            {
                                LightSourceLabel.Text += "Standard Light B";
                            }
                            else if (lso == 19)
                            {
                                LightSourceLabel.Text += "Standard Light C";
                            }
                            else if (lso == 20)
                            {
                                LightSourceLabel.Text += "D55";
                            }
                            else if (lso == 21)
                            {
                                LightSourceLabel.Text += "D65";
                            }
                            else if (lso == 22)
                            {
                                LightSourceLabel.Text += "D75";
                            }
                            else if (lso == 23)
                            {
                                LightSourceLabel.Text += "D50";
                            }
                            else if (lso == 24)
                            {
                                LightSourceLabel.Text += "ISO Studio Tungsten";
                            }
                            else if (lso == 255)
                            {
                                LightSourceLabel.Text += "Other";
                            }
                        }
                        else
                        {
                            LightSourceLabel.Text = "Light Source: No data";
                        }

                    }

                    if (reader.GetTagValue<object>(ExifTags.MakerNote, out makerNote))
                    {
                        MakerNoteLabel.Text = "Maker Note: " + makerNote.ToString();
                    }
                    else
                    {
                        MakerNoteLabel.Text = "Maker Note: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.MaxApertureValue, out maxApertureValue))
                    {
                        MaxApertureValueLabel.Text = "Max Aperture Value: " + maxApertureValue.ToString();
                    }
                    else
                    {
                        MaxApertureValueLabel.Text = "Max Aperture Value: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.MeteringMode, out meteringMode))
                    {
                        MeteringModeLabel.Text = "Metering Mode: ";
                        if (meteringMode == 0)
                        {
                            MeteringModeLabel.Text += "Unknown";
                        }
                        else if (meteringMode == 1)
                        {
                            MeteringModeLabel.Text += "Average";
                        }
                        else if (meteringMode == 2)
                        {
                            MeteringModeLabel.Text += "Center-weighted average";
                        }
                        else if (meteringMode == 3)
                        {
                            MeteringModeLabel.Text += "Spot";
                        }
                        else if (meteringMode == 4)
                        {
                            MeteringModeLabel.Text += "Multi-spot";
                        }
                        else if (meteringMode == 5)
                        {
                            MeteringModeLabel.Text += "Multi-segment";
                        }
                        else if (meteringMode == 6)
                        {
                            MeteringModeLabel.Text += "Partial";
                        }
                        else if (meteringMode == 255)
                        {
                            MeteringModeLabel.Text += "Other";
                        }
                    }
                    else
                    {
                        MeteringModeLabel.Text = "Metering Mode: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.OECF, out oECF))
                    {
                        OECFLabel.Text = "OECF: " + oECF.ToString();
                    }
                    else
                    {
                        OECFLabel.Text = "OECF: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.Orientation, out orientation))
                    {
                        OrientationLabel.Text = "Orientation: ";
                        if (orientation == 1)
                        {
                            OrientationLabel.Text += "Horizontal (normal)";
                        }
                        else if (orientation == 2)
                        {
                            OrientationLabel.Text += "Mirror horizontal";
                        }
                        else if (orientation == 3)
                        {
                            OrientationLabel.Text += "Rotate 180";
                        }
                        else if (orientation == 4)
                        {
                            OrientationLabel.Text += "Mirror vertical";
                        }
                        else if (orientation == 5)
                        {
                            OrientationLabel.Text += "Mirror horizontal and rotate 270 CW";
                        }
                        else if (orientation == 6)
                        {
                            OrientationLabel.Text += "Rotate 90 CW";
                        }
                        else if (orientation == 7)
                        {
                            OrientationLabel.Text += "Mirror horizontal and rotate 90 CW";
                        }
                        else if (orientation == 8)
                        {
                            OrientationLabel.Text += "Rotate 270 CW";
                        }
                    }
                    else
                    {
                        OrientationLabel.Text = "Orientation: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.PhotographicSensitivity, out photographicSensitivity))
                    {
                        PhotographicSensitivityLabel.Text = "Photographic Sensitivity: " + photographicSensitivity.ToString();
                    }
                    else
                    {
                        PhotographicSensitivityLabel.Text = "Photographic Sensitivity: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.PhotometricInterpretation, out photometricInterpretation))
                    {
                        PhotometricInterpretationLabel.Text = "Photometric Interpretation: ";
                        if (photometricInterpretation == 0)
                        {
                            PhotometricInterpretationLabel.Text += "WhiteIsZero";
                        }
                        else if (photometricInterpretation == 1)
                        {
                            PhotometricInterpretationLabel.Text += "BlackIsZero";
                        }
                        else if (photometricInterpretation == 2)
                        {
                            PhotometricInterpretationLabel.Text += "RGB";
                        }
                        else if (photometricInterpretation == 3)
                        {
                            PhotometricInterpretationLabel.Text += "RGB Palette";
                        }
                        else if (photometricInterpretation == 4)
                        {
                            PhotometricInterpretationLabel.Text += "Transparency Mask";
                        }
                        else if (photometricInterpretation == 5)
                        {
                            PhotometricInterpretationLabel.Text += "CMYK";
                        }
                        else if (photometricInterpretation == 6)
                        {
                            PhotometricInterpretationLabel.Text += "YCbCr";
                        }
                        else if (photometricInterpretation == 8)
                        {
                            PhotometricInterpretationLabel.Text += "CIELab";
                        }
                        else if (photometricInterpretation == 9)
                        {
                            PhotometricInterpretationLabel.Text += "ICCLab";
                        }
                        else if (photometricInterpretation == 10)
                        {
                            PhotometricInterpretationLabel.Text += "ITULab";
                        }
                        else if (photometricInterpretation == 32803)
                        {
                            PhotometricInterpretationLabel.Text += "Color Filter Array";
                        }
                        else if (photometricInterpretation == 32844)
                        {
                            PhotometricInterpretationLabel.Text += "Pixar LogL";
                        }
                        else if (photometricInterpretation == 32845)
                        {
                            PhotometricInterpretationLabel.Text += "Pixar LogLuv";
                        }
                        else if (photometricInterpretation == 32892)
                        {
                            PhotometricInterpretationLabel.Text += "Sequential Color Filter";
                        }
                        else if (photometricInterpretation == 34892)
                        {
                            PhotometricInterpretationLabel.Text += "Linear Raw";
                        }
                        else if (photometricInterpretation == 51177)
                        {
                            PhotometricInterpretationLabel.Text += "Depth Map";
                        }
                    }
                    else
                    {
                        PhotometricInterpretationLabel.Text = "Photometric Interpretation: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.PlanarConfiguration, out planarConfiguration))
                    {
                        PlanarConfigurationLabel.Text = "Planar Configuration: ";
                        if (planarConfiguration == 1)
                        {
                            PlanarConfigurationLabel.Text += "Chunky";
                        }
                        else if (planarConfiguration == 2)
                        {
                            PlanarConfigurationLabel.Text += "Planar";
                        }
                    }
                    else
                    {
                        PlanarConfigurationLabel.Text = "Planar Configuration: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.PrimaryChromaticities, out primaryChromaticities))
                    {
                        PrimaryChromaticitiesLabel.Text = "Primary Chromaticities: ";
                        for (int i = 0; i < primaryChromaticities.Length; i++)
                        {
                            PrimaryChromaticitiesLabel.Text += primaryChromaticities[i];
                            PrimaryChromaticitiesLabel.Text += " ";
                        }
                    }
                    else
                    {
                        PrimaryChromaticitiesLabel.Text = "Primary Chromaticities: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.RecommendedExposureIndex, out recommendedExposureIndex))
                    {
                        RecommendedExposureIndexLabel.Text = "Recommended Exposure Index: " + recommendedExposureIndex.ToString();
                    }
                    else
                    {
                        RecommendedExposureIndexLabel.Text = "Recommended Exposure Index: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.ReferenceBlackWhite, out referenceBlackWhite))
                    {
                        ReferenceBlackWhiteLabel.Text = "Reference Black White: ";
                        for (int i = 0; i < referenceBlackWhite.Length; i++)
                        {
                            ReferenceBlackWhiteLabel.Text += referenceBlackWhite[i];
                            ReferenceBlackWhiteLabel.Text += " ";
                        }
                    }
                    else
                    {
                        ReferenceBlackWhiteLabel.Text = "Reference Black White: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.RelatedSoundFile, out relatedSoundFile))
                    {
                        RelatedSoundFileLabel.Text = "Related Sound File: " + relatedSoundFile.ToString();
                    }
                    else
                    {
                        RelatedSoundFileLabel.Text = "Related Sound File: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.ResolutionUnit, out resolutionUnit))
                    {
                        ResolutionUnitLabel.Text = "Resolution Unit: ";
                        if (resolutionUnit == 1)
                        {
                            ResolutionUnitLabel.Text += "None";
                        }
                        else if (resolutionUnit == 2)
                        {
                            ResolutionUnitLabel.Text += "inches";
                        }
                        else if (resolutionUnit == 3)
                        {
                            ResolutionUnitLabel.Text += "cm";
                        }
                    }
                    else
                    {
                        ResolutionUnitLabel.Text = "Resolution Unit: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.RowsPerStrip, out rowsPerStrip))
                    {
                        RowsPerStripLabel.Text = "Rows Per Strip: " + rowsPerStrip.ToString();
                    }
                    else
                    {
                        RowsPerStripLabel.Text = "Rows Per Strip: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.SamplesPerPixel, out samplesPerPixel))
                    {
                        SamplesPerPixelLabel.Text = "Samples Per Pixel: " + samplesPerPixel.ToString();
                    }
                    else
                    {
                        SamplesPerPixelLabel.Text = "Samples Per Pixel: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.Saturation, out saturation))
                    {
                        SaturationLabel.Text = "Saturation: " + saturation.ToString();
                    }
                    else
                    {
                        SaturationLabel.Text = "Saturation: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.SceneCaptureType, out sceneCaptureType))
                    {
                        SceneCaptureTypeLabel.Text = "Scene Capture Type: ";
                        if (sceneCaptureType == 0)
                        {
                            SceneCaptureTypeLabel.Text += "Standard";
                        }
                        else if (sceneCaptureType == 1)
                        {
                            SceneCaptureTypeLabel.Text += "Landscape";
                        }
                        else if (sceneCaptureType == 2)
                        {
                            SceneCaptureTypeLabel.Text += "Portrait";
                        }
                        else if (sceneCaptureType == 3)
                        {
                            SceneCaptureTypeLabel.Text += "Night";
                        }
                        else if (sceneCaptureType == 4)
                        {
                            SceneCaptureTypeLabel.Text += "Other";
                        }
                    }
                    else
                    {
                        SceneCaptureTypeLabel.Text = "Scene Capture Type: No data";
                    }
                    if (reader.GetTagValue<Byte>(ExifTags.SceneType, out sceneType))
                    {
                        SceneTypeLabel.Text = "Scene Type: " + sceneType.ToString();
                    }
                    else
                    {
                        SceneTypeLabel.Text = "Scene Type: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.SensingMethod, out sensingMethod))
                    {
                        SensingMethodLabel.Text = "Sensing Method: " + sensingMethod.ToString();
                    }
                    else
                    {
                        SensingMethodLabel.Text = "Sensing Method: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.SensitivityType, out sensitivityType))
                    {
                        SensitivityTypeLabel.Text = "Sensitivity Type: " + sensitivityType.ToString();
                    }
                    else
                    {
                        SensitivityTypeLabel.Text = "Sensitivity Type: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.Sharpness, out sharpness))
                    {
                        SharpnessLabel.Text = "Sharpness: ";
                        if (sharpness == 0)
                        {
                            SharpnessLabel.Text += "Normal";
                        }
                        else if (sharpness == 1)
                        {
                            SharpnessLabel.Text += "Soft";
                        }
                        else if (sharpness == 2)
                        {
                            SharpnessLabel.Text += "Hard";
                        }
                    }
                    else
                    {
                        SharpnessLabel.Text = "Sharpness: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.ShutterSpeedValue, out shutterSpeedValue))
                    {
                        ShutterSpeedValueLabel.Text = "Shutter Speed Value: " + shutterSpeedValue.ToString();
                    }
                    else
                    {
                        ShutterSpeedValueLabel.Text = "Shutter Speed Value: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.Software, out software))
                    {
                        SoftwareLabel.Text = "Software: " + software.ToString();
                    }
                    else
                    {
                        SoftwareLabel.Text = "Software: No data";
                    }

                    if (reader.GetTagValue<object>(ExifTags.SpatialFrequencyResponse, out spatialFrequencyResponse))
                    {
                        SpatialFrequencyResponseLabel.Text = "Spatial Frequency Response: " + spatialFrequencyResponse.ToString();
                    }
                    else
                    {
                        SpatialFrequencyResponseLabel.Text = "Spatial Frequency Response: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.SpectralSensitivity, out spectralSensitivity))
                    {
                        SpectralSensitivityLabel.Text = "Spectral Sensitivity: " + spectralSensitivity.ToString();
                    }
                    else
                    {
                        SpectralSensitivityLabel.Text = "Spectral Sensitivity: No data";
                    }
                    if (reader.GetTagValue<UInt32>(ExifTags.StandardOutputSensitivity, out standardOutputSensitivity))
                    {
                        StandardOutputSensitivityLabel.Text = "Standard Output Sensitivity: " + standardOutputSensitivity.ToString();
                    }
                    else
                    {
                        StandardOutputSensitivityLabel.Text = "Standard Output Sensitivity: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.StripByteCounts, out stripByteCounts))
                    {
                        StripByteCountsLabel.Text = "Strip Byte Counts: " + stripByteCounts.ToString();
                    }
                    else
                    {
                        StripByteCountsLabel.Text = "Strip Byte Counts: No data";
                    }

                    if (reader.GetTagValue<object>(ExifTags.StripOffsets, out stripOffsets))
                    {
                        StripOffsetsLabel.Text = "Strip Offsets: " + stripOffsets.ToString();
                    }
                    else
                    {
                        StripOffsetsLabel.Text = "Strip Offsets: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.SubjectArea, out subjectArea))
                    {
                        SubjectAreaLabel.Text = "Subject Area: ";
                        for (int i = 0; i < subjectArea.Length; i++)
                        {
                            SubjectAreaLabel.Text += subjectArea[i];
                            SubjectAreaLabel.Text += " ";
                        }
                    }
                    else
                    {
                        SubjectAreaLabel.Text = "Subject Area: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.SubjectDistance, out subjectDistance))
                    {
                        SubjectDistanceLabel.Text = "Subject Distance: " + subjectDistance.ToString();
                    }
                    else
                    {
                        SubjectDistanceLabel.Text = "Subject Distance: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.SubjectDistanceRange, out subjectDistanceRange))
                    {
                        SubjectDistanceRangeLabel.Text = "Subject Distance Range: ";
                        if (subjectDistanceRange == 0)
                        {
                            SubjectDistanceRangeLabel.Text += "Unknown";
                        }
                        if (subjectDistanceRange == 1)
                        {
                            SubjectDistanceRangeLabel.Text += "Macro";
                        }
                        if (subjectDistanceRange == 2)
                        {
                            SubjectDistanceRangeLabel.Text += "Close";
                        }
                        if (subjectDistanceRange == 3)
                        {
                            SubjectDistanceRangeLabel.Text += "Distant";
                        }
                    }
                    else
                    {
                        SubjectDistanceRangeLabel.Text = "Subject Distance Range: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.SubjectLocation, out subjectLocation))
                    {
                        SubjectLocationLabel.Text = "Subject Location: ";
                        for (int i = 0; i < subjectLocation.Length; i++)
                        {
                            SubjectLocationLabel.Text += subjectLocation[i];
                            SubjectLocationLabel.Text += " ";
                        }
                    }
                    else
                    {
                        SubjectLocationLabel.Text = "Subject Location: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.SubsecTime, out subsecTime))
                    {
                        SubsecTimeLabel.Text = "Subsec Time: " + subsecTime.ToString();
                    }
                    else
                    {
                        SubsecTimeLabel.Text = "Subsec Time: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.SubsecTimeDigitized, out subsecTimeDigitized))
                    {
                        SubsecTimeDigitizedLabel.Text = "Subsec Time Digitized: " + subsecTimeDigitized.ToString();
                    }
                    else
                    {
                        SubsecTimeDigitizedLabel.Text = "Subsec Time Digitized: No data";
                    }
                    if (reader.GetTagValue<String>(ExifTags.SubsecTimeOriginal, out subsecTimeOriginal))
                    {
                        SubsecTimeOriginalLabel.Text = "Subsec Time Original: " + subsecTimeOriginal.ToString();
                    }
                    else
                    {
                        SubsecTimeOriginalLabel.Text = "Subsec Time Original: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.TransferFunction, out transferFunction))
                    {
                        TransferFunctionLabel.Text = "Transfer Function: ";
                        for (int i = 0; i < transferFunction.Length; i++)
                        {
                            TransferFunctionLabel.Text += transferFunction[i];
                            TransferFunctionLabel.Text += " ";
                        }
                    }
                    else
                    {
                        TransferFunctionLabel.Text = "Transfer Function: No data";
                    }
                    if (reader.GetTagValue<object>(ExifTags.UserComment, out userComment))
                    {
                        UserCommentLabel.Text = "User Comment: " + userComment.ToString();
                    }
                    else
                    {
                        UserCommentLabel.Text = "User Comment: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.WhiteBalance, out whiteBalance))
                    {
                        WhiteBalanceLabel.Text = "White Balance: ";
                        if (whiteBalance == 0)
                        {
                            WhiteBalanceLabel.Text += "Auto";
                        }
                        else if (whiteBalance == 1)
                        {
                            WhiteBalanceLabel.Text += "Manual";
                        }
                    }
                    else
                    {
                        WhiteBalanceLabel.Text = "White Balance: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.WhitePoint, out whitePoint))
                    {
                        WhitePointLabel.Text = "White Point: ";
                        for (int i = 0; i < whitePoint.Length; i++)
                        {
                            WhitePointLabel.Text += whitePoint[i];
                            WhitePointLabel.Text += " ";
                        }
                    }
                    else
                    {
                        WhitePointLabel.Text = "White Point: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.XPAuthor, out xPAuthor))
                    {
                        XPAuthorLabel.Text = "XP Author: " + xPAuthor.ToString();
                    }
                    else
                    {
                        XPAuthorLabel.Text = "XP Author: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.XPComment, out xPComment))
                    {
                        XPCommentLabel.Text = "XP Comment: " + xPComment.ToString();
                    }
                    else
                    {
                        XPCommentLabel.Text = "XP Comment: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.XPKeywords, out xPKeywords))
                    {
                        XPKeywordsLabel.Text = "XP Keywords: " + xPKeywords.ToString();
                    }
                    else
                    {
                        XPKeywordsLabel.Text = "XP Keywords: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.XPSubject, out xPSubject))
                    {
                        XPSubjectLabel.Text = "XP Subject: " + xPSubject.ToString();
                    }
                    else
                    {
                        XPSubjectLabel.Text = "XP Subject: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.XPTitle, out xPTitle))
                    {
                        XPTitleLabel.Text = "XP Title: " + xPTitle.ToString();
                    }
                    else
                    {
                        XPTitleLabel.Text = "XP Title: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.XResolution, out xResolution))
                    {
                        XResolutionLabel.Text = "X Resolution: " + xResolution.ToString();
                    }
                    else
                    {
                        XResolutionLabel.Text = "X Resolution: No data";
                    }
                    if (reader.GetTagValue<Double>(ExifTags.YResolution, out yResolution))
                    {
                        YResolutionLabel.Text = "Y Resolution: " + yResolution.ToString();
                    }
                    else
                    {
                        YResolutionLabel.Text = "Y Resolution: No data";
                    }
                    if (reader.GetTagValue<Double[]>(ExifTags.YCbCrCoefficients, out yCbCrCoefficients))
                    {
                        YCbCrCoefficientsLabel.Text = "YCbCr Coefficients: ";
                        for (int i = 0; i < yCbCrCoefficients.Length; i++)
                        {
                            YCbCrCoefficientsLabel.Text += yCbCrCoefficients[i];
                            YCbCrCoefficientsLabel.Text += " ";
                        }
                    }
                    else
                    {
                        YCbCrCoefficientsLabel.Text = "YCbCr Coefficients: No data";
                    }
                    if (reader.GetTagValue<UInt16>(ExifTags.YCbCrPositioning, out yCbCrPositioning))
                    {
                        YCbCrPositioningLabel.Text = "YCbCr Positioning: ";
                        if (yCbCrPositioning == 1)
                        {
                            YCbCrPositioningLabel.Text += "Centered";
                        }
                        else if (yCbCrPositioning == 2)
                        {
                            YCbCrPositioningLabel.Text += "Co-sited";
                        }
                    }
                    else
                    {
                        YCbCrPositioningLabel.Text = "YCbCr Positioning: No data";
                    }
                    if (reader.GetTagValue<UInt16[]>(ExifTags.YCbCrSubSampling, out yCbCrSubSampling))
                    {
                        YCbCrSubSamplingLabel.Text = "YCbCr SubSampling: ";
                        if (yCbCrSubSampling[0] == 1)
                        {
                            if (yCbCrSubSampling[1] == 1)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:4:4 (1 1)";
                            }
                            if (yCbCrSubSampling[1] == 2)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:4:0 (1 2)";
                            }
                            if (yCbCrSubSampling[1] == 4)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:4:1 (1 4)";
                            }
                        }
                        else if (yCbCrSubSampling[0] == 2)
                        {
                            if (yCbCrSubSampling[1] == 1)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:2:2 (2 1)	";
                            }
                            if (yCbCrSubSampling[1] == 2)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:2:0 (2 2)";
                            }
                            if (yCbCrSubSampling[1] == 4)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:2:1 (2 4)";
                            }
                        }
                        else if (yCbCrSubSampling[0] == 4)
                        {
                            if (yCbCrSubSampling[1] == 1)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:1:1 (4 1)";
                            }
                            if (yCbCrSubSampling[1] == 2)
                            {
                                YCbCrSubSamplingLabel.Text += "YCbCr4:1:0 (4 2)";
                            }
                        }
                    }
                    else
                    {
                        YCbCrSubSamplingLabel.Text = "YCbCr SubSampling: No data";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The program has encountered a problem. Unable to read EXIF\n" + ex);
                }
            }
        }

        private void GoogleMapsButton_Click(object sender, EventArgs e)
        {
            MainWindow myParent = (MainWindow)this.Parent.Parent;

            bool isOk = false;
            if (myParent.fileName != "None")
            {
                try
                {
                    ExifReader testreader = new ExifReader(myParent.fileName);
                    isOk = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid File");

                }

            }
            else
            {
                MessageBox.Show("Please select file");
            }

            if (isOk)
            {
                ExifReader reader = new ExifReader(myParent.fileName);
                Double[] gPSLatitude, gPSLongitude;
                String gPSLatitudeRef, gPSLongitudeRef;
                string link = String.Empty;
                if (reader.GetTagValue<Double[]>(ExifTags.GPSLatitude, out gPSLatitude) && reader.GetTagValue<String>(ExifTags.GPSLatitudeRef, out gPSLatitudeRef) && reader.GetTagValue<Double[]>(ExifTags.GPSLongitude, out gPSLongitude) && reader.GetTagValue<String>(ExifTags.GPSLongitudeRef, out gPSLongitudeRef))
                {
                    string lach = gpsReplace(gPSLatitude[2]);
                    string loch = gpsReplace(gPSLongitude[2]);

                    link = "https://www.google.pl/maps/place/" + gPSLatitude[0] + "°" + gPSLatitude[1] + "'" + lach + "\"" + gPSLatitudeRef + "+" + gPSLongitude[0] + "°" + gPSLongitude[1] + "'" + loch + "\"" + gPSLongitudeRef;



                    System.Diagnostics.Process.Start(link);
                }
                else
                {
                    MessageBox.Show("Not enough data to open via Google Maps");
                }
            }
        }
        static string gpsReplace(double x)
        {
            double y = 0;
            y = Math.Floor(x * 10 + 0.5) / 10;
            return y.ToString().Replace(",", ".");
        }
        private void clearLabelsButton_Click(object sender, EventArgs e)
        {


            Size size = Size;

            this.ModelLabel.Dispose();
            this.DateTimeLabel.Dispose();
            this.LensModelLabel.Dispose();
            this.LensMakeLabel.Dispose();
            this.LensSerialNumberLabel.Dispose();
            this.LensSpecificationLabel.Dispose();
            this.ImageWidthLabel.Dispose();
            this.ImageLengthLabel.Dispose();
            this.GPSAltitudeLabel.Dispose();
            this.GPSAreaInformationLabel.Dispose();
            this.GPSDateStampLabel.Dispose();
            this.GPSDestBearingLabel.Dispose();
            this.GPSDestBearingRefLabel.Dispose();
            this.GPSDestDistanceLabel.Dispose();
            this.GPSDestDistanceRefLabel.Dispose();
            this.GPSDestLatitudeLabel.Dispose();
            this.GPSDestLatitudeRefLabel.Dispose();
            this.GPSDestLongitudeLabel.Dispose();
            this.GPSDestLongitudeRefLabel.Dispose();
            this.GPSDifferentialLabel.Dispose();
            this.GPSDOPLabel.Dispose();
            this.GPSHPositioningErrorLabel.Dispose();
            this.GPSImgDirectionLabel.Dispose();
            this.GPSImgDirectionRefLabel.Dispose();
            this.GPSMapDatumLabel.Dispose();
            this.GPSMeasureModeLabel.Dispose();
            this.GPSProcessingMethodLabel.Dispose();
            this.GPSSatellitesLabel.Dispose();
            this.GPSSpeedLabel.Dispose();
            this.GPSSpeedRefLabel.Dispose();
            this.GPSStatusLabel.Dispose();
            this.GPSTimestampLabel.Dispose();
            this.GPSTrackLabel.Dispose();
            this.GPSTrackRefLabel.Dispose();
            this.GPSVersionIDLabel.Dispose();
            this.ApertureValueLabel.Dispose();
            this.ArtistLabel.Dispose();
            this.BitsPerSampleLabel.Dispose();
            this.BodySerialNumberLabel.Dispose();
            this.BrightnessValueLabel.Dispose();
            this.CameraOwnerNameLabel.Dispose();
            this.CFAPatternLabel.Dispose();
            this.ColorSpaceLabel.Dispose();
            this.ComponentsConfigurationLabel.Dispose();
            this.CompressedBitsPerPixelLabel.Dispose();
            this.ContrastLabel.Dispose();
            this.CopyrightLabel.Dispose();
            this.CustomRenderedLabel.Dispose();
            this.DateTimeDigitizedLabel.Dispose();
            this.DateTimeOriginalLabel.Dispose();
            this.DeviceSettingDescriptionLabel.Dispose();
            this.DigitalZoomRatioLabel.Dispose();
            this.ExifVersionLabel.Dispose();
            this.ExposureBiasValueLabel.Dispose();
            this.ExposureIndexLabel.Dispose();
            this.ExposureModeLabel.Dispose();
            this.ExposureProgramLabel.Dispose();
            this.ExposureTimeLabel.Dispose();
            this.FileSourceLabel.Dispose();
            this.FlashLabel.Dispose();
            this.FlashEnergyLabel.Dispose();
            this.FlashpixVersionLabel.Dispose();
            this.FNumberLabel.Dispose();
            this.FocalLengthLabel.Dispose();
            this.FocalLengthIn35mmFilmLabel.Dispose();
            this.FocalPlaneResolutionUnitLabel.Dispose();
            this.FocalPlaneXResolutionLabel.Dispose();
            this.FocalPlaneYResolutionLabel.Dispose();
            this.GainControlLabel.Dispose();
            this.ImageDescriptionLabel.Dispose();
            this.ImageUniqueIDLabel.Dispose();
            this.ISOSpeedLabel.Dispose();
            this.ISOSpeedLatitudeyyyLabel.Dispose();
            this.ISOSpeedLatitudezzzLabel.Dispose();
            this.JPEGInterchangeFormatLabel.Dispose();
            this.JPEGInterchangeFormatLengthLabel.Dispose();
            this.LightSourceLabel.Dispose();
            this.MakerNoteLabel.Dispose();
            this.MaxApertureValueLabel.Dispose();
            this.MeteringModeLabel.Dispose();
            this.OECFLabel.Dispose();
            this.OrientationLabel.Dispose();
            this.PhotographicSensitivityLabel.Dispose();
            this.PhotometricInterpretationLabel.Dispose();
            this.ISOSpeedRatingsLabel.Dispose();
            this.PlanarConfigurationLabel.Dispose();
            this.PrimaryChromaticitiesLabel.Dispose();
            this.RecommendedExposureIndexLabel.Dispose();
            this.ReferenceBlackWhiteLabel.Dispose();
            this.RelatedSoundFileLabel.Dispose();
            this.ResolutionUnitLabel.Dispose();
            this.RowsPerStripLabel.Dispose();
            this.SamplesPerPixelLabel.Dispose();
            this.SaturationLabel.Dispose();
            this.SceneCaptureTypeLabel.Dispose();
            this.SceneTypeLabel.Dispose();
            this.SensingMethodLabel.Dispose();
            this.SensitivityTypeLabel.Dispose();
            this.SharpnessLabel.Dispose();
            this.ShutterSpeedValueLabel.Dispose();
            this.SoftwareLabel.Dispose();
            this.SpatialFrequencyResponseLabel.Dispose();
            this.SpectralSensitivityLabel.Dispose();
            this.StandardOutputSensitivityLabel.Dispose();
            this.StripByteCountsLabel.Dispose();
            this.SubjectAreaLabel.Dispose();
            this.SubjectDistanceLabel.Dispose();
            this.SubjectDistanceRangeLabel.Dispose();
            this.SubjectLocationLabel.Dispose();
            this.SubsecTimeLabel.Dispose();
            this.StripOffsetsLabel.Dispose();
            this.SubsecTimeDigitizedLabel.Dispose();
            this.SubsecTimeOriginalLabel.Dispose();
            this.TransferFunctionLabel.Dispose();
            this.UserCommentLabel.Dispose();
            this.WhiteBalanceLabel.Dispose();
            this.WhitePointLabel.Dispose();
            this.XPAuthorLabel.Dispose();
            this.XPCommentLabel.Dispose();
            this.XPKeywordsLabel.Dispose();
            this.XPSubjectLabel.Dispose();
            this.XPTitleLabel.Dispose();
            this.XResolutionLabel.Dispose();
            this.YResolutionLabel.Dispose();
            this.YCbCrCoefficientsLabel.Dispose();
            this.YCbCrPositioningLabel.Dispose();
            this.YCbCrSubSamplingLabel.Dispose();
            this.BasicInfo.Dispose();
            this.GPSLocationLabel.Dispose();
            this.FileLabel.Dispose();
            InitializeComponent();
            Size = size;

        }
    }
}