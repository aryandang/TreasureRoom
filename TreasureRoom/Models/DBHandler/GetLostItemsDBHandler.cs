using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetLostItemsDBHandler
    {
        public List<LostItemsViewModel> GetLostItems()
        {
            using (var db = new TreasureRoomEntities())
            {
                var lostItems = db.dbo_LostItems.Select(m=>new LostItemsViewModel()
                {
                    ID = m.ID,
                    Title = m.Title,
                    Description = m.Description,
                    ItemType = m.ItemType,
                    Image = m.Image,
                    Postcode = m.Postcode,
                    DatePosted = m.DatePosted.Value
                }).ToList();

                return lostItems;
            }
        }
    }
}