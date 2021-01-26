using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsWalletOrPurseElectronicDBHandler
    {
        public List<QuestionsWalletOrPurseViewModel> GetQuestions()
        {
            var getQuestions = new List<QuestionsWalletOrPurseViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getQuestions = db.dbo_Questions_WalletOrPurse.Select(m => new QuestionsWalletOrPurseViewModel()
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