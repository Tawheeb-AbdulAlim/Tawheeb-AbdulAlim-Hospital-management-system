namespace Hospital_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        Specialization = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Phone = c.String(),
                        BloodType = c.String(),
                        reseptionId = c.Int(nullable: false),
                        reseptionist_ReseptionistId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.reseptionists", t => t.reseptionist_ReseptionistId)
                .Index(t => t.reseptionist_ReseptionistId);
            
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        VisitId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        VisitDate = c.DateTime(nullable: false),
                        VisitType = c.String(),
                        CurrentMedication = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.VisitId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.reseptionists",
                c => new
                    {
                        ReseptionistId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        FullName = c.String(),
                        Age = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReseptionistId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Username = c.String(),
                        Role = c.String(),
                        PasswordHash = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        Patient_PatientId = c.Int(nullable: false),
                        Doctor_DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Patient_PatientId, t.Doctor_DoctorId })
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId, cascadeDelete: true)
                .Index(t => t.Patient_PatientId)
                .Index(t => t.Doctor_DoctorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "reseptionist_ReseptionistId", "dbo.reseptionists");
            DropForeignKey("dbo.Visits", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientDoctors", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.PatientDoctors", "Patient_PatientId", "dbo.Patients");
            DropIndex("dbo.PatientDoctors", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.PatientDoctors", new[] { "Patient_PatientId" });
            DropIndex("dbo.Visits", new[] { "PatientId" });
            DropIndex("dbo.Patients", new[] { "reseptionist_ReseptionistId" });
            DropTable("dbo.PatientDoctors");
            DropTable("dbo.Users");
            DropTable("dbo.reseptionists");
            DropTable("dbo.Visits");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
