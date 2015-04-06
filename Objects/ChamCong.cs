using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class ChamCong : XPObject
    {
        public ChamCong()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public ChamCong(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public string TenBangChamCong
        {
            get;
            set;
        }

        public Employee NhanVien
        {
            get;
            set;
        }


        public DateTime Thang
        {
            get;
            set;
        }

        public LoaiDuLieuChamCong LoaiDuLieuChamCong
        {
            get;
            set;
        }
       

        public string KetQua
        {
            get;
            set;
        }
       

        public string HieuSuat
        {
            get;
            set;
        }
        

        #region "Ng�y"
        [DisplayName("Ng�y 1")]
        public string Ngay1
        {
            get;
            set;
        }
        [DisplayName("Ng�y 2")]
        public string Ngay2
        {
            get;
            set;
        }
        [DisplayName("Ng�y 3")]
        public string Ngay3
        {
            get;
            set;
        }
        [DisplayName("Ng�y 4")]
        public string Ngay4
        {
            get;
            set;
        }
        [DisplayName("Ng�y 5")]
        public string Ngay5
        {
            get;
            set;
        }
        [DisplayName("Ng�y 6")]
        public string Ngay6
        {
            get;
            set;
        }
        [DisplayName("Ng�y 7")]
        public string Ngay7
        {
            get;
            set;
        }
        [DisplayName("Ng�y 8")]
        public string Ngay8
        {
            get;
            set;
        }
        [DisplayName("Ng�y 9")]
        public string Ngay9
        {
            get;
            set;
        }
        [DisplayName("Ng�y 10")]
        public string Ngay10
        {
            get;
            set;
        }
        [DisplayName("Ng�y 11")]
        public string Ngay11
        {
            get;
            set;
        }
        [DisplayName("Ng�y 12")]
        public string Ngay12
        {
            get;
            set;
        }
        [DisplayName("Ng�y 13")]
        public string Ngay13
        {
            get;
            set;
        }
        [DisplayName("Ng�y 14")]
        public string Ngay14
        {
            get;
            set;
        }
        [DisplayName("Ng�y 15")]
        public string Ngay15
        {
            get;
            set;
        }
        [DisplayName("Ng�y 16")]
        public string Ngay16
        {
            get;
            set;
        }
        [DisplayName("Ng�y 17")]
        public string Ngay17
        {
            get;
            set;
        }
        [DisplayName("Ng�y 18")]
        public string Ngay18
        {
            get;
            set;
        }
        [DisplayName("Ng�y 19")]
        public string Ngay19
        {
            get;
            set;
        }
        [DisplayName("Ng�y 20")]
        public string Ngay20
        {
            get;
            set;
        }
        [DisplayName("Ng�y 21")]
        public string Ngay21
        {
            get;
            set;
        }
        [DisplayName("Ng�y 22")]
        public string Ngay22
        {
            get;
            set;
        }
        [DisplayName("Ng�y 23")]
        public string Ngay23
        {
            get;
            set;
        }
        [DisplayName("Ng�y 24")]
        public string Ngay24
        {
            get;
            set;
        }
        [DisplayName("Ng�y 25")]
        public string Ngay25
        {
            get;
            set;
        }
        [DisplayName("Ng�y 26")]
        public string Ngay26
        {
            get;
            set;
        }
        [DisplayName("Ng�y 27")]
        public string Ngay27
        {
            get;
            set;
        }
        [DisplayName("Ng�y 28")]
        public string Ngay28
        {
            get;
            set;
        }
        [DisplayName("Ng�y 29")]
        public string Ngay29
        {
            get;
            set;
        }
        [DisplayName("Ng�y 30")]
        public string Ngay30
        {
            get;
            set;
        }
        [DisplayName("Ng�y 31")]
        public string Ngay31
        {
            get;
            set;
        }
        #endregion


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}