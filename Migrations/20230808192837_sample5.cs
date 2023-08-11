using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Big_Bang3_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class sample5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_feedBacks_agentRegisters_agentRegisterAgent_Id",
                table: "feedBacks");

            migrationBuilder.RenameColumn(
                name: "agentRegisterAgent_Id",
                table: "feedBacks",
                newName: "AgentRegisterAgent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_feedBacks_agentRegisterAgent_Id",
                table: "feedBacks",
                newName: "IX_feedBacks_AgentRegisterAgent_Id");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBack_area",
                table: "feedBacks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_feedBacks_agentRegisters_AgentRegisterAgent_Id",
                table: "feedBacks",
                column: "AgentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_feedBacks_agentRegisters_AgentRegisterAgent_Id",
                table: "feedBacks");

            migrationBuilder.RenameColumn(
                name: "AgentRegisterAgent_Id",
                table: "feedBacks",
                newName: "agentRegisterAgent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_feedBacks_AgentRegisterAgent_Id",
                table: "feedBacks",
                newName: "IX_feedBacks_agentRegisterAgent_Id");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBack_area",
                table: "feedBacks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_feedBacks_agentRegisters_agentRegisterAgent_Id",
                table: "feedBacks",
                column: "agentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");
        }
    }
}
