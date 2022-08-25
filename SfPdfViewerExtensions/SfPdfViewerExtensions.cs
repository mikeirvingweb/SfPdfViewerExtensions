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
            try
            {
                return PageSize(sfPdfViewer, page).Width;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public static int PageHeight(this SfPdfViewer sfPdfViewer, int page)
        {
            try
            {
                return PageSize(sfPdfViewer, page).Height;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static bool PageIsLandscape(this SfPdfViewer sfPdfViewer, int page)
        {
            try
            {
                var pageSize = PageSize(sfPdfViewer, page);

                return pageSize.Width > pageSize.Height;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool PageIsPortrait(this SfPdfViewer sfPdfViewer, int page)
        {
            try
            {
                var pageSize = PageSize(sfPdfViewer, page);

                return pageSize.Height > pageSize.Width;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
