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
            
        }
        #endregion
    }
}
