//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contacts
    {
        public int id { get; set; }
        public string Address { get; set; }
        public string Timetable { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    
        public virtual Main Main { get; set; }
    }
}
