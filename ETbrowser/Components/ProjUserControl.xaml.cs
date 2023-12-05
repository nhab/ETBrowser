using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ETbrowser.Components
{
    /// <summary>
    /// Interaction logic for ProjUserControl.xaml
    /// </summary>
    public partial class ProjUserControl : UserControl
    {
        public ProjUserControl()
        {
            InitializeComponent();
        }

        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(ProjUserControl), new PropertyMetadata(null));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string thePath = txtPath.Text;
            string[] files = System.IO.Directory.GetFiles(thePath);

            foreach (string file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Content= file.Substring(file.LastIndexOf("//"));
               
                item.Tag = file;
              ListviewFileFolders.Items.Add(item);
            }

        }
    }
}
