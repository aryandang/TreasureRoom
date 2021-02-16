namespace TreasureRoom.Models.DBHandler
{
    public class DeleteLostItemsDbHandler
    {
        public void DeleteLostItemsData(string editId)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Delete_LostItems(editId);
            }
        }
    }
}