using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using PatientRecordMVVM.Resources;

namespace PatientRecordMVVM.Utilities
{
    public class LanguageTransalationUtility : INotifyPropertyChanged
    {
        private static readonly LanguageTransalationUtility transalationUtility = new LanguageTransalationUtility();

        public static LanguageTransalationUtility TransalationUtility
        {
            get { return transalationUtility; }
        }

        private readonly ResourceManager resourceManager = UILanguage.ResourceManager;
        private CultureInfo currentCulture = null;

        public string this[string key]
        {
            get { return this.resourceManager.GetString(key, this.currentCulture); }
        }

        public CultureInfo CurrentCulture
        {
            get { return this.currentCulture; }
            set
            {
                if (this.currentCulture != value)
                {
                    this.currentCulture = value;
                    var @event = this.PropertyChanged;
                    if (@event != null)
                    {
                        @event.Invoke(this, new PropertyChangedEventArgs(string.Empty));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
