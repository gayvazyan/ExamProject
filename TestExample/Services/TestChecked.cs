using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.ViewModels;

namespace TestExample.Services
{
    public class TestChecked : ITestChecked
    {
        private readonly ExamDbContect _examDbContect;

        public TestChecked(ExamDbContect examDbContect)
        {
            _examDbContect = examDbContect;
        }
        public CitizenTestViewModel TestResult(CitizenTestResults citizenTestResults, EmptyTextViewModel emptyTextViewModel)
        {
           
           
            double result = 0;
            CitizenTestViewModel citizenTestViewModel = new CitizenTestViewModel();


            // citizenTestViewModel Result creating  start
            citizenTestViewModel.NumberTicket = citizenTestResults.NumberTicket;

            citizenTestViewModel.Region = citizenTestResults.Region;

            citizenTestViewModel.Community = citizenTestResults.Community;

            citizenTestViewModel.CEC = citizenTestResults.CEC;

            citizenTestViewModel.TEC = citizenTestResults.TEC;

            citizenTestViewModel.Participants = citizenTestResults.Participants;

            citizenTestViewModel.AllAdditionallyDuringElDay = citizenTestResults.AllAdditionallyDuringElDay;

            citizenTestViewModel.PartAdditionallyDuringElDay = citizenTestResults.AllAdditionallyDuringElDay;

            citizenTestViewModel.AllMobileVoters = citizenTestResults.AllMobileVoters;

            citizenTestViewModel.PartMobileVoters = citizenTestResults.PartMobileVoters;

            //citizenTestViewModel.AllSum = emptyTextViewModel.ListAll
            //                              + emptyTextViewModel.AllAdditionallyDuringElDay
            //                              + emptyTextViewModel.AllMobileVoters;

            //citizenTestViewModel.PartSum = emptyTextViewModel.Participants
            //                                + emptyTextViewModel.AllAdditionallyDuringElDay
            //                                + emptyTextViewModel.PartMobileVoters;

            citizenTestViewModel.AllSum = citizenTestResults.AllSum;

            citizenTestViewModel.PartSum = citizenTestResults.PartSum;

            citizenTestViewModel.VadTickets = citizenTestResults.VadTickets;

            citizenTestViewModel.NumerableTickets = citizenTestResults.NumerableTickets;

            //citizenTestViewModel.AllTickets = emptyTextViewModel.VadTickets
            //                                +emptyTextViewModel.NumerableTickets;
            citizenTestViewModel.AllTickets = citizenTestResults.AllTickets;

            citizenTestViewModel.UnusedNumerableTickets = citizenTestResults.UnusedNumerableTickets;

            citizenTestViewModel.UnusedGlueTickets = citizenTestResults.UnusedGlueTickets;

            citizenTestViewModel.InvalidTickets = citizenTestResults.InvalidTickets;

            citizenTestViewModel.ForA = citizenTestResults.ForA;

            citizenTestViewModel.ForB = citizenTestResults.ForB;

            citizenTestViewModel.ForC = citizenTestResults.ForC;

            citizenTestViewModel.ForAx = citizenTestResults.ForAx;

            citizenTestViewModel.ForAy = citizenTestResults.ForAy;

            citizenTestViewModel.ForBm = citizenTestResults.ForBm;

            citizenTestViewModel.ForBn = citizenTestResults.ForBn;

            citizenTestViewModel.ForCk = citizenTestResults.ForCk;

            citizenTestViewModel.ForCl = citizenTestResults.ForCl;

            // citizenTestViewModel Resoult creating  end



            if (citizenTestResults.Region == emptyTextViewModel.Region)
            {
              
                citizenTestViewModel.RegionBool = true;
                result += 0.1;
            }
            if (citizenTestResults.Community == emptyTextViewModel.Community)
            {
                citizenTestViewModel.CommunityBool = true;
                result += 0.1;
            }
            if (citizenTestResults.CEC == emptyTextViewModel.CEC)
            {
                citizenTestViewModel.CECBool = true;
                result += 0.1;
            }
            if (citizenTestResults.TEC == emptyTextViewModel.TEC)
            {
                citizenTestViewModel.TECBool = true;
                result += 0.1;
            }
            if (citizenTestResults.Participants == emptyTextViewModel.Participants)
            {
                citizenTestViewModel.ParticipantsBool = true;
                result += 0.4;
            }
            if (citizenTestResults.AllAdditionallyDuringElDay == emptyTextViewModel.AllAdditionallyDuringElDay)
            {
                citizenTestViewModel.AllAdditionallyDuringElDayBool = true;
                result += 0.3;
            }
            if (citizenTestResults.PartAdditionallyDuringElDay == emptyTextViewModel.AllAdditionallyDuringElDay)
            {
                citizenTestViewModel.PartAdditionallyDuringElDayBool = true;
                result += 0.3;
            }
            if (citizenTestResults.AllMobileVoters == emptyTextViewModel.AllMobileVoters)
            {
                citizenTestViewModel.AllMobileVotersBool = true;
                result += 0.3;
            }
            if (citizenTestResults.PartMobileVoters == emptyTextViewModel.PartMobileVoters)
            {
                citizenTestViewModel.PartMobileVotersBool = true;
                result += 0.3;
            }
            if (citizenTestResults.AllSum == emptyTextViewModel.ListAll
                                          + emptyTextViewModel.AllAdditionallyDuringElDay
                                          + emptyTextViewModel.AllMobileVoters)
            {
                citizenTestViewModel.AllSumBool = true;
                result += 0.3;
            }
            if (citizenTestResults.PartSum == emptyTextViewModel.Participants
                                            + emptyTextViewModel.AllAdditionallyDuringElDay
                                            + emptyTextViewModel.PartMobileVoters)
            {
                citizenTestViewModel.PartSumBool = true;
                result += 0.3;
            }
            if (citizenTestResults.VadTickets == emptyTextViewModel.VadTickets)
            {
                citizenTestViewModel.VadTicketsBool = true;
                result += 0.4;
            }
            if (citizenTestResults.NumerableTickets == emptyTextViewModel.NumerableTickets)
            {
                citizenTestViewModel.NumerableTicketsBool = true;
                result += 0.3;
            }
            if (citizenTestResults.AllTickets == emptyTextViewModel.VadTickets
                                            + emptyTextViewModel.NumerableTickets)
            {
                citizenTestViewModel.AllTicketsBool = true;
                result += 0.2;
            }
            if (citizenTestResults.UnusedNumerableTickets == emptyTextViewModel.UnusedNumerableTickets)
            {
                citizenTestViewModel.UnusedNumerableTicketsBool = true;
                result += 0.2;
            }
            if (citizenTestResults.UnusedGlueTickets == emptyTextViewModel.UnusedGlueTickets)
            {
                citizenTestViewModel.UnusedGlueTicketsBool = true;
                result += 0.2;
            }
            if (citizenTestResults.InvalidTickets == emptyTextViewModel.InvalidTickets)
            {
                citizenTestViewModel.InvalidTicketsBool = true;
                result += 0.2;
            }
            if (citizenTestResults.ForA == emptyTextViewModel.ForA)
            {
                citizenTestViewModel.ForABool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForB == emptyTextViewModel.ForB)
            {
                citizenTestViewModel.ForBBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForC == emptyTextViewModel.ForC)
            {
                citizenTestViewModel.ForCBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForAx == emptyTextViewModel.ForAx)
            {
                citizenTestViewModel.ForAxBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForAy == emptyTextViewModel.ForAy)
            {
                citizenTestViewModel.ForAyBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForBm == emptyTextViewModel.ForBm)
            {
                citizenTestViewModel.ForBmBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForBn == emptyTextViewModel.ForBn)
            {
                citizenTestViewModel.ForBnBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForCk == emptyTextViewModel.ForCk)
            {
                citizenTestViewModel.ForCkBool = true;
                result += 0.1;
            }
            if (citizenTestResults.ForCl == emptyTextViewModel.ForCl)
            {
                citizenTestViewModel.ForClBool = true;
                result += 0.1;
            }

            citizenTestViewModel.Result = result;

            return citizenTestViewModel;
        }


    }
}
