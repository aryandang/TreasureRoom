using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsFashionAccessoryDBHandler
    {
        public List<QuestionsViewModel> GetElectronicQuestions()
        {
            var getFashionAccessoryQuestions = new List<QuestionsViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                getFashionAccessoryQuestions = db.dbo_Questions_FashionAccessory.Select(m => new QuestionsViewModel()
                {
                    ID = m.ID,
                    Question = m.Question
                }
                ).ToList();
                return getFashionAccessoryQuestions;
            }
        }
    }
}