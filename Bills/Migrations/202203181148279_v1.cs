namespace Bills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        client_id = c.Int(nullable: false, identity: true),
                        client_name = c.String(nullable: false, maxLength: 150),
                        client_address = c.String(nullable: false, maxLength: 250),
                        client_phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.client_id)
                .Index(t => t.client_name, unique: true);
            
            CreateTable(
                "dbo.Sales_Invoice",
                c => new
                    {
                        invoice_id = c.Int(nullable: false, identity: true),
                        invoice_time = c.Time(nullable: false, precision: 7),
                        invoice_date = c.DateTime(nullable: false, storeType: "date"),
                        invoice_percentage_discount = c.Single(nullable: false),
                        invoice_employee_id = c.Int(nullable: false),
                        invoice_client_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.invoice_id)
                .ForeignKey("dbo.Clients", t => t.invoice_client_id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.invoice_employee_id, cascadeDelete: true)
                .Index(t => t.invoice_employee_id)
                .Index(t => t.invoice_client_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employee_id = c.Int(nullable: false, identity: true),
                        employee_name = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.employee_id)
                .Index(t => t.employee_name, unique: true);
            
            CreateTable(
                "dbo.Invoive_items",
                c => new
                    {
                        invoice_id = c.Int(nullable: false),
                        item_id = c.Int(nullable: false),
                        quantity = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.invoice_id, t.item_id })
                .ForeignKey("dbo.Items", t => t.item_id, cascadeDelete: true)
                .ForeignKey("dbo.Sales_Invoice", t => t.invoice_id, cascadeDelete: true)
                .Index(t => t.invoice_id)
                .Index(t => t.item_id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        item_Code = c.Int(nullable: false, identity: true),
                        item_name = c.String(nullable: false, maxLength: 150),
                        item_notes = c.String(maxLength: 500),
                        buy_price = c.Decimal(nullable: false, storeType: "money"),
                        sell_price = c.Decimal(nullable: false, storeType: "money"),
                        type_id = c.Int(nullable: false),
                        unit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.item_Code)
                .ForeignKey("dbo.Type_p", t => t.type_id, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.unit_id, cascadeDelete: true)
                .Index(t => t.item_name, unique: true)
                .Index(t => t.type_id)
                .Index(t => t.unit_id);
            
            CreateTable(
                "dbo.Type_p",
                c => new
                    {
                        typ_id = c.Int(nullable: false, identity: true),
                        typ_name = c.String(nullable: false, maxLength: 150),
                        typ_notes = c.String(maxLength: 500),
                        company_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.typ_id)
                .ForeignKey("dbo.Companies", t => t.company_id, cascadeDelete: true)
                .Index(t => t.typ_name, unique: true)
                .Index(t => t.company_id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        compan_id = c.Int(nullable: false, identity: true),
                        company_name = c.String(nullable: false, maxLength: 150),
                        company_notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.compan_id)
                .Index(t => t.company_name, unique: true);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        unt_id = c.Int(nullable: false, identity: true),
                        unt_name = c.String(nullable: false, maxLength: 150),
                        unt_notes = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.unt_id)
                .Index(t => t.unt_name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoive_items", "invoice_id", "dbo.Sales_Invoice");
            DropForeignKey("dbo.Invoive_items", "item_id", "dbo.Items");
            DropForeignKey("dbo.Items", "unit_id", "dbo.Units");
            DropForeignKey("dbo.Items", "type_id", "dbo.Type_p");
            DropForeignKey("dbo.Type_p", "company_id", "dbo.Companies");
            DropForeignKey("dbo.Sales_Invoice", "invoice_employee_id", "dbo.Employees");
            DropForeignKey("dbo.Sales_Invoice", "invoice_client_id", "dbo.Clients");
            DropIndex("dbo.Units", new[] { "unt_name" });
            DropIndex("dbo.Companies", new[] { "company_name" });
            DropIndex("dbo.Type_p", new[] { "company_id" });
            DropIndex("dbo.Type_p", new[] { "typ_name" });
            DropIndex("dbo.Items", new[] { "unit_id" });
            DropIndex("dbo.Items", new[] { "type_id" });
            DropIndex("dbo.Items", new[] { "item_name" });
            DropIndex("dbo.Invoive_items", new[] { "item_id" });
            DropIndex("dbo.Invoive_items", new[] { "invoice_id" });
            DropIndex("dbo.Employees", new[] { "employee_name" });
            DropIndex("dbo.Sales_Invoice", new[] { "invoice_client_id" });
            DropIndex("dbo.Sales_Invoice", new[] { "invoice_employee_id" });
            DropIndex("dbo.Clients", new[] { "client_name" });
            DropTable("dbo.Units");
            DropTable("dbo.Companies");
            DropTable("dbo.Type_p");
            DropTable("dbo.Items");
            DropTable("dbo.Invoive_items");
            DropTable("dbo.Employees");
            DropTable("dbo.Sales_Invoice");
            DropTable("dbo.Clients");
        }
    }
}
