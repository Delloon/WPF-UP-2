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
    
    public partial class PossibleSuppliers
    {
        public int IDМатериала { get; set; }
        public int IDПоставщика { get; set; }
        public string Описание { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
