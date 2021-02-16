using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostKeysPageController : RenderMvcController
    {
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
        private GetQuestionsKeysDBHandler getQuestionsKeysDbHandler = new GetQuestionsKeysDBHandler();
        public override ActionResult Index(ContentModel model)
        {
            var lostKeysContentModel = new LostKeysContentModel(model.Content);

            var getTitlesData = getTitlesDbHandler.GetTitles();
            var getQuestionsData = getQuestionsKeysDbHandler.GetQuestions();

            var lostKeysViewModel = new LostKeysViewModel()
            {
                TitlesData = getTitlesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData
            };

            lostKeysContentModel.LostKeysViewModel = lostKeysViewModel;

            return CurrentTemplate(lostKeysContentModel);
        }
    }
}