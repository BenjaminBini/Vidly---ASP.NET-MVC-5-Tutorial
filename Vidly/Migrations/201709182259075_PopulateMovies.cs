namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO movies (Name, AddDate, ReleaseDate, InStockCount, Genre_Id) VALUES ('Get Out', '20170201', '20170201', 5, 3)");
            Sql("INSERT INTO movies (Name, AddDate, ReleaseDate, InStockCount, Genre_Id) VALUES ('Dikkenek', '20110201', '20080201', 5, 1)");
            Sql("INSERT INTO movies (Name, AddDate, ReleaseDate, InStockCount, Genre_Id) VALUES ('La Cité de la Peur', '19980201', '20170201', 5, 1)");
        }

        public override void Down()
        {
        }
    }
}