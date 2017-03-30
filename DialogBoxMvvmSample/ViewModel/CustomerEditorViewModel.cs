using System;
using DialogBoxMvvmSample.ViewModel.Common;

namespace DialogBoxMvvmSample.ViewModel
{
    public class CustomerEditorViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public event EventHandler Save;

        public SimpleRelayCommand SaveCommand { get; set; }

        public CustomerEditorViewModel()
        {
            this.SaveCommand = new SimpleRelayCommand(x => this.Save(this, new EventArgs()));
        }

        public void Reset()
        {
            this.FirstName = "";
            this.LastName = "";
        }
    }
}