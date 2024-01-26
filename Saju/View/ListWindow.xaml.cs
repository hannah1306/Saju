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
using System.Windows.Shapes;
using Saju.Model;

namespace Saju.View
{
    public partial class ListWindow : Window
    {
        List<User> list;
        public ListWindow()
        {
            InitializeComponent();

            list = new List<User>();
            list.Add(new User() { Name = "오승환", Birth = "19800203", Gender = "남" });
            list.Add(new User() { Name = "노서윤", Birth = "19951113", Gender = "여" });
            list.Add(new User() { Name = "박슬기", Birth = "20040822", Gender = "여" });
            list.Add(new User() { Name = "전경태", Birth = "19910401", Gender = "남" });
            userList.ItemsSource = list;
        }

        //사주입력 창 열기
        private void ShowRegister(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Owner = Application.Current.MainWindow;
            registerWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            registerWindow.ShowDialog();

            //등록 성공시 결과 창 띄우기
            ResultWindow resultWindow = new ResultWindow();
            resultWindow.Owner = Application.Current.MainWindow;
            resultWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            resultWindow.Show();
        }
    }
}
