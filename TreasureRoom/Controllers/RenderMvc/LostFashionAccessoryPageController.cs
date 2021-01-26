using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostFashionAccessoryPageController : RenderMvcController
    {
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
        private GetQuestionsFashionAccessoryDBHandler getQuestionsFashionAccessoryDbHandler = new GetQuestionsFashionAccessoryDBHandler();
        public ActionResult Index(ContentModel model)
        {
            var lostFashionAccessoryContentModel = new LostFashionAccessoryContentModel(model.Content);

            var getTitlesData = getTitlesDbHandler.GetTitles();
            var getQuestionsData = getQuestionsFashionAccessoryDbHandler.GetQuestions();

            var lostFashionAccessoryViewModel = new LostFashionAccessoryViewModel()
            {
                TitlesData = getTitlesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData
            };

            lostFashionAccessoryContentModel.LostFashionAccessoryViewModel = lostFashionAccessoryViewModel;

            return CurrentTemplate(lostFashionAccessoryContentModel);
        }
    }
}