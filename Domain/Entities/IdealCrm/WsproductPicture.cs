using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductPicture
    {
        public WsproductPicture()
        {
            WsproductPictureLang = new HashSet<WsproductPictureLang>();
        }

        public int PrdPictureId { get; set; }
        public int PrdId { get; set; }
        public byte[] PrdFirstPic { get; set; }
        public string PrdFirstPicDesc { get; set; }
        public byte[] PrdSecondPic { get; set; }
        public string PrdSecondPicDesc { get; set; }
        public byte[] PrdThirdPic { get; set; }
        public string PrdThirdPicDesc { get; set; }
        public byte[] PrdFourthPic { get; set; }
        public string PrdFourthPicDesc { get; set; }
        public byte[] PrdFifthPic { get; set; }
        public string PrdFifthPicDesc { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? Whid { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsproductPictureLang> WsproductPictureLang { get; set; }
    }
}
