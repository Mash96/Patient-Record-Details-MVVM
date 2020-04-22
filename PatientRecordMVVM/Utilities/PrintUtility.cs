using System.Printing;
using System.Windows.Controls;

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
            PrintDialog PrintDialog = AdjustPrinterCapabilities();

            return m_printDialog;           
        }

        public static PrintDialog ConfigureAndPrintAdjustments()
        {
            m_printCapabilities = m_printDialog.PrintQueue.GetPrintCapabilities(m_printDialog.PrintTicket);            
            PrintDialog printDialog = AdjustPrinterCapabilities();

            return printDialog;
        }
        #endregion

        #region Handlers: Members
        private static PrintDialog AdjustPrinterCapabilities()
        {
            PrintTicket printTicket = new PrintTicket();
            printTicket.PageOrientation = PageOrientation.Portrait;
            printTicket.PageMediaSize = new PageMediaSize(PageMediaSizeName.ISOA4, 2480, 3508);
            System.Printing.ValidationResult validationResult = m_printDialog.PrintQueue.MergeAndValidatePrintTicket(m_printDialog.PrintTicket, printTicket);
            m_printDialog.PrintTicket = validationResult.ValidatedPrintTicket;
            m_printDialog.PrintQueue.Commit();

            return m_printDialog;
        }
        #endregion
    }
}
