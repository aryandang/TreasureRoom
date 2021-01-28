using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class PostLostPurseDBHandler
    {


        public void PostLostItemsData(LostPurseViewModel model)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Post_LostItems(model.ID, model.EditID, model.Title, model.Description, model.Postcode, model.ItemType,
                    model.ImagePath,
                    model.DatePosted, model.UserTitle, model.FullName, model.EmailAddress, model.Question1, model.Answer1, model.Question2, model.Answer2, model.Question3, model.Answer3);
            }
        }
    }
}