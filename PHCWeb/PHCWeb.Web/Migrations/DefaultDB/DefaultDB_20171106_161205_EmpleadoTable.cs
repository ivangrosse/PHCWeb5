using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PHCWeb.Migrations.DefaultDB
{
    [Migration(20171106161205)]
    public class DefaultDB_20171106_161205_EmpleadoTable : Migration
    {
        public override void Up()
        {
            Create.Schema("PHC");

            Create.Table("Empleado").InSchema("PHC")
                .WithColumn("idEmpleado").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("apellido").AsString(45).Nullable()
                .WithColumn("nombre").AsString(45).Nullable()
                .WithColumn("legajo").AsString(45).NotNullable()
                .WithColumn("fechaIngreso").AsDateTime().Nullable()
                .WithColumn("dni").AsInt32()
                .WithColumn("cuil").AsString(45).Nullable()
                .WithColumn("fechaNacimiento").AsDateTime().Nullable()
                .WithColumn("esActivo").AsBoolean().Nullable()
                .WithColumn("telefono").AsString(45).Nullable()
                .WithColumn("email").AsString(45).Nullable()
                .WithColumn("domiclio").AsString(45).Nullable()                
                .WithColumn("sexo").AsString(1).Nullable();
        }

        public override void Down()
        {
        }
    }

}