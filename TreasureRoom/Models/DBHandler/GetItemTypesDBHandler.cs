using System.Collections.Generic;
using System.Linq;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetItemTypesDBHandler
    {
        public List<ItemTypesViewModel> GetItemTypes()
        {
            var getItemTypes = new List<ItemTypesViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                getItemTypes = db.dbo_ItemTypes.Select(m => new ItemTypesViewModel()
                {
                    ID = m.ID,
                    ItemType = m.ItemType
                }
                ).ToList();
                return getItemTypes;
            }
        }
    }
}