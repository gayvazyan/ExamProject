using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.MyModels;

using TestExample.ViewModels;

namespace TestExample.Models
{
    public class ExamDbContect : IdentityDbContext
    {
        public ExamDbContect(DbContextOptions<ExamDbContect> options)
            : base(options) { }

        public DbSet<CitizenTestResults> DbCitizenTestResults { get; set; }

        public DbSet<EmptyTextViewModel> DbEmptyTextViewModel { get; set; }

        public DbSet<CitizenUser> DbCitizenUser { get; set; }

        public DbSet<CitizenReport> DbCitizenReport { get; set; }

        public DbSet<Answer> DbAnswer { get; set; }


        public DbSet<Question> DbQuestion { get; set; }



        public DbSet<TempQuestions> DbTempQuestions { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmptyTextViewModel>().HasData(
                 new EmptyTextViewModel
                 {
                     Id = 1,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 7,
                     VadTickets = 173,
                     NumerableTickets = 5,
                     UnusedNumerableTickets = 258,
                     UnusedGlueTickets = 122,
                     Participants = 170,
                     AllAdditionallyDuringElDay = 3,
                     PartMobileVoters = 5,
                     InvalidTickets = 11,
                     ForA = 81,
                     ForB = 52,
                     ForC = 34,
                     ForAx = 31,
                     ForAy = 49,
                     ForBm = 23,
                     ForBn = 29,
                     ForCk = 27,
                     ForCl = 7,
                     ListAll = 250,
                     TecGlueTickets = 300,
                     TecNumerableTickets = 263
                 },
                 new EmptyTextViewModel
                 {
                     Id = 2,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 3,
                     VadTickets = 600,
                     NumerableTickets = 24,
                     UnusedNumerableTickets = 858,
                     UnusedGlueTickets = 300,
                     Participants = 620,
                     AllAdditionallyDuringElDay = 1,
                     PartMobileVoters = 3,
                     InvalidTickets = 11,
                     ForA = 120,
                     ForB = 280,
                     ForC = 213,
                     ForAx = 80,
                     ForAy = 40,
                     ForBm = 150,
                     ForBn = 130,
                     ForCk = 95,
                     ForCl = 118,
                     ListAll = 840,
                     TecGlueTickets = 900,
                     TecNumerableTickets = 882
                 },
                 new EmptyTextViewModel
                 {
                     Id = 3,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 4,
                     VadTickets = 428,
                     NumerableTickets = 8,
                     UnusedNumerableTickets = 528,
                     UnusedGlueTickets = 164,
                     Participants = 430,
                     AllAdditionallyDuringElDay = 2,
                     PartMobileVoters = 4,
                     InvalidTickets = 6,
                     ForA = 60,
                     ForB = 210,
                     ForC = 160,
                     ForAx = 20,
                     ForAy = 40,
                     ForBm = 170,
                     ForBn = 40,
                     ForCk = 90,
                     ForCl = 70,
                     ListAll = 510,
                     TecGlueTickets = 600,
                     TecNumerableTickets = 536
                 },
                 new EmptyTextViewModel
                 {
                     Id = 4,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 5,
                     VadTickets = 480,
                     NumerableTickets = 27,
                     UnusedNumerableTickets = 729,
                     UnusedGlueTickets = 293,
                     Participants = 500,
                     AllAdditionallyDuringElDay = 3,
                     PartMobileVoters = 4,
                     InvalidTickets = 15,
                     ForA = 100,
                     ForB = 320,
                     ForC = 72,
                     ForAx = 51,
                     ForAy = 49,
                     ForBm = 205,
                     ForBn = 115,
                     ForCk = 30,
                     ForCl = 42,
                     ListAll = 720,
                     TecGlueTickets = 800,
                     TecNumerableTickets = 756
                 },
                 new EmptyTextViewModel
                 {
                     Id = 5,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 7,
                     VadTickets = 390,
                     NumerableTickets = 17,
                     UnusedNumerableTickets = 424,
                     UnusedGlueTickets = 93,
                     Participants = 400,
                     AllAdditionallyDuringElDay = 2,
                     PartMobileVoters = 5,
                     InvalidTickets = 7,
                     ForA = 40,
                     ForB = 250,
                     ForC = 110,
                     ForAx = 13,
                     ForAy = 27,
                     ForBm = 150,
                     ForBn = 100,
                     ForCk = 45,
                     ForCl = 65,
                     ListAll = 420,
                     TecGlueTickets = 500,
                     TecNumerableTickets = 441
                 },
                 new EmptyTextViewModel
                 {
                     Id = 6,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 10,
                     VadTickets = 800,
                     NumerableTickets = 41,
                     UnusedNumerableTickets = 967,
                     UnusedGlueTickets = 159,
                     Participants = 830,
                     AllAdditionallyDuringElDay = 3,
                     PartMobileVoters = 8,
                     InvalidTickets = 15,
                     ForA = 300,
                     ForB = 290,
                     ForC = 236,
                     ForAx = 170,
                     ForAy = 130,
                     ForBm = 60,
                     ForBn = 230,
                     ForCk = 136,
                     ForCl = 100,
                     ListAll = 960,
                     TecGlueTickets = 1000,
                     TecNumerableTickets = 1008
                 },
                 new EmptyTextViewModel
                 {
                     Id = 7,
                     Region = "Շիրակի",
                     Community = "Շիրակ",
                     CEC = 55,
                     TEC = "55/1",
                     AllMobileVoters = 10,
                     VadTickets = 95,
                     NumerableTickets = 18,
                     UnusedNumerableTickets = 108,
                     UnusedGlueTickets = 87,
                     Participants = 100,
                     AllAdditionallyDuringElDay = 3,
                     PartMobileVoters = 10,
                     InvalidTickets = 3,
                     ForA = 10,
                     ForB = 40,
                     ForC = 60,
                     ForAx = 5,
                     ForAy = 5,
                     ForBm = 10,
                     ForBn = 30,
                     ForCk = 40,
                     ForCl = 20,
                     ListAll = 120,
                     TecGlueTickets = 200,
                     TecNumerableTickets = 126
                 }

                );

            modelBuilder.Entity<Answer>().HasData(
              new Answer
              {
                  Id = 1,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 2,
                  QuestionVariantContent = "եթե կողմ են  քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանված դեպքերի ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 3,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 4,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer
              {
                  Id = 5,
                  QuestionVariantContent = "քվեարկության օրվանից 2 օր առաջ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer
              {
                  Id = 6,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer
              {
                  Id = 7,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 3
              },
              new Answer
              {
                  Id = 8,
                  QuestionVariantContent = "քվեարկության օրվանից ոչ շուտ, քան 30, և ոչ ուշ, քան 25 օր առաջ` մինչև ժամը 18:00-ն ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 3
              },
              new Answer
              {
                  Id = 9,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 3
              },
              new Answer
              {
                  Id = 10,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer
              {
                  Id = 11,
                  QuestionVariantContent = "քվեարկության օրը ժամը 7:00-ին` վիճակահանությամբ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer
              {
                  Id = 12,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer
              {
                  Id = 13,
                  QuestionVariantContent = "առնվազն 7 անդամ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              },
              new Answer
              {
                  Id = 14,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              },
              new Answer
              {
                  Id = 15,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              },
               new Answer
               {
                   Id = 16,
                   QuestionVariantContent = "sxal",
                   CorrectAnswer = false,
                   CheckCorrectAnswer = false,
                   CheckdAnswer = false,
                   QuestionId = 6
               },
              new Answer
              {
                  Id = 17,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 6
              },
              new Answer
              {
                  Id = 18,
                  QuestionVariantContent = "հանձնաժողովի կազմավորման օրվանից հետո` 3-րդ օրը` ժամը 12:00-ին",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 6
              },
             new Answer
             {
                 Id = 19,
                 QuestionVariantContent = "եթե նիստին ներկա է հանձնաժողովի անդամների կեսից ավելին",
                 CorrectAnswer = true,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 7
             },
              new Answer
              {
                  Id = 20,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 7
              },
              new Answer
              {
                  Id = 21,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 7
              },
             new Answer
             {
                 Id = 22,
                 QuestionVariantContent = "sxal",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 8
             },
              new Answer
              {
                  Id = 23,
                  QuestionVariantContent = "միայն Ազգային ժողովի ընտրությունների ժամանակ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 8
              },
              new Answer
              {
                  Id = 24,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 8
              },
               new Answer
               {
                   Id = 25,
                   QuestionVariantContent = "քվեարկության օրվանից ոչ ուշ, քան 10 օր առաջ` մինչև ժամը 14:00-ն",
                   CorrectAnswer = true,
                   CheckCorrectAnswer = false,
                   CheckdAnswer = false,
                   QuestionId = 9
               },
              new Answer
              {
                  Id = 26,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 9
              },
              new Answer
              {
                  Id = 27,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 9
              },
              new Answer
              {
                  Id = 28,
                  QuestionVariantContent = "նաև նրանց նշանակող կուսակցության կամ տարածքային ընտրական հանձնաժողովի նախագահի կողմից՝ տեղամասային ընտրական հանձնաժողովի անդամի դիմումի հիման վրա",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 10
              },
              new Answer
              {
                  Id = 29,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 10
              },
              new Answer
              {
                  Id = 30,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 10
              },
             new Answer
             {
                 Id = 31,
                 QuestionVariantContent = "sxal",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 11
             },
              new Answer
              {
                  Id = 32,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 11
              },
              new Answer
              {
                  Id = 33,
                  QuestionVariantContent = "կազմակերպում է ընտրությունների և հանրաքվեների քվեարկությունը, ամփոփում քվեարկության արդյունքներն ընտրական տեղամասում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 11
              },
              new Answer
              {
                  Id = 34,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 12
              },
              new Answer
              {
                  Id = 35,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 12
              },
               new Answer
               {
                   Id = 36,
                   QuestionVariantContent = "Ազգային ժողովում խմբակցություն ունեցող կուսակցությունները, կուսակցությունների դաշինքները և համապատասխան տարածքային ընտրական հանձնաժողովը",
                   CorrectAnswer = true,
                   CheckCorrectAnswer = false,
                   CheckdAnswer = false,
                   QuestionId = 12
               },
              new Answer
              {
                  Id = 37,
                  QuestionVariantContent = "հանձնաժողովի անդամների միջև գործառույթների բաշխման",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 13
              },
              new Answer
              {
                  Id = 38,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 13
              },
              new Answer
              {
                  Id = 39,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 13
              },
              new Answer
              {
                  Id = 40,
                  QuestionVariantContent = "քվեարկության արդյունքների արձանագրությունը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 14
              },
              new Answer
              {
                  Id = 41,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 14
              },
              new Answer
              {
                  Id = 42,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 14
              },
              new Answer
              {
                  Id = 43,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 15
              },
              new Answer
              {
                  Id = 44,
                  QuestionVariantContent = "այո, եթե քվեարկության սենյակում գտնվող ընտրողների թիվն այնքան է, որ ակնհայտորեն խաթարվում է քվեարկության բնականոն ընթացքը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 15
              },
              new Answer
              {
                  Id = 45,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 15
              },
              new Answer
              {
                  Id = 46,
                  QuestionVariantContent = "գրառվում են տեղամասային ընտրական հանձնաժողովի գրանցամատյանում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 16
              },
              new Answer
              {
                  Id = 47,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 16
              },
              new Answer
              {
                  Id = 48,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 16
              },
              new Answer
              {
                  Id = 49,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 17
              },
              new Answer
              {
                  Id = 50,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 17
              },
              new Answer
              {
                  Id = 51,
                  QuestionVariantContent = "քվեարկության սենյակում կամ դրա մուտքի մոտ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 17
              },
              new Answer
              {
                  Id = 52,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 18
              },
              new Answer
              {
                  Id = 53,
                  QuestionVariantContent = "միմյանցից առնվազն 1 մետր հեռավորությամբ և այն դիրքով, որ ընտրողը քվեարկելիս լինի հանձնաժողովին դեմքով և թիկունքով դեպի պատը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 18
              },
              new Answer
              {
                  Id = 54,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 18
              },
              new Answer
              {
                  Id = 55,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 19
              },
              new Answer
              {
                  Id = 56,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 19
              },
              new Answer
              {
                  Id = 57,
                  QuestionVariantContent = "քվեարկության օրվանից ոչ շուտ, քան 20, և ոչ ուշ, քան 18 օր առաջ` մինչև ժամը 18:00-ն",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 19
              },
              new Answer
              {
                  Id = 58,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 20
              },
              new Answer
              {
                  Id = 59,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 20
              },
              new Answer
              {
                  Id = 60,
                  QuestionVariantContent = "յուրաքանչյուր միջազգային կազմակերպությունից մինչև 2 դիտորդ` թարգմանչի ուղեկցությամբ ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 20
              },
              new Answer
              {
                  Id = 61,
                  QuestionVariantContent = "յուրաքանչյուր տեղական դիտորդական կազմակերպությունից 1 դիտորդ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 21
              },
              new Answer
              {
                  Id = 62,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 21
              },
              new Answer
              {
                  Id = 63,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 21
              },
              new Answer
              {
                  Id = 64,
                  QuestionVariantContent = "վստահված անձինք, դիտորդները, այցելուները, զանգվածային լրատվության միջոցների ներկայացուցիչներն ու վերադաս ընտրական հանձնաժողովի անդամները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 22
              },
              new Answer
              {
                  Id = 65,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 22
              },
              new Answer
              {
                  Id = 66,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 22
              },
              new Answer
              {
                  Id = 67,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 23
              },
              new Answer
              {
                  Id = 68,
                  QuestionVariantContent = "կարող են լուսանկարել, տեսանկարահանել քվեարկության արդյունքների ամփոփման գործընթացը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 23
              },
              new Answer
              {
                  Id = 69,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 23
              },
              new Answer
              {
                  Id = 70,
                  QuestionVariantContent = "յուրաքանչյուր թեկնածուի մեկ վստահված անձ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 24
              },
              new Answer
              {
                  Id = 71,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 24
              },
              new Answer
              {
                  Id = 72,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 24
              },
              new Answer
              {
                  Id = 73,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 25
              },
              new Answer
              {
                  Id = 74,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 25
              },
              new Answer
              {
                  Id = 75,
                  QuestionVariantContent = "մինչև երկու վստահված անձ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 25
              },
              new Answer
              {
                  Id = 76,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 26
              },
              new Answer
              {
                  Id = 77,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 26
              },
              new Answer
              {
                  Id = 78,
                  QuestionVariantContent = "իրավունք ունի պահանջելու, որ իր գնահատականը արձանագրվի տեղամասային ընտրական հանձնաժողովի գրանցամատյանում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 26
              },
              new Answer
              {
                  Id = 79,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 27
              },
              new Answer
              {
                  Id = 80,
                  QuestionVariantContent = "չեն կարող ունենալ վստահված անձ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 27
              },
              new Answer
              {
                  Id = 81,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 27
              },
              new Answer
              {
                  Id = 82,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 28
              },
              new Answer
              {
                  Id = 83,
                  QuestionVariantContent = "քվեարկության արդյունքների ամփոփման նիստին ներկա գտնվելու իրավունք ունեցող անձինք",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 28
              },
              new Answer
              {
                  Id = 84,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 28
              },
              new Answer
              {
                  Id = 85,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 29
              },
              new Answer
              {
                  Id = 86,
                  QuestionVariantContent = "ներկա գտնվելու ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում` նաև քվեարկության սենյակում ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 29
              },
              new Answer
              {
                  Id = 87,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 29
              },
              new Answer
              {
                  Id = 88,
                  QuestionVariantContent = "խաթարելու ընտրական հանձնաժողովի բնականոն աշխատանքը կամ քվեարկության բնականոն ընթացքը ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 30
              },
              new Answer
              {
                  Id = 89,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 30
              },
              new Answer
              {
                  Id = 90,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 30
              },
              new Answer
              {
                  Id = 91,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 31
              },
              new Answer
              {
                  Id = 92,
                  QuestionVariantContent = "խորհրդակցական ձայնի իրավունքով մասնակցելու հանձնաժողովի նիստերին",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 31
              },
              new Answer
              {
                  Id = 93,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 31
              },
              new Answer
              {
                  Id = 94,
                  QuestionVariantContent = "բողոքարկելու ընտրական հանձնաժողովների որոշումները, գործողությունները, անգործությունը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 32
              },
              new Answer
              {
                  Id = 95,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 32
              },
              new Answer
              {
                  Id = 96,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 32
              },
              new Answer
              {
                  Id = 97,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 33
              },
              new Answer
              {
                  Id = 98,
                  QuestionVariantContent = "անձամբ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 33
              },
              new Answer
              {
                  Id = 99,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 33
              },
              new Answer
              {
                  Id = 100,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 34
              },
              new Answer
              {
                  Id = 101,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 34
              },
              new Answer
              {
                  Id = 102,
                  QuestionVariantContent = "ընտրողների ցուցակում գտնում է ընտրողի տողը, ընտրողը ստորագրում է համապատասխան սյունակում, հաջորդ սյունակում հանձնաժողովի անդամը դնում է իր անհատական կնիքը, որից հետո անհատական կնիքով կնքում քվեարկության կտրոնը և այն փոխանցում ընտրողին ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 34
              },
              new Answer
              {
                  Id = 103,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 35
              },
              new Answer
              {
                  Id = 104,
                  QuestionVariantContent = "ընտրական տեղամասում քվեարկությանը մասնակցած ընտրողների թիվը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 35
              },
              new Answer
              {
                  Id = 105,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 35
              },
              new Answer
              {
                  Id = 106,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 36
              },
              new Answer
              {
                  Id = 107,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 36
              },
              new Answer
              {
                  Id = 108,
                  QuestionVariantContent = "հիմք չէ նրան քվեարկության չթողնելու համար, բացառությամբ այն դեպքի, երբ տեխնիկական սարքավորումում առկա տեղեկություններից պարզվում է, որ ընտրողն ունի այլ` վավերականության ժամկետը չլրացած, անձը հաստատող փաստաթուղթ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 36
              },
              new Answer
              {
                  Id = 109,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 37
              },
              new Answer
              {
                  Id = 110,
                  QuestionVariantContent = "տեղամասային ընտրական հանձնաժողովի նախագահը նրան նոր ինքնասոսնձվող դրոշմանիշեր է հանձնում նրանից քվեարկության կտրոնները ստանալուց հետո",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 37
              },
              new Answer
              {
                  Id = 111,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 37
              },
              new Answer
              {
                  Id = 112,
                  QuestionVariantContent = "քվեարկության կտրոնը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 38
              },
              new Answer
              {
                  Id = 113,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 38
              },
              new Answer
              {
                  Id = 114,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 38
              },
              new Answer
              {
                  Id = 115,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 39
              },
              new Answer
              {
                  Id = 116,
                  QuestionVariantContent = "հանձնաժողովի անդամն առանց քվեարկության ծրարը  ընտրողից վերցնելու  քվեարկության ծրարի կտրվածքի միջով ինքնասոսնձվող դրոշմանիշը   փակցնում է քվեաթերթիկին",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 39
              },
              new Answer
              {
                  Id = 117,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 39
              },
              new Answer
              {
                  Id = 118,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 40
              },
              new Answer
              {
                  Id = 119,
                  QuestionVariantContent = "նույնականացման քարտը ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 40
              },
              new Answer
              {
                  Id = 120,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 40
              },
              new Answer
              {
                  Id = 121,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 41
              },
              new Answer
              {
                  Id = 122,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 41
              },
              new Answer
              {
                  Id = 123,
                  QuestionVariantContent = "կենսաչափական անձնագիրը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 41
              },
              new Answer
              {
                  Id = 124,
                  QuestionVariantContent = "ոչ կենսաչափական անձնագիրը ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 42
              },
              new Answer
              {
                  Id = 125,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 42
              },
              new Answer
              {
                  Id = 126,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 42
              },
              new Answer
              {
                  Id = 127,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 43
              },
              new Answer
              {
                  Id = 128,
                  QuestionVariantContent = "սոսնձվում է տեղամասային ընտրական հանձնաժողովի գրանցամատյանում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 43
              },
              new Answer
              {
                  Id = 129,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 43
              },
              new Answer
              {
                  Id = 130,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 44
              },
              new Answer
              {
                  Id = 131,
                  QuestionVariantContent = "եթե ընտրողն իր անձը հաստատող որևէ փաստաթղթով արդեն իսկ մասնակցել է քվեարկությանը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 44
              },
              new Answer
              {
                  Id = 132,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 44
              },
              new Answer
              {
                  Id = 133,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 45
              },
              new Answer
              {
                  Id = 134,
                  QuestionVariantContent = "եթե ընտրողը գրանցված չէ տվյալ ընտրական տեղամասի ընտրողների ցուցակում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 45
              },
              new Answer
              {
                  Id = 135,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 45
              },
              new Answer
              {
                  Id = 136,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 46
              },
              new Answer
              {
                  Id = 137,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 46
              },
              new Answer
              {
                  Id = 138,
                  QuestionVariantContent = "իր անհատական կնիքը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 46
              },
              new Answer
              {
                  Id = 139,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 47
              },
              new Answer
              {
                  Id = 140,
                  QuestionVariantContent = "քվեարկության խցիկում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 47
              },
              new Answer
              {
                  Id = 141,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 47
              },
              new Answer
              {
                  Id = 142,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 48
              },
              new Answer
              {
                  Id = 143,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 48
              },
              new Answer
              {
                  Id = 144,
                  QuestionVariantContent = "տվյալ տեխնիկական սարքավորման միջոցով գրանցված ընտրողների բացակայությունը հավաստող տեղեկանք",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 48
              }, 
              new Answer
              {
                  Id = 145,
                  QuestionVariantContent = "արգելվում է",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 49
              },
              new Answer
              {
                  Id = 146,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 49
              },
              new Answer
              {
                  Id = 147,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 49
              },
              new Answer
              {
                  Id = 148,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 50
              },
              new Answer
              {
                  Id = 149,
                  QuestionVariantContent = "քվեաթերթիկի վրա ինքնասոսնձվող դրոշմանիշը փակցնելուց հետո",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 50
              },
              new Answer
              {
                  Id = 150,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 50
              }, 
              new Answer
              {
                  Id = 151,
                  QuestionVariantContent = "իրավասու է իր որոշմամբ սահմանելու քվեարկության սենյակում միաժամանակյա գտնվելու իրավունք ունեցող դիտորդների և զանգվածային լրատվության միջոցների ներկայացուցիչների առավելագույն թիվը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 51
              },
              new Answer
              {
                  Id = 152,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 51
              },
              new Answer
              {
                  Id = 153,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 51
              }, 
              new Answer
              {
                  Id = 154,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 52
              },
              new Answer
              {
                  Id = 155,
                  QuestionVariantContent = "գրառվում են տեղամասային ընտրական հանձնաժողովի գրանցամատյանում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 52
              },
              new Answer
              {
                  Id = 156,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 52
              }, 
              new Answer
              {
                  Id = 157,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 53
              },
              new Answer
              {
                  Id = 158,
                  QuestionVariantContent = "ընտրական հանձնաժողովի անդամ, վստահված անձ, դիտորդ, այցելու, զանգվածային լրատվության միջոցի ներկայացուցիչ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 53
              },
              new Answer
              {
                  Id = 159,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 53
              },
              new Answer
              {
                  Id = 160,
                  QuestionVariantContent = "հանձնաժողովի անդամը տեղեկացնում է տեղամասային հանձնաժողովի նախագահին, որն ընտրողից վերցնում է քվեարկության ծրարը, անհապաղ մարում է՝ առանց պարունակությունը ստուգելու",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 54
              },
              new Answer
              {
                  Id = 161,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 54
              },
              new Answer
              {
                  Id = 162,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 54
              }, 
              new Answer
              {
                  Id = 163,
                  QuestionVariantContent = "ոչ ուշ, քան մինչև ժամը 20:00-ն",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 55
              },
              new Answer
              {
                  Id = 164,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 55
              },
              new Answer
              {
                  Id = 165,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 55
              },
              new Answer
              {
                  Id = 166,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 56
              },
              new Answer
              {
                  Id = 167,
                  QuestionVariantContent = "շրջիկ արկղով քվեարկության դեպքում ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 56
              },
              new Answer
              {
                  Id = 168,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 56
              }, 
              new Answer
              {
                  Id = 169,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 57
              },
              new Answer
              {
                  Id = 170,
                  QuestionVariantContent = "տեխնիկակական սարքավորման խափանման կամ չլինելու պարագայում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 57
              },
              new Answer
              {
                  Id = 171,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 57
              }, 
              new Answer
              {
                  Id = 172,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 58
              },
              new Answer
              {
                  Id = 173,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 58
              },
              new Answer
              {
                  Id = 174,
                  QuestionVariantContent = "քրեակատարողական հիմնարկում ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 58
              }, 
              new Answer
              {
                  Id = 175,
                  QuestionVariantContent = "միայն մեկ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 59
              },
              new Answer
              {
                  Id = 176,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 59
              },
              new Answer
              {
                  Id = 177,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 59
              }, 
              new Answer
              {
                  Id = 178,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 60
              },
              new Answer
              {
                  Id = 179,
                  QuestionVariantContent = "քվեարկության օրը՝ ժամը 8:00-ից հետո, բայց այն հաշվարկով, որ քվեարկությունն ավարտվի մինչև ժամը 18:00-ն",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 60
              },
              new Answer
              {
                  Id = 180,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 60
              }, 
              new Answer
              {
                  Id = 181,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 61
              },
              new Answer
              {
                  Id = 182,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 61
              },
              new Answer
              {
                  Id = 183,
                  QuestionVariantContent = "ստացիոնար բուժման մեջ գտնվող, քվեարկության օրը տեղամասային կենտրոն ինքնուրույն ներկայանալու հնարավորություն չունեցող անձանց համար ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 61
              },
              new Answer
              {
                  Id = 184,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 62
              },
              new Answer
              {
                  Id = 185,
                  QuestionVariantContent = "ձերբակալված անձանց պահելու վայրում քվեարկության օրը գտնվող ընտրողների համար",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 62
              },
              new Answer
              {
                  Id = 186,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 62
              }, 
              new Answer
              {
                  Id = 187,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 63
              },
              new Answer
              {
                  Id = 188,
                  QuestionVariantContent = "կցվում են քվեարկության օրն ընտրական տեղամասում կազմվող ընտրողների լրացուցիչ ցուցակին",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 63
              },
              new Answer
              {
                  Id = 189,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 63
              },
              new Answer
              {
                  Id = 190,
                  QuestionVariantContent = "քրեակատարողական հիմնարկում քվեարկության ժամանակ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 64
              },
              new Answer
              {
                  Id = 191,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 64
              },
              new Answer
              {
                  Id = 192,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 64
              },
              new Answer
              {
                  Id = 193,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 65
              },
              new Answer
              {
                  Id = 194,
                  QuestionVariantContent = "շրջիկ արկղով քվեարկության ժամանակ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 65
              },
              new Answer
              {
                  Id = 195,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 65
              },
              new Answer
              {
                  Id = 196,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 66
              },
              new Answer
              {
                  Id = 197,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 66
              },
              new Answer
              {
                  Id = 198,
                  QuestionVariantContent = "տեխնիկական սարքավորման խափանման կամ չլինելու պարագայում քվեարկության ժամանակ ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 66
              }, 
              new Answer
              {
                  Id = 199,
                  QuestionVariantContent = "հանձնաժողովի նախագահը, կամ նրա հանձնարարությամբ հանձնաժողովի քարտուղարը կամ այլ անդամ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 67
              },
              new Answer
              {
                  Id = 200,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 67
              },
              new Answer
              {
                  Id = 201,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 67
              }, 
              new Answer
              {
                  Id = 202,
                  QuestionVariantContent = "մասնագետն այդ մասին տեղեկացնում է հանձնաժողովի նախագահին, ով քվեարկության սենյակ է հրավիրում ոստիկանության ծառայողներին, որոնք ձեռնարկում են օրենքով սահմանված միջոցներ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 68
              },
              new Answer
              {
                  Id = 203,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 68
              },
              new Answer
              {
                  Id = 204,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 68
              },
              new Answer
              {
                  Id = 205,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 69
              },
              new Answer
              {
                  Id = 206,
                  QuestionVariantContent = "տեղամասային ընտրական հանձնաժողովի նախագահի կողմից",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 69
              },
              new Answer
              {
                  Id = 207,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 69
              }, 
              new Answer
              {
                  Id = 208,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 70
              },
              new Answer
              {
                  Id = 209,
                  QuestionVariantContent = "դիմում է հանձնաժողովի նախագահին` նոր քվեաթերթիկ (ԱԺ ընտրության ժամանակ՝ յուրաքանչյուր կուսակցության մեկական քվեաթերթիկ) ստանալու համար",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 70
              },
              new Answer
              {
                  Id = 210,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 70
              },
              new Answer
              {
                  Id = 211,
                  QuestionVariantContent = "հանձնաժողովի նախագահի հանձնարարությամբ ընտրողին հատկացնում է նոր քվեաթերթիկ, սխալ լրացված (վնասված) քվեաթերթիկը (քվեաթերթիկները) անհապաղ մարվում են",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 71
              },
              new Answer
              {
                  Id = 212,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 71
              },
              new Answer
              {
                  Id = 213,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 71
              },
              new Answer
              {
                  Id = 214,
                  QuestionVariantContent = "ստացիոնար բուժման մեջ գտնվող ընտրողների լրացուցիչ ցուցակները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 72
              },
              new Answer
              {
                  Id = 215,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 72
              },
              new Answer
              {
                  Id = 216,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 72
              }, 
              new Answer
              {
                  Id = 217,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 73
              },
              new Answer
              {
                  Id = 218,
                  QuestionVariantContent = "քվեարկության օրը, այն պահին, երբ ընտրական տեղամաս են այցելում զորամասի ցուցակում ընդգրկված ընտրողները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 73
              },
              new Answer
              {
                  Id = 219,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 73
              },
              new Answer
              {
                  Id = 220,
                  QuestionVariantContent = "տեղամասային կենտրոնում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 74
              },
              new Answer
              {
                  Id = 221,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 74
              },
              new Answer
              {
                  Id = 222,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 74
              }, 
              new Answer
              {
                  Id = 223,
                  QuestionVariantContent = "հանձնաժողովի անդամի առաջարկությունը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 75
              },
              new Answer
              {
                  Id = 224,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 75
              },
              new Answer
              {
                  Id = 225,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 75
              }, 
              new Answer
              {
                  Id = 226,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 76
              },
              new Answer
              {
                  Id = 227,
                  QuestionVariantContent = "հաշվի չեն առնվում և չեն հաշվարկվում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 76
              },
              new Answer
              {
                  Id = 228,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 76
              },
              new Answer
              {
                  Id = 229,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 77
              },
              new Answer
              {
                  Id = 230,
                  QuestionVariantContent = ". համայնքի ավագանու ընտրության քվեարկության արդյունքները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 77
              },
              new Answer
              {
                  Id = 231,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 77
              }, 
              new Answer
              {
                  Id = 232,
                  QuestionVariantContent = "ըստ առավել կողմ քվեարկված քվեաթերթիկներ ստացած կուսակցությունների ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 78
              },
              new Answer
              {
                  Id = 233,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 78
              },
              new Answer
              {
                  Id = 234,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 78
              },
              new Answer
              {
                  Id = 235,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 79
              },
              new Answer
              {
                  Id = 236,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 79
              },
              new Answer
              {
                  Id = 237,
                  QuestionVariantContent = "քվեաթերթիկը ծրարից չի հանվում, քվեարկության ծրարը դրանում գտնվող քվեաթերթիկի հետ անհապաղ մարվում է",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 79
              }, 
              new Answer
              {
                  Id = 238,
                  QuestionVariantContent = "հաշվարկված և տեսակավորված քվեաթերթիկները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 80
              },
              new Answer
              {
                  Id = 239,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 80
              },
              new Answer
              {
                  Id = 240,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 80
              }, 
              new Answer
              {
                  Id = 241,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 81
              },
              new Answer
              {
                  Id = 242,
                  QuestionVariantContent = "հանձնաժողովի անդամների անհատական կնիքները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 81
              },
              new Answer
              {
                  Id = 243,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 81
              },
              new Answer
              {
                  Id = 244,
                  QuestionVariantContent = "քվեարկության արդյունքների արձանագրության մեկ օրինակը ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 82
              },
              new Answer
              {
                  Id = 245,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 82
              },
              new Answer
              {
                  Id = 246,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 82
              },
              new Answer
              {
                  Id = 247,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 83
              },
              new Answer
              {
                  Id = 248,
                  QuestionVariantContent = "հաշվարկում ընդգրկվում է միայն ինքնասոսնձվող դրոշմանիշով քվեաթերթիկը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 83
              },
              new Answer
              {
                  Id = 249,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 83
              },
              new Answer
              {
                  Id = 250,
                  QuestionVariantContent = "լրացուցիչ ցուցակների ընտրողների և ընտրողների ցուցակում ընդգրկված ընտրողների թվերի գումարին ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 84
              },
              new Answer
              {
                  Id = 251,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 84
              },
              new Answer
              {
                  Id = 252,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 84
              },
              new Answer
              {
                  Id = 253,
                  QuestionVariantContent = "տեղամասային ընտրական հանձնաժողովի նախագահը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 85
              },
              new Answer
              {
                  Id = 254,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 85
              },
              new Answer
              {
                  Id = 255,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 85
              }, 
              new Answer
              {
                  Id = 256,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 86
              },
              new Answer
              {
                  Id = 257,
                  QuestionVariantContent = "սահմանված  նմուշի քվեաթերթիկն անվավեր է, եթե ներառում է ավելորդ գրառում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 86
              },
              new Answer
              {
                  Id = 258,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 86
              },
              new Answer
              {
                  Id = 259,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 87
              },
              new Answer
              {
                  Id = 260,
                  QuestionVariantContent = "մեկից ավելի կուսակցության օգտին նշումներ է ներառում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 87
              },
              new Answer
              {
                  Id = 261,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 87
              },
              new Answer
              {
                  Id = 262,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 88
              },
              new Answer
              {
                  Id = 263,
                  QuestionVariantContent = "եթե բացի քվեարկության համար սահմանված կամ դրան նմանվող նշանից ներառում է ավելորդ գրառում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 88
              },
              new Answer
              {
                  Id = 264,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 88
              },
              new Answer
              {
                  Id = 265,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 89
              },
              new Answer
              {
                  Id = 266,
                  QuestionVariantContent = "որևէ նշում չի ներառում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 89
              },
              new Answer
              {
                  Id = 267,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 89
              },
              new Answer
              {
                  Id = 268,
                  QuestionVariantContent = "մեկ թեկնածու քվեարկվելու դեպքում միաժամանակ «կողմ եմ» և «դեմ եմ» բառերի դիմաց նշումներ է ներառում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 90
              },
              new Answer
              {
                  Id = 269,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 90
              },
              new Answer
              {
                  Id = 270,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 90
              },
              new Answer
              {
                  Id = 271,
                  QuestionVariantContent = "հաստատված նմուշի այն քվեաթերթիկը, որը հանվել է ծրարից, և որի վրա փակցված է այդ ընտրական տեղամասի ինքնասոսնձվող դրոշմանիշը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 91
              },
              new Answer
              {
                  Id = 272,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 91
              },
              new Answer
              {
                  Id = 273,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 91
              },
              new Answer
              {
                  Id = 274,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 92
              },
              new Answer
              {
                  Id = 275,
                  QuestionVariantContent = "հաշվում է չօգտագործված ինքնասոսնձվող դրոշմանիշերը, փաթեթավորում, փաթեթը կնքում և տեղադրում է պարկում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 92
              },
              new Answer
              {
                  Id = 276,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 92
              },
              new Answer
              {
                  Id = 277,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 93
              },
              new Answer
              {
                  Id = 278,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 93
              },
              new Answer
              {
                  Id = 279,
                  QuestionVariantContent = "ըստ ընտրողների ցուցակում առկա ընտրողների ստորագրությունների հաշվում է քվեարկության մասնակիցների ընդհանուր թիվը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 93
              },
              new Answer
              {
                  Id = 280,
                  QuestionVariantContent = "փաթեթավորվում են հանձնաժողովի անդամների անհատական կնիքները, փաթեթը կնքվում և տեղադրվում է ընտրական փաստաթղթերի պարկում",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 94
              },
              new Answer
              {
                  Id = 281,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 94
              },
              new Answer
              {
                  Id = 282,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 94
              },
              new Answer
              {
                  Id = 283,
                  QuestionVariantContent = "առանց հաշվելու փաթեթավորվում են չօգտագործված քվեաթերթիկները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 95
              },
              new Answer
              {
                  Id = 284,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 95
              },
              new Answer
              {
                  Id = 285,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 95
              }, 
              new Answer
              {
                  Id = 286,
                  QuestionVariantContent = "առանձին-առանձին հաշվվում են ընտրողներից ստացված տեխնիկական սարքավորման միջոցով տպված և համարակալված քվեարկության կտրոնները",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 96
              },
              new Answer
              {
                  Id = 287,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 96
              },
              new Answer
              {
                  Id = 288,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 96
              },
              new Answer
              {
                  Id = 289,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 97
              },
              new Answer
              {
                  Id = 290,
                  QuestionVariantContent = "տեղամասային ընտրական հանձնաժողովի մյուս անդամները և վստահված անձինք",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 97
              },
              new Answer
              {
                  Id = 291,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 97
              },
              new Answer
              {
                  Id = 292,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 98
              },
              new Answer
              {
                  Id = 293,
                  QuestionVariantContent = "չօգտագործված քվեաթերթիկները ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 98
              },
              new Answer
              {
                  Id = 294,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 98
              },
              new Answer
              {
                  Id = 295,
                  QuestionVariantContent = "հանձնաժողովի գրանցամատյանը և քվեարկության արդյունքների արձանագրության երկու օրինակը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 99
              },
              new Answer
              {
                  Id = 296,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 99
              },
              new Answer
              {
                  Id = 297,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 99
              },
              new Answer
              {
                  Id = 298,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 100
              },
              new Answer
              {
                  Id = 299,
                  QuestionVariantContent = "հանձնաժողովի կնիքը",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 100
              },
              new Answer
              {
                  Id = 300,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 100
              },
              new Answer
              {
                  Id = 301,
                  QuestionVariantContent = "ոչ ուշ, քան 14 ժամվա ընթացքում, ներկայացնում են տարածքային ընտրական հանձնաժողով",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 101
              },
              new Answer
              {
                  Id = 302,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 101
              },
              new Answer
              {
                  Id = 303,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 101
              },
              new Answer
              {
                  Id = 304,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 102
              },
              new Answer
              {
                  Id = 305,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 102
              },
              new Answer
              {
                  Id = 306,
                  QuestionVariantContent = "չի կարող ընդհատվել",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 102
              },
              new Answer
              {
                  Id = 307,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 103
              },
              new Answer
              {
                  Id = 308,
                  QuestionVariantContent = "sxal",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 103
              },
              new Answer
              {
                  Id = 309,
                  QuestionVariantContent = "չորս օրինակից",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 103
              }
             
                );



            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuestionContent = "Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունված`"
                },
                new Question
                {
                    Id = 2,
                    QuestionContent = "Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցնում է`"
                },
                new Question
                {
                    Id = 3,
                    QuestionContent = "Հերթական ընտրությունների դեպքում ե՞րբ է կազմավորվում տեղամասային ընտրական հանձնաժողովը`"
                },
                new Question
                {
                    Id = 4,
                    QuestionContent = "Ե՞րբ է իրականացվում տեղամասային ընտրական հանձնաժողովի անդամների միջև գործառույթների բաշխումը և ի՞նչպես`"
                },
                new Question
                {
                    Id = 5,
                    QuestionContent = "Քանի՞ անդամ ունի տեղամասային ընտրական հանձնաժողովը`"
                },
                new Question
                {
                    Id = 6,
                    QuestionContent = "Ե՞րբ է հրավիրվում տեղամասային ընտրական հանձնաժողովի առաջին նիստը`"
                },
                new Question
                {
                    Id = 7,
                    QuestionContent = "Ընտրական հանձնաժողովի նիստը ե՞րբ է համարվում իրավազոր`"
                },
                new Question
                {
                    Id = 8,
                    QuestionContent = "Տեղամասային ընտրական հանձնաժողովների անդամները կարող են ընդգրկվել իրենց ընտրական տեղամասի` ըստ գտնվելու վայրի ընտրական տեղամասի ընտրողների ցուցակում՝"
                },
                new Question
                {
                    Id = 9,
                    QuestionContent = "Ազգային ժողովի ընտրությունների ժամանակ տեղամասային ընտրական հանձնաժողովների անդամներին ըստ գտնվելու վայրի ընտրական տեղամասի ընտրողների ցուցակներում ընդգրկելու մասին դիմումը լիազոր մարմին կարող է ներկայացվել՝"
                },
                new Question
                {
                    Id = 10,
                    QuestionContent = "Ազգային ժողովի ընտրությունների ժամանակ տեղամասային ընտրական հանձնաժողովների անդամները կարող են ընդգրկվել իրենց ընտրական տեղամասի` ըստ գտնվելու վայրի ընտրողների ցուցակում՝"
                },
                new Question
                {
                    Id = 11,
                    QuestionContent = "Նշվածներից ո՞րն է տեղամասային ընտրական հանձնաժողովի լիազորություն`"
                },
                new Question
                {
                    Id = 12,
                    QuestionContent = "Ովքե՞ր են նշանակում տեղամասային ընտրական հանձնաժողովի անդամներին`"
                },
                new Question
                {
                    Id = 13,
                    QuestionContent = "Տեղամասային ընտրական հանձնաժողովի նախագահը և քարտուղարը նշվածներից ո՞ր վիճակահանությանը չեն մասնակցում`"
                },
                new Question
                {
                    Id = 14,
                    QuestionContent = "Հանձնաժողովի անդամը պարտավոր է  ստորագրել`"
                },
                new Question
                {
                    Id = 15,
                    QuestionContent = "Իրավունք ունի արդյո՞ք տեղամասային ընտրական հանձնաժողովի նախագահը սահմանափակելու քվեարկության սենյակում միաժամանակ գտնվող ընտրողների թիվը`"
                },
                new Question
                {
                    Id = 16,
                    QuestionContent = "Տեղամասային ընտրական հանձնաժողովում անցկացվող վիճակահանությունների արդյունքները`"
                },
                new Question
                {
                    Id = 17,
                    QuestionContent = "Ո՞րտեղ են փակցվում ընտրություններին մասնակցող կուսակցությունների ընտրական ցուցակները՝"
                },
                new Question
                {
                    Id = 18,
                    QuestionContent = "Տեղամասային կենտրոնում ինչպե՞ս են տեղադրվում քվեարկության խցիկները`"
                },
                new Question
                {
                    Id = 19,
                    QuestionContent = "Արտահերթ ընտրությունների դեպքում ե՞րբ է կազմավորվում տեղամասային ընտրական հանձնաժողովը`"
                },
                new Question
                {
                    Id = 20,
                    QuestionContent = "Ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում նաև քվեարկության սենյակում կարող են ներկա գտնվել`"
                },
                new Question
                {
                    Id = 21,
                    QuestionContent = "Ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում նաև քվեարկության սենյակում կարող են ներկա գտնվել`"
                },
                new Question
                {
                    Id = 22,
                    QuestionContent = "Ընտրական հանձնաժողովի անդամներից և քվեարկողներից բացի, ովքե՞ր կարող են ներկա գտնվել քվեարկության սենյակում`"
                },
                new Question
                {
                    Id = 23,
                    QuestionContent = "Վստահված անձինք, դիտորդները, այցելուները, զանգվածային լրատվության միջոցների ներկայացուցիչները`"
                },
                new Question
                {
                    Id = 24,
                    QuestionContent = "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների ժամանակ ընտրական հանձնաժողովի նիստին և քվեարկության ընթացքում քվեարկության սենյակում կարող են ներկա գտնվել`"
                },
                new Question
                {
                    Id = 25,
                    QuestionContent = "Ազգային ժողովի ընտրությունների ժամանակ ընտրական հանձնաժողովի նիստին և քվեարկության ընթացքում քվեարկության սենյակում կարող է ներկա գտնվել ընտրություններին մասնակցող յուրաքանչյուր կուսակցության, կուսակցությունների դաշինքի`"
                },
                new Question
                {
                    Id = 26,
                    QuestionContent = "Եթե հանձնաժողովի անդամը, վստահված անձը կամ դիտորդը գտնում է, որ քվեարկության ընթացքում տեղի է ունեցել ընտրական օրենսգրքով նախատեսված քվեարկության կարգի խախտում, ապա`"
                },
                new Question
                {
                    Id = 27,
                    QuestionContent = "Ազգային ժողովի, Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրություններին մասնակցող կուսակցությունների ընտրական ցուցակում ընդգրկված թեկնածուները`"
                },
                new Question
                {
                    Id = 28,
                    QuestionContent = "Ազգային ժողովի ընտրությունների ժամանակ քվեարկության արդյունքների արձանագրությունը ովքե՞ր կարող են լուսանկարել կամ տեսանկարահանել`"
                },
                new Question
                {
                    Id = 29,
                    QuestionContent = "Դիտորդը, զանգվածային լրատվության միջոցի ներկայացուցիչը, այցելուն իրավունք ունի`"
                },
                new Question
                {
                    Id = 30,
                    QuestionContent = "Դիտորդը, զանգվածային լրատվության միջոցի ներկայացուցիչը, այցելուն իրավունք չունի`"
                },
                new Question
                {
                    Id = 31,
                    QuestionContent = "Վստահված անձն իրավունք ունի`"
                },
                new Question
                {
                    Id = 32,
                    QuestionContent = "Վստահված անձն իրավունք ունի`"
                },
                new Question
                {
                    Id = 33,
                    QuestionContent = "Ընտրողը քվեարկությանը մասնակցում է`"
                },
                new Question
                {
                    Id = 34,
                    QuestionContent = "Ընտրողների գրանցումն իրականացնող հանձնաժողովի անդամը վերցնում է քվեարկության կտրոնը և կատարում հետևյալ բոլոր գործողությունները՝"
                },
                new Question
                {
                    Id = 35,
                    QuestionContent = "Քվեարկության օրը տեղամասային ընտրական հանձնաժողովը  տարածքային ընտրական հանձնաժողովին հաղորդում է`"
                },
                new Question
                {
                    Id = 36,
                    QuestionContent = "Ընտրողի անձը հաստատող փաստաթղթի վավերականության ժամկետի ավարտը`"
                },
                new Question
                {
                    Id = 37,
                    QuestionContent = "Եթե հանձնաժողովի պատասխանատու անդամին հատկացված ինքնասոսնձվող դրոշմանիշերը սպառվել են,ապա՝"
                },
               new Question
               {
                   Id = 38,
                   QuestionContent = "Մինչև ինքնասոսնձվող դրոշմանիշը քվեաթերթիկին փակցնելը, հանձնաժողովի անդամը ընտրողից պետք է ստանա՝"
               },
              new Question
                       {
                           Id = 39,
                           QuestionContent = "Ի՞նչ կարգով է փակցվում ինքնասոսնձվող դրոշմանիշը`"
                       },
             new Question
                       {
                           Id = 40,
                           QuestionContent = "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`"
                       },
            new Question
                       {
                           Id = 41,
                           QuestionContent = "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`"
                       },
                       new Question
                       {
                           Id = 42,
                           QuestionContent = "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`"
                       },
                       new Question
                       {
                           Id = 43,
                           QuestionContent = "Մինչև քվեարկության սկսվելը տեխնիկական սարքավորման միջոցով տպված տեղեկանքը`"
                       },
                       new Question
                       {
                           Id = 44,
                           QuestionContent = "Ո՞ր դեպքում է էկրանին հայտնվում կարմիր նշան`"
                       },
                       new Question
                       {
                           Id = 45,
                           QuestionContent = "Ո՞ր դեպքում է էկրանին հայտնվում դեղին նշան`"
                       },
                       new Question
                       {
                           Id = 46,
                           QuestionContent = ". Ընտրողի գրանցումն իրականացնող հանձնաժողովի անդամն ընտրողների ցուցակի համապատասխան սյունակում և քվեարկության կտրոնի վրա դնում է`"
                       },
                       new Question
                       {
                           Id = 47,
                           QuestionContent = "Ընտրողը քվեաթերթիկը լրացնում է կամ քվեաթերթիկներից մեկն ընտրում է`"
                       },
                       new Question
                       {
                           Id = 48,
                           QuestionContent = ". Քվեարկությունը սկսվելուց առաջ մասնագետը տեխնիկական սարքավորման միջոցով տպում է`"
                       },
                       new Question
                       {
                           Id = 49,
                           QuestionContent = "Ընտրողի կողմից կատարած քվեարկության մասին որևէ ձևով տեղեկանալը`"
                       },
                       new Question
                       {
                           Id = 50,
                           QuestionContent = "Ինքնասոսնձվող դրոշմանիշ փակցնող և քվեատուփի համար պատասխանատու անդամը քվեարկության ծրարը քվեատուփի մեջ գցելու հնարավորություն է ընձեռում միայն` "
                       },
                       new Question
                       {
                           Id = 51,
                           QuestionContent = "Եթե քվեարկության սենյակում գտնվող դիտորդների, զանգվածային լրատվության միջոցների ներկայացուցիչների թիվն այնքան է, որ ակնհայտորեն խաթարում է քվեարկության բնականոն ընթացքը, ապա տեղամասային ընտրական հանձնաժողովը`"
                       },
                       new Question
                       {
                           Id = 52,
                           QuestionContent = "Քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող ընտրողին օգնող անձի տվյալները`"
                       },
                       new Question
                       {
                           Id = 53,
                           QuestionContent = "Քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող ընտրողն իրավունք ունի հանձնաժողովի նախագահին տեղեկացնելուց հետո քվեարկության խցիկ հրավիրելու այլ անձի, որը չպետք է լինի`"
                       },
                       new Question
                       {
                           Id = 54,
                           QuestionContent = "Եթե ընտրողը չի ներկայացնում քվեարկության կտրոն, ապա`"
                       },
                       new Question
                       {
                           Id = 55,
                           QuestionContent = "Տեղամասային ընտրական հանձնաժողովի նախագահը կամ վերջինիս հանձնարարությամբ հանձնաժողովի քարտուղարը ե՞րբ են բացում շրջիկ արկղը`"
                       },
                       new Question
                       {
                           Id = 56,
                           QuestionContent = "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`"
                       },
                       new Question
                       {
                           Id = 57,
                           QuestionContent = "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`"
                       },
                       new Question
                       {
                           Id = 58,
                           QuestionContent = "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`"
                       },
                       new Question
                       {
                           Id = 59,
                           QuestionContent = "Միևնույն անձը քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող քանի՞ ընտրողի կարող է օգնել`"
                       },
                       new Question
                       {
                           Id = 60,
                           QuestionContent = "Ե՞րբ է անցկացվում շրջիկ արկղով քվեարկությունը`"
                       },
                       new Question
                       {
                           Id = 61,
                           QuestionContent = "Շրջիկ արկղով քվեարկությունը կազմակերպվում է՝ "
                       },
                       new Question
                       {
                           Id = 62,
                           QuestionContent = "Շրջիկ արկղով քեարկությունը կազմակերպվում է՝ "
                       },
                       new Question
                       {
                           Id = 63,
                           QuestionContent = "Ընտրողին ընտրողների լրացուցիչ ցուցակում ընդգրկելու համար հիմք համարվող փաստաթղթերը`"
                       },
                       new Question
                       {
                           Id = 64,
                           QuestionContent = "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`"
                       },
                       new Question
                       {
                           Id = 65,
                           QuestionContent = "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`"
                       },
                       new Question
                       {
                           Id = 66,
                           QuestionContent = "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`"
                       },
                       new Question
                       {
                           Id = 67,
                           QuestionContent = "Մասնագետի ժամանակավոր բացակայության դեպքում, ո՞վ կարող է նրան փոխարինել`"
                       },
                                 new Question
                                 {
                                     Id = 68,
                                     QuestionContent = "Եթե ընտրողը ներկայացրել է այլ անձի անձը հաստատող փաստաթուղթ, ապա`"
                                 },
                                 new Question
                                 {
                                     Id = 69,
                                     QuestionContent = "Տեղամասային ընտրական հանձնաժողովի կազմած ընտրողների լրացուցիչ ցուցակի յուրաքանչյուր էջ ստորագրվում և կնքվում է`"
                                 },
                                 new Question
                                 {
                                     Id = 70,
                                     QuestionContent = "Ընտրողի գործողությունները քվեաթերթիկը սխալ լրացնելու կամ վնասելու դեպքում`"
                                 },
                                 new Question
                                 {
                                     Id = 71,
                                     QuestionContent = "Ընտրական հանձնաժողովի անդամի գործողություններն ընտրողի կողմից քվեաթերթիկը սխալ լրացնելու կամ վնասելու դեպքում`"
                                 },
                                 new Question
                                 {
                                     Id = 72,
                                     QuestionContent = "Տեխնիկական սարքավորման մեջ չեն ներբեռնվում՝"
                                 },
                                 new Question
                                 {
                                     Id = 73,
                                     QuestionContent = "Զորամասում հաշվառված ընտրողների ցուցակները տեղամասային ընտրական հանձնաժողովի կողմից բացվում են միայն`"
                                 },
                                 new Question
                                 {
                                     Id = 74,
                                     QuestionContent = "Զինծառայողները քվեարկում են`"
                                 },
                                 new Question
                                 {
                                     Id = 75,
                                     QuestionContent = "Քվեաթերթիկի վավեր (անվավեր) լինելու վերաբերյալ առարկության դեպքում քվեարկության է դրվում`"
                                 },
                                 new Question
                                 {
                                     Id = 76,
                                     QuestionContent = "Քվեարկության արդյունքներն ամփոփելիս չսահմանված նմուշի քվեաթերթիկները`"
                                 },
                                 new Question
                                 {
                                     Id = 77,
                                     QuestionContent = "Միաժամանակ համայնքի ղեկավարի և ավագանու ընտրությունների դեպքում տեղամասային ընտրական հանձնաժողովն առաջին հերթին ամփոփում է`"
                                 },
                                 new Question
                                 {
                                     Id = 78,
                                     QuestionContent = "Ի՞նչ հաջորդականությամբ է հաշվարկվում կուսակցության տարածքային ցուցակում ընդգրկված թեկնածուին կողմ քվեարկված քվեաթերթիկների թիվը(Ազգային ժողովի ընտրությունների ժամանակ)`"
                                 },
                                 new Question
                                 {
                                     Id = 79,
                                     QuestionContent = "Քվեարկության արդյունքներն ամփոփելիս ի՞նչ գործողություն է կատարում տեղամասային ընտրական հանձնաժողովը քվեարկության ծրարի վրա ավելորդ գրառում լինելու դեպքում`"
                                 },
                                 new Question
                                 {
                                     Id = 80,
                                     QuestionContent = "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`"
                                 },
                                 new Question
                                 {
                                     Id = 81,
                                     QuestionContent = "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`"
                                 },
                                 new Question
                                 {
                                     Id = 82,
                                     QuestionContent = "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`"
                                 },
                                 new Question
                                 {
                                     Id = 83,
                                     QuestionContent = "Ընտրական հանձնաժողովի գործողությունները քվեարկության ծրարի մեջ մեկից ավելի քվեաթերթիկներ հայտնաբերելու դեպքում`"
                                 },
                                 new Question
                                 {
                                     Id = 84,
                                     QuestionContent = "Ընտրական տեղամասում ընտրողների ընդհանուր թիվը հավասար է`"
                                 },
                                 new Question
                                 {
                                     Id = 85,
                                     QuestionContent = "Տեղամասային ընտրական հանձնաժողովում մեկանգամյա օգտագործման պարկը սահմանված կարգով փակելու համար պատասխանատու է` "
                                 },
                                 new Question
                                 {
                                     Id = 86,
                                     QuestionContent = "Ազգային Ժողովի ընտրությունների դեպքում ո՞ր քվեաթերթիկն է անվավեր`"
                                 },
                                 new Question
                                 {
                                     Id = 87,
                                     QuestionContent = "Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`"
                                 },
                                 new Question
                                 {
                                     Id = 88,
                                     QuestionContent = "Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է`"
                                 },
                                 new Question
                                 {
                                     Id = 89,
                                     QuestionContent = "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`"
                                 },
                                 new Question
                                 {
                                     Id = 90,
                                     QuestionContent = "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`"
                                 },
                                 new Question
                                 {
                                     Id = 91,
                                     QuestionContent = "Ո՞ր քվեաթերթիկն է համարվում սահմանված նմուշի՝"
                                 },
                                 new Question
                                 {
                                     Id = 92,
                                     QuestionContent = "Տեղամասային ընտրական հանձնաժողովը նշվածներից ո՞ր գործողությունն է կատարում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`"
                                 },
                                 new Question
                                 {
                                     Id = 93,
                                     QuestionContent = "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`"
                                 },
                                 new Question
                                 {
                                     Id = 94,
                                     QuestionContent = "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`"
                                 },
                                 new Question
                                 {
                                     Id = 95,
                                     QuestionContent = "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`"
                                 },
                                 new Question
                                 {
                                     Id = 96,
                                     QuestionContent = "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`"
                                 },
                                 new Question
                                 {
                                     Id = 97,
                                     QuestionContent = "Հանձնաժողովի նախագահից բացի, ովքե՞ր իրավունք ունեն ստորագրելու հաշվարկված և տեսակավորված քվեաթերթիկների փաթեթների վրա`"
                                 },
                                 new Question
                                 {
                                     Id = 98,
                                     QuestionContent = "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`"
                                 },
                                 new Question
                                 {
                                     Id = 99,
                                     QuestionContent = "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`"
                                 },
                                 new Question
                                 {
                                     Id = 100,
                                     QuestionContent = "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`"
                                 },
                                 new Question
                                 {
                                     Id = 101,
                                     QuestionContent = "Տեղամասային ընտրական հանձնաժողովի նախագահը և քարտուղարը պարկը, քվեարկության արդյունքների արձանագրության երկու օրինակը, գրանցամատյանը, հանձնաժողովի կնիքը և տեխնիկական սարքավորումը քվեարկության ավարտից հետո՝"
                                 },
                                 new Question
                                 {
                                     Id = 102,
                                     QuestionContent = "Քվեարկության ավարտից հետո՝ մինչև ընտրական տեղամասում քվեարկության արդյունքների վերաբերյալ արձանագրություն կազմելը, տեղամասային ընտրական հանձնաժողովի նիստը`"
                                 },
                                 new Question
                                 {
                                     Id = 103,
                                     QuestionContent = "Քանի՞ օրինակից է կազմվում ընտրական տեղամասում քվեարկության արդյունքների արձանագրությունը`"
                                 }

                );
        }
    }
}
