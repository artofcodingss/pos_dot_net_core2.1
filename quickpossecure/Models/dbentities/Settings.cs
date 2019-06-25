using System;
using System.Collections.Generic;

namespace quickpossecure.Models.dbentities
{
    public partial class Settings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string UserType { get; set; }
        public int? UserId { get; set; }
        public float? FloatValue { get; set; }
        public float? DateValue { get; set; }
        public sbyte? Boolvalue { get; set; }
        public string VarcharValue { get; set; }
        public string VarcharValue2 { get; set; }
        public string VarcharValue3 { get; set; }
    }
}
