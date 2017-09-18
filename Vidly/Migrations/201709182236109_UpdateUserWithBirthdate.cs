namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateUserWithBirthdate : DbMigration
    {
        public override void Up()
        {
            DateTime date = new DateTime(1990, 9, 7);
            Sql("UPDATE customers set birthdate = '19900709' WHERE id = 1");
        }

        public override void Down()
        {
        }
    }
}