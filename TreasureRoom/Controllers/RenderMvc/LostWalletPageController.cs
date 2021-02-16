using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostWalletPageController : RenderMvcController
    {
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
        private GetQuestionsWalletOrPurseElectronicDBHandler getQuestionsWalletOrPurseElectronicDbHandler = new GetQuestionsWalletOrPurseElectronicDBHandler();
        public override ActionResult Index(ContentModel model)
        {
            var lostWalletContentModel = new LostWalletContentModel(model.Content);

            var getTitlesData = getTitlesDbHandler.GetTitles();
            var getQuestionsData = getQuestionsWalletOrPurseElectronicDbHandler.GetQuestions();

            var lostWalletViewModel = new LostWalletViewModel()
            {
                TitlesData = getTitlesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData
            };

            lostWalletContentModel.LostWalletViewModel = lostWalletViewModel;

            return CurrentTemplate(lostWalletContentModel);
        }
    }
}