﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class PostLostItemsDBHandler
    {


        public void PostLostItemsData(PostViewModel model)
        {
            using (var db = new TreasureRoomEntities())
            {
                db.Post_LostItems(model.ID, model.Title, model.Description, model.Postcode, model.ItemType,
                    model.ImagePath,
                    model.DatePosted, model.UserTitle, model.FullName, model.EmailAddress);
            }
        }
    }
}