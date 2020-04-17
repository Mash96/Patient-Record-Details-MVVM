using System;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PatientRecordMVVM.Utilities
{
    static class PrintUtility
    {
        #region Fields
        private static PrintDialog m_printDialog;
        private static PrintCapabilities m_printCapabilities;
        #endregion

        #region Constructors
        static PrintUtility()
        {
            m_printDialog = new PrintDialog();
        }
        #endregion

        #region Members
        public static PrintDialog DefaultPrintAdjustments()
        {
            PrintQueue printQueue = new LocalPrintServer().DefaultPrintQueue;
            m_printCapabilities = printQueue.GetPrintCapabilities();
            m_printDialog.PrintQueue = printQueue;
            return m_printDialog;           
        }

        public static PrintDialog ConfigureAndPrintAdjustments()
        {
            if (m_printDialog.ShowDialog() == true)
            {
                m_printCapabilities = m_printDialog.PrintQueue.GetPrintCapabilities(m_printDialog.PrintTicket);
                return m_printDialog;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Handlers: Members
        private static void AdjustPrinterScalesAndPrint(Visual visual)
        {
            FrameworkElement frameworkElement = visual as FrameworkElement;

            Transform originalScale = frameworkElement.LayoutTransform;
            Size originalSize = new Size(frameworkElement.ActualWidth, frameworkElement.ActualHeight);

            // get the scale of the printer with respect to the visual
            double scale = Math.Min(m_printCapabilities.PageImageableArea.ExtentWidth / originalSize.Width, m_printCapabilities.PageImageableArea.ExtentHeight / originalSize.Height);

            if (scale > 1.0)
            {
                // keep the original size and layout if printable area is greater than the object being printed
                scale = 1.0;
            }

            // transform the visual into calculated scale
            frameworkElement.LayoutTransform = new ScaleTransform(scale, scale);

            // get the size of the printer page
            Size newSize = new Size(m_printCapabilities.PageImageableArea.ExtentWidth, m_printCapabilities.PageImageableArea.ExtentHeight);

            // update the layout of the visual to printer page
            frameworkElement.Measure(newSize);
            frameworkElement.Arrange(new Rect(new Point(m_printCapabilities.PageImageableArea.OriginWidth, m_printCapabilities.PageImageableArea.OriginHeight), newSize));

            // print the visual
            m_printDialog.PrintVisual(frameworkElement as Visual, "PrintPreview");

            // apply the original transform
            frameworkElement.LayoutTransform = originalScale;
            //frameworkElement.Measure(originalSize);
            //frameworkElement.Arrange(new Rect(new Point(0, 0), oldSize));
        }
        #endregion
    }
}
