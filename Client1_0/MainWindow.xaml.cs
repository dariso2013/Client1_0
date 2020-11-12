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

namespace Client1_0
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, RoutedEventArgs e)
    {
      TextBox txtBox = new TextBox();
      txtBox.Width = 500;
      txtBox.Height = 20;
      txtBox.Text = Mess.Text;
      txtBox.IsEnabled = false;
      Thickness m = txtBox.Margin;
      m.Bottom = 10;
      txtBox.Margin = m;
      if (Mess.Text != "")
        MyPanel.Children.Add(txtBox);
      Mess.Text = "";
    }

    private void Mess_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Key == Key.Enter)
      {
        TextBox txtBox = new TextBox();
        txtBox.Width = 500;
        txtBox.Height = 20;
        txtBox.Text = Mess.Text;
        txtBox.IsEnabled = false;
        Thickness m = txtBox.Margin;
        m.Bottom = 10;
        txtBox.Margin = m;
        if (Mess.Text != "")
          MyPanel.Children.Add(txtBox);
        Mess.Text = "";
      }
    }
  }
}
