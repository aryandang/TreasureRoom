using System.Collections.Generic;
using System.Linq;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsKeysDBHandler
    {
        public List<QuestionsViewModel> GetElectronicQuestions()
        {
            var getKeyQuestions = new List<QuestionsViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                getKeyQuestions = db.dbo_Questions_Keys.Select(m => new QuestionsViewModel()
                {
                    ID = m.ID,
                    Question = m.Question
                }
                ).ToList();
                return getKeyQuestions;
            }
        }
    }
}