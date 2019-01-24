using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GridViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Orders = new ObservableCollection<string>();
            Orders.Add("SS");
            Orders.Add("SS");
            Orders.Add("SS");
            Orders.Add("SS");
        }

        private void GridView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((Setting)this.Resources["Setting"]).ItemWidth = 500;
        }
        private ObservableCollection<string> Orders { get; set; }
    }

    public class Setting : INotifyPropertyChanged
    {
        private double _itemWidth = 200;
        public double ItemWidth
        {
            get { return _itemWidth; }
            set { _itemWidth = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
