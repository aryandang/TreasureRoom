﻿using System.Collections.Generic;
using System.Linq;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsWalletOrPurseElectronicDBHandler
    {
        public List<QuestionsViewModel> GetQuestions()
        {
            var getQuestions = new List<QuestionsViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getQuestions = db.dbo_Questions_WalletOrPurse.Select(m => new QuestionsViewModel()
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