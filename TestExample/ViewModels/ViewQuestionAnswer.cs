using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestExample.ViewModels
{
    public class ViewQuestionAnswer
    {
        public int Id { get; set; }

        public int QId { get; set; }

        public string QuestionContent { get; set; }

        public string RAnswerContent { get; set; }

        public bool Cheked { get; set; }

        public int Score { get; set; }

    }
}
