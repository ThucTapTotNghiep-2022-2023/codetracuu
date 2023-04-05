using System;
using System.Collections.Generic;

#nullable disable

namespace tracuu.Models
{
    public partial class Phuongtien
    {
        public Phuongtien()
        {
            Lichdangkiems = new HashSet<Lichdangkiem>();
        }

        public int MaPt { get; set; }
        public string BienSoxe { get; set; }
        public string LoaiXe { get; set; }
        public int LoaiBien { get; set; }
        public int MaCpt { get; set; }

        public virtual Chuphuongtien MaCptNavigation { get; set; }
        public virtual ICollection<Lichdangkiem> Lichdangkiems { get; set; }
    }
}
