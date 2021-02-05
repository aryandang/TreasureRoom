using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class PostRetrieveItemsUsersDBHandler
    {


        public void PostRetrieveItemsUsersData(RetrieveViewModel model)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Post_RetrieveItemsUsers(model.ID, model.FullName, model.EmailAddress, model.PhoneNumber, model.Age18AboveAndHonesty, model.ConsentToData);
            }
        }
    }
}