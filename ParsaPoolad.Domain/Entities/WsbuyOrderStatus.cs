﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsbuyOrderStatus
    {
        public WsbuyOrderStatus()
        {
            WsbuyOrder = new HashSet<WsbuyOrder>();
            WsbuyOrderStatusLang = new HashSet<WsbuyOrderStatusLang>();
        }

        public int BuyOrderStatusId { get; set; }
        public string BuyOrderStatus { get; set; }
        public int? OrderView { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<WsbuyOrderStatusLang> WsbuyOrderStatusLang { get; set; }
    }
}
