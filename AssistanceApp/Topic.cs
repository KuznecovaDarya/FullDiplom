//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssistanceApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topic
    {
        public long Id_Topic { get; set; }
        public string Name { get; set; }
        public long Id_Course { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
