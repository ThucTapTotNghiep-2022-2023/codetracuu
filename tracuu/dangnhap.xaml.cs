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
using tracuu.Models;

namespace tracuu
{
    /// <summary>
    /// Interaction logic for dangnhap.xaml
    /// </summary>
    public partial class dangnhap : Window
    {
        private dbdangkiemContext db = new dbdangkiemContext();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, RoutedEventArgs e)
        {
            Button? btn = sender as Button;
            FrameworkElement? fe = btn.Parent as FrameworkElement;

            //ComboBox? cmb = fe.FindName("cmbMalop") as ComboBox;
            TextBox? txtTen = fe.FindName("txtTen") as TextBox;
            TextBox? txtMatkhau = fe.FindName("txtMatkhau") as TextBox;

            Dangkiemvien x = db.Dangkiemviens.Find(txtTen.Text);
            Dangkiemvien y = db.Dangkiemviens.Find(txtMatkhau.Text);
            //tim va cap nhat
            if (x.TenDangNhap == txtTen.Text && y.MatKhau==txtMatkhau.Text)
            {
                MainWindow f = new MainWindow();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }

        }
    }
}
