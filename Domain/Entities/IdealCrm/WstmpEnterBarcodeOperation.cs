﻿using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WstmpEnterBarcodeOperation
    {
        public long Id { get; set; }
        public string Barcode { get; set; }
        public string BarcodeKind { get; set; }
        public int PrdId { get; set; }
        public int? PrdSerialId { get; set; }
        public int? Quantity { get; set; }
        public int? WhId { get; set; }
        public bool? Selector { get; set; }
        public bool? InsertedOk { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string RegisterTime { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
