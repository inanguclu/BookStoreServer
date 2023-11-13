using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "CreateAt", "ISBN", "IsActive", "IsDeleted", "Price", "Quantity", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Author1", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9751), "ISBN1", true, false, 10m, 10, "Summary1", "Book1" },
                    { 2, "Author2", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9755), "ISBN2", true, false, 10m, 10, "Summary2", "Book2" },
                    { 3, "Author3", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9757), "ISBN3", true, false, 10m, 10, "Summary3", "Book3" },
                    { 4, "Author4", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9759), "ISBN4", true, false, 10m, 10, "Summary4", "Book4" },
                    { 5, "Author5", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9761), "ISBN5", true, false, 10m, 10, "Summary5", "Book5" },
                    { 6, "Author6", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9764), "ISBN6", true, false, 10m, 10, "Summary6", "Book6" },
                    { 7, "Author7", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9766), "ISBN7", true, false, 10m, 10, "Summary7", "Book7" },
                    { 8, "Author8", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9768), "ISBN8", true, false, 10m, 10, "Summary8", "Book8" },
                    { 9, "Author9", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9770), "ISBN9", true, false, 10m, 10, "Summary9", "Book9" },
                    { 10, "Author10", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9773), "ISBN10", true, false, 10m, 10, "Summary10", "Book10" },
                    { 11, "Author11", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9775), "ISBN11", true, false, 10m, 10, "Summary11", "Book11" },
                    { 12, "Author12", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9776), "ISBN12", true, false, 10m, 10, "Summary12", "Book12" },
                    { 13, "Author13", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9778), "ISBN13", true, false, 10m, 10, "Summary13", "Book13" },
                    { 14, "Author14", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9780), "ISBN14", true, false, 10m, 10, "Summary14", "Book14" },
                    { 15, "Author15", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9782), "ISBN15", true, false, 10m, 10, "Summary15", "Book15" },
                    { 16, "Author16", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9783), "ISBN16", true, false, 10m, 10, "Summary16", "Book16" },
                    { 17, "Author17", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9785), "ISBN17", true, false, 10m, 10, "Summary17", "Book17" },
                    { 18, "Author18", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9807), "ISBN18", true, false, 10m, 10, "Summary18", "Book18" },
                    { 19, "Author19", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9809), "ISBN19", true, false, 10m, 10, "Summary19", "Book19" },
                    { 20, "Author20", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9811), "ISBN20", true, false, 10m, 10, "Summary20", "Book20" },
                    { 21, "Author21", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9813), "ISBN21", true, false, 10m, 10, "Summary21", "Book21" },
                    { 22, "Author22", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9815), "ISBN22", true, false, 10m, 10, "Summary22", "Book22" },
                    { 23, "Author23", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9816), "ISBN23", true, false, 10m, 10, "Summary23", "Book23" },
                    { 24, "Author24", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9818), "ISBN24", true, false, 10m, 10, "Summary24", "Book24" },
                    { 25, "Author25", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9820), "ISBN25", true, false, 10m, 10, "Summary25", "Book25" },
                    { 26, "Author26", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9821), "ISBN26", true, false, 10m, 10, "Summary26", "Book26" },
                    { 27, "Author27", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9823), "ISBN27", true, false, 10m, 10, "Summary27", "Book27" },
                    { 28, "Author28", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9825), "ISBN28", true, false, 10m, 10, "Summary28", "Book28" },
                    { 29, "Author29", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9826), "ISBN29", true, false, 10m, 10, "Summary29", "Book29" },
                    { 30, "Author30", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9828), "ISBN30", true, false, 10m, 10, "Summary30", "Book30" },
                    { 31, "Author31", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9830), "ISBN31", true, false, 10m, 10, "Summary31", "Book31" },
                    { 32, "Author32", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9831), "ISBN32", true, false, 10m, 10, "Summary32", "Book32" },
                    { 33, "Author33", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9833), "ISBN33", true, false, 10m, 10, "Summary33", "Book33" },
                    { 34, "Author34", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9835), "ISBN34", true, false, 10m, 10, "Summary34", "Book34" },
                    { 35, "Author35", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9837), "ISBN35", true, false, 10m, 10, "Summary35", "Book35" },
                    { 36, "Author36", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9839), "ISBN36", true, false, 10m, 10, "Summary36", "Book36" },
                    { 37, "Author37", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9840), "ISBN37", true, false, 10m, 10, "Summary37", "Book37" },
                    { 38, "Author38", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9842), "ISBN38", true, false, 10m, 10, "Summary38", "Book38" },
                    { 39, "Author39", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9843), "ISBN39", true, false, 10m, 10, "Summary39", "Book39" },
                    { 40, "Author40", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9845), "ISBN40", true, false, 10m, 10, "Summary40", "Book40" },
                    { 41, "Author41", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9847), "ISBN41", true, false, 10m, 10, "Summary41", "Book41" },
                    { 42, "Author42", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9848), "ISBN42", true, false, 10m, 10, "Summary42", "Book42" },
                    { 43, "Author43", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9850), "ISBN43", true, false, 10m, 10, "Summary43", "Book43" },
                    { 44, "Author44", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9852), "ISBN44", true, false, 10m, 10, "Summary44", "Book44" },
                    { 45, "Author45", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9853), "ISBN45", true, false, 10m, 10, "Summary45", "Book45" },
                    { 46, "Author46", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9855), "ISBN46", true, false, 10m, 10, "Summary46", "Book46" },
                    { 47, "Author47", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9876), "ISBN47", true, false, 10m, 10, "Summary47", "Book47" },
                    { 48, "Author48", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9878), "ISBN48", true, false, 10m, 10, "Summary48", "Book48" },
                    { 49, "Author49", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9880), "ISBN49", true, false, 10m, 10, "Summary49", "Book49" },
                    { 50, "Author50", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9881), "ISBN50", true, false, 10m, 10, "Summary50", "Book50" },
                    { 51, "Author51", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9883), "ISBN51", true, false, 10m, 10, "Summary51", "Book51" },
                    { 52, "Author52", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9885), "ISBN52", true, false, 10m, 10, "Summary52", "Book52" },
                    { 53, "Author53", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9886), "ISBN53", true, false, 10m, 10, "Summary53", "Book53" },
                    { 54, "Author54", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9888), "ISBN54", true, false, 10m, 10, "Summary54", "Book54" },
                    { 55, "Author55", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9890), "ISBN55", true, false, 10m, 10, "Summary55", "Book55" },
                    { 56, "Author56", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9891), "ISBN56", true, false, 10m, 10, "Summary56", "Book56" },
                    { 57, "Author57", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9893), "ISBN57", true, false, 10m, 10, "Summary57", "Book57" },
                    { 58, "Author58", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9895), "ISBN58", true, false, 10m, 10, "Summary58", "Book58" },
                    { 59, "Author59", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9896), "ISBN59", true, false, 10m, 10, "Summary59", "Book59" },
                    { 60, "Author60", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9898), "ISBN60", true, false, 10m, 10, "Summary60", "Book60" },
                    { 61, "Author61", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9899), "ISBN61", true, false, 10m, 10, "Summary61", "Book61" },
                    { 62, "Author62", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9901), "ISBN62", true, false, 10m, 10, "Summary62", "Book62" },
                    { 63, "Author63", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9903), "ISBN63", true, false, 10m, 10, "Summary63", "Book63" },
                    { 64, "Author64", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9904), "ISBN64", true, false, 10m, 10, "Summary64", "Book64" },
                    { 65, "Author65", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9906), "ISBN65", true, false, 10m, 10, "Summary65", "Book65" },
                    { 66, "Author66", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9908), "ISBN66", true, false, 10m, 10, "Summary66", "Book66" },
                    { 67, "Author67", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9910), "ISBN67", true, false, 10m, 10, "Summary67", "Book67" },
                    { 68, "Author68", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9912), "ISBN68", true, false, 10m, 10, "Summary68", "Book68" },
                    { 69, "Author69", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9913), "ISBN69", true, false, 10m, 10, "Summary69", "Book69" },
                    { 70, "Author70", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9915), "ISBN70", true, false, 10m, 10, "Summary70", "Book70" },
                    { 71, "Author71", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9916), "ISBN71", true, false, 10m, 10, "Summary71", "Book71" },
                    { 72, "Author72", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9918), "ISBN72", true, false, 10m, 10, "Summary72", "Book72" },
                    { 73, "Author73", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9920), "ISBN73", true, false, 10m, 10, "Summary73", "Book73" },
                    { 74, "Author74", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9921), "ISBN74", true, false, 10m, 10, "Summary74", "Book74" },
                    { 75, "Author75", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9950), "ISBN75", true, false, 10m, 10, "Summary75", "Book75" },
                    { 76, "Author76", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9953), "ISBN76", true, false, 10m, 10, "Summary76", "Book76" },
                    { 77, "Author77", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9955), "ISBN77", true, false, 10m, 10, "Summary77", "Book77" },
                    { 78, "Author78", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9956), "ISBN78", true, false, 10m, 10, "Summary78", "Book78" },
                    { 79, "Author79", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9958), "ISBN79", true, false, 10m, 10, "Summary79", "Book79" },
                    { 80, "Author80", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9960), "ISBN80", true, false, 10m, 10, "Summary80", "Book80" },
                    { 81, "Author81", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9962), "ISBN81", true, false, 10m, 10, "Summary81", "Book81" },
                    { 82, "Author82", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9963), "ISBN82", true, false, 10m, 10, "Summary82", "Book82" },
                    { 83, "Author83", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9965), "ISBN83", true, false, 10m, 10, "Summary83", "Book83" },
                    { 84, "Author84", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9967), "ISBN84", true, false, 10m, 10, "Summary84", "Book84" },
                    { 85, "Author85", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9969), "ISBN85", true, false, 10m, 10, "Summary85", "Book85" },
                    { 86, "Author86", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9971), "ISBN86", true, false, 10m, 10, "Summary86", "Book86" },
                    { 87, "Author87", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9972), "ISBN87", true, false, 10m, 10, "Summary87", "Book87" },
                    { 88, "Author88", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9974), "ISBN88", true, false, 10m, 10, "Summary88", "Book88" },
                    { 89, "Author89", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9976), "ISBN89", true, false, 10m, 10, "Summary89", "Book89" },
                    { 90, "Author90", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9977), "ISBN90", true, false, 10m, 10, "Summary90", "Book90" },
                    { 91, "Author91", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9979), "ISBN91", true, false, 10m, 10, "Summary91", "Book91" },
                    { 92, "Author92", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9981), "ISBN92", true, false, 10m, 10, "Summary92", "Book92" },
                    { 93, "Author93", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9982), "ISBN93", true, false, 10m, 10, "Summary93", "Book93" },
                    { 94, "Author94", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9984), "ISBN94", true, false, 10m, 10, "Summary94", "Book94" },
                    { 95, "Author95", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9986), "ISBN95", true, false, 10m, 10, "Summary95", "Book95" },
                    { 96, "Author96", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9987), "ISBN96", true, false, 10m, 10, "Summary96", "Book96" },
                    { 97, "Author97", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9989), "ISBN97", true, false, 10m, 10, "Summary97", "Book97" },
                    { 98, "Author98", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9991), "ISBN98", true, false, 10m, 10, "Summary98", "Book98" },
                    { 99, "Author99", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9992), "ISBN99", true, false, 10m, 10, "Summary99", "Book99" },
                    { 100, "Author100", "https://m.media-amazon.com/images/I/71W4dU3uOZL._AC_UF350,350_QL80_.jpg", new DateTime(2023, 11, 13, 1, 1, 9, 686, DateTimeKind.Local).AddTicks(9994), "ISBN100", true, false, 10m, 10, "Summary100", "Book100" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "Category1" },
                    { 2, true, false, "Category2" },
                    { 3, true, false, "Category3" },
                    { 4, true, false, "Category4" },
                    { 5, true, false, "Category5" },
                    { 6, true, false, "Category6" },
                    { 7, true, false, "Category7" },
                    { 8, true, false, "Category8" },
                    { 9, true, false, "Category9" },
                    { 10, true, false, "Category10" }
                });

            migrationBuilder.InsertData(
                table: "bookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 6 },
                    { 3, 9 },
                    { 4, 7 },
                    { 5, 10 },
                    { 6, 6 },
                    { 7, 3 },
                    { 8, 2 },
                    { 9, 5 },
                    { 10, 6 },
                    { 11, 3 },
                    { 12, 7 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 3 },
                    { 16, 7 },
                    { 17, 9 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 3 },
                    { 21, 10 },
                    { 22, 5 },
                    { 23, 1 },
                    { 24, 3 },
                    { 25, 9 },
                    { 26, 10 },
                    { 27, 10 },
                    { 28, 5 },
                    { 29, 8 },
                    { 30, 9 },
                    { 31, 5 },
                    { 32, 7 },
                    { 33, 5 },
                    { 34, 9 },
                    { 35, 1 },
                    { 36, 6 },
                    { 37, 7 },
                    { 38, 6 },
                    { 39, 4 },
                    { 40, 8 },
                    { 41, 9 },
                    { 42, 6 },
                    { 43, 3 },
                    { 44, 3 },
                    { 45, 1 },
                    { 46, 2 },
                    { 47, 7 },
                    { 48, 1 },
                    { 49, 4 },
                    { 50, 9 },
                    { 51, 7 },
                    { 52, 8 },
                    { 53, 3 },
                    { 54, 3 },
                    { 55, 6 },
                    { 56, 3 },
                    { 57, 1 },
                    { 58, 3 },
                    { 59, 7 },
                    { 60, 6 },
                    { 61, 7 },
                    { 62, 2 },
                    { 63, 3 },
                    { 64, 2 },
                    { 65, 4 },
                    { 66, 5 },
                    { 67, 8 },
                    { 68, 8 },
                    { 69, 2 },
                    { 70, 3 },
                    { 71, 8 },
                    { 72, 3 },
                    { 73, 2 },
                    { 74, 8 },
                    { 75, 2 },
                    { 76, 8 },
                    { 77, 10 },
                    { 78, 7 },
                    { 79, 3 },
                    { 80, 2 },
                    { 81, 3 },
                    { 82, 8 },
                    { 83, 3 },
                    { 84, 9 },
                    { 85, 8 },
                    { 86, 10 },
                    { 87, 1 },
                    { 88, 9 },
                    { 89, 5 },
                    { 90, 3 },
                    { 91, 3 },
                    { 92, 6 },
                    { 93, 1 },
                    { 94, 3 },
                    { 95, 5 },
                    { 96, 3 },
                    { 97, 8 },
                    { 98, 1 },
                    { 99, 1 },
                    { 100, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 7 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 10 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 9 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 6 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 5 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 3 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 8 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "bookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 5 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");
        }
    }
}
