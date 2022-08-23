using Syncfusion.Drawing;
using Syncfusion.SfPdfViewer.XForms;

namespace SfPdfViewerExtensions
{
    public static class SfPdfViewerExtensions
    {
        public static Size PageSize(this SfPdfViewer sfPdfViewer, int page)
        {
            return new Syncfusion.Drawing.Image(sfPdfViewer.ExportAsImage(page - 1)).Size;
        }

        public static int PageWidth(this SfPdfViewer sfPdfViewer, int page)
        {
            return PageSize(sfPdfViewer, page).Width;
        }

        public static int PageHeight(this SfPdfViewer sfPdfViewer, int page)
        {
            return PageSize(sfPdfViewer, page).Height;
        }

        public static bool PageIsLandscape(this SfPdfViewer sfPdfViewer, int page)
        {
            var pageSize = PageSize(sfPdfViewer, page);

            return pageSize.Width > pageSize.Height;
        }

        public static bool PageIsPortrait(this SfPdfViewer sfPdfViewer, int page)
        {
            var pageSize = PageSize(sfPdfViewer, page);

            return pageSize.Height > pageSize.Width;
        }
    }
}
