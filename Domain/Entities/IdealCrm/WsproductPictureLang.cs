using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductPictureLang
    {
        public int WsproductPictureLangId { get; set; }
        public int PrdPictureId { get; set; }
        public int LanguageId { get; set; }
        public string PrdFirstPicDesc { get; set; }
        public string PrdSecondPicDesc { get; set; }
        public string PrdThirdPicDesc { get; set; }
        public string PrdFourthPicDesc { get; set; }
        public string PrdFifthPicDesc { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsproductPicture PrdPicture { get; set; }
    }
}
