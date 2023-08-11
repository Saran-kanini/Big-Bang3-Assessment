using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Big_Bang3_Assessment.Migrations
{
    /// <inheritdoc />
    public partial class sample1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "agentRegisterAgent_Id",
                table: "feedBacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "agentRegisterAgent_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "amount_for_childer",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "amount_for_person",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_childer",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "no_of_perons",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "adminPostid",
                table: "agencies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedBacks_agentRegisterAgent_Id",
                table: "feedBacks",
                column: "agentRegisterAgent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_agentRegisterAgent_Id",
                table: "Booking",
                column: "agentRegisterAgent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_agencies_adminPostid",
                table: "agencies",
                column: "adminPostid");

            migrationBuilder.AddForeignKey(
                name: "FK_agencies_AdminPost_adminPostid",
                table: "agencies",
                column: "adminPostid",
                principalTable: "AdminPost",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_agentRegisters_agentRegisterAgent_Id",
                table: "Booking",
                column: "agentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_feedBacks_agentRegisters_agentRegisterAgent_Id",
                table: "feedBacks",
                column: "agentRegisterAgent_Id",
                principalTable: "agentRegisters",
                principalColumn: "Agent_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agencies_AdminPost_adminPostid",
                table: "agencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_agentRegisters_agentRegisterAgent_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_feedBacks_agentRegisters_agentRegisterAgent_Id",
                table: "feedBacks");

            migrationBuilder.DropIndex(
                name: "IX_feedBacks_agentRegisterAgent_Id",
                table: "feedBacks");

            migrationBuilder.DropIndex(
                name: "IX_Booking_agentRegisterAgent_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_agencies_adminPostid",
                table: "agencies");

            migrationBuilder.DropColumn(
                name: "agentRegisterAgent_Id",
                table: "feedBacks");

            migrationBuilder.DropColumn(
                name: "agentRegisterAgent_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "amount_for_childer",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "amount_for_person",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "no_of_childer",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "no_of_perons",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "adminPostid",
                table: "agencies");
        }
    }
}
