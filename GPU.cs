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
    
    public partial class GPU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPU()
        {
            this.Table = new HashSet<Table>();
        }
    
        public int Код_GPU { get; set; }
        public string Модель { get; set; }
        public string Графический_процессор { get; set; }
        public string Техпроцесс { get; set; }
        public string Объем_видеопамяти { get; set; }
        public string Тип_памяти { get; set; }
        public Nullable<double> Версия_шейдера { get; set; }
        public Nullable<int> Стоимость { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table> Table { get; set; }
    }
}