using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsElectronicDBHandler
    {
        public List<QuestionsViewModel> GetElectronicQuestions(string itemType)
        {
            var getElectronicQuestions = new List<QuestionsViewModel>();
            if (itemType.Contains("Electronic"))
            {
                using (var db = new TreasureRoomEntities())
                {
                    getElectronicQuestions = db.dbo_Questions_Electronics.Select(m => new QuestionsViewModel()
                        {
                            ID = m.ID,
                            Question = m.Question
                        }
                    ).ToList();
                    return getElectronicQuestions;
                }
            }
            else
            {
                return null;
            }
        }
    }
}