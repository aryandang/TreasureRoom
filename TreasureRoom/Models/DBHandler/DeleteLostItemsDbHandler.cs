using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class DeleteLostItemsDbHandler
    {
        public void DeleteLostItemsData(LostItemsViewModel model)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Delete_LostItems(model.EditID);
            }
        }
    }
}