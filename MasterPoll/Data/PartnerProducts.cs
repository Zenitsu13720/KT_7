//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPoll.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerProducts
    {
        public int Id { get; set; }
        public int IdProductName { get; set; }
        public int IdPartnerName { get; set; }
        public int Count { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual PartnerName PartnerName { get; set; }
        public virtual ProductName ProductName { get; set; }
        public virtual Products Products { get; set; }
    }
}
