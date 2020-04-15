using PatientRecordMVVM.View;
using PatientRecordMVVM.ViewModel;
using PatientRecordMVVM.Model;
using System;
using System.Windows.Controls;
using System.Printing;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Documents;
using System.Windows.Media;

namespace PatientRecordMVVM.Services
{
    class WindowService : IWindowService
    {

        public void CreateWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);
            printPreview.Show();
        }

        public string GetCurrentDate()
        {
            DateTime dateTime = DateTime.Now;

            string date = dateTime.ToString("d");
            string time = dateTime.ToString("T");
            string Date_Time = date + " " + time;

            return Date_Time;
        }

        public void PrintWindow(PatientRecordDetailsModel patient)
        {
            PrintPreview printPreview = new PrintPreview();
            printPreview.DataContext = new PrintPreviewViewModel(patient);
            //var doc = printPreview as IDocumentPaginatorSource;
            PrintDialog printDlg = new PrintDialog();

            //PrintQueue ReceiptPrinter = new LocalPrintServer().GetPrintQueue("Microsoft Print To PDF");
            //PrintCapabilities PC = ReceiptPrinter.GetPrintCapabilities();
            //printDlg.PrintQueue = ReceiptPrinter;

            PrintCapabilities printCapabilities = printDlg.PrintQueue.GetPrintCapabilities(printDlg.PrintTicket);
            double scale = Math.Min(printCapabilities.PageImageableArea.ExtentWidth / printPreview.ActualWidth, printCapabilities.PageImageableArea.ExtentHeight / printPreview.ActualHeight);
            printPreview.LayoutTransform = new ScaleTransform(scale, scale);
            Size size = new Size(printCapabilities.PageImageableArea.ExtentWidth, printCapabilities.PageImageableArea.ExtentHeight);
            printPreview.Measure(size);
            printPreview.Arrange(new Rect(new Point(printCapabilities.PageImageableArea.OriginWidth, printCapabilities.PageImageableArea.OriginHeight), size));
            printDlg.PrintVisual(printPreview.MainGrid, "PrintPreview");

        }
    }
}
