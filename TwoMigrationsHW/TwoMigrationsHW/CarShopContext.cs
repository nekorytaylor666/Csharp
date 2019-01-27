﻿namespace TwoMigrationsHW
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarShopContext : DbContext
    {
        // Контекст настроен для использования строки подключения "CarShopContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TwoMigrationsHW.CarShopContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CarShopContext" 
        // в файле конфигурации приложения.
        public CarShopContext()
            : base("name=CarShopContext")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarShop> CarShops { get; set; }


        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}