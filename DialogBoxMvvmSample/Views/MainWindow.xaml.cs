using System;
using DialogBoxMvvmSample.ViewModel;

namespace DialogBoxMvvmSample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnAddClick(object sender, EventArgs e)
        {
            //For each dialog we use the same instance of ViewModel
            var customerDialogBox = new CustomerEditorView( ((MainViewModel) this.DataContext).CustomerEditorViewModel );

            //No need to check DialogResult - it is respnsibility of ViewModel to interpret the result of commands
            //View only displays the window
            customerDialogBox.ShowDialog();
        }
    }
}
