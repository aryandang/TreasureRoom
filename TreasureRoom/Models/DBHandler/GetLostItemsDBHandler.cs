﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetLostItemsDBHandler
    {
        SearchViewModel searchViewModel = new SearchViewModel();
        public List<LostItemsViewModel> GetLostItems(string searchTerm, string postCode, string itemType)
        {
            var lostItems = new List<LostItemsViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                if (searchTerm.IsNullOrWhiteSpace() && postCode.IsNullOrWhiteSpace() && itemType.IsNullOrWhiteSpace())
                {
                     lostItems = db.dbo_LostItems.Select(m => new LostItemsViewModel()
                    {
                        ID = m.ID,
                        Title = m.Title,
                        Description = m.Description,
                        ItemType = m.ItemType,
                        Image = m.Image,
                        Postcode = m.Postcode,
                        DatePosted = m.DatePosted.Value
                    }).ToList();
                }
                else if (!searchTerm.IsNullOrWhiteSpace() && !postCode.IsNullOrWhiteSpace() && !itemType.IsNullOrWhiteSpace())
                {
                    lostItems = db.dbo_LostItems.Select(m => new LostItemsViewModel()
                    {
                        ID = m.ID,
                        Title = m.Title,
                        Description = m.Description,
                        ItemType = m.ItemType,
                        Image = m.Image,
                        Postcode = m.Postcode,
                        DatePosted = m.DatePosted.Value
                    }).Where(m => (m.Description.Contains(searchTerm) || m.Title.Contains(searchTerm)) &&
                                  (m.Postcode.Contains(postCode))
                                  & (m.ItemType.Contains(itemType))).ToList();
                }
                

                return lostItems;
            }
        }
    }
}