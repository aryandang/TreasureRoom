using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AngleSharp;
using TreasureRoom.Models.ViewModel;

namespace TreasureRoom.Models.DBHandler
{
    public class GetItemTypesDBHandler
    {
        private SqlConnection con;

        private void connection()
        {
            string conString = ConfigurationManager.ConnectionStrings["TreasureRoomEntities"].ToString();
            con = new SqlConnection(conString);
        }

        public List<SearchViewModel> GetItemTypes()
        {
            connection();
            List<SearchViewModel> ItemTypes = new List<SearchViewModel>();

            SqlCommand cmd = new SqlCommand("EXEC Get_ItemTypes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ItemTypes.Add(
                    new SearchViewModel
                    {
                        ItemType = Convert.ToString(dr["ItemType"])
                    });
            }
            return ItemTypes;
        }
    }
}