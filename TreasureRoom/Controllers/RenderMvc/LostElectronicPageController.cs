using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostElectronicPageController : RenderMvcController
    {
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
        private GetQuestionsElectronicDBHandler getQuestionsDbHandler = new GetQuestionsElectronicDBHandler();
        public override ActionResult Index(ContentModel model)
        {
            var lostElectronicContentModel = new LostElectronicContentModel(model.Content);

            var getTitlesData = getTitlesDbHandler.GetTitles();
            var getQuestionsData = getQuestionsDbHandler.GetQuestions();

            var lostElectronicViewModel = new LostElectronicViewModel()
            {
                TitlesData = getTitlesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData
            };

            lostElectronicContentModel.LostElectronicViewModel = lostElectronicViewModel;

            return CurrentTemplate(lostElectronicContentModel);
        }
    }
}