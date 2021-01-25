using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsWalletsOrPursesDBHandler
    {
        public List<QuestionsViewModel> GetElectronicQuestions()
        {
            var getWalletsorOrPursesQuestions = new List<QuestionsViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                getWalletsorOrPursesQuestions = db.dbo_Questions_WalletsOrPurses.Select(m => new QuestionsViewModel()
                {
                    ID = m.ID,
                    Question = m.Question
                }
                ).ToList();
                return getWalletsorOrPursesQuestions;
            }
        }
    }
}