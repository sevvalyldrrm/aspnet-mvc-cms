using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cms.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speacialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDischarged = table.Column<bool>(type: "bit", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    DoctorId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Patient_RoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetRoles_Patient_RoleId",
                        column: x => x.Patient_RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetUsers_DoctorId1",
                        column: x => x.DoctorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryPosts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    DoctorId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_DoctorId1",
                        column: x => x.DoctorId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostComments_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostComments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Doctor", "DOCTOR" },
                    { "3", null, "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d667726-0b62-496e-b4c4-800314ac8297", 0, "Gaziantep", "842ead80-3c94-429b-878e-59200aee583d", "AppUser", null, false, "User Seven", false, null, null, null, null, null, false, "922bf718-ad9a-411a-b6bf-80a409c4ffe8", false, null },
                    { "5739bdf1-3230-41e7-af11-de3fa143997a", 0, "Konya", "1713d245-22a5-471c-b685-0e1e7bfe91fd", "AppUser", null, false, "User Six", false, null, null, null, null, null, false, "84706ff9-4dbe-4433-9fbe-903612f5b147", false, null },
                    { "595b7798-181a-4a57-bbcd-99bac1de6f48", 0, "İzmir", "471d3216-147e-4caf-950f-fb0e5f336b8c", "AppUser", null, false, "User Two", false, null, null, null, null, null, false, "3ffef1df-4ae3-4c66-9c82-0bfcbd836b65", false, null },
                    { "6946d5ed-65a8-4edd-b1c0-046590726e6e", 0, "Adana", "340dd87b-756c-4bc1-b360-659f240ce12a", "AppUser", null, false, "User Five", false, null, null, null, null, null, false, "fd97ec0c-39da-4810-b113-8be6c8032083", false, null },
                    { "72bca839-1e19-430d-a329-ae62e737655e", 0, "Bursa", "bfb9bfb0-ae24-4873-a5bb-cf2be13c5335", "AppUser", null, false, "User Four", false, null, null, null, null, null, false, "c98e1c61-8904-47a3-9a71-a647354f8fb9", false, null },
                    { "90afa8be-ebf4-412a-a5e5-ea533fda36cc", 0, "Samsun", "a3dd9c81-f700-4892-b0fb-16e732f8295c", "AppUser", null, false, "User Eight", false, null, null, null, null, null, false, "bed71e6e-2de9-4649-8512-2ea54f5cc229", false, null },
                    { "b38bd881-8cea-40f4-b69f-48e42fd6f4d6", 0, "Kayseri", "d8faf6db-e1d7-4ffa-ab6d-8d24efcbae45", "AppUser", null, false, "User Nine", false, null, null, null, null, null, false, "df25cb27-5516-40a7-bc4e-78de3acffe26", false, null },
                    { "e0fab7d9-08cf-4c8f-9f74-797bb189b5e6", 0, "Ankara", "7881742b-4888-4a92-ba47-5148e7d80be4", "AppUser", null, false, "User One", false, null, null, null, null, null, false, "7af5d655-a473-488f-9035-feda7af0044e", false, null },
                    { "f0cac610-41c2-4758-aeea-215e62189c2a", 0, "Antalya", "3e740d18-33c4-4446-b5b6-06463923e920", "AppUser", null, false, "User Three", false, null, null, null, null, null, false, "2e5a880e-12c7-42d5-bb36-7265e1999418", false, null },
                    { "ffe6e692-a04d-483d-a24a-3746a9a49b2a", 0, "İstanbul", "fd775bc3-253b-4b1a-abe5-0a573acb8e0f", "AppUser", null, false, "Admin", false, null, null, null, null, null, false, "6808c275-993a-4e25-8e9a-94b1a9e37adb", false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Teknoloji ile ilgili haberler", "Teknoloji" },
                    { 2, "Spor haberleri", "Spor" },
                    { 3, "Sağlık ve yaşam tarzı ile ilgili bilgiler", "Sağlık" },
                    { 4, "Eğitim dünyasından haberler ve ipuçları", "Eğitim" },
                    { 5, "Ekonomi ve finans dünyasına dair güncel bilgiler", "Ekonomi" },
                    { 6, "Seyahat ipuçları ve destinasyon önerileri", "Seyahat" },
                    { 7, "Sanat dünyasından son gelişmeler", "Sanat" },
                    { 8, "Moda dünyasından en son trendler", "Moda" },
                    { 9, "Yemek kültürü ve gastronomi haberleri", "Gastronomi" },
                    { 10, "Teknolojideki son yenilikler ve icatlar", "Teknoloji Yenilikleri" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "CreatedAt", "DeletedAt", "IsActive", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Bu sayfa şirketimiz hakkında bilgiler içerir.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1333), null, true, "Hakkımızda", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1333) },
                    { 2, "Şirketimizin misyonunu bu sayfada bulabilirsiniz.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1335), null, true, "Misyonumuz", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1336) },
                    { 3, "Gelecek vizyonumuz hakkında bilgi alın.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1338), null, true, "Vizyonumuz", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1338) },
                    { 4, "Kariyer olanaklarımız hakkında bilgi alın.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1341), null, true, "Kariyer", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1342) },
                    { 5, "Bizimle iletişim bilgileri.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1344), null, true, "İletişim", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1344) },
                    { 6, "Basın bültenlerimiz ve haberler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1347), null, true, "Basın Odası", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1347) },
                    { 7, "Yatırımcılar için önemli bilgiler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1350), null, true, "Yatırımcı İlişkileri", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1350) },
                    { 8, "Topluma katkıda bulunduğumuz projeler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1352), null, true, "Sosyal Sorumluluk Projeleri", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1352) },
                    { 9, "Müşterilerimizin sık sorduğu sorular.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1354), null, true, "Sıkça Sorulan Sorular", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1354) },
                    { 10, "Gizlilik ve veri koruma politikamız.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1355), null, true, "Gizlilik Politikası", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1356) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AppUserId", "Content", "CreatedAt", "DeletedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Yeni teknolojiler hakkında bilgiler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(935), null, "Yeni Teknolojiler", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(948) },
                    { 2, 1, "Spor dünyasından son gelişmeler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(954), null, "Spor Dünyası", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(954) },
                    { 3, 9, "Sağlıklı yaşam için ipuçları.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(956), null, "Sağlıklı Yaşam", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(957) },
                    { 4, 2, "Eğitim alanında yaşanan son gelişmeler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(959), null, "Eğitimde Yenilikler", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(959) },
                    { 5, 8, "Dünya ekonomisine genel bir bakış.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(961), null, "Ekonomi Analizi", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(962) },
                    { 6, 3, "Keşfedilecek yeni yerler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(963), null, "Seyahat Rehberi", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(964) },
                    { 7, 4, "Sanat dünyasından haberler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(965), null, "Sanatın Kalbi", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(966) },
                    { 8, 5, "Moda dünyasının nabzı.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(967), null, "Moda Dünyasında Neler Oluyor?", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(968) },
                    { 9, 6, "Gastronomi dünyasından lezzetli haberler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(969), null, "Gastronomi Keşifleri", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(970) },
                    { 10, 7, "Teknolojideki son gelişmeler ve inovasyonlar.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(971), null, "Teknolojik Gelişmeler", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(972) }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Name", "UserId", "Value" },
                values: new object[,]
                {
                    { 1, "Tema", 1, "Koyu" },
                    { 2, "Dil", 1, "Türkçe" },
                    { 3, "Tema", 2, "Açık" },
                    { 4, "Dil", 2, "İngilizce" },
                    { 5, "Tema", 3, "Koyu" },
                    { 6, "Dil", 3, "Türkçe" },
                    { 7, "Tema", 4, "Açık" },
                    { 8, "Dil", 4, "İngilizce" },
                    { 9, "Tema", 5, "Koyu" },
                    { 10, "Dil", 5, "Türkçe" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPosts",
                columns: new[] { "Id", "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 3, 6 },
                    { 7, 3, 7 },
                    { 8, 4, 8 },
                    { 9, 4, 9 },
                    { 10, 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "PostComments",
                columns: new[] { "Id", "AppUserId", "AppUserId1", "Comment", "CreatedAt", "DeletedAt", "IsActive", "PostId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, null, "Harika bir yazı!", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1229), null, true, 1, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1230) },
                    { 2, 2, null, "Çok bilgilendirici, teşekkürler.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1233), null, true, 1, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1233) },
                    { 3, 3, null, "Bu konuda daha fazla bilgi bekliyorum.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1235), null, true, 1, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1236) },
                    { 4, 4, null, "Sporla ilgili bu tür yazıları seviyorum.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1238), null, true, 2, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1238) },
                    { 5, 5, null, "Yazarın bakış açısını beğendim.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1240), null, true, 2, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1240) },
                    { 6, 6, null, "Faydalı bir yazı olmuş.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1242), null, true, 2, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1242) },
                    { 7, 7, null, "Teknolojinin geldiği nokta gerçekten şaşırtıcı.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1244), null, true, 1, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1244) },
                    { 8, 8, null, "Yazar bu konuda çok iyi bilgi sahibi.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1246), null, true, 1, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1246) },
                    { 9, 9, null, "Spor haberlerini takip etmeyi seviyorum.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1248), null, true, 2, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1248) },
                    { 10, 10, null, "Daha fazla spor içeriği görmek isterim.", new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1250), null, true, 3, new DateTime(2024, 2, 17, 23, 37, 53, 903, DateTimeKind.Local).AddTicks(1250) }
                });

            migrationBuilder.InsertData(
                table: "PostImages",
                columns: new[] { "Id", "ImagePath", "PostId" },
                values: new object[,]
                {
                    { 1, "images/post1.jpg", 1 },
                    { 2, "images/post2.jpg", 1 },
                    { 3, "images/post3.jpg", 1 },
                    { 4, "images/post4.jpg", 2 },
                    { 5, "images/post5.jpg", 2 },
                    { 6, "images/post6.jpg", 2 },
                    { 7, "images/post7.jpg", 3 },
                    { 8, "images/post8.jpg", 3 },
                    { 9, "images/post9.jpg", 4 },
                    { 10, "images/post10.jpg", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CategoryId",
                table: "Appointments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId1",
                table: "Appointments",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CategoryId",
                table: "AspNetUsers",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DoctorId1",
                table: "AspNetUsers",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Patient_RoleId",
                table: "AspNetUsers",
                column: "Patient_RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPosts_CategoryId",
                table: "CategoryPosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPosts_PostId",
                table: "CategoryPosts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_AppUserId1",
                table: "PostComments",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostComments_PostId",
                table: "PostComments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostId",
                table: "PostImages",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryPosts");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "PostComments");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
