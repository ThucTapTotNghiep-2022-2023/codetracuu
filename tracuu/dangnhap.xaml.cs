using Microsoft.EntityFrameworkCore;
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

            string username = txtTen.Text;
            string password = txtMatkhau.Text;
            Dangkiemvien user = db.Dangkiemviens.FirstOrDefault(u => u.TenDangNhap == username && u.MatKhau == password);
            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
                return;
            }

            // thành công
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        
            Close();

            
        }
    }
}
