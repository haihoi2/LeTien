using System;
using DevExpress.Xpo;

namespace LeTien.Objects
{

    public class XepCa : XPObject
    {
        public XepCa()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public XepCa(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        [DisplayName("Ng�y")]
        public DateTime Ngay
        {
            get;
            set;
        }

        [DisplayName("Nh�n Vi�n")]
        public Employee NhanVien
        {
            get;
            set;
        }

        [DisplayName("Ca")]
        public DanhMucCa Ca
        {
            get;
            set;
        }
    }

}