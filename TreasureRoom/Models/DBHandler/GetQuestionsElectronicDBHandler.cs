using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsElectronicDBHandler
    {
        public List<QuestionsElectronicViewModel> GetQuestions()
        {
            var getQuestions = new List<QuestionsElectronicViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getQuestions = db.dbo_Questions_Electronic.Select(m => new QuestionsElectronicViewModel()
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