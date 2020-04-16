using PatientRecordMVVM.Model;
using PatientRecordMVVM.Views;
using PatientRecordMVVM.ViewModel;
using System;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PatientRecordMVVM.Utilities
{
    class PrintUtility
    {
        public static void DefaultPrintPatientDetails(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);

            PrintDialog printDialog = new PrintDialog();
            PrintQueue printQueue = new LocalPrintServer().GetPrintQueue("Microsoft Print To PDF");
            PrintCapabilities printCapabilities = printQueue.GetPrintCapabilities();
            printDialog.PrintQueue = printQueue;

            Transform originalScale = printPreview.LayoutTransform;
            // get the scale of the printer with respect to the visual
            double scale = Math.Min(printCapabilities.PageImageableArea.ExtentWidth / printPreview.ActualWidth, printCapabilities.PageImageableArea.ExtentHeight / printPreview.ActualHeight);

            // transform the visual into calculated scale
            printPreview.LayoutTransform = new ScaleTransform(scale, scale);

            // get the size of the printer page
            Size size = new Size(printCapabilities.PageImageableArea.ExtentWidth, printCapabilities.PageImageableArea.ExtentHeight);

            // update the layout of the visual to printer page
            printPreview.Measure(size);
            printPreview.Arrange(new Rect(new Point(printCapabilities.PageImageableArea.OriginWidth, printCapabilities.PageImageableArea.OriginHeight), size));

            // print the visual
            printDialog.PrintVisual(printPreview.MainSubGrid, "PrintPreview");

            // apply the original transform
            printPreview.LayoutTransform = originalScale;
        }

        public static void ConfigureAndPrintPatientDetails(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);

            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                Transform originalScale = printPreview.LayoutTransform;

                // get the capabilities of selected printer
                PrintCapabilities printCapabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);

                // get the scale of the printer with respect to the visual
                double scale = Math.Min(printCapabilities.PageImageableArea.ExtentWidth / printPreview.ActualWidth, printCapabilities.PageImageableArea.ExtentHeight / printPreview.ActualHeight);

                // transform the visual into calculated scale
                printPreview.LayoutTransform = new ScaleTransform(scale, scale);

                // get the size of the printer page
                Size size = new Size(printCapabilities.PageImageableArea.ExtentWidth, printCapabilities.PageImageableArea.ExtentHeight);

                // update the layout of the visual to printer page
                printPreview.Measure(size);
                printPreview.Arrange(new Rect(new Point(printCapabilities.PageImageableArea.OriginWidth, printCapabilities.PageImageableArea.OriginHeight), size));

                // print the visual
                printDialog.PrintVisual(printPreview.MainSubGrid, "PrintPreview");

                // apply the original transform
                printPreview.LayoutTransform = originalScale;
            }        
        }
    }
}
