using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Services
{
    public class EditLostItemService
    {
        public void EditLostItemData(EditOrDeleteItemViewModel model)
        {
            foreach (var var in model.LostItemsData)
            {
                model.ID = var.ID;
                model.Title = var.Title;
                model.Description = var.Description;
                model.ItemType = var.ItemType;
                model.Postcode = var.Postcode;
                model.DatePosted = var.DatePosted;
                model.Question1 = var.Question1;
                model.Answer1 = var.Answer1;
                model.Question2 = var.Question2;
                model.Answer2 = var.Answer2;
                model.Question3 = var.Question3;
                model.Answer3 = var.Answer3;
                model.UserTitle = var.UserTitle;
                model.FullName = var.FullName;
                model.EmailAddress = var.EmailAddress;
            }
        }
    }
}