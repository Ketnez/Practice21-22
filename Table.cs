//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace data0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Код_CPU { get; set; }
        public int Код_GPU { get; set; }
        public int Код_HDD { get; set; }
        public int Код_MB { get; set; }
        public int Код_PS { get; set; }
        public int Код_RAM { get; set; }
        public int Код_Repair { get; set; }
    
        public virtual CPU CPU { get; set; }
        public virtual GPU GPU { get; set; }
        public virtual HDD HDD { get; set; }
        public virtual MB MB { get; set; }
        public virtual PS PS { get; set; }
        public virtual RAM RAM { get; set; }
        public virtual Repair Repair { get; set; }
    }
}
