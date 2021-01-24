using System.Collections.Generic;
using System.Linq;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetTitlesDBHandler
    {
        public List<TitlesViewModel> GetTitles()
        {
            var getTitles = new List<TitlesViewModel>();
            using (var db = new TreasureRoomEntities())
            {
                getTitles = db.dbo_Titles.Select(m => new TitlesViewModel()
                {
                    ID = m.ID,
                    Title = m.Title
                }
                ).ToList();
                return getTitles;
            }
        }
    }
}