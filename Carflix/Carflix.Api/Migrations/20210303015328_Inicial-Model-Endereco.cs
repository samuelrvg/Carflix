using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carflix.Api.Migrations
{
    public partial class InicialModelEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Localidade = table.Column<string>(nullable: false),
                    Uf = table.Column<string>(nullable: false),
                    Ibge = table.Column<string>(nullable: false),
                    Gia = table.Column<string>(nullable: false),
                    DDD = table.Column<string>(nullable: false),
                    Siafi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.EnderecoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
