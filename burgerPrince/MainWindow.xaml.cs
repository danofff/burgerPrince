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
using burgerPrince.Model;
using burgerPrince.Model.CashMachine_;

namespace burgerPrince
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BurgerModel burgersBuild;
        public CashMachine mainMachine;
        public MainWindow()
        {
            InitializeComponent();          
            burgersBuild = new BurgerModel();
            mainFrame.Source = new Uri(@"View\OrderPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
