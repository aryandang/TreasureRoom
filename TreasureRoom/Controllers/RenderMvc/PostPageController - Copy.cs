//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using TreasureRoom.Models;
//using TreasureRoom.Models.DBHandler;
//using TreasureRoom.Models.ViewModel;
//using Umbraco.Web.Models;
//using Umbraco.Web.Mvc;

//namespace TreasureRoom.Controllers.RenderMvc
//{
//    public class PostPageController : RenderMvcController
//    {
//        private GetTitlesDBHandler getTitlesDbHandler = new GetTitlesDBHandler();
//        private GetItemTypesDBHandler getItemTypesDbHandler = new GetItemTypesDBHandler();
//        private GetQuestionsDBHandler getQuestionsDbHandler = new GetQuestionsDBHandler();
//        public ActionResult Index(ContentModel model, string itemType)
//        {
//            var postPageModel = new PostContentModel(model.Content);

//            var getTitlesData = getTitlesDbHandler.GetTitles();
//            var getItemTypesData = getItemTypesDbHandler.GetItemTypes();
//            var getQuestionsData = getQuestionsDbHandler.GetQuestions();

//            var postViewModel = new PostViewModel()
//            {
//                TitlesData = getTitlesData,
//                ItemTypesData = getItemTypesData,
//                Question1Data = getQuestionsData,
//                Question2Data = getQuestionsData,
//                Question3Data = getQuestionsData
//            };

//            postPageModel.PostViewModel = postViewModel;

//            return CurrentTemplate(postPageModel);
//        }
//    }
//}