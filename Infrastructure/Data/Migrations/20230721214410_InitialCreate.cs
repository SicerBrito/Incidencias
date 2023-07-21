using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Concurrencias",
                columns: table => new
                {
                    Id_Concurrencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CantidadDeConcurrencias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concurrencias", x => x.Id_Concurrencia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id_Emails = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Emails = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id_Emails);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lugares",
                columns: table => new
                {
                    IdLugar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreLugar = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionLugar = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugares", x => x.IdLugar);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personalizacion",
                columns: table => new
                {
                    Id_Personalizacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalizacion", x => x.Id_Personalizacion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    IdRols = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreDelRol = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionDelRol = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.IdRols);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    Id_Telefono = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.Id_Telefono);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposDeDocumentos",
                columns: table => new
                {
                    Id_TipoDocumento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abreviatura = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeDocumentos", x => x.Id_TipoDocumento);
                    table.ForeignKey(
                        name: "FK_TiposDeDocumentos_TiposDeDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TiposDeDocumentos",
                        principalColumn: "Id_TipoDocumento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposDeIncidente",
                columns: table => new
                {
                    Id_TipoDeIncidente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeIncidente", x => x.Id_TipoDeIncidente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id_Area = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AreaEntrenamiento = table.Column<int>(type: "int", nullable: false),
                    AreaReview = table.Column<int>(type: "int", nullable: false),
                    Lugar_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id_Area);
                    table.ForeignKey(
                        name: "FK_Areas_Lugares_Lugar_Id",
                        column: x => x.Lugar_Id,
                        principalTable: "Lugares",
                        principalColumn: "IdLugar",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id_Genero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Masculino = table.Column<int>(type: "int", nullable: false),
                    Femenino = table.Column<int>(type: "int", nullable: false),
                    Privado = table.Column<int>(type: "int", nullable: false),
                    Personalizacion_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id_Genero);
                    table.ForeignKey(
                        name: "FK_Generos_Personalizacion_Personalizacion_Id",
                        column: x => x.Personalizacion_Id,
                        principalTable: "Personalizacion",
                        principalColumn: "Id_Personalizacion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    IdUbicacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUbicacion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Area_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.IdUbicacion);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Areas_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "Areas",
                        principalColumn: "Id_Area",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DatosPersonales",
                columns: table => new
                {
                    Id_Info = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    Genero_ID = table.Column<int>(type: "int", nullable: false),
                    Telefono_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPersonales", x => x.Id_Info);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Generos_Genero_ID",
                        column: x => x.Genero_ID,
                        principalTable: "Generos",
                        principalColumn: "Id_Genero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosPersonales_Telefonos_Telefono_ID",
                        column: x => x.Telefono_ID,
                        principalTable: "Telefonos",
                        principalColumn: "Id_Telefono",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InformacionDeDocumentos",
                columns: table => new
                {
                    InformacionPersonal_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Documento_Id = table.Column<int>(type: "int", nullable: false),
                    DocumentosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionDeDocumentos", x => x.InformacionPersonal_Id);
                    table.ForeignKey(
                        name: "FK_InformacionDeDocumentos_DatosPersonales_Documento_Id",
                        column: x => x.Documento_Id,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id_Info",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InformacionDeDocumentos_TiposDeDocumentos_DocumentosId",
                        column: x => x.DocumentosId,
                        principalTable: "TiposDeDocumentos",
                        principalColumn: "Id_TipoDocumento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email_Id = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo_Id = table.Column<int>(type: "int", nullable: false),
                    Info_Id = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id_Login);
                    table.ForeignKey(
                        name: "FK_Logins_DatosPersonales_Info_Id",
                        column: x => x.Info_Id,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id_Info",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logins_Emails_Email_Id",
                        column: x => x.Email_Id,
                        principalTable: "Emails",
                        principalColumn: "Id_Emails",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logins_Rols_Cargo_Id",
                        column: x => x.Cargo_Id,
                        principalTable: "Rols",
                        principalColumn: "IdRols",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonasIncidentes",
                columns: table => new
                {
                    Id_Incidencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Info_Id = table.Column<int>(type: "int", nullable: false),
                    Concurrencia_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasIncidentes", x => x.Id_Incidencia);
                    table.ForeignKey(
                        name: "FK_PersonasIncidentes_Concurrencias_Concurrencia_Id",
                        column: x => x.Concurrencia_Id,
                        principalTable: "Concurrencias",
                        principalColumn: "Id_Concurrencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonasIncidentes_DatosPersonales_Info_Id",
                        column: x => x.Info_Id,
                        principalTable: "DatosPersonales",
                        principalColumn: "Id_Info",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    Id_Incidencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usuario_Id = table.Column<int>(type: "int", nullable: false),
                    PersonaIncidente_Id = table.Column<int>(type: "int", nullable: false),
                    TipoIncidencia_Id = table.Column<int>(type: "int", nullable: false),
                    Ubicacion_Id = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.Id_Incidencia);
                    table.ForeignKey(
                        name: "FK_Incidencias_Logins_Usuario_Id",
                        column: x => x.Usuario_Id,
                        principalTable: "Logins",
                        principalColumn: "Id_Login",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_PersonasIncidentes_PersonaIncidente_Id",
                        column: x => x.PersonaIncidente_Id,
                        principalTable: "PersonasIncidentes",
                        principalColumn: "Id_Incidencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_TiposDeIncidente_TipoIncidencia_Id",
                        column: x => x.TipoIncidencia_Id,
                        principalTable: "TiposDeIncidente",
                        principalColumn: "Id_TipoDeIncidente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidencias_Ubicaciones_Ubicacion_Id",
                        column: x => x.Ubicacion_Id,
                        principalTable: "Ubicaciones",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Lugar_Id",
                table: "Areas",
                column: "Lugar_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_Genero_ID",
                table: "DatosPersonales",
                column: "Genero_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPersonales_Telefono_ID",
                table: "DatosPersonales",
                column: "Telefono_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Generos_Personalizacion_Id",
                table: "Generos",
                column: "Personalizacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_PersonaIncidente_Id",
                table: "Incidencias",
                column: "PersonaIncidente_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_TipoIncidencia_Id",
                table: "Incidencias",
                column: "TipoIncidencia_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Ubicacion_Id",
                table: "Incidencias",
                column: "Ubicacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_Usuario_Id",
                table: "Incidencias",
                column: "Usuario_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionDeDocumentos_Documento_Id",
                table: "InformacionDeDocumentos",
                column: "Documento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InformacionDeDocumentos_DocumentosId",
                table: "InformacionDeDocumentos",
                column: "DocumentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Cargo_Id",
                table: "Logins",
                column: "Cargo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Email_Id",
                table: "Logins",
                column: "Email_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Info_Id",
                table: "Logins",
                column: "Info_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonasIncidentes_Concurrencia_Id",
                table: "PersonasIncidentes",
                column: "Concurrencia_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonasIncidentes_Info_Id",
                table: "PersonasIncidentes",
                column: "Info_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeDocumentos_TipoDocumentoId",
                table: "TiposDeDocumentos",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_Area_Id",
                table: "Ubicaciones",
                column: "Area_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "InformacionDeDocumentos");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "PersonasIncidentes");

            migrationBuilder.DropTable(
                name: "TiposDeIncidente");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "TiposDeDocumentos");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropTable(
                name: "Concurrencias");

            migrationBuilder.DropTable(
                name: "DatosPersonales");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Lugares");

            migrationBuilder.DropTable(
                name: "Personalizacion");
        }
    }
}
