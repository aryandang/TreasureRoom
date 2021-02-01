using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class UpdateLostItemsDBHandler
    {
        EditOrDeleteItemViewModel editOrDeleteItemViewModel = new EditOrDeleteItemViewModel();
        public void UpdateLostItemsData(EditOrDeleteItemViewModel model)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Update_LostItems(model.EditID, model.Title, model.Description, model.Postcode, model.ItemType,
                    model.ImagePath, model.DatePosted,
                    model.UserTitle, model.FullName, model.EmailAddress, model.Question1, model.Answer1, 
                    model.Question2,
                    model.Answer2, model.Question3, model.Answer3);
            }
        }
    }
}