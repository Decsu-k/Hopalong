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
    
    public partial class Suppliers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string TypeSuppliersCode { get; set; }
        public string Code { get; set; }
        public Nullable<int> DeliveryHistoryID { get; set; }
    
        public virtual DeliveryHistory DeliveryHistory { get; set; }
        public virtual Production Production { get; set; }
    }
}
