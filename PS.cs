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
    
    public partial class PS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PS()
        {
            this.Table = new HashSet<Table>();
        }
    
        public int Код_PS { get; set; }
        public string Модель { get; set; }
        public string Мощность { get; set; }
        public string Форм_фактор { get; set; }
        public string Сертификат { get; set; }
        public Nullable<int> Стоимость { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table> Table { get; set; }
    }
}
