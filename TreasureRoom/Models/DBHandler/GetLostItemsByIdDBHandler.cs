﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetLostItemsByIdDBHandler
    {
        public List<LostItemsViewModel> GetLostItemsById(string id)
        {
            var lostItems = new List<LostItemsViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                lostItems = db.dbo_LostItems.Select(m => new LostItemsViewModel()
                {
                    ID = m.ID,
                    Title = m.Title,
                    Description = m.Description,
                    ItemType = m.ItemType,
                    Image = m.ImagePath,
                    Postcode = m.Postcode,
                    DatePosted = m.DatePosted.Value,
                    Question1 = m.Question1,
                    Answer1 = m.Answer1,
                    Question2 = m.Question2,
                    Answer2 = m.Answer2,
                    Question3 = m.Question3,
                    Answer3 = m.Answer3,
                    FullName = m.UserFullName,
                    EmailAddress = m.UserEmailAddress

                }).Where(m => (m.ID.Contains(id))).ToList();
                return lostItems;
            }
        }
    }
}