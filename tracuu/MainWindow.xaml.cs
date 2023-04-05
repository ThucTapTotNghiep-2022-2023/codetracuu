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
using tracuu.Models;

namespace tracuu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private dbdangkiemContext db = new dbdangkiemContext();
        private List<Lichdangkiem> ds;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTracuu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string bienSoXe = txtBiensoxe.Text.ToUpper(); // Lấy biển số xe từ TextBox và chuyển về chữ hoa
            DateTime ngayHienTai = DateTime.Now.Date;



            var ketQua = ds.FirstOrDefault(x => x.MaPtNavigation.BienSoxe == bienSoXe && x.NgayDangkiem == ngayHienTai);

            Lichdangkiem x = db.Lichdangkiems.Find();
            if (ketQua == null)
            {
                MessageBox.Show("khach hang chưa đăng ký", "Thông báo", MessageBoxButton.OK);
            }
            else
            {
               

                dg.ItemsSource = db.Phuongtiens.Where(t => t.MaPt == x.MaPt)
                .Join(db.Chuphuongtiens, x => x.MaCpt, y => y.MaCpt, (x, y) => new {
                    HoVaTen = y.HoVaten,
                    SoDt = y.SoDt,
                    bienSoXe = x.BienSoxe,
                    LoaiPhuongTien = x.LoaiXe
                   
                }).ToList();
            }
        }

       
        }
    }
}
