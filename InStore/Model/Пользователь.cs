//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователь
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователь()
        {
            this.Корзина = new HashSet<Корзина>();
            this.Отзывы = new HashSet<Отзывы>();
        }
    
        public int id_Пользователя { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Электронная_почта { get; set; }
        public string Пароль { get; set; }
        public Nullable<int> id_Категории_пользователя { get; set; }
        public string Login { get; set; }
    
        public virtual Категория_Пользователя Категория_Пользователя { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Корзина> Корзина { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Отзывы> Отзывы { get; set; }
    }
}
