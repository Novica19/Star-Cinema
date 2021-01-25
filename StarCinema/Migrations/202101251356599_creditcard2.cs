namespace StarCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creditcard2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilets",
                c => new
                    {
                        id_bilet = c.Int(nullable: false, identity: true),
                        cena = c.Int(nullable: false),
                        e_mail = c.String(),
                        vreme_na_rezervacija = c.DateTime(nullable: false),
                        id_proekcija = c.Int(nullable: false),
                        id_film = c.Int(nullable: false),
                        broj_sala = c.Int(nullable: false),
                        broj_sediste = c.Int(nullable: false),
                        broj_red = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_bilet);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        card_id = c.Int(nullable: false, identity: true),
                        card_num = c.String(nullable: false, maxLength: 16),
                        card_type = c.String(nullable: false, maxLength: 16),
                        card_name = c.String(nullable: false, maxLength: 30),
                        card_expiry = c.String(nullable: false, maxLength: 12),
                        card_cvv = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.card_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditCards");
            DropTable("dbo.Bilets");
        }
    }
}
