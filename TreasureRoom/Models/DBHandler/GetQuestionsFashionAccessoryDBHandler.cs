using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetQuestionsFashionAccessoryDBHandler
    {
        public List<QuestionsFashionAccessoryViewModel> GetQuestions()
        {
            var getQuestions = new List<QuestionsFashionAccessoryViewModel>();
                using (var db = new TreasureRoomEntities())
                {
                    getQuestions = db.dbo_Questions_FashionAccessory.Select(m => new QuestionsFashionAccessoryViewModel()
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