﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Интернет_магазинEntities2 : DbContext
    {
        public Интернет_магазинEntities2()
            : base("name=Интернет_магазинEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Категория_Пользователя> Категория_Пользователя { get; set; }
        public virtual DbSet<Категория_товара> Категория_товара { get; set; }
        public virtual DbSet<Корзина> Корзина { get; set; }
        public virtual DbSet<Купоны_и_скидки> Купоны_и_скидки { get; set; }
        public virtual DbSet<Отзывы> Отзывы { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Продукт> Продукт { get; set; }
        public virtual DbSet<Способ_доставки> Способ_доставки { get; set; }
        public virtual DbSet<Способ_оплаты> Способ_оплаты { get; set; }
    }
}
