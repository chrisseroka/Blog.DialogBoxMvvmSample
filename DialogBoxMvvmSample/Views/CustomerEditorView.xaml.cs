using System;
using DialogBoxMvvmSample.ViewModel;

namespace DialogBoxMvvmSample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerEditorView
    {
        public CustomerEditorView()
        {
            InitializeComponent();
        }

        public CustomerEditorView(CustomerEditorViewModel context):this()
        {
            this.DataContext = context;
            context.Save += Save;
        }

        void Save(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
