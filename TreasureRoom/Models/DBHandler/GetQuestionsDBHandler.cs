using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsDBHandler
    {
        public List<QuestionsViewModel> GetQuestions()
        {
            var getElectronicQuestions = new List<QuestionsViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getElectronicQuestions = db.dbo_Questions.Select(m => new QuestionsViewModel()
                        {
                            ID = m.ID,
                            Question = m.Question
                        }
                    ).ToList();
                    return getElectronicQuestions;
                }
        }
    }
}