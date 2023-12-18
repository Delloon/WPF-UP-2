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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Production = new HashSet<Production>();
            this.ProductSales = new HashSet<ProductSales>();
        }
    
        public int IDПродукции { get; set; }
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string ТипПродукта { get; set; }
        public string Описание { get; set; }
        public byte[] Изображение { get; set; }
        public decimal МинСтоимость { get; set; }
        public double РазмерУпаковки { get; set; }
        public double ВесБезУпаковки { get; set; }
        public double ВесСУпаковкой { get; set; }
        public int СертификатКачества { get; set; }
        public int НомерСтандарта { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Production> Production { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSales> ProductSales { get; set; }
    }
}
