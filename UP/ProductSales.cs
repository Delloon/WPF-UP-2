//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSales
    {
        public int IDРеализации { get; set; }
        public int IDПродукции { get; set; }
        public Nullable<int> Количество { get; set; }
    
        public virtual HistoryImplementations HistoryImplementations { get; set; }
        public virtual Products Products { get; set; }
    }
}
