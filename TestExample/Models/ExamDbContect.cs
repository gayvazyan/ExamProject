using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.MyModels;
using TestExample.QAmodels;
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

        public DbSet<Answer1> DbAnswer1 { get; set; }

        public DbSet<Question1> DbQuestion1 { get; set; }

        public DbSet<Answer2> DbAnswer2 { get; set; }

        public DbSet<Question2> DbQuestion2 { get; set; }



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

            modelBuilder.Entity<Answer1>().HasData(
              new Answer1
              {
                  Id = 1,
                  QuestionVariantContent = "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer1
              {
                  Id = 2,
                  QuestionVariantContent = "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer=false,
                  QuestionId = 1
              },
              new Answer1
              {
                  Id = 3,
                  QuestionVariantContent = "եթե կողմ են քվեարկել հանձնաժողովի նախագահն ու քարտուղարը, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer1
              {
                  Id = 4,
                  QuestionVariantContent = "քվեարկության օրվանից 1 օր առաջ",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer1
              {
                  Id = 5,
                  QuestionVariantContent = "քվեարկության օրվանից 2 օր առաջ",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer1
              {
                  Id = 6,
                  QuestionVariantContent = "քվեարկության օրը",
                  CorrectAnswer = false,
                  CheckCorrectAnswer=false,
                  CheckdAnswer = false,
                  QuestionId = 2
              },
              new Answer1
              {
                  Id = 7,
                  QuestionVariantContent = "4-1",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer1
              {
                  Id = 8,
                  QuestionVariantContent = "4-2",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer1
              {
                  Id = 9,
                  QuestionVariantContent = "4-3",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 4
              },
              new Answer1
              {
                  Id = 10,
                  QuestionVariantContent = "5-1",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              },
              new Answer1
              {
                  Id = 11,
                  QuestionVariantContent = "5-2",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              },
              new Answer1
              {
                  Id = 12,
                  QuestionVariantContent = "5-3",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 5
              }
                );

            modelBuilder.Entity<Answer2>().HasData(
             new Answer2
             {
                 Id = 1,
                 QuestionVariantContent = "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի",
                 CorrectAnswer = true,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 1
             },
             new Answer2
             {
                 Id = 2,
                 QuestionVariantContent = "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 1
             },
             new Answer2
             {
                 Id = 3,
                 QuestionVariantContent = "եթե կողմ են քվեարկել հանձնաժողովի նախագահն ու քարտուղարը, բացառությամբ օրենքով սահմանցած դեպքերի",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 1
             },
             new Answer2
             {
                 Id = 4,
                 QuestionVariantContent = "քվեարկության օրվանից 1 օր առաջ",
                 CorrectAnswer = true,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 2
             },
             new Answer2
             {
                 Id = 5,
                 QuestionVariantContent = "քվեարկության օրվանից 2 օր առաջ",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 2
             },
             new Answer2
             {
                 Id = 6,
                 QuestionVariantContent = "քվեարկության օրը",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 2
             },
             new Answer2
             {
                 Id = 7,
                 QuestionVariantContent = "4-1",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 4
             },
             new Answer2
             {
                 Id = 8,
                 QuestionVariantContent = "4-2",
                 CorrectAnswer = true,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 4
             },
             new Answer2
             {
                 Id = 9,
                 QuestionVariantContent = "4-3",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 4
             },
             new Answer2
             {
                 Id = 10,
                 QuestionVariantContent = "5-1",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 5
             },
             new Answer2
             {
                 Id = 11,
                 QuestionVariantContent = "5-2",
                 CorrectAnswer = true,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 5
             },
             new Answer2
             {
                 Id = 12,
                 QuestionVariantContent = "5-3",
                 CorrectAnswer = false,
                 CheckCorrectAnswer = false,
                 CheckdAnswer = false,
                 QuestionId = 5
             }
               );

            modelBuilder.Entity<Question1>().HasData(
                new Question1
                {
                    Id = 1,
                    QuestionContent = "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝"
                },
                new Question1
                {
                    Id = 2,
                    QuestionContent = "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ "
                },
                new Question1
                 {
                     Id = 3,
                     QuestionContent = "Հարց 3. "
                 },
                new Question1
                {
                    Id = 4,
                    QuestionContent = "Հարց 4. "
                },
                new Question1
                {
                    Id = 5,
                    QuestionContent = "Հարց 5. "
                },
                new Question1
                {
                    Id = 6,
                    QuestionContent = "Հարց 6. "
                },
                new Question1
                {
                    Id = 7,
                    QuestionContent = "Հարց 7."
                },
                new Question1
                {
                    Id = 8,
                    QuestionContent = "Հարց 8."
                },
                new Question1
                {
                    Id = 9,
                    QuestionContent = "Հարց 9. "
                },
                new Question1
                {
                    Id = 10,
                    QuestionContent = "Հարց 10. "
                },
                new Question1
                {
                    Id = 11,
                    QuestionContent = "Հարց 11. "
                },
                new Question1
                {
                    Id = 12,
                    QuestionContent = "Հարց 12. "
                },
                new Question1
                {
                    Id = 13,
                    QuestionContent = "Հարց 13. "
                },
                new Question1
                {
                    Id = 14,
                    QuestionContent = "Հարց 14. "
                },
                new Question1
                {
                    Id = 15,
                    QuestionContent = "Հարց 15. "
                },
                new Question1
                 {
                     Id = 16,
                     QuestionContent = "Հարց 16. "
                 },
                new Question1
                {
                    Id = 17,
                    QuestionContent = "Հարց 17. "
                },
                new Question1
                {
                    Id = 18,
                    QuestionContent = "Հարց 18. "
                },
                new Question1
                {
                    Id = 19,
                    QuestionContent = "Հարց 19. "
                },
                new Question1
                {
                    Id =20,
                    QuestionContent = "Հարց 20. "
                },
                new Question1
                {
                    Id = 21,
                    QuestionContent = "Հարց 21. "
                },
                new Question1
                {
                    Id = 22,
                    QuestionContent = "Հարց 22. "
                },
                new Question1
                {
                    Id = 23,
                    QuestionContent = "Հարց 23. "
                },
                new Question1
                {
                    Id = 24,
                    QuestionContent = "Հարց 24."
                },
                new Question1
                {
                    Id = 25,
                    QuestionContent = "Հարց 25. "
                },
                new Question1
                {
                    Id = 26,
                    QuestionContent = "Հարց 26."
                },
                new Question1
                {
                    Id = 27,
                    QuestionContent = "Հարց 27. "
                },
                new Question1
                {
                    Id =28,
                    QuestionContent = "Հարց 28. "
                },
                new Question1
                {
                    Id = 29,
                    QuestionContent = "Հարց 29. "
                },
                new Question1
                {
                    Id = 30,
                    QuestionContent = "Հարց 30. "
                }
                );

            modelBuilder.Entity<Question2>().HasData(
                new Question2
                {
                    Id = 1,
                    QuestionContent = "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝"
                },
                new Question2
                {
                    Id = 2,
                    QuestionContent = "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ "
                },
                new Question2
                {
                    Id = 3,
                    QuestionContent = "Հարց 3. "
                },
                new Question2
                {
                    Id = 4,
                    QuestionContent = "Հարց 4. "
                },
                new Question2
                {
                    Id = 5,
                    QuestionContent = "Հարց 5. "
                },
                new Question2
                {
                    Id = 6,
                    QuestionContent = "Հարց 6. "
                },
                new Question2
                {
                    Id = 7,
                    QuestionContent = "Հարց 7."
                },
                new Question2
                {
                    Id = 8,
                    QuestionContent = "Հարց 8."
                },
                new Question2
                {
                    Id = 9,
                    QuestionContent = "Հարց 9. "
                },
                new Question2
                {
                    Id = 10,
                    QuestionContent = "Հարց 10. "
                },
                new Question2
                {
                    Id = 11,
                    QuestionContent = "Հարց 11. "
                },
                new Question2
                {
                    Id = 12,
                    QuestionContent = "Հարց 12. "
                },
                new Question2
                {
                    Id = 13,
                    QuestionContent = "Հարց 13. "
                },
                new Question2
                {
                    Id = 14,
                    QuestionContent = "Հարց 14. "
                },
                new Question2
                {
                    Id = 15,
                    QuestionContent = "Հարց 15. "
                },
                new Question2
                {
                    Id = 16,
                    QuestionContent = "Հարց 16. "
                },
                new Question2
                {
                    Id = 17,
                    QuestionContent = "Հարց 17. "
                },
                new Question2
                {
                    Id = 18,
                    QuestionContent = "Հարց 18. "
                },
                new Question2
                {
                    Id = 19,
                    QuestionContent = "Հարց 19. "
                },
                new Question2
                {
                    Id = 20,
                    QuestionContent = "Հարց 20. "
                },
                new Question2
                {
                    Id = 21,
                    QuestionContent = "Հարց 21. "
                },
                new Question2
                {
                    Id = 22,
                    QuestionContent = "Հարց 22. "
                },
                new Question2
                {
                    Id = 23,
                    QuestionContent = "Հարց 23. "
                },
                new Question2
                {
                    Id = 24,
                    QuestionContent = "Հարց 24."
                },
                new Question2
                {
                    Id = 25,
                    QuestionContent = "Հարց 25. "
                },
                new Question2
                {
                    Id = 26,
                    QuestionContent = "Հարց 26."
                },
                new Question2
                {
                    Id = 27,
                    QuestionContent = "Հարց 27. "
                },
                new Question2
                {
                    Id = 28,
                    QuestionContent = "Հարց 28. "
                },
                new Question2
                {
                    Id = 29,
                    QuestionContent = "Հարց 29. "
                },
                new Question2
                {
                    Id = 30,
                    QuestionContent = "Հարց 30. "
                }
                );

        }
    }
}
