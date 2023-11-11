using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concert.Migrations
{
    public partial class NewTableTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: true),
                    EntranceGate = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "EntranceGate", "IsUsed", "UseDate" },
                values: new object[,]
                {
                    { new Guid("00402047-278b-427c-a62a-2ab6f837139f"), null, false, null },
                    { new Guid("034930b5-f737-484c-86dd-f298ebdc9d8f"), null, false, null },
                    { new Guid("052bab52-42e6-40b7-a53d-465ae29105df"), null, false, null },
                    { new Guid("07770e38-08c1-4046-8c31-91c5f52597c5"), null, false, null },
                    { new Guid("0da9321c-43b4-4ccd-871b-727dd6f80602"), null, false, null },
                    { new Guid("0e0c0e94-a138-4979-b6b4-d6f7dc29f61d"), null, false, null },
                    { new Guid("15d13579-9ba0-41ec-8fe8-968c6f66bc1a"), null, false, null },
                    { new Guid("16ccc9d0-02a1-4ca3-9520-75316844e84b"), null, false, null },
                    { new Guid("1a5cdf59-51e5-4106-8ddd-0e0f13eeee1b"), null, false, null },
                    { new Guid("24e584e2-3e9e-44ba-82be-c619e5f1af42"), null, false, null },
                    { new Guid("2f24fcfb-b81f-4caa-9080-f896a0f89703"), null, false, null },
                    { new Guid("41edf72a-5fe1-4375-a9f7-1524009572ac"), null, false, null },
                    { new Guid("4688d5fa-d564-4848-9990-f12a53fcb5e2"), null, false, null },
                    { new Guid("4871b819-992a-4f36-95aa-dcd20251c324"), null, false, null },
                    { new Guid("6e6205e1-78fe-407d-934a-19a731aa6772"), null, false, null },
                    { new Guid("7110ffb5-e0d5-48a1-bb21-c6bbb5538bbc"), null, false, null },
                    { new Guid("742913f5-49f2-486c-948f-f82e338c3415"), null, false, null },
                    { new Guid("8c2b831e-da98-408e-bea4-6ff65a8d76ae"), null, false, null },
                    { new Guid("985d9082-2d10-42b4-b9f1-9e998c5bea1d"), null, false, null },
                    { new Guid("a1d080b1-2db0-4b47-a803-4945ac7a7627"), null, false, null },
                    { new Guid("a300bfc8-7c1a-4a3d-9ace-aee8eb05fb12"), null, false, null },
                    { new Guid("b1f15497-fe5b-4925-a722-d780333acbfd"), null, false, null },
                    { new Guid("b5baca16-ffdf-44a5-b55f-48bb09652cab"), null, false, null },
                    { new Guid("bc58a26e-fdcc-4125-aa0b-ea810baae223"), null, false, null },
                    { new Guid("d928f9e6-9ae3-42fb-bf85-2615be572b14"), null, false, null },
                    { new Guid("e52acc46-1c62-485c-bde4-793e1d6bbbac"), null, false, null },
                    { new Guid("ed36bf12-4c66-4d33-b334-5ed83fe04806"), null, false, null },
                    { new Guid("f656fe07-bc6e-4c78-a887-e698b47f528b"), null, false, null },
                    { new Guid("f68cdb7f-f07a-4a13-9abf-4448837486f5"), null, false, null },
                    { new Guid("f9d20d0e-f10e-436c-b834-352bb80e2a98"), null, false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
