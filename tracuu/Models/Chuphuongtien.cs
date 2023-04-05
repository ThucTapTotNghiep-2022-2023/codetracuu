using System;
using System.Collections.Generic;

#nullable disable

namespace tracuu.Models
{
    public partial class Chuphuongtien
    {
        public Chuphuongtien()
        {
            Lichdangkiems = new HashSet<Lichdangkiem>();
            Phuongtiens = new HashSet<Phuongtien>();
        }

        public int MaCpt { get; set; }
        public string Cccd { get; set; }
        public string HoVaten { get; set; }
        public string SoDt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Lichdangkiem> Lichdangkiems { get; set; }
        public virtual ICollection<Phuongtien> Phuongtiens { get; set; }
    }
}
