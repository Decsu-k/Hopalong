//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hopalong_Rozhin.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfRawMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfRawMaterial()
        {
            this.QuantityOfGoods = new HashSet<QuantityOfGoods>();
        }
    
        public string Code { get; set; }
        public Nullable<int> QuantityOfGoodsID { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuantityOfGoods> QuantityOfGoods { get; set; }
    }
}