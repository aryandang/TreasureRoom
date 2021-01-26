using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostPursePageController : RenderMvcController
    {
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
        private GetQuestionsWalletOrPurseElectronicDBHandler getQuestionsWalletOrPurseElectronicDbHandler = new GetQuestionsWalletOrPurseElectronicDBHandler();
        public ActionResult Index(ContentModel model)
        {
            var lostPurseContentModel = new LostPurseContentModel(model.Content);

            var getTitlesData = getTitlesDbHandler.GetTitles();
            var getQuestionsData = getQuestionsWalletOrPurseElectronicDbHandler.GetQuestions();

            var lostPurseViewModel = new LostPurseViewModel()
            {
                TitlesData = getTitlesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData
            };

            lostPurseContentModel.LostPurseViewModel = lostPurseViewModel;

            return CurrentTemplate(lostPurseContentModel);
        }
    }
}