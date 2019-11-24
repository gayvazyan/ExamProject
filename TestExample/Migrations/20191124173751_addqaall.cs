using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addqaall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տվյալ տեխնիկական սարքավորման միջոցով գրանցված ընտրողների բացակայությունը հավաստող տեղեկանք" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "արգելվում է" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "քվեաթերթիկի վրա ինքնասոսնձվող դրոշմանիշը փակցնելուց հետո" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "իրավասու է իր որոշմամբ սահմանելու քվեարկության սենյակում միաժամանակյա գտնվելու իրավունք ունեցող դիտորդների և զանգվածային լրատվության միջոցների ներկայացուցիչների առավելագույն թիվը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "գրառվում են տեղամասային ընտրական հանձնաժողովի գրանցամատյանում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ընտրական հանձնաժողովի անդամ, վստահված անձ, դիտորդ, այցելու, զանգվածային լրատվության միջոցի ներկայացուցիչ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի անդամը տեղեկացնում է տեղամասային հանձնաժողովի նախագահին, որն ընտրողից վերցնում է քվեարկության ծրարը, անհապաղ մարում է՝ առանց պարունակությունը ստուգելու" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ոչ ուշ, քան մինչև ժամը 20:00-ն" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "շրջիկ արկղով քվեարկության դեպքում " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տեխնիկակական սարքավորման խափանման կամ չլինելու պարագայում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 174,
                column: "QuestionVariantContent",
                value: "քրեակատարողական հիմնարկում ");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "միայն մեկ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 179,
                column: "QuestionVariantContent",
                value: "քվեարկության օրը՝ ժամը 8:00-ից հետո, բայց այն հաշվարկով, որ քվեարկությունն ավարտվի մինչև ժամը 18:00-ն");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 183,
                column: "QuestionVariantContent",
                value: "ստացիոնար բուժման մեջ գտնվող, քվեարկության օրը տեղամասային կենտրոն ինքնուրույն ներկայանալու հնարավորություն չունեցող անձանց համար ");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 185,
                column: "QuestionVariantContent",
                value: "ձերբակալված անձանց պահելու վայրում քվեարկության օրը գտնվող ընտրողների համար");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "կցվում են քվեարկության օրն ընտրական տեղամասում կազմվող ընտրողների լրացուցիչ ցուցակին" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "քրեակատարողական հիմնարկում քվեարկության ժամանակ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "շրջիկ արկղով քվեարկության ժամանակ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տեխնիկական սարքավորման խափանման կամ չլինելու պարագայում քվեարկության ժամանակ " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի նախագահը, կամ նրա հանձնարարությամբ հանձնաժողովի քարտուղարը կամ այլ անդամ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "մասնագետն այդ մասին տեղեկացնում է հանձնաժողովի նախագահին, ով քվեարկության սենյակ է հրավիրում ոստիկանության ծառայողներին, որոնք ձեռնարկում են օրենքով սահմանված միջոցներ" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 206,
                column: "QuestionVariantContent",
                value: "տեղամասային ընտրական հանձնաժողովի նախագահի կողմից");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "դիմում է հանձնաժողովի նախագահին` նոր քվեաթերթիկ (ԱԺ ընտրության ժամանակ՝ յուրաքանչյուր կուսակցության մեկական քվեաթերթիկ) ստանալու համար" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի նախագահի հանձնարարությամբ ընտրողին հատկացնում է նոր քվեաթերթիկ, սխալ լրացված (վնասված) քվեաթերթիկը (քվեաթերթիկները) անհապաղ մարվում են" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ստացիոնար բուժման մեջ գտնվող ընտրողների լրացուցիչ ցուցակները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "քվեարկության օրը, այն պահին, երբ ընտրական տեղամաս են այցելում զորամասի ցուցակում ընդգրկված ընտրողները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տեղամասային կենտրոնում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի անդամի առաջարկությունը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հաշվի չեն առնվում և չեն հաշվարկվում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, ". համայնքի ավագանու ընտրության քվեարկության արդյունքները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ըստ առավել կողմ քվեարկված քվեաթերթիկներ ստացած կուսակցությունների " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "քվեաթերթիկը ծրարից չի հանվում, քվեարկության ծրարը դրանում գտնվող քվեաթերթիկի հետ անհապաղ մարվում է" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հաշվարկված և տեսակավորված քվեաթերթիկները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի անդամների անհատական կնիքները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "քվեարկության արդյունքների արձանագրության մեկ օրինակը " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հաշվարկում ընդգրկվում է միայն ինքնասոսնձվող դրոշմանիշով քվեաթերթիկը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "լրացուցիչ ցուցակների ընտրողների և ընտրողների ցուցակում ընդգրկված ընտրողների թվերի գումարին " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տեղամասային ընտրական հանձնաժողովի նախագահը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "սահմանված  նմուշի քվեաթերթիկն անվավեր է, եթե ներառում է ավելորդ գրառում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 260,
                column: "QuestionVariantContent",
                value: "մեկից ավելի կուսակցության օգտին նշումներ է ներառում");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "եթե բացի քվեարկության համար սահմանված կամ դրան նմանվող նշանից ներառում է ավելորդ գրառում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "որևէ նշում չի ներառում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "մեկ թեկնածու քվեարկվելու դեպքում միաժամանակ «կողմ եմ» և «դեմ եմ» բառերի դիմաց նշումներ է ներառում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հաստատված նմուշի այն քվեաթերթիկը, որը հանվել է ծրարից, և որի վրա փակցված է այդ ընտրական տեղամասի ինքնասոսնձվող դրոշմանիշը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հաշվում է չօգտագործված ինքնասոսնձվող դրոշմանիշերը, փաթեթավորում, փաթեթը կնքում և տեղադրում է պարկում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ըստ ընտրողների ցուցակում առկա ընտրողների ստորագրությունների հաշվում է քվեարկության մասնակիցների ընդհանուր թիվը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "փաթեթավորվում են հանձնաժողովի անդամների անհատական կնիքները, փաթեթը կնքվում և տեղադրվում է ընտրական փաստաթղթերի պարկում" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "առանց հաշվելու փաթեթավորվում են չօգտագործված քվեաթերթիկները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "առանձին-առանձին հաշվվում են ընտրողներից ստացված տեխնիկական սարքավորման միջոցով տպված և համարակալված քվեարկության կտրոնները" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "տեղամասային ընտրական հանձնաժողովի մյուս անդամները և վստահված անձինք" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "չօգտագործված քվեաթերթիկները " });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի գրանցամատյանը և քվեարկության արդյունքների արձանագրության երկու օրինակը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "հանձնաժողովի կնիքը" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "ոչ ուշ, քան 14 ժամվա ընթացքում, ներկայացնում են տարածքային ընտրական հանձնաժողով" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "չի կարող ընդհատվել" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { true, "չորս օրինակից" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 174,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 179,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 183,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 185,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 206,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 260,
                column: "QuestionVariantContent",
                value: "sxal");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CorrectAnswer", "QuestionVariantContent" },
                values: new object[] { false, "sxal" });

            migrationBuilder.InsertData(
                table: "DbAnswer",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 310, false, false, false, 104, "sxal" },
                    { 311, false, false, false, 104, "sxal" },
                    { 312, false, false, false, 104, "sxal" }
                });
        }
    }
}
