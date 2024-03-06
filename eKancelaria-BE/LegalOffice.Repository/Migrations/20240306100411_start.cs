using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegalOffice.Repository.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adjudication = table.Column<short>(type: "smallint", nullable: true),
                    AccordingToStandards = table.Column<short>(type: "smallint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReducedCourtFee = table.Column<bool>(type: "bit", nullable: false),
                    ReducedCourtFeeSpecified = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Exemption = table.Column<short>(type: "smallint", nullable: false),
                    Adjudication = table.Column<short>(type: "smallint", nullable: false),
                    Identifier = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    IdentifierSpecified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroundTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroundTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefundAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefundAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountOwner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proofs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterestRate = table.Column<short>(type: "smallint", nullable: false),
                    Jointly = table.Column<short>(type: "smallint", nullable: false),
                    Type = table.Column<short>(type: "smallint", nullable: false),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LawsuitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountSpecified = table.Column<bool>(type: "bit", nullable: false),
                    IsStatutory = table.Column<short>(type: "smallint", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RateSpecified = table.Column<bool>(type: "bit", nullable: false),
                    Period = table.Column<short>(type: "smallint", nullable: false),
                    PeriodSpecified = table.Column<bool>(type: "bit", nullable: false),
                    FromSubmission = table.Column<short>(type: "smallint", nullable: false),
                    FromSubmissionSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ToPayment = table.Column<short>(type: "smallint", nullable: false),
                    ToPaymentSpecified = table.Column<bool>(type: "bit", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterestPeriod_Claim_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claim",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lawsuits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmitterId = table.Column<int>(type: "int", nullable: false),
                    Ground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfControversy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeeId = table.Column<int>(type: "int", nullable: false),
                    CostId = table.Column<int>(type: "int", nullable: false),
                    RefundAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawsuits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lawsuits_Cost_CostId",
                        column: x => x.CostId,
                        principalTable: "Cost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lawsuits_Fee_FeeId",
                        column: x => x.FeeId,
                        principalTable: "Fee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lawsuits_RefundAccount_RefundAccountId",
                        column: x => x.RefundAccountId,
                        principalTable: "RefundAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plantiffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsForeigner = table.Column<bool>(type: "bit", nullable: false),
                    LacksIdentificationNumbers = table.Column<bool>(type: "bit", nullable: false),
                    Representation = table.Column<short>(type: "smallint", nullable: false),
                    PartyType = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LawsuitId = table.Column<int>(type: "int", nullable: true),
                    LawsuitId1 = table.Column<int>(type: "int", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headquarters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRegistered = table.Column<short>(type: "smallint", nullable: true),
                    KRS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantiffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantiffs_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plantiffs_Lawsuits_LawsuitId",
                        column: x => x.LawsuitId,
                        principalTable: "Lawsuits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plantiffs_Lawsuits_LawsuitId1",
                        column: x => x.LawsuitId1,
                        principalTable: "Lawsuits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonForCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonForCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonForCompany_Plantiffs_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Plantiffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Submitter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Proxy = table.Column<short>(type: "smallint", nullable: false),
                    Basis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submitter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submitter_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Submitter_PersonForCompany_PersonId",
                        column: x => x.PersonId,
                        principalTable: "PersonForCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claim_LawsuitId",
                table: "Claim",
                column: "LawsuitId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestPeriod_ClaimId",
                table: "InterestPeriod",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawsuits_CostId",
                table: "Lawsuits",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawsuits_FeeId",
                table: "Lawsuits",
                column: "FeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawsuits_RefundAccountId",
                table: "Lawsuits",
                column: "RefundAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawsuits_SubmitterId",
                table: "Lawsuits",
                column: "SubmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonForCompany_CompanyId",
                table: "PersonForCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantiffs_AddressId",
                table: "Plantiffs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantiffs_LawsuitId",
                table: "Plantiffs",
                column: "LawsuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantiffs_LawsuitId1",
                table: "Plantiffs",
                column: "LawsuitId1");

            migrationBuilder.CreateIndex(
                name: "IX_Submitter_AddressId",
                table: "Submitter",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Submitter_PersonId",
                table: "Submitter",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Claim_Lawsuits_LawsuitId",
                table: "Claim",
                column: "LawsuitId",
                principalTable: "Lawsuits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawsuits_Submitter_SubmitterId",
                table: "Lawsuits",
                column: "SubmitterId",
                principalTable: "Submitter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantiffs_Lawsuits_LawsuitId",
                table: "Plantiffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Plantiffs_Lawsuits_LawsuitId1",
                table: "Plantiffs");

            migrationBuilder.DropTable(
                name: "GroundTemplates");

            migrationBuilder.DropTable(
                name: "InterestPeriod");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "Lawsuits");

            migrationBuilder.DropTable(
                name: "Cost");

            migrationBuilder.DropTable(
                name: "Fee");

            migrationBuilder.DropTable(
                name: "RefundAccount");

            migrationBuilder.DropTable(
                name: "Submitter");

            migrationBuilder.DropTable(
                name: "PersonForCompany");

            migrationBuilder.DropTable(
                name: "Plantiffs");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
