using System.Windows.Data;

namespace PatientRecordMVVM.Utilities
{
    public class LocalizationExtension : Binding
    {
        public LocalizationExtension() { }

        public LocalizationExtension(string name) : base("[" + name + "]")
        {
            this.Mode = BindingMode.OneWay;
            this.Source = LanguageTransalationUtility.TransalationUtility;
        }       
    }
}
