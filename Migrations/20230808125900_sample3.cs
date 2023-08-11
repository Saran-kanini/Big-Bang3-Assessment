using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Big_Bang3_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class sample3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_agentRegisters_agentRegisterAgent_Id",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "agentRegisterAgent_Id",
                table: "Booking",
                newName: "AgentRegisterAgent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_agentRegisterAgent_Id",
                table: "Booking",
                newName: "IX_Booking_AgentRegisterAgent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_agentRegisters_AgentRegisterAgent_Id",
                table: "Booking",
                column: "AgentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_agentRegisters_AgentRegisterAgent_Id",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "AgentRegisterAgent_Id",
                table: "Booking",
                newName: "agentRegisterAgent_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_AgentRegisterAgent_Id",
                table: "Booking",
                newName: "IX_Booking_agentRegisterAgent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_agentRegisters_agentRegisterAgent_Id",
                table: "Booking",
                column: "agentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");
        }
    }
}
