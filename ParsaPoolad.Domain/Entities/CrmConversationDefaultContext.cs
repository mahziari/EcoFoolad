﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmConversationDefaultContext
    {
        public CrmConversationDefaultContext()
        {
            CrmConversationDefaultContextLang = new HashSet<CrmConversationDefaultContextLang>();
        }

        public int Id { get; set; }
        public string ColOne { get; set; }
        public string ColTwo { get; set; }
        public string ColThree { get; set; }
        public string ColFour { get; set; }
        public string ColFive { get; set; }
        public string ColSix { get; set; }
        public string ColSeven { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string ColEight { get; set; }
        public string ColNine { get; set; }
        public string ColTen { get; set; }
        public string Col11 { get; set; }
        public string Col12 { get; set; }
        public string Col13 { get; set; }
        public string Col14 { get; set; }
        public string Col15 { get; set; }
        public string Col16 { get; set; }
        public string Col17 { get; set; }
        public string Col18 { get; set; }
        public string Col19 { get; set; }
        public string Col20 { get; set; }
        public string Col21 { get; set; }
        public string Col22 { get; set; }
        public string Col23 { get; set; }
        public string Col24 { get; set; }
        public string Col25 { get; set; }
        public string Col26 { get; set; }
        public string Col27 { get; set; }
        public string Col28 { get; set; }
        public string Col29 { get; set; }
        public string Col30 { get; set; }
        public string Col31 { get; set; }
        public string Col32 { get; set; }
        public string Col33 { get; set; }
        public string Col34 { get; set; }
        public string Col35 { get; set; }
        public string Col36 { get; set; }
        public string Col37 { get; set; }
        public string Col38 { get; set; }
        public string Col39 { get; set; }
        public string Col40 { get; set; }
        public string Col41 { get; set; }
        public string Col42 { get; set; }
        public string Col43 { get; set; }
        public string Col44 { get; set; }
        public string Col45 { get; set; }
        public string Col46 { get; set; }
        public string Col47 { get; set; }
        public string Col48 { get; set; }
        public string Col49 { get; set; }
        public string Col50 { get; set; }
        public string Col51 { get; set; }
        public string Col52 { get; set; }
        public string Col53 { get; set; }
        public string Col54 { get; set; }
        public string Col55 { get; set; }
        public string Col56 { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmConversationDefaultContextLang> CrmConversationDefaultContextLang { get; set; }
    }
}
