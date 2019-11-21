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
                  QuestionVariantContent = "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 2,
                  QuestionVariantContent = "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = true,
                  CheckCorrectAnswer = false,
                  CheckdAnswer=false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 3,
                  QuestionVariantContent = "եթե կողմ են քվեարկել հանձնաժողովի նախագահն ու քարտուղարը, բացառությամբ օրենքով սահմանցած դեպքերի",
                  CorrectAnswer = false,
                  CheckCorrectAnswer = false,
                  CheckdAnswer = false,
                  QuestionId = 1
              },
              new Answer
              {
                  Id = 4,
                  QuestionVariantContent = "քվեարկության օրվանից 1 օր առաջ",
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
                  QuestionVariantContent = "քվեարկության օրը",
                  CorrectAnswer = false,
                  CheckCorrectAnswer=false,
                  CheckdAnswer = false,
                  QuestionId = 2
              }
                );
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    QuestionContent = "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝"
                },
                new Question
                {
                    Id = 2,
                    QuestionContent = "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ "
                }
                );

        }
    }
}
