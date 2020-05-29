using Hospital.Pages;
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

namespace Hospital
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Adult adult;
    Child child = new Child();

    public MainWindow()
    {
      InitializeComponent();
            OpenData.LoadData();
            var x = OpenData.GetChildrenHospitals();
            var y = OpenData.GetAdultHospitals();

      adult = new Adult(x);
      MainFrame.Navigate(adult);
    }

    private void AdultButton_Click(object sender, RoutedEventArgs e)
    {
      AdultBorder.Style = Resources["TabBorderOn"] as Style;
      AdultLabel.Style = Resources["TabLabelOn"] as Style;
      ChildBorder.Style = Resources["TabBorderOff"] as Style;
      ChildLabel.Style = Resources["TabLabelOff"] as Style;

      MainFrame.Navigate(adult);
    }

    private void ChildButton_Click(object sender, RoutedEventArgs e)
    {
      ChildBorder.Style = Resources["TabBorderOn"] as Style;
      ChildLabel.Style = Resources["TabLabelOn"] as Style;
      AdultBorder.Style = Resources["TabBorderOff"] as Style;
      AdultLabel.Style = Resources["TabLabelOff"] as Style;

      MainFrame.Navigate(child);
    }
  }
}
