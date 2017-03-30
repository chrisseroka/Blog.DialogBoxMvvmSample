using System;
using System.Collections.ObjectModel;

namespace DialogBoxMvvmSample.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<CustomerItemViewModel> Customers { get; set; }

        public CustomerEditorViewModel CustomerEditorViewModel { get; set; }

        public MainViewModel()
        {
            this.Customers = new ObservableCollection<CustomerItemViewModel>();

            //ViewModel is aware of existence of another ViewModel for editing customer item
            //but it does not need to be a "dialog" - it can be tabPanel, collapsable panel etc
            //the important thing here is that from this ViewModel it is possible to "Save" the data
            this.CustomerEditorViewModel = new CustomerEditorViewModel();
            this.CustomerEditorViewModel.Save += CustomerViewModelOnSave;
        }

        private void CustomerViewModelOnSave(object sender, EventArgs eventArgs)
        {
            this.Customers.Add(new CustomerItemViewModel(this.CustomerEditorViewModel.FirstName, this.CustomerEditorViewModel.LastName));
            this.CustomerEditorViewModel.Reset();
        }
    }
}