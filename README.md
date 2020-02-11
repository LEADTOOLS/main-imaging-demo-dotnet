# LEADTOOLS Main Imaging Demo for .NET Framework

This demo falls under the [license located here.](./LICENSE.md)

Powered by patented artificial intelligence and machine learning algorithms, [LEADTOOLS is a collection of award-winning document, medical, multimedia, and imaging SDKs](https://www.leadtools.com)

This .NET WinForms Demo showcases the [LEADTOOLS Image Processing SDK](https://www.leadtools.com/sdk/image-processing) and allows user to load images and perform various image processing functions, such as:

- Cleanup Images
  - Deskew, Invert, Dot Removal, Line Removal, and Despeckle
- Crop and Merge Images
- Segment, Binarize, and Detect Images
- Viewer Interpolation and Transparency
- Scan in images from scanners that support TWAIN and WIA
- Create and limit image processing functions to regions of interest
- General list of some of the image processing functions available in LEADTOOLS
  - Auto Binarize 
  - Auto Deskew
  - Auto Invert
  - Auto Orient
  - Auto Trim
  - Binary Filter
  - Border Removal
  - Check Deskew
  - Despeckle
  - Dilation Filter
  - Dot Removal
  - Dynamic Binary
  - Erosion Filter
  - Glare Detection
  - High Quality Rotate
  - Hole Punch Removal
  - Inverted Text Detection and Correction
  - Line Removal
  - Perspective Deskew (Automatic and Manual)
  - Rake Removal
  - Smooth Document
  - Text Blur Detection
  - Auto Binary
  - Auto zoning to detect text paragraphs, images, and table data, including rows and columns
  - Automatic Image Segmentation for Compression and Recognition
  - Binary Segmentation
  - Color Threshold
  - Dynamic Binary Segmentation
  - Select Data
  - Subtract Background
  - Water Shed/Magic Wand
  - Add, Subtract, and Combine Images
  - Adjust Brightness and Contrast
  - Artistic Effects
  - Color and Bit-Depth Expansion and Reduction
  - Color Correction
  - Color Space Conversion
  - Digital Paint
  - Edge Detection, Line Detection, and Image Sharpening
  - Geometric Transformation
  - Image Enhancement
  - Image Segmentation
  - Manipulate Image Bits
  - Noise Reduction and Smoothing
  - Statistical Information

With this demo, you can load any of the [150+ supported file formats](https://www.leadtools.com/sdk/formats) into the [`ImageViewer`](https://www.leadtools.com/help/leadtools/v20/dh/c/imageviewer.html). You can test the [LEADTOOLS Image Processing](https://www.leadtools.com/sdk/image-processing) commands and save the processed images.

## Set Up

In order to use any LEADTOOLS functionality, you must have a valid license. You can obtain a fully functional 30-day license [from our website](https://www.leadtools.com/downloads).

Locate the `RasterSupport.SetLicense(licenseFilePath, developerKey);` line in the application and modify the code to point to use your new license and key.

Open the csproj file in Visual Studio. Build the project to restore the [LEADTOOLS NuGet packages](https://www.leadtools.com/downloads/nuget).

## Use

To view documents with the Main Demo simply open the file you want to view in the file open menu. Many image processing functions are included in the various toolbar menus to apply to the image. You can then save out the image using the Save menu item.

## Resources

Website: <https://www.leadtools.com/>

Download Full Evaluation: <https://www.leadtools.com/downloads>

Documentation: <https://www.leadtools.com/help/leadtools/v20/dh/to/introduction.html>

Technical Support: <https://www.leadtools.com/support/chat>

[nuget-profile]: https://www.nuget.org/profiles/LEADTOOLS
