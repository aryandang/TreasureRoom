using System.Collections.Generic;
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class EditOrDeleteItemPageController : RenderMvcController
    {
        private GetLostItemsByEditIdDBHandler getLostItemsByEditIdDbHandler = new GetLostItemsByEditIdDBHandler();
        private GetQuestionsElectronicDBHandler getQuestionsElectronicDbHandler = new GetQuestionsElectronicDBHandler();
        private GetQuestionsWalletOrPurseElectronicDBHandler getQuestionsWalletOrPurseElectronicDbHandler = new GetQuestionsWalletOrPurseElectronicDBHandler();
        private GetQuestionsKeysDBHandler getQuestionsKeysDbHandler = new GetQuestionsKeysDBHandler();
        private GetQuestionsFashionAccessoryDBHandler getQuestionsFashionAccessoryDbHandler = new GetQuestionsFashionAccessoryDBHandler();
        private GetItemTypesDBHandler getItemTypesDbHandler = new GetItemTypesDBHandler();
        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();

        public ActionResult Index(ContentModel model, string editId)
        {
            var editOrDeleteItemPageModel = new EditOrDeleteItemContentModel(model.Content);

            var getItemData = getLostItemsByEditIdDbHandler.GetLostItemsById(editId);

            var getQuestionsData = new List<QuestionsViewModel>();

            foreach (var value in getItemData)
            {
                if (value.ItemType.Contains("Electronic"))
                {
                    getQuestionsData = getQuestionsElectronicDbHandler.GetQuestions();
                }

                if (value.ItemType.Contains("Wallet") || value.ItemType.Contains("Purse"))
                {
                    getQuestionsData = getQuestionsWalletOrPurseElectronicDbHandler.GetQuestions();
                }

                if (value.ItemType.Contains("Keys"))
                {
                    getQuestionsData = getQuestionsKeysDbHandler.GetQuestions();
                }

                if (value.ItemType.Contains("Fashion Accessory"))
                {
                    getQuestionsData = getQuestionsFashionAccessoryDbHandler.GetQuestions();
                }
            }

            var getItemTypesData = getItemTypesDbHandler.GetItemTypes();

            var getTitlesData = getTitlesDbHandler.GetTitles();

            var editOrDeleteItemViewModel = new EditOrDeleteItemViewModel()
            {
                LostItemsData = getItemData,
                ItemTypesData = getItemTypesData,
                Question1Data = getQuestionsData,
                Question2Data = getQuestionsData,
                Question3Data = getQuestionsData,
                TitlesData = getTitlesData
            };

            editOrDeleteItemPageModel.EditOrDeleteItemViewModel = editOrDeleteItemViewModel;

            return CurrentTemplate(editOrDeleteItemPageModel);
        }
    }
}