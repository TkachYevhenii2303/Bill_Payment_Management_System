using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bill_Payment_Management_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Bogus_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "ID", "Balance", "BankTitle", "CreatedDateTime", "SwithCode", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("058286f1-0323-4b7d-81fc-768e804697f3"), 114.50m, "Marvin Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3972), "012", null },
                    { new Guid("05c130d0-696e-4e29-a43a-0b59874cbc45"), 611.34m, "Kemmer and Sons", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3732), "360", null },
                    { new Guid("0c5a707c-800d-4a5d-b718-307ca094804b"), 694.36m, "Mills - Schaden", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1646), "738", null },
                    { new Guid("10028310-9315-4cf8-a40c-da97f9452e82"), 581.71m, "Wiegand - Runte", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(344), "719", null },
                    { new Guid("16bfba5d-8d48-47d4-8a21-a911000f515d"), 207.88m, "Terry, Boyer and Spencer", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6877), "891", null },
                    { new Guid("172a9dae-446a-4adc-a608-5a3716514bf9"), 33.70m, "Christiansen - Hirthe", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6206), "256", null },
                    { new Guid("2631a0bb-a502-45ec-ab65-d7a7e733342a"), 744.23m, "Walsh Inc", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3450), "899", null },
                    { new Guid("2a38d95c-2890-41e8-9c40-b694d52c1e25"), 968.40m, "Rice, Reichert and Auer", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2980), "129", null },
                    { new Guid("34ef67ca-31bc-4660-bca6-b98cc82f2aa0"), 182.19m, "Feest - Mohr", new DateTime(2023, 5, 11, 10, 3, 42, 42, DateTimeKind.Local).AddTicks(9828), "124", null },
                    { new Guid("35b7b17f-19e5-4400-bf8a-bc3dae464db1"), 323.70m, "McLaughlin - Brakus", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6355), "447", null },
                    { new Guid("3788b397-6f56-49ed-ba41-9d86e6044f3a"), 595.15m, "Kris, Kilback and Considine", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4796), "901", null },
                    { new Guid("3c6b89f0-aeb3-48fa-91b2-d6a0166728de"), 439.07m, "Moen Inc", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2396), "811", null },
                    { new Guid("47837055-95c6-4123-b2cf-024f29365fb6"), 924.89m, "Mills LLC", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1926), "591", null },
                    { new Guid("559a9d3f-f784-4a52-9f5c-ee65321f99f1"), 627.80m, "Lebsack Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(958), "936", null },
                    { new Guid("55f4d148-a232-4e1e-a652-9c6fa0af824d"), 854.39m, "Buckridge Inc", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6458), "465", null },
                    { new Guid("5ff0b966-b1de-4924-a3cc-1c4babb1e6fc"), 523.73m, "Lehner - Lind", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2840), "339", null },
                    { new Guid("60ed2325-d53d-4209-8bb5-0ec780ac4015"), 969.73m, "Turcotte, Rippin and Rau", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1148), "265", null },
                    { new Guid("655cd521-5a6f-4e3c-92e6-34f7d5a36369"), 82.34m, "Mueller, Spencer and Roberts", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5266), "680", null },
                    { new Guid("66c7bef5-cafc-45d2-a071-0a60f12df003"), 241.23m, "Heidenreich and Sons", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4690), "406", null },
                    { new Guid("698cd106-c76c-4722-a245-4181d07013ba"), 702.96m, "Jerde - Mueller", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6104), "608", null },
                    { new Guid("6d9dcd2e-cb8c-4a42-a0a5-4e7225995cd1"), 482.42m, "Kiehn Inc", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2288), "744", null },
                    { new Guid("75f225e3-5164-4385-b89c-cc91b8b86e17"), 988.14m, "Beier - Hoeger", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4075), "202", null },
                    { new Guid("7e5f3541-f074-458a-9570-92d2eb9ee1d2"), 210.39m, "Collier LLC", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3554), "705", null },
                    { new Guid("7f3a2b4f-5b38-4477-a896-c0114a7f76bf"), 460.85m, "Mills - Tremblay", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(665), "773", null },
                    { new Guid("863f3e06-84a0-44c0-b7dd-0c3cebc6a4e2"), 640.70m, "Oberbrunner - Orn", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4979), "113", null },
                    { new Guid("8d4349fa-a4c9-4a82-92bc-361d2726167c"), 214.71m, "Runolfsdottir - Vandervort", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6596), "529", null },
                    { new Guid("8ecf635a-afee-41c7-807e-0cc63b2f8910"), 874.80m, "Schuppe, Effertz and Lehner", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(483), "183", null },
                    { new Guid("90f0b1e0-2bdb-46b7-8a59-de196ff1c90c"), 544.78m, "Kuphal Inc", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5734), "246", null },
                    { new Guid("9bf798ee-af41-414b-923a-c424d44069d1"), 148.24m, "Hirthe, Bergnaum and Becker", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4492), "305", null },
                    { new Guid("9c0c018a-ee7b-4265-a4f3-9e13212cc3df"), 308.44m, "Kiehn Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3307), "307", null },
                    { new Guid("a3fc4852-77ee-4c02-9282-e8454007af4e"), 744.19m, "Rowe and Sons", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1299), "260", null },
                    { new Guid("a4962071-9195-4411-ba06-c24f0d9ea0fd"), 523.84m, "Schaefer Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2035), "473", null },
                    { new Guid("a816f455-f011-4c17-9304-d4d50cb642f4"), 285.96m, "Brekke, Jerde and Herzog", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5551), "363", null },
                    { new Guid("ae496530-6dea-4890-98b9-b23858bc9847"), 131.15m, "Farrell, Yundt and Harris", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1750), "603", null },
                    { new Guid("bf002f3e-db7d-45a5-9506-d1d969efb5ea"), 895.80m, "Bechtelar, Friesen and Bartoletti", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5085), "053", null },
                    { new Guid("c107a52a-87fc-4288-936c-6b3c35ccec3d"), 91.79m, "Muller, Jaskolski and Littel", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(778), "511", null },
                    { new Guid("c25b8910-5bfd-4a20-856d-5bc6d4418c32"), 872.12m, "Berge Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5445), "153", null },
                    { new Guid("c79e6a74-6378-41a0-80cd-ab1dc6bb1863"), 451.40m, "Jenkins Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4211), "140", null },
                    { new Guid("c97e6f4a-8577-42a1-9429-0cd874d90347"), 116.85m, "Doyle Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2697), "868", null },
                    { new Guid("ca1cdef6-280d-4336-ac27-3e7d3a1f7519"), 976.66m, "Hansen and Sons", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(2531), "511", null },
                    { new Guid("ccc929ea-deae-44e1-9e93-927354fece90"), 857.58m, "Sawayn, Von and Satterfield", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4), "222", null },
                    { new Guid("d0957b41-c3f3-4ab3-a673-37d7e42103ab"), 792.38m, "Gorczany, Kuhn and Prosacco", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(191), "572", null },
                    { new Guid("d0b37139-06e9-4311-a7cc-361394d2e1c3"), 826.32m, "Bode, Beatty and Cummings", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3124), "089", null },
                    { new Guid("d807cfc9-9852-4d38-b291-4c09727a341d"), 504.51m, "Skiles, Morar and Pfeffer", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(6700), "827", null },
                    { new Guid("e1afd01e-b09c-49fa-8851-50a7142ae31e"), 644.08m, "Dickens, Mosciski and Mraz", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(1444), "771", null },
                    { new Guid("e4d17015-21cc-44b1-b1a5-ae0cfffa1e46"), 932.22m, "Koss and Sons", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(4318), "606", null },
                    { new Guid("e68a042c-566a-4272-bf72-7f5ba7956600"), 350.05m, "Marks LLC", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(3836), "970", null },
                    { new Guid("ea211b90-13e1-4b4f-a2fa-d8b3b49a7011"), 67.76m, "Kirlin Group", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5869), "487", null },
                    { new Guid("f5cf0326-9cf2-462f-b8e8-71406145e4d7"), 429.75m, "Roberts LLC", new DateTime(2023, 5, 11, 10, 3, 42, 43, DateTimeKind.Local).AddTicks(5971), "012", null },
                    { new Guid("fb58d6ce-de1b-4b94-af6f-770f2f5f2bf0"), 330.68m, "Schultz - Hansen", new DateTime(2023, 5, 11, 10, 3, 42, 42, DateTimeKind.Local).AddTicks(8981), "461", null }
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "ID", "CreatedDateTime", "ExpirationDate", "Limit", "MoneyOwned", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("01c0ff7c-6450-4103-8a26-2221b7064475"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 7, 25, 12, 42, 46, 976, DateTimeKind.Local).AddTicks(1312), 431.79m, false, null },
                    { new Guid("02ae29c4-51eb-4d97-ba5a-517f5847ce64"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 9, 17, 8, 53, 27, 107, DateTimeKind.Local).AddTicks(3668), 888.53m, false, null },
                    { new Guid("053e6297-8484-473d-90d1-fec08ddb1c3c"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 12, 18, 18, 25, 41, 519, DateTimeKind.Local).AddTicks(9422), 751.13m, true, null },
                    { new Guid("0c63bfc6-9546-4d7b-9ec4-e97c80cb3b8d"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 10, 22, 12, 51, 49, 691, DateTimeKind.Local).AddTicks(6107), 308.06m, true, null },
                    { new Guid("0d1f9c6e-d3cb-4e14-8d46-7cb217241467"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 12, 16, 4, 9, 46, 244, DateTimeKind.Local).AddTicks(835), 804.14m, false, null },
                    { new Guid("18c24add-c346-4146-929b-bf50093aa68d"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 3, 9, 21, 48, 54, 48, DateTimeKind.Local).AddTicks(6365), 418.67m, true, null },
                    { new Guid("1d3490ca-7731-451c-8b7c-a5cf0eeb2b70"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 12, 24, 20, 22, 59, 21, DateTimeKind.Local).AddTicks(7987), 499.15m, false, null },
                    { new Guid("23790e45-94ae-49e7-8b15-5eae043967d0"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2792), new DateTime(2024, 3, 5, 20, 35, 21, 249, DateTimeKind.Local).AddTicks(8071), 620.59m, true, null },
                    { new Guid("2577e2dc-1019-456d-a988-c2667cf33897"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 10, 7, 7, 30, 47, 103, DateTimeKind.Local).AddTicks(2571), 778.49m, false, null },
                    { new Guid("25c164ac-1a02-43fe-9cf0-51b49d19ab73"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 6, 26, 8, 24, 51, 187, DateTimeKind.Local).AddTicks(2823), 477.51m, true, null },
                    { new Guid("26a8fb2a-9f8c-433f-af73-b5af325974c8"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 9, 22, 12, 58, 47, 747, DateTimeKind.Local).AddTicks(7845), 340.19m, true, null },
                    { new Guid("27a8fedd-01d0-4d15-bb4d-6c778f034e0e"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 11, 22, 12, 49, 9, 33, DateTimeKind.Local).AddTicks(2430), 629.26m, true, null },
                    { new Guid("2a47b215-8198-42b6-b085-072336c2f407"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 4, 29, 3, 13, 22, 349, DateTimeKind.Local).AddTicks(4987), 941.83m, false, null },
                    { new Guid("50a1a9d1-667b-4c0a-a108-7686758da3d8"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 6, 7, 2, 58, 9, 432, DateTimeKind.Local).AddTicks(8617), 675.58m, false, null },
                    { new Guid("5a559d5c-942d-49d8-a2f4-a056e5396b8e"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 10, 21, 22, 49, 44, 792, DateTimeKind.Local).AddTicks(6709), 586.98m, false, null },
                    { new Guid("5e7bf9a6-ba09-4d87-bb6a-1c6c7645ce7f"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2985), new DateTime(2024, 1, 8, 4, 58, 44, 637, DateTimeKind.Local).AddTicks(1171), 408.97m, true, null },
                    { new Guid("5fda03b0-ed87-4143-a977-e1132ad68ae2"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 9, 21, 23, 12, 20, 590, DateTimeKind.Local).AddTicks(8833), 800.83m, true, null },
                    { new Guid("644a011f-c242-4762-a14e-7cef84e6e755"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 10, 21, 11, 3, 43, 187, DateTimeKind.Local).AddTicks(4218), 552.39m, false, null },
                    { new Guid("708d5a36-c282-4ef8-a7b6-c093853b2a20"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 7, 30, 7, 55, 17, 709, DateTimeKind.Local).AddTicks(2177), 486.75m, true, null },
                    { new Guid("73d61520-7175-4438-a6ca-31cdcce70d7d"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 10, 31, 7, 27, 2, 224, DateTimeKind.Local).AddTicks(637), 855.74m, true, null },
                    { new Guid("7689c824-7f87-4be7-a05b-6b33787d8389"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 7, 3, 11, 33, 19, 11, DateTimeKind.Local).AddTicks(9403), 107.84m, false, null },
                    { new Guid("76e0e0c1-ff92-4350-a120-ee250ba9e3f0"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 12, 13, 10, 49, 2, 962, DateTimeKind.Local).AddTicks(7336), 623.89m, true, null },
                    { new Guid("7a8f6a9e-8ee5-4f39-9c1f-51e937cf5ad4"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 12, 10, 5, 56, 53, 997, DateTimeKind.Local).AddTicks(9600), 916.51m, true, null },
                    { new Guid("8bce849c-5398-4730-807f-c893fea3c844"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 12, 28, 15, 56, 28, 852, DateTimeKind.Local).AddTicks(9249), 994.74m, true, null },
                    { new Guid("8c35ffbd-60bd-4e32-8343-502f7f6a891b"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 10, 15, 13, 5, 39, 132, DateTimeKind.Local).AddTicks(647), 397.96m, true, null },
                    { new Guid("8d9965a7-60f8-4ee2-8477-4baff6af4f67"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 8, 1, 19, 59, 47, 605, DateTimeKind.Local).AddTicks(3209), 857.80m, true, null },
                    { new Guid("8f94fec3-a3e1-42ad-8a52-182b90e85231"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 9, 16, 1, 58, 45, 768, DateTimeKind.Local).AddTicks(2392), 919.89m, false, null },
                    { new Guid("9170c036-eec3-4455-b2fc-2b7faed00085"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 2, 10, 2, 39, 24, 613, DateTimeKind.Local).AddTicks(3219), 840.50m, false, null },
                    { new Guid("929d48ab-9b9d-4229-800e-2e42084c87f0"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3164), new DateTime(2023, 9, 16, 4, 19, 22, 696, DateTimeKind.Local).AddTicks(2532), 275.54m, false, null },
                    { new Guid("95c3c876-3155-4d67-a754-0a08c5fb2da8"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 12, 26, 14, 5, 11, 416, DateTimeKind.Local).AddTicks(5143), 312.31m, false, null },
                    { new Guid("9f34352f-32f0-4ddc-8351-04e05fada5ac"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 4, 1, 19, 36, 0, 124, DateTimeKind.Local).AddTicks(1759), 113.77m, true, null },
                    { new Guid("a2c9d1c4-3fad-4282-a0c8-e0d81b81e50f"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 2, 18, 18, 54, 36, 72, DateTimeKind.Local).AddTicks(827), 810.69m, false, null },
                    { new Guid("aea72de0-69c7-4e9b-85d2-a267e886a38f"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 5, 28, 15, 41, 5, 672, DateTimeKind.Local).AddTicks(5454), 175.65m, false, null },
                    { new Guid("b1d696e0-2d72-4d15-934e-a5d64e0cc5be"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2817), new DateTime(2024, 3, 23, 11, 56, 55, 738, DateTimeKind.Local).AddTicks(3424), 990.75m, false, null },
                    { new Guid("b53b5df8-78f0-437d-8da7-b6ae1a1e01b3"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2404), new DateTime(2023, 8, 17, 14, 26, 57, 352, DateTimeKind.Local).AddTicks(5250), 118.94m, true, null },
                    { new Guid("be2c5392-9746-48d2-aaae-0e2379df9959"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 5, 13, 22, 14, 25, 681, DateTimeKind.Local).AddTicks(5911), 136.51m, false, null },
                    { new Guid("c104a6c9-7861-4877-9b8e-451336c8e314"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 5, 25, 22, 48, 18, 774, DateTimeKind.Local).AddTicks(6131), 342.98m, false, null },
                    { new Guid("c2b622de-18b6-49cb-9cdb-af6e17ffaecd"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3139), new DateTime(2024, 5, 4, 12, 31, 11, 170, DateTimeKind.Local).AddTicks(3546), 481.76m, true, null },
                    { new Guid("c3b40105-4b51-48c1-8881-9468f13f5792"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 3, 26, 23, 26, 12, 243, DateTimeKind.Local).AddTicks(2091), 339.23m, false, null },
                    { new Guid("c9f98697-8bda-415b-ade0-efd60f9e423c"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 9, 15, 2, 17, 53, 930, DateTimeKind.Local).AddTicks(870), 156.82m, true, null },
                    { new Guid("d0a4fdf1-8d57-4f82-b1ec-4fb058a2337e"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 4, 23, 9, 31, 59, 521, DateTimeKind.Local).AddTicks(1190), 287.68m, true, null },
                    { new Guid("d9fd9836-6c29-43ce-a0b7-c2a760ae8132"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2998), new DateTime(2024, 3, 7, 6, 53, 22, 263, DateTimeKind.Local).AddTicks(322), 369.59m, true, null },
                    { new Guid("dd677cd0-2dee-4f46-8771-37109299c4c5"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 8, 31, 10, 37, 20, 178, DateTimeKind.Local).AddTicks(130), 826.49m, true, null },
                    { new Guid("e235f647-fd17-4b6b-a08b-e04a7a09b188"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 8, 23, 0, 37, 49, 437, DateTimeKind.Local).AddTicks(4806), 20.21m, true, null },
                    { new Guid("e6e9acb9-b7a1-4b63-8288-c849b75a653d"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 6, 7, 21, 3, 2, 831, DateTimeKind.Local).AddTicks(4208), 301.69m, false, null },
                    { new Guid("f32ec43b-0951-4a59-bc44-c679a3d7fe33"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 9, 29, 9, 40, 1, 225, DateTimeKind.Local).AddTicks(8855), 683.60m, true, null },
                    { new Guid("faf697cb-f482-4b74-820e-9b5541539dae"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(2870), new DateTime(2024, 4, 17, 4, 4, 1, 584, DateTimeKind.Local).AddTicks(295), 885.95m, false, null },
                    { new Guid("fb295fda-511a-4e60-b19c-d0fd2117c4b0"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 2, 27, 3, 29, 27, 117, DateTimeKind.Local).AddTicks(5799), 838.17m, false, null },
                    { new Guid("ff21d401-13a7-44b3-8fa2-620644a770d1"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 7, 12, 6, 36, 40, 117, DateTimeKind.Local).AddTicks(2127), 929.10m, true, null },
                    { new Guid("ffca64e0-883a-4348-a8b0-82cc1cc54fcb"), new DateTime(2023, 5, 11, 10, 3, 42, 46, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 7, 30, 4, 48, 49, 608, DateTimeKind.Local).AddTicks(5247), 330.95m, true, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedDateTime", "Email", "Name", "Password", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("006964ea-4715-4c68-8747-4a27b9d09cc8"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(599), "NicholasBruen25@hotmail.com", "Nicholas Bruen", "XxtC2yxp4g", null },
                    { new Guid("01b371c0-d062-4254-a1af-b8f657fcbbfe"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(3536), "GerardoNikolaus_Hand1@gmail.com", "Gerardo Nikolaus", "qwTA_zHicG", null },
                    { new Guid("0291b51b-98ba-46a1-8d5c-6f103cdb6e65"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(4500), "NathanielBrekke_Lockman@gmail.com", "Nathaniel Brekke", "JPg36GydcW", null },
                    { new Guid("04eca414-5770-4580-a541-e4a777d7a553"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(4645), "AdaCrist.Abshire84@yahoo.com", "Ada Crist", "mFRMqRbnW2", null },
                    { new Guid("0710cb6f-f1e0-47ee-96ce-c41a740ca748"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(5546), "MelanieWehner.Nikolaus39@hotmail.com", "Melanie Wehner", "d6Gxk83l32", null },
                    { new Guid("081e3e62-1656-43be-b300-4408d95205e4"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(8869), "ClaraMertz18@gmail.com", "Clara Mertz", "fTWr6WaL2J", null },
                    { new Guid("0835c87b-b037-4b36-b431-a2f5ed8a951b"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(4647), "CesarHowell36@gmail.com", "Cesar Howell", "pdDN5pSTE1", null },
                    { new Guid("0e18966c-f0d5-4a40-9f88-c32f65538456"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(7366), "JohnathanRippin38@hotmail.com", "Johnathan Rippin", "YoxLIWHPeJ", null },
                    { new Guid("0ee43f12-c6fc-4575-8a00-7413992fde6a"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(6269), "MargaritaSchneider_Hansen@gmail.com", "Margarita Schneider", "sbYTg6znG6", null },
                    { new Guid("12391b43-b602-4edb-9adb-cd4579dcbcde"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(3091), "SimonCremin89@yahoo.com", "Simon Cremin", "wXuIX9YxlK", null },
                    { new Guid("13df7bc3-b3ec-47d0-be22-5fe748235075"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(4409), "HugoTurner.Hayes88@hotmail.com", "Hugo Turner", "VlLtQ2hJJv", null },
                    { new Guid("155bad98-02bd-480e-9c26-1f93eec3f7cd"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(7235), "ColinKling41@hotmail.com", "Colin Kling", "NwiwBBGvec", null },
                    { new Guid("1b5bc28f-c8fc-4b7e-ae28-2e4c887d4275"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(802), "OmarSchaefer_Luettgen75@yahoo.com", "Omar Schaefer", "EQFa8lRam1", null },
                    { new Guid("1c21b45b-1718-412d-9b4d-c1d3184ec9e0"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(7681), "HenriettaHills98@gmail.com", "Henrietta Hills", "xFOV3p70Dp", null },
                    { new Guid("215d2ed3-ee94-49e8-af2a-1f2f9b11530a"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(7278), "MichelleJohnston_Douglas@hotmail.com", "Michelle Johnston", "GJ6NPnxIo2", null },
                    { new Guid("22a458da-12df-4c80-bcf4-16aee6bd17e8"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(8991), "TraceyEmard_OConner@yahoo.com", "Tracey Emard", "OHyQWSAb_9", null },
                    { new Guid("264f1a07-7776-4b0b-8076-71530f73743b"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(6768), "AdrianBogisich.Cronin@hotmail.com", "Adrian Bogisich", "lk3nae1VL3", null },
                    { new Guid("2a836d0c-522e-4ef2-b3f4-3a54a338056d"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(6774), "CalebLubowitz.Homenick8@gmail.com", "Caleb Lubowitz", "4cVvuc_GQU", null },
                    { new Guid("2b243319-77dd-4557-bb18-adf96d098264"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(2833), "KevinSchuster_Cole54@hotmail.com", "Kevin Schuster", "Mt823Qe6XL", null },
                    { new Guid("2d1f36f7-0845-4ce2-a01a-bd7a63d6fc93"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(8044), "JackFritsch_Rath@yahoo.com", "Jack Fritsch", "xSqXkW3a3b", null },
                    { new Guid("31811c76-9a19-4024-8644-82c332adbf2e"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(3835), "BeatriceLind_Gerhold97@hotmail.com", "Beatrice Lind", "XUk5dBMonu", null },
                    { new Guid("334c1d80-9cf9-47d9-bf0e-77d6902ebcf4"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(5656), "AltonBernier78@hotmail.com", "Alton Bernier", "nIxE5J1IS6", null },
                    { new Guid("3be3db6a-0ae6-46c8-b684-942c332bdf8e"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(9019), "KarlaAbernathy0@yahoo.com", "Karla Abernathy", "SAEptw96du", null },
                    { new Guid("3d0d9822-3fff-47f0-bcaf-b5d9c2fa72ce"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(1289), "AustinAdams.Beahan19@hotmail.com", "Austin Adams", "b6Ly9bpSVa", null },
                    { new Guid("3d532113-fcd8-4966-b68b-bd8aabdeed92"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(5002), "DustinWalker.Daniel@gmail.com", "Dustin Walker", "wlSc0V6h2Y", null },
                    { new Guid("42183835-6448-4488-b847-4b0cdb57336d"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(6391), "DianaHoppe_Lind75@yahoo.com", "Diana Hoppe", "5WMGM7k1h5", null },
                    { new Guid("49347c8b-c9d0-4aec-ae4d-9b5e49712217"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(6492), "ClayGleason_Kiehn26@yahoo.com", "Clay Gleason", "vwFvgGTeGX", null },
                    { new Guid("4afb9e48-0c65-4733-b7c7-6be41d0c2b05"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(1069), "KatherineHarber_Hilll@hotmail.com", "Katherine Harber", "FJt3tV8ccu", null },
                    { new Guid("4c731bc6-fab7-4972-af73-66fc500607a3"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(3547), "TashaSchneider.Smith69@yahoo.com", "Tasha Schneider", "GrbU011osV", null },
                    { new Guid("4fa99b9b-3393-443d-8775-65034d0b6538"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(802), "MattFeeney.Prosacco@yahoo.com", "Matt Feeney", "4dWVpviiFl", null },
                    { new Guid("50fc8abc-d299-4024-94da-d7229e623669"), new DateTime(2023, 5, 11, 10, 3, 42, 30, DateTimeKind.Local).AddTicks(8816), "DustinMohr9@gmail.com", "Dustin Mohr", "JZtWWEoCFz", null },
                    { new Guid("53f26863-749d-481b-837c-fd475e594cd4"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(3981), "SheldonWalter44@gmail.com", "Sheldon Walter", "MRZNBhrmcu", null },
                    { new Guid("54f1a5d8-9b37-470a-889f-d8691a095ab5"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(9347), "DarrellMurazik1@gmail.com", "Darrell Murazik", "zj1TG4Kmcj", null },
                    { new Guid("551c11ec-6a88-4787-b6b3-0251941e3543"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(3726), "PamelaSmitham32@yahoo.com", "Pamela Smitham", "zhAuGAG46S", null },
                    { new Guid("5b5f8b7f-e86e-4633-9e8f-c960555c9a02"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(2778), "ShaunKohler.Thompson29@gmail.com", "Shaun Kohler", "H9CBun38d3", null },
                    { new Guid("5befe664-ea24-41dd-855c-b671552e2899"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(4568), "NellieReichel_Reichel@gmail.com", "Nellie Reichel", "vH84GmC18A", null },
                    { new Guid("6417bbc7-d538-4092-94ef-6408dd0e3e23"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(9021), "SamanthaHowell_Yost11@hotmail.com", "Samantha Howell", "MGUKZ9sE1U", null },
                    { new Guid("6538345b-fdf7-4881-92b1-850edcfdf071"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(3348), "RyanOndricka7@gmail.com", "Ryan Ondricka", "eFaDSsiSyV", null },
                    { new Guid("67ebd7a0-e312-4605-9af9-a8266cd9a1bd"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(1044), "RomanKunze59@yahoo.com", "Roman Kunze", "xVpBl7wzXV", null },
                    { new Guid("693f2f3f-e85a-45a3-9662-c3207a3082a4"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(872), "JulioLemke_Schroeder@gmail.com", "Julio Lemke", "8A7S_mFgtn", null },
                    { new Guid("6b6fbcc2-4ecc-4acb-9811-e7a870f9b708"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(9935), "PedroBode_Watsica@yahoo.com", "Pedro Bode", "0O8FGQVl36", null },
                    { new Guid("7a59bbff-c2c2-4da3-a74e-11c9f9df37fa"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(4318), "TomasBailey_Funk63@gmail.com", "Tomas Bailey", "WVjPUQnpmm", null },
                    { new Guid("7b629ce9-df3b-408e-a781-582420662409"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(9902), "TomLegros_Jerde16@yahoo.com", "Tom Legros", "Ky2LmETICn", null },
                    { new Guid("7c6d31ec-6088-42d5-8a16-75559c3f2868"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(1846), "MorrisFeil57@gmail.com", "Morris Feil", "Zdbckuht4m", null },
                    { new Guid("7cbc8baf-d1c0-4f90-8e4c-5f730ea27d70"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(512), "DixieHomenick42@gmail.com", "Dixie Homenick", "XYcJOHJTRA", null },
                    { new Guid("7e0ade16-4ec1-4823-8c88-c243eb7b6c7d"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(9217), "SaraGorczany_Kulas91@yahoo.com", "Sara Gorczany", "R_n6N1LXnR", null },
                    { new Guid("7e73cee1-2828-4a7a-83cc-167b8214a530"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(1321), "CecilTurner_Johnston95@hotmail.com", "Cecil Turner", "750vfHhr7n", null },
                    { new Guid("829d48b0-41b0-4781-9fe5-625c83102c56"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(2464), "NealBahringer.Kohler@gmail.com", "Neal Bahringer", "i7_fKFg2jU", null },
                    { new Guid("847ae148-7a51-4535-9d8a-ef98aa1b87ee"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(2851), "WesleyWaters_Ratke62@gmail.com", "Wesley Waters", "sHQtiT25Z5", null },
                    { new Guid("877ac72f-c5f6-49c2-aa1b-7482d85dc090"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(6022), "AndyDibbert.Smith@yahoo.com", "Andy Dibbert", "_HsQ4Ffa4Y", null },
                    { new Guid("88e899b9-4e55-45ef-859b-90a06d26017d"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(851), "OrlandoRunolfsson_Mayer@yahoo.com", "Orlando Runolfsson", "IgW0zvEKyR", null },
                    { new Guid("8b19ea37-03b7-47b0-8cee-018ccd7176d5"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(6041), "TomOrn.Baumbach2@hotmail.com", "Tom Orn", "M8f3hhiYTI", null },
                    { new Guid("8c94f667-cd79-44e4-91ec-4f2bd3f43512"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(5071), "CalebStrosin.Schuppe51@yahoo.com", "Caleb Strosin", "gA8YaNoa1v", null },
                    { new Guid("901facb2-e378-430d-95e1-7ed2527862f9"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(7559), "JoFunk70@yahoo.com", "Jo Funk", "rK0f1EBD2w", null },
                    { new Guid("909ac67c-d653-4b82-aa13-00b4cc75a6db"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(5406), "HermanBorer.Feeney79@hotmail.com", "Herman Borer", "NquzmtYk6a", null },
                    { new Guid("91ea5f7c-4b74-47d4-93a0-9cbf57b6bdfd"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(7238), "OrlandoSchmitt96@hotmail.com", "Orlando Schmitt", "uyckAuKuzO", null },
                    { new Guid("94693528-e169-431f-b435-44796efbb170"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(5389), "LeslieHarber17@yahoo.com", "Leslie Harber", "X3I1VlHkAA", null },
                    { new Guid("94a266a5-8eb4-4bc1-9bba-bab8f2bdcdb4"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(5090), "LuzSteuber.Reichel5@hotmail.com", "Luz Steuber", "IDgkeuNiDx", null },
                    { new Guid("9508757c-9cdd-4379-a1c2-a890c16e75f8"), new DateTime(2023, 5, 11, 10, 3, 42, 37, DateTimeKind.Local).AddTicks(8204), "MikeHuel_Gislason62@gmail.com", "Mike Huel", "ypUiFhIVIW", null },
                    { new Guid("962fef06-b809-46a0-9705-3eae9dc268d6"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(4820), "SidneyLeuschke90@yahoo.com", "Sidney Leuschke", "2EVVZsTqtW", null },
                    { new Guid("989cceb4-d7e9-41b2-8956-0a2c56de4031"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(70), "ErinRatke85@yahoo.com", "Erin Ratke", "mQ8bJPG3UC", null },
                    { new Guid("98c8639d-a297-4386-88ce-2b44f11c5293"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(6934), "JeremiahHermiston5@yahoo.com", "Jeremiah Hermiston", "3rP_eanXza", null },
                    { new Guid("9988395a-2537-490f-9836-c36fc30d049b"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(6444), "DaleRomaguera.Quigley14@yahoo.com", "Dale Romaguera", "LiRr_Opauy", null },
                    { new Guid("99c596df-c57b-486e-bd9f-dd8d9161c3ff"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(6215), "ChadLang_Roob@gmail.com", "Chad Lang", "x9Pnflh638", null },
                    { new Guid("99e66afe-e20e-4717-994e-705daf8a2fbc"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(5210), "KristenRogahn_Gutkowski67@gmail.com", "Kristen Rogahn", "OX5xAGt3Jc", null },
                    { new Guid("9e489241-c767-430a-bf16-2010cde89386"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(3457), "MeganKozey_Hyatt20@gmail.com", "Megan Kozey", "j4le1DJdW3", null },
                    { new Guid("9fc7816c-0ad0-4b27-8c2f-35d66aa12f0e"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(5461), "GeraldineSmith_Hermiston@yahoo.com", "Geraldine Smith", "2prlEHPQd9", null },
                    { new Guid("a55a4a6c-858a-4869-b904-e3c454912cd4"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(8500), "SalvatoreJast_Walter60@gmail.com", "Salvatore Jast", "LdYRb6BMqQ", null },
                    { new Guid("a6bd392c-2948-4ea2-8bd8-ba163c90f99b"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(2177), "ThelmaRobel95@hotmail.com", "Thelma Robel", "Cw9Vrr5Cye", null },
                    { new Guid("a97784f6-7dc1-4f91-9fa8-6a2e2a49bb20"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(6483), "JanisEbert97@gmail.com", "Janis Ebert", "59s90vn61V", null },
                    { new Guid("aa668f69-6962-4ccc-addd-c0756134470a"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(2291), "HomerEffertz96@gmail.com", "Homer Effertz", "1gBPFcOLOq", null },
                    { new Guid("ac1c0857-7d38-4774-a2e8-5c85c213c514"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(4238), "GregoryPredovic15@gmail.com", "Gregory Predovic", "dwDPcHQU4I", null },
                    { new Guid("ae4178a6-b26f-499d-b876-aa85083b89fb"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(7475), "DoreenShanahan25@hotmail.com", "Doreen Shanahan", "tyBVUahFY6", null },
                    { new Guid("afb75d58-efae-43f6-8a96-980a020a475b"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(9745), "MarionSchowalter.Hirthe@hotmail.com", "Marion Schowalter", "Z_y7yPJcCH", null },
                    { new Guid("afd7d8c4-e4dd-4db6-9f29-d4b76f9561ec"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(2568), "RandolphWindler_Lowe@yahoo.com", "Randolph Windler", "GpdRD9ImAM", null },
                    { new Guid("b138d6fe-1dcd-421d-9ea3-eba431140c46"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(7068), "ElizabethWehner18@gmail.com", "Elizabeth Wehner", "u6nkOSP0j6", null },
                    { new Guid("b718e0f7-b215-4c16-ad3d-006661a1f978"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(9361), "RooseveltRunte.OHara@hotmail.com", "Roosevelt Runte", "V4fuCWNo8v", null },
                    { new Guid("bc05ced6-1992-4c92-be2c-675fe596b4b9"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(3706), "CaseyKub_Spencer61@yahoo.com", "Casey Kub", "648romHCf0", null },
                    { new Guid("bd155a1d-264d-4ff8-b467-c9d0830b06c4"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(233), "CharleneSchaden10@hotmail.com", "Charlene Schaden", "o5Rou65tkw", null },
                    { new Guid("bd8f32cf-23f6-435c-96ce-98fd05c011e4"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(5930), "LoriMaggio4@yahoo.com", "Lori Maggio", "qstV5A7nhM", null },
                    { new Guid("c197c7cc-ccdf-473d-9245-65111b4e76b5"), new DateTime(2023, 5, 11, 10, 3, 42, 31, DateTimeKind.Local).AddTicks(8117), "ReginaldLueilwitz.Yundt@hotmail.com", "Reginald Lueilwitz", "qenlxr19BQ", null },
                    { new Guid("c3d499f4-6176-48ca-8aba-19069ca76c57"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(1899), "EricGleichner14@hotmail.com", "Eric Gleichner", "nga2Inixgb", null },
                    { new Guid("cb83fd9b-eca5-4ed6-81df-2377bf14c15b"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(1449), "PennyKihn_Reynolds73@yahoo.com", "Penny Kihn", "Nfm_l4QbF1", null },
                    { new Guid("d05315be-189b-4384-9ad6-e1cd119a9c4f"), new DateTime(2023, 5, 11, 10, 3, 42, 40, DateTimeKind.Local).AddTicks(1940), "NadineSpinka.Johnson58@gmail.com", "Nadine Spinka", "hI9hDoCB0w", null },
                    { new Guid("d0a55314-0613-46a6-9f03-4d6d1e7528e2"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(2143), "DixieLarson86@gmail.com", "Dixie Larson", "oQT6UUEo2w", null },
                    { new Guid("d1a41a10-0ea0-41f7-bdd6-2c59960d33c5"), new DateTime(2023, 5, 11, 10, 3, 42, 32, DateTimeKind.Local).AddTicks(6167), "JuneDach_Purdy@gmail.com", "June Dach", "u_zfAvlElu", null },
                    { new Guid("d8b56e16-3056-4569-802e-626ef1c0ade8"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(205), "JohnFay_Funk0@gmail.com", "John Fay", "ADoBiFTirC", null },
                    { new Guid("d90f1872-bdc6-4c2b-b90a-d4da1cfaf4c0"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(5181), "ScottDavis.Keeling37@yahoo.com", "Scott Davis", "1XFUhk_afg", null },
                    { new Guid("d9d3f3bd-18df-4cb1-b3aa-f720aa96a29b"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(9364), "ErnestinePurdy52@yahoo.com", "Ernestine Purdy", "0KYn1wqXcq", null },
                    { new Guid("df60b2ee-8fbf-42ab-9792-178e35fe91c4"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(8164), "HarrietMcGlynn.Pagac@gmail.com", "Harriet McGlynn", "FhFXFwA358", null },
                    { new Guid("e4c0dcf5-a2e0-4afe-a1d4-ac2c26d0f07d"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(6904), "PhilWatsica_Kunde@gmail.com", "Phil Watsica", "waeEjBwlmn", null },
                    { new Guid("e4e4b035-5c23-42a8-94f9-260b34b2020e"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(3952), "MelvinFahey.Beier@hotmail.com", "Melvin Fahey", "3pL_wGAnDx", null },
                    { new Guid("eb8a28fb-e7f8-4a9e-9d9f-14f91bb7ac40"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(8263), "DiannaBrown64@gmail.com", "Dianna Brown", "4KrQWyclsU", null },
                    { new Guid("f01514c5-8193-4caf-b471-375b4a071201"), new DateTime(2023, 5, 11, 10, 3, 42, 38, DateTimeKind.Local).AddTicks(2992), "RitaConn.Harber@gmail.com", "Rita Conn", "UgA004H5xc", null },
                    { new Guid("f01f3dad-287e-453c-8eea-1662671aa796"), new DateTime(2023, 5, 11, 10, 3, 42, 35, DateTimeKind.Local).AddTicks(2721), "JesseMonahan32@gmail.com", "Jesse Monahan", "wbMKdAprV3", null },
                    { new Guid("f413a42f-d3e1-45bc-90db-421f8393c1fe"), new DateTime(2023, 5, 11, 10, 3, 42, 33, DateTimeKind.Local).AddTicks(8329), "MiguelSanford65@gmail.com", "Miguel Sanford", "X9JO_HWKjs", null },
                    { new Guid("f8305b9c-cdf3-4bad-bcf6-e47897993e7d"), new DateTime(2023, 5, 11, 10, 3, 42, 39, DateTimeKind.Local).AddTicks(8529), "JustinDurgan_Wolf@yahoo.com", "Justin Durgan", "f07ehJME6W", null },
                    { new Guid("f98fd5f4-d7c7-4769-8900-46e076c9dff8"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(7672), "JasonBoyle.Bashirian@yahoo.com", "Jason Boyle", "6GsJ52XPBn", null },
                    { new Guid("fc344a3f-50ec-4b3f-a40e-d977aa65eb3f"), new DateTime(2023, 5, 11, 10, 3, 42, 36, DateTimeKind.Local).AddTicks(9109), "AngelinaOKeefe40@gmail.com", "Angelina O'Keefe", "BHfUPZX91H", null },
                    { new Guid("ff73d9ba-2e66-4142-90ad-ada7c457eb5e"), new DateTime(2023, 5, 11, 10, 3, 42, 34, DateTimeKind.Local).AddTicks(1701), "KristiOkuneva_OConnell50@hotmail.com", "Kristi Okuneva", "g6_aXitQte", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "ID", "BankAccountsId", "CreatedDateTime", "CreditCardsId", "CustomersId", "PaymentTypes", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("02adc07f-79d1-4b9a-9e09-044729a272e1"), new Guid("f5cf0326-9cf2-462f-b8e8-71406145e4d7"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9657), new Guid("c3b40105-4b51-48c1-8881-9468f13f5792"), new Guid("215d2ed3-ee94-49e8-af2a-1f2f9b11530a"), 0, null },
                    { new Guid("0539577e-2a31-4e86-96a9-4fa4d0f75521"), new Guid("d0957b41-c3f3-4ab3-a673-37d7e42103ab"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(8987), new Guid("8d9965a7-60f8-4ee2-8477-4baff6af4f67"), new Guid("9e489241-c767-430a-bf16-2010cde89386"), 4, null },
                    { new Guid("06a27f92-a245-4743-9c40-5d96a615f9cc"), new Guid("655cd521-5a6f-4e3c-92e6-34f7d5a36369"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9580), new Guid("e235f647-fd17-4b6b-a08b-e04a7a09b188"), new Guid("2b243319-77dd-4557-bb18-adf96d098264"), 2, null },
                    { new Guid("1d1b80b0-0633-4811-bb68-7442bfa67587"), new Guid("559a9d3f-f784-4a52-9f5c-ee65321f99f1"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9083), new Guid("be2c5392-9746-48d2-aaae-0e2379df9959"), new Guid("f01f3dad-287e-453c-8eea-1662671aa796"), 2, null },
                    { new Guid("1e926b8d-17c6-4c67-bf44-413ecea7830f"), new Guid("c97e6f4a-8577-42a1-9429-0cd874d90347"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9258), new Guid("76e0e0c1-ff92-4350-a120-ee250ba9e3f0"), new Guid("264f1a07-7776-4b0b-8076-71530f73743b"), 5, null },
                    { new Guid("1f1dd62b-b3fd-47b1-b735-3b63481a9846"), new Guid("fb58d6ce-de1b-4b94-af6f-770f2f5f2bf0"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(8379), new Guid("9170c036-eec3-4455-b2fc-2b7faed00085"), new Guid("01b371c0-d062-4254-a1af-b8f657fcbbfe"), 2, null },
                    { new Guid("23fc53b1-ca77-4443-8cfa-c7e2d26e6728"), new Guid("05c130d0-696e-4e29-a43a-0b59874cbc45"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9410), new Guid("23790e45-94ae-49e7-8b15-5eae043967d0"), new Guid("94a266a5-8eb4-4bc1-9bba-bab8f2bdcdb4"), 5, null },
                    { new Guid("254ccdfb-71b1-4e67-8a20-7845156f606f"), new Guid("2631a0bb-a502-45ec-ab65-d7a7e733342a"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9375), new Guid("8f94fec3-a3e1-42ad-8a52-182b90e85231"), new Guid("22a458da-12df-4c80-bcf4-16aee6bd17e8"), 1, null },
                    { new Guid("2581f554-64c8-4dc7-ba0e-ab4f63d6f8e0"), new Guid("8ecf635a-afee-41c7-807e-0cc63b2f8910"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9033), new Guid("2577e2dc-1019-456d-a988-c2667cf33897"), new Guid("3d0d9822-3fff-47f0-bcaf-b5d9c2fa72ce"), 2, null },
                    { new Guid("28613717-8042-4b89-b749-40a79824a144"), new Guid("60ed2325-d53d-4209-8bb5-0ec780ac4015"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9098), new Guid("708d5a36-c282-4ef8-a7b6-c093853b2a20"), new Guid("aa668f69-6962-4ccc-addd-c0756134470a"), 4, null },
                    { new Guid("31f97f6e-e027-48dd-8b5d-b9366b3da69b"), new Guid("66c7bef5-cafc-45d2-a071-0a60f12df003"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9518), new Guid("644a011f-c242-4762-a14e-7cef84e6e755"), new Guid("b718e0f7-b215-4c16-ad3d-006661a1f978"), 5, null },
                    { new Guid("33686a87-2d35-4973-ba10-413c00f65aa9"), new Guid("863f3e06-84a0-44c0-b7dd-0c3cebc6a4e2"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9548), new Guid("5e7bf9a6-ba09-4d87-bb6a-1c6c7645ce7f"), new Guid("334c1d80-9cf9-47d9-bf0e-77d6902ebcf4"), 5, null },
                    { new Guid("3b63a9c7-c4cd-4bc9-a608-3cebb4bc8fbc"), new Guid("698cd106-c76c-4722-a245-4181d07013ba"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9672), new Guid("ff21d401-13a7-44b3-8fa2-620644a770d1"), new Guid("afb75d58-efae-43f6-8a96-980a020a475b"), 5, null },
                    { new Guid("3c0fd05a-c84b-4cfc-afa8-af312c060aa8"), new Guid("e1afd01e-b09c-49fa-8851-50a7142ae31e"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9131), new Guid("27a8fedd-01d0-4d15-bb4d-6c778f034e0e"), new Guid("7c6d31ec-6088-42d5-8a16-75559c3f2868"), 2, null },
                    { new Guid("3c654bb0-e435-40c9-9c3c-0acb78311c84"), new Guid("172a9dae-446a-4adc-a608-5a3716514bf9"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9689), new Guid("053e6297-8484-473d-90d1-fec08ddb1c3c"), new Guid("12391b43-b602-4edb-9adb-cd4579dcbcde"), 3, null },
                    { new Guid("41eda6c3-b5e4-45ff-9962-28919b6a951d"), new Guid("9c0c018a-ee7b-4265-a4f3-9e13212cc3df"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9359), new Guid("0c63bfc6-9546-4d7b-9ec4-e97c80cb3b8d"), new Guid("1c21b45b-1718-412d-9b4d-c1d3184ec9e0"), 0, null },
                    { new Guid("44d5610e-58ec-46d8-8aff-c09efc85a5bd"), new Guid("bf002f3e-db7d-45a5-9506-d1d969efb5ea"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9564), new Guid("d9fd9836-6c29-43ce-a0b7-c2a760ae8132"), new Guid("2b243319-77dd-4557-bb18-adf96d098264"), 0, null },
                    { new Guid("4a8876d3-bc42-4ca0-8142-64ebeaf01059"), new Guid("e68a042c-566a-4272-bf72-7f5ba7956600"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9427), new Guid("01c0ff7c-6450-4103-8a26-2221b7064475"), new Guid("3d0d9822-3fff-47f0-bcaf-b5d9c2fa72ce"), 0, null },
                    { new Guid("4d16d972-9faa-45d2-9c4a-9b41ef8a8c3c"), new Guid("7f3a2b4f-5b38-4477-a896-c0114a7f76bf"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9050), new Guid("25c164ac-1a02-43fe-9cf0-51b49d19ab73"), new Guid("8c94f667-cd79-44e4-91ec-4f2bd3f43512"), 5, null },
                    { new Guid("51280e68-485f-4c69-b192-0e06b8320006"), new Guid("47837055-95c6-4123-b2cf-024f29365fb6"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9181), new Guid("2a47b215-8198-42b6-b085-072336c2f407"), new Guid("ae4178a6-b26f-499d-b876-aa85083b89fb"), 0, null },
                    { new Guid("5605e1bb-2b54-4f6b-9eb1-cfc051f51787"), new Guid("2a38d95c-2890-41e8-9c40-b694d52c1e25"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9293), new Guid("8c35ffbd-60bd-4e32-8343-502f7f6a891b"), new Guid("877ac72f-c5f6-49c2-aa1b-7482d85dc090"), 3, null },
                    { new Guid("5a530665-9055-43d9-a3dd-6fab588fa4dd"), new Guid("75f225e3-5164-4385-b89c-cc91b8b86e17"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9457), new Guid("1d3490ca-7731-451c-8b7c-a5cf0eeb2b70"), new Guid("264f1a07-7776-4b0b-8076-71530f73743b"), 4, null },
                    { new Guid("63050db6-28ed-451d-b325-a31ff3661e85"), new Guid("058286f1-0323-4b7d-81fc-768e804697f3"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9443), new Guid("b1d696e0-2d72-4d15-934e-a5d64e0cc5be"), new Guid("94a266a5-8eb4-4bc1-9bba-bab8f2bdcdb4"), 3, null },
                    { new Guid("67d865ae-2c5b-44cd-ae34-8e1f397c9c90"), new Guid("7e5f3541-f074-458a-9570-92d2eb9ee1d2"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9394), new Guid("f32ec43b-0951-4a59-bc44-c679a3d7fe33"), new Guid("334c1d80-9cf9-47d9-bf0e-77d6902ebcf4"), 4, null },
                    { new Guid("6bfe5898-8b6a-4220-a3b0-e69df1766726"), new Guid("c107a52a-87fc-4288-936c-6b3c35ccec3d"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9066), new Guid("5fda03b0-ed87-4143-a977-e1132ad68ae2"), new Guid("e4c0dcf5-a2e0-4afe-a1d4-ac2c26d0f07d"), 1, null },
                    { new Guid("6e208da3-c8bf-4773-9550-20ad0c4cb6dd"), new Guid("0c5a707c-800d-4a5d-b718-307ca094804b"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9149), new Guid("c104a6c9-7861-4877-9b8e-451336c8e314"), new Guid("0710cb6f-f1e0-47ee-96ce-c41a740ca748"), 0, null },
                    { new Guid("700421ce-d451-446a-b727-a60d23fc1cf3"), new Guid("34ef67ca-31bc-4660-bca6-b98cc82f2aa0"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(8946), new Guid("b53b5df8-78f0-437d-8da7-b6ae1a1e01b3"), new Guid("67ebd7a0-e312-4605-9af9-a8266cd9a1bd"), 5, null },
                    { new Guid("709e17c1-93cd-459b-92a5-69c79b95fff7"), new Guid("10028310-9315-4cf8-a40c-da97f9452e82"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9016), new Guid("18c24add-c346-4146-929b-bf50093aa68d"), new Guid("3be3db6a-0ae6-46c8-b684-942c332bdf8e"), 5, null },
                    { new Guid("7b28ef34-e9dc-451b-9b59-f0ce8a31e148"), new Guid("d807cfc9-9852-4d38-b291-4c09727a341d"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9754), new Guid("a2c9d1c4-3fad-4282-a0c8-e0d81b81e50f"), new Guid("94693528-e169-431f-b435-44796efbb170"), 2, null },
                    { new Guid("7fd9e3b3-181d-4a27-9ea5-2aaced80647f"), new Guid("d0b37139-06e9-4311-a7cc-361394d2e1c3"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9308), new Guid("02ae29c4-51eb-4d97-ba5a-517f5847ce64"), new Guid("c3d499f4-6176-48ca-8aba-19069ca76c57"), 1, null },
                    { new Guid("8b8db2ac-2a11-49ec-89e6-620713550a19"), new Guid("8d4349fa-a4c9-4a82-92bc-361d2726167c"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9738), new Guid("c2b622de-18b6-49cb-9cdb-af6e17ffaecd"), new Guid("829d48b0-41b0-4781-9fe5-625c83102c56"), 1, null },
                    { new Guid("8d193936-c974-4af8-ba7a-d5da234910af"), new Guid("16bfba5d-8d48-47d4-8a21-a911000f515d"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9769), new Guid("929d48ab-9b9d-4229-800e-2e42084c87f0"), new Guid("c3d499f4-6176-48ca-8aba-19069ca76c57"), 5, null },
                    { new Guid("8dfca02a-40b6-4732-bc37-5599671c223a"), new Guid("9bf798ee-af41-414b-923a-c424d44069d1"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9502), new Guid("faf697cb-f482-4b74-820e-9b5541539dae"), new Guid("4fa99b9b-3393-443d-8775-65034d0b6538"), 4, null },
                    { new Guid("907f55b8-25d3-4ad4-a682-4676dc9567f6"), new Guid("55f4d148-a232-4e1e-a652-9c6fa0af824d"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9721), new Guid("fb295fda-511a-4e60-b19c-d0fd2117c4b0"), new Guid("42183835-6448-4488-b847-4b0cdb57336d"), 4, null },
                    { new Guid("910172c5-6380-4b92-8f2a-e07efe1a2ab2"), new Guid("ae496530-6dea-4890-98b9-b23858bc9847"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9166), new Guid("7689c824-7f87-4be7-a05b-6b33787d8389"), new Guid("afd7d8c4-e4dd-4db6-9f29-d4b76f9561ec"), 3, null },
                    { new Guid("93feefe5-61df-4b40-8ffe-d75939854e9e"), new Guid("ea211b90-13e1-4b4f-a2fa-d8b3b49a7011"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9642), new Guid("0d1f9c6e-d3cb-4e14-8d46-7cb217241467"), new Guid("54f1a5d8-9b37-470a-889f-d8691a095ab5"), 3, null },
                    { new Guid("9ae3c5e6-1736-4fa5-bd4a-7736fd3f3518"), new Guid("a3fc4852-77ee-4c02-9282-e8454007af4e"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9114), new Guid("aea72de0-69c7-4e9b-85d2-a267e886a38f"), new Guid("c197c7cc-ccdf-473d-9245-65111b4e76b5"), 0, null },
                    { new Guid("9c90b3d4-c8c9-4906-93d9-c16024826800"), new Guid("c25b8910-5bfd-4a20-856d-5bc6d4418c32"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9594), new Guid("5a559d5c-942d-49d8-a2f4-a056e5396b8e"), new Guid("215d2ed3-ee94-49e8-af2a-1f2f9b11530a"), 0, null },
                    { new Guid("a11e4604-0ec0-4221-ab33-b49b9f4a101d"), new Guid("e4d17015-21cc-44b1-b1a5-ae0cfffa1e46"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9488), new Guid("73d61520-7175-4438-a6ca-31cdcce70d7d"), new Guid("67ebd7a0-e312-4605-9af9-a8266cd9a1bd"), 1, null },
                    { new Guid("ab79854f-1d58-453e-9cca-513bd3142ac4"), new Guid("a816f455-f011-4c17-9304-d4d50cb642f4"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9610), new Guid("50a1a9d1-667b-4c0a-a108-7686758da3d8"), new Guid("bc05ced6-1992-4c92-be2c-675fe596b4b9"), 3, null },
                    { new Guid("acbfdb2b-7ae8-493e-95aa-8c24c8577c1d"), new Guid("3c6b89f0-aeb3-48fa-91b2-d6a0166728de"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9229), new Guid("9f34352f-32f0-4ddc-8351-04e05fada5ac"), new Guid("9988395a-2537-490f-9836-c36fc30d049b"), 0, null },
                    { new Guid("bd3f8452-c9c3-4ae2-aa65-ad8cb98127f5"), new Guid("ca1cdef6-280d-4336-ac27-3e7d3a1f7519"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9244), new Guid("8bce849c-5398-4730-807f-c893fea3c844"), new Guid("3d0d9822-3fff-47f0-bcaf-b5d9c2fa72ce"), 2, null },
                    { new Guid("c9244e20-586e-421f-bcde-7a3a516ab22b"), new Guid("6d9dcd2e-cb8c-4a42-a0a5-4e7225995cd1"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9214), new Guid("d0a4fdf1-8d57-4f82-b1ec-4fb058a2337e"), new Guid("9988395a-2537-490f-9836-c36fc30d049b"), 3, null },
                    { new Guid("d1d8180b-e1ff-4f79-8633-5fcf27e4edc1"), new Guid("35b7b17f-19e5-4400-bf8a-bc3dae464db1"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9705), new Guid("c9f98697-8bda-415b-ade0-efd60f9e423c"), new Guid("7cbc8baf-d1c0-4f90-8e4c-5f730ea27d70"), 2, null },
                    { new Guid("de84cb0c-bbcd-4ce1-a4f7-b951ba61108f"), new Guid("90f0b1e0-2bdb-46b7-8a59-de196ff1c90c"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9626), new Guid("ffca64e0-883a-4348-a8b0-82cc1cc54fcb"), new Guid("f01514c5-8193-4caf-b471-375b4a071201"), 2, null },
                    { new Guid("e13ce82c-fc6e-4425-88f6-31fa999378cf"), new Guid("ccc929ea-deae-44e1-9e93-927354fece90"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(8970), new Guid("7a8f6a9e-8ee5-4f39-9c1f-51e937cf5ad4"), new Guid("d0a55314-0613-46a6-9f03-4d6d1e7528e2"), 5, null },
                    { new Guid("e6e07ae2-58d3-4d2d-86d4-1cf644b00bc7"), new Guid("c79e6a74-6378-41a0-80cd-ab1dc6bb1863"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9472), new Guid("dd677cd0-2dee-4f46-8771-37109299c4c5"), new Guid("2a836d0c-522e-4ef2-b3f4-3a54a338056d"), 0, null },
                    { new Guid("e7bb1063-33b9-4624-b1a4-b27cf702dd45"), new Guid("5ff0b966-b1de-4924-a3cc-1c4babb1e6fc"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9276), new Guid("95c3c876-3155-4d67-a754-0a08c5fb2da8"), new Guid("d1a41a10-0ea0-41f7-bdd6-2c59960d33c5"), 1, null },
                    { new Guid("eebf89dd-36ad-467d-a1c4-91e727652a86"), new Guid("3788b397-6f56-49ed-ba41-9d86e6044f3a"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9534), new Guid("e6e9acb9-b7a1-4b63-8288-c849b75a653d"), new Guid("c3d499f4-6176-48ca-8aba-19069ca76c57"), 5, null },
                    { new Guid("f46c7185-5e87-41fa-b07d-25a56e727ad5"), new Guid("a4962071-9195-4411-ba06-c24f0d9ea0fd"), new DateTime(2023, 5, 11, 10, 3, 42, 48, DateTimeKind.Local).AddTicks(9198), new Guid("26a8fb2a-9f8c-433f-af73-b5af325974c8"), new Guid("d90f1872-bdc6-4c2b-b90a-d4da1cfaf4c0"), 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("006964ea-4715-4c68-8747-4a27b9d09cc8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0291b51b-98ba-46a1-8d5c-6f103cdb6e65"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("04eca414-5770-4580-a541-e4a777d7a553"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("081e3e62-1656-43be-b300-4408d95205e4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0835c87b-b037-4b36-b431-a2f5ed8a951b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0e18966c-f0d5-4a40-9f88-c32f65538456"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0ee43f12-c6fc-4575-8a00-7413992fde6a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("13df7bc3-b3ec-47d0-be22-5fe748235075"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("155bad98-02bd-480e-9c26-1f93eec3f7cd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1b5bc28f-c8fc-4b7e-ae28-2e4c887d4275"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2d1f36f7-0845-4ce2-a01a-bd7a63d6fc93"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("31811c76-9a19-4024-8644-82c332adbf2e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3d532113-fcd8-4966-b68b-bd8aabdeed92"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("49347c8b-c9d0-4aec-ae4d-9b5e49712217"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4afb9e48-0c65-4733-b7c7-6be41d0c2b05"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4c731bc6-fab7-4972-af73-66fc500607a3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("50fc8abc-d299-4024-94da-d7229e623669"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("53f26863-749d-481b-837c-fd475e594cd4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("551c11ec-6a88-4787-b6b3-0251941e3543"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5b5f8b7f-e86e-4633-9e8f-c960555c9a02"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5befe664-ea24-41dd-855c-b671552e2899"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("6417bbc7-d538-4092-94ef-6408dd0e3e23"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("6538345b-fdf7-4881-92b1-850edcfdf071"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("693f2f3f-e85a-45a3-9662-c3207a3082a4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("6b6fbcc2-4ecc-4acb-9811-e7a870f9b708"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7a59bbff-c2c2-4da3-a74e-11c9f9df37fa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7b629ce9-df3b-408e-a781-582420662409"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7e0ade16-4ec1-4823-8c88-c243eb7b6c7d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7e73cee1-2828-4a7a-83cc-167b8214a530"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("847ae148-7a51-4535-9d8a-ef98aa1b87ee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("88e899b9-4e55-45ef-859b-90a06d26017d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("8b19ea37-03b7-47b0-8cee-018ccd7176d5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("901facb2-e378-430d-95e1-7ed2527862f9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("909ac67c-d653-4b82-aa13-00b4cc75a6db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("91ea5f7c-4b74-47d4-93a0-9cbf57b6bdfd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("9508757c-9cdd-4379-a1c2-a890c16e75f8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("962fef06-b809-46a0-9705-3eae9dc268d6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("989cceb4-d7e9-41b2-8956-0a2c56de4031"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("98c8639d-a297-4386-88ce-2b44f11c5293"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("99c596df-c57b-486e-bd9f-dd8d9161c3ff"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("99e66afe-e20e-4717-994e-705daf8a2fbc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("9fc7816c-0ad0-4b27-8c2f-35d66aa12f0e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("a55a4a6c-858a-4869-b904-e3c454912cd4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("a6bd392c-2948-4ea2-8bd8-ba163c90f99b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("a97784f6-7dc1-4f91-9fa8-6a2e2a49bb20"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("ac1c0857-7d38-4774-a2e8-5c85c213c514"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b138d6fe-1dcd-421d-9ea3-eba431140c46"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bd155a1d-264d-4ff8-b467-c9d0830b06c4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bd8f32cf-23f6-435c-96ce-98fd05c011e4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("cb83fd9b-eca5-4ed6-81df-2377bf14c15b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d05315be-189b-4384-9ad6-e1cd119a9c4f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d8b56e16-3056-4569-802e-626ef1c0ade8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d9d3f3bd-18df-4cb1-b3aa-f720aa96a29b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("df60b2ee-8fbf-42ab-9792-178e35fe91c4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e4e4b035-5c23-42a8-94f9-260b34b2020e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("eb8a28fb-e7f8-4a9e-9d9f-14f91bb7ac40"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f413a42f-d3e1-45bc-90db-421f8393c1fe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f8305b9c-cdf3-4bad-bcf6-e47897993e7d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f98fd5f4-d7c7-4769-8900-46e076c9dff8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("fc344a3f-50ec-4b3f-a40e-d977aa65eb3f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("ff73d9ba-2e66-4142-90ad-ada7c457eb5e"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("02adc07f-79d1-4b9a-9e09-044729a272e1"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("0539577e-2a31-4e86-96a9-4fa4d0f75521"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("06a27f92-a245-4743-9c40-5d96a615f9cc"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("1d1b80b0-0633-4811-bb68-7442bfa67587"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("1e926b8d-17c6-4c67-bf44-413ecea7830f"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("1f1dd62b-b3fd-47b1-b735-3b63481a9846"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("23fc53b1-ca77-4443-8cfa-c7e2d26e6728"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("254ccdfb-71b1-4e67-8a20-7845156f606f"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("2581f554-64c8-4dc7-ba0e-ab4f63d6f8e0"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("28613717-8042-4b89-b749-40a79824a144"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("31f97f6e-e027-48dd-8b5d-b9366b3da69b"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("33686a87-2d35-4973-ba10-413c00f65aa9"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("3b63a9c7-c4cd-4bc9-a608-3cebb4bc8fbc"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("3c0fd05a-c84b-4cfc-afa8-af312c060aa8"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("3c654bb0-e435-40c9-9c3c-0acb78311c84"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("41eda6c3-b5e4-45ff-9962-28919b6a951d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("44d5610e-58ec-46d8-8aff-c09efc85a5bd"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("4a8876d3-bc42-4ca0-8142-64ebeaf01059"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("4d16d972-9faa-45d2-9c4a-9b41ef8a8c3c"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("51280e68-485f-4c69-b192-0e06b8320006"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("5605e1bb-2b54-4f6b-9eb1-cfc051f51787"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("5a530665-9055-43d9-a3dd-6fab588fa4dd"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("63050db6-28ed-451d-b325-a31ff3661e85"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("67d865ae-2c5b-44cd-ae34-8e1f397c9c90"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("6bfe5898-8b6a-4220-a3b0-e69df1766726"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("6e208da3-c8bf-4773-9550-20ad0c4cb6dd"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("700421ce-d451-446a-b727-a60d23fc1cf3"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("709e17c1-93cd-459b-92a5-69c79b95fff7"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("7b28ef34-e9dc-451b-9b59-f0ce8a31e148"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("7fd9e3b3-181d-4a27-9ea5-2aaced80647f"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("8b8db2ac-2a11-49ec-89e6-620713550a19"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("8d193936-c974-4af8-ba7a-d5da234910af"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("8dfca02a-40b6-4732-bc37-5599671c223a"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("907f55b8-25d3-4ad4-a682-4676dc9567f6"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("910172c5-6380-4b92-8f2a-e07efe1a2ab2"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("93feefe5-61df-4b40-8ffe-d75939854e9e"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("9ae3c5e6-1736-4fa5-bd4a-7736fd3f3518"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("9c90b3d4-c8c9-4906-93d9-c16024826800"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("a11e4604-0ec0-4221-ab33-b49b9f4a101d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("ab79854f-1d58-453e-9cca-513bd3142ac4"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("acbfdb2b-7ae8-493e-95aa-8c24c8577c1d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("bd3f8452-c9c3-4ae2-aa65-ad8cb98127f5"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("c9244e20-586e-421f-bcde-7a3a516ab22b"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("d1d8180b-e1ff-4f79-8633-5fcf27e4edc1"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("de84cb0c-bbcd-4ce1-a4f7-b951ba61108f"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("e13ce82c-fc6e-4425-88f6-31fa999378cf"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("e6e07ae2-58d3-4d2d-86d4-1cf644b00bc7"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("e7bb1063-33b9-4624-b1a4-b27cf702dd45"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("eebf89dd-36ad-467d-a1c4-91e727652a86"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "ID",
                keyValue: new Guid("f46c7185-5e87-41fa-b07d-25a56e727ad5"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("058286f1-0323-4b7d-81fc-768e804697f3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("05c130d0-696e-4e29-a43a-0b59874cbc45"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("0c5a707c-800d-4a5d-b718-307ca094804b"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("10028310-9315-4cf8-a40c-da97f9452e82"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("16bfba5d-8d48-47d4-8a21-a911000f515d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("172a9dae-446a-4adc-a608-5a3716514bf9"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("2631a0bb-a502-45ec-ab65-d7a7e733342a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("2a38d95c-2890-41e8-9c40-b694d52c1e25"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("34ef67ca-31bc-4660-bca6-b98cc82f2aa0"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("35b7b17f-19e5-4400-bf8a-bc3dae464db1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("3788b397-6f56-49ed-ba41-9d86e6044f3a"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("3c6b89f0-aeb3-48fa-91b2-d6a0166728de"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("47837055-95c6-4123-b2cf-024f29365fb6"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("559a9d3f-f784-4a52-9f5c-ee65321f99f1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("55f4d148-a232-4e1e-a652-9c6fa0af824d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("5ff0b966-b1de-4924-a3cc-1c4babb1e6fc"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("60ed2325-d53d-4209-8bb5-0ec780ac4015"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("655cd521-5a6f-4e3c-92e6-34f7d5a36369"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("66c7bef5-cafc-45d2-a071-0a60f12df003"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("698cd106-c76c-4722-a245-4181d07013ba"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("6d9dcd2e-cb8c-4a42-a0a5-4e7225995cd1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("75f225e3-5164-4385-b89c-cc91b8b86e17"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("7e5f3541-f074-458a-9570-92d2eb9ee1d2"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("7f3a2b4f-5b38-4477-a896-c0114a7f76bf"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("863f3e06-84a0-44c0-b7dd-0c3cebc6a4e2"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("8d4349fa-a4c9-4a82-92bc-361d2726167c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("8ecf635a-afee-41c7-807e-0cc63b2f8910"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("90f0b1e0-2bdb-46b7-8a59-de196ff1c90c"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("9bf798ee-af41-414b-923a-c424d44069d1"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("9c0c018a-ee7b-4265-a4f3-9e13212cc3df"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("a3fc4852-77ee-4c02-9282-e8454007af4e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("a4962071-9195-4411-ba06-c24f0d9ea0fd"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("a816f455-f011-4c17-9304-d4d50cb642f4"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("ae496530-6dea-4890-98b9-b23858bc9847"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("bf002f3e-db7d-45a5-9506-d1d969efb5ea"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("c107a52a-87fc-4288-936c-6b3c35ccec3d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("c25b8910-5bfd-4a20-856d-5bc6d4418c32"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("c79e6a74-6378-41a0-80cd-ab1dc6bb1863"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("c97e6f4a-8577-42a1-9429-0cd874d90347"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("ca1cdef6-280d-4336-ac27-3e7d3a1f7519"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("ccc929ea-deae-44e1-9e93-927354fece90"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("d0957b41-c3f3-4ab3-a673-37d7e42103ab"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("d0b37139-06e9-4311-a7cc-361394d2e1c3"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("d807cfc9-9852-4d38-b291-4c09727a341d"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("e1afd01e-b09c-49fa-8851-50a7142ae31e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("e4d17015-21cc-44b1-b1a5-ae0cfffa1e46"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("e68a042c-566a-4272-bf72-7f5ba7956600"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("ea211b90-13e1-4b4f-a2fa-d8b3b49a7011"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("f5cf0326-9cf2-462f-b8e8-71406145e4d7"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "ID",
                keyValue: new Guid("fb58d6ce-de1b-4b94-af6f-770f2f5f2bf0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("01c0ff7c-6450-4103-8a26-2221b7064475"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("02ae29c4-51eb-4d97-ba5a-517f5847ce64"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("053e6297-8484-473d-90d1-fec08ddb1c3c"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("0c63bfc6-9546-4d7b-9ec4-e97c80cb3b8d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("0d1f9c6e-d3cb-4e14-8d46-7cb217241467"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("18c24add-c346-4146-929b-bf50093aa68d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("1d3490ca-7731-451c-8b7c-a5cf0eeb2b70"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("23790e45-94ae-49e7-8b15-5eae043967d0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("2577e2dc-1019-456d-a988-c2667cf33897"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("25c164ac-1a02-43fe-9cf0-51b49d19ab73"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("26a8fb2a-9f8c-433f-af73-b5af325974c8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("27a8fedd-01d0-4d15-bb4d-6c778f034e0e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("2a47b215-8198-42b6-b085-072336c2f407"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("50a1a9d1-667b-4c0a-a108-7686758da3d8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("5a559d5c-942d-49d8-a2f4-a056e5396b8e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("5e7bf9a6-ba09-4d87-bb6a-1c6c7645ce7f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("5fda03b0-ed87-4143-a977-e1132ad68ae2"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("644a011f-c242-4762-a14e-7cef84e6e755"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("708d5a36-c282-4ef8-a7b6-c093853b2a20"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("73d61520-7175-4438-a6ca-31cdcce70d7d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("7689c824-7f87-4be7-a05b-6b33787d8389"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("76e0e0c1-ff92-4350-a120-ee250ba9e3f0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("7a8f6a9e-8ee5-4f39-9c1f-51e937cf5ad4"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("8bce849c-5398-4730-807f-c893fea3c844"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("8c35ffbd-60bd-4e32-8343-502f7f6a891b"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("8d9965a7-60f8-4ee2-8477-4baff6af4f67"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("8f94fec3-a3e1-42ad-8a52-182b90e85231"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("9170c036-eec3-4455-b2fc-2b7faed00085"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("929d48ab-9b9d-4229-800e-2e42084c87f0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("95c3c876-3155-4d67-a754-0a08c5fb2da8"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("9f34352f-32f0-4ddc-8351-04e05fada5ac"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("a2c9d1c4-3fad-4282-a0c8-e0d81b81e50f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("aea72de0-69c7-4e9b-85d2-a267e886a38f"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("b1d696e0-2d72-4d15-934e-a5d64e0cc5be"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("b53b5df8-78f0-437d-8da7-b6ae1a1e01b3"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("be2c5392-9746-48d2-aaae-0e2379df9959"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("c104a6c9-7861-4877-9b8e-451336c8e314"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("c2b622de-18b6-49cb-9cdb-af6e17ffaecd"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("c3b40105-4b51-48c1-8881-9468f13f5792"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("c9f98697-8bda-415b-ade0-efd60f9e423c"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("d0a4fdf1-8d57-4f82-b1ec-4fb058a2337e"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("d9fd9836-6c29-43ce-a0b7-c2a760ae8132"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("dd677cd0-2dee-4f46-8771-37109299c4c5"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("e235f647-fd17-4b6b-a08b-e04a7a09b188"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("e6e9acb9-b7a1-4b63-8288-c849b75a653d"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("f32ec43b-0951-4a59-bc44-c679a3d7fe33"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("faf697cb-f482-4b74-820e-9b5541539dae"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("fb295fda-511a-4e60-b19c-d0fd2117c4b0"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("ff21d401-13a7-44b3-8fa2-620644a770d1"));

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "ID",
                keyValue: new Guid("ffca64e0-883a-4348-a8b0-82cc1cc54fcb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("01b371c0-d062-4254-a1af-b8f657fcbbfe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0710cb6f-f1e0-47ee-96ce-c41a740ca748"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("12391b43-b602-4edb-9adb-cd4579dcbcde"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1c21b45b-1718-412d-9b4d-c1d3184ec9e0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("215d2ed3-ee94-49e8-af2a-1f2f9b11530a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("22a458da-12df-4c80-bcf4-16aee6bd17e8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("264f1a07-7776-4b0b-8076-71530f73743b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2a836d0c-522e-4ef2-b3f4-3a54a338056d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2b243319-77dd-4557-bb18-adf96d098264"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("334c1d80-9cf9-47d9-bf0e-77d6902ebcf4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3be3db6a-0ae6-46c8-b684-942c332bdf8e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3d0d9822-3fff-47f0-bcaf-b5d9c2fa72ce"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("42183835-6448-4488-b847-4b0cdb57336d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4fa99b9b-3393-443d-8775-65034d0b6538"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("54f1a5d8-9b37-470a-889f-d8691a095ab5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("67ebd7a0-e312-4605-9af9-a8266cd9a1bd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7c6d31ec-6088-42d5-8a16-75559c3f2868"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7cbc8baf-d1c0-4f90-8e4c-5f730ea27d70"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("829d48b0-41b0-4781-9fe5-625c83102c56"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("877ac72f-c5f6-49c2-aa1b-7482d85dc090"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("8c94f667-cd79-44e4-91ec-4f2bd3f43512"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("94693528-e169-431f-b435-44796efbb170"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("94a266a5-8eb4-4bc1-9bba-bab8f2bdcdb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("9988395a-2537-490f-9836-c36fc30d049b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("9e489241-c767-430a-bf16-2010cde89386"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("aa668f69-6962-4ccc-addd-c0756134470a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("ae4178a6-b26f-499d-b876-aa85083b89fb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("afb75d58-efae-43f6-8a96-980a020a475b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("afd7d8c4-e4dd-4db6-9f29-d4b76f9561ec"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b718e0f7-b215-4c16-ad3d-006661a1f978"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bc05ced6-1992-4c92-be2c-675fe596b4b9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c197c7cc-ccdf-473d-9245-65111b4e76b5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c3d499f4-6176-48ca-8aba-19069ca76c57"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d0a55314-0613-46a6-9f03-4d6d1e7528e2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d1a41a10-0ea0-41f7-bdd6-2c59960d33c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d90f1872-bdc6-4c2b-b90a-d4da1cfaf4c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e4c0dcf5-a2e0-4afe-a1d4-ac2c26d0f07d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f01514c5-8193-4caf-b471-375b4a071201"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f01f3dad-287e-453c-8eea-1662671aa796"));
        }
    }
}
