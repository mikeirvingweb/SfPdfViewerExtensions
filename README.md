## SfPdfViewer Extensions

Useful Extensions for **Syncfusion Xamarin.Forms PDF Viewer Component (SfPdfViewer)**, to get the size and orientation of the PDF, per page.

Written to address shortcomings in the core functionality of [SfPdfViewer](https://www.nuget.org/packages/Syncfusion.Xamarin.SfPdfViewer).

### Current Extension Properties / Methods

    public static Size PageSize(this SfPdfViewer sfPdfViewer, int page)  
    
    public static int PageWidth(this SfPdfViewer sfPdfViewer, int page)  
    
    public static int PageHeight(this SfPdfViewer sfPdfViewer, int page)  
    
    public static bool PageIsLandscape(this SfPdfViewer sfPdfViewer, int page)  
    
    public static bool PageIsPortrait(this SfPdfViewer sfPdfViewer, int page)

## How to use

📦 Add the [SfPdfViewerExtensions NuGet Package](https://www.nuget.org/packages/SfPdfViewerExtensions) to your C# Solution in [Visual Studio](https://visualstudio.microsoft.com/).

⚒️ Alternatively, clone this repository or take the `SfPdfViewerExtensions.cs` file from it.

✏️ Utilise the Extension Methods.

### Examples

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
    
    // get Width of Page 1. returns int
    int pageWidth = sfPdfViewer.PageWidth(1);
    
    // get Height of Page 1. returns int
    int pageHeight = sfPdfViewer.PageHeight(1);
    
    // is Page 1 Landscape? returns bool
    bool pageIsLandscape = sfPdfViewer.PageIsLandscape(1);
    
    // is Page 1 Portrait? returns bool
    bool pageIsPortrait = sfPdfViewer.PageIsPortrait(1);
    
### Contributions

🍴 Feel free to Fork / Branch / Modify, raise any Pull Requests for changes.
