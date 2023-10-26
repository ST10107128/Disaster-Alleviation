using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Disaster_Alleviation.Areas.Identity.Pages.Account.Manage
{
    public class ViewModel2 : PageModel
    {
      

        public List<string[]> GetGetDisasterData()
        {

            List<string[]> disas = new List<string[]>();

            String connection = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "SELECT StartDate, EndDate, Location, DisaterDescription, RequiredAid from Disaster";



            using (Microsoft.Data.SqlClient.SqlConnection co = new SqlConnection(connection))


            {
                co.Open();

                using (SqlCommand com = new SqlCommand(sqlQuery, co))
                {


                    using (SqlDataReader reader = com.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            string sDate = reader["StartDate"].ToString();
                            string eDate = reader["EndDate"].ToString();
                            string Loc = reader["Location"].ToString();
                            string DisDes = reader["DisaterDescription"].ToString();
                            string ReqAid = reader["RequiredAid"].ToString();

                            string[] dataRow = { sDate, eDate, Loc, DisDes, ReqAid };
                            disas.Add(dataRow);

                        }
                    }

                }
            }

            return disas;

        }



        public IActionResult OnGet()
        {

            List<string[]> disas = GetGetDisasterData();

            ViewData["Disater"] = disas;
            return Page();
        }

    }
}

