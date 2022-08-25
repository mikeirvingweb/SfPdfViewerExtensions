## SfPdfViewer Extensions

Useful Extensions for **Syncfusion Xamarin.Forms PDF Viewer Component (SfPdfViewer)**, to get the size and orientation of the PDF, per page.

Written to address shortcomings in the core functionality of [SfPdfViewer](https://www.nuget.org/packages/Syncfusion.Xamarin.SfPdfViewer).

Feel free to contribute to the Source Code at: https://github.com/mikeirvingweb/SfPdfViewerExtensions

**Examples**


	using SfPdfViewerExtensions;
	using Syncfusion.Drawing;
	using Syncfusion.SfPdfViewer.XForms;

	SfPdfViewer sfPdfViewer = new SfPdfViewer();
    
    /* 
        your code here,
        load your PDF etc
    */
    
    // get Size of Page 1. returns Size
    Size pageSize = sfPdfViewer.PageSize(1);
    
    // get Width of Page 1. returns int, returns -1 if an error should occur
    int pageWidth = sfPdfViewer.PageWidth(1);
    
    // get Height of Page 1. returns int, returns -1 if an error should occur
    int pageHeight = sfPdfViewer.PageHeight(1);
    
    // is Page 1 Landscape? returns bool, returns false if an error should occur
    bool pageIsLandscape = sfPdfViewer.PageIsLandscape(1);
    
    // is Page 1 Portrait? returns bool, returns false if an error should occur
    bool pageIsPortrait = sfPdfViewer.PageIsPortrait(1);