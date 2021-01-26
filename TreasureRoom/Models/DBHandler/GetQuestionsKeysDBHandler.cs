using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsKeysDBHandler
    {
        public List<QuestionsKeysViewModel> GetQuestions()
        {
            var getQuestions = new List<QuestionsKeysViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getQuestions = db.dbo_Questions_Keys.Select(m => new QuestionsKeysViewModel()
                        {
                            ID = m.ID,
                            Question = m.Question
                        }
                    ).ToList();
                    return getQuestions;
                }
        }
    }
}