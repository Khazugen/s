using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Diagnostics;

namespace s
{
    public class Info
    {
        public string Udaj { get; set; }
        public string Hodnota { get; set; }
    }
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MercurePage : ContentPage
    {
        public static ObservableCollection<Info> InfoList { get; set; }
        public MercurePage()
        {
            InitializeComponent();
            InfoList = new ObservableCollection<Info>(
               new Info[]
               {
                    new Info {Udaj="Pořadí od Slunce: ", Hodnota="1." },
                    new Info {Udaj="Počet měsíců:", Hodnota="0" },
                    new Info {Udaj="Polární průměr:", Hodnota="4879,4 km" },
               });
               InfoListView.ItemsSource = InfoList;

        }
    }
}