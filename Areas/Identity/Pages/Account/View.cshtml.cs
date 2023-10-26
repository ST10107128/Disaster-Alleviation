using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Disaster_Alleviation.Areas.Identity.Pages.Account.Manage
{
    public class ViewModel : PageModel
    {



        public List<string[]> GetMonetaryDonationData()
        {

            List<string[]> money_Donations = new List<string[]>();

            String connection = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "SELECT MoneyDate, Amount, DonateeName from MonetaryDonation";



            using (SqlConnection co = new SqlConnection(connection))


            {
                co.Open();

                using (SqlCommand com = new SqlCommand(sqlQuery, co))
                {


                    using (SqlDataReader reader = com.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            string Date = reader["MoneyDate"].ToString();
                            string Amount = reader["Amount"].ToString();
                            string DonateeName = reader["DonateeName"].ToString();

                            string[] dataRow = { Date, Amount, DonateeName };
                            money_Donations.Add(dataRow);

                        }
                    }

                }
            }

            return money_Donations;

        }



        public IActionResult OnGet()
        {

            List<string[]> money_Donations = GetMonetaryDonationData();

            ViewData["MonetaryDonation"] = money_Donations;
            return Page();
        }

        public void OnPost()
        {

            string goDate = Request.Form["goodsDate"];
            string noItem = Request.Form["numItems"];
            string goCat = Request.Form["goodsCat"];
            string des = Request.Form["description"];
            string nCat = Request.Form["newCat"];


            string connectionString = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "INSERT INTO GoodsDonation (GoodsDate, NumberOfItems, Category, DonationDescription, NewCategory) VALUES (" + "'" + goDate + "'" + "," + "'" + noItem + "'" + "," + "'" + goCat + "'" + "," + "'" + des + "'" + "," + "'" + nCat + "'" + ")";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();



        }

        public List<string[]> GetGoodsDonationData()
        {

            List<string[]> good_Donations = new List<string[]>();

            String connection = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "SELECT GoodsDate, NoOfItems, Category, DonationDescription, NewCategory from GoodsDonation";



            using (SqlConnection co = new SqlConnection(connection))


            {
                co.Open();

                using (SqlCommand com = new SqlCommand(sqlQuery, co))
                {


                    using (SqlDataReader reader = com.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            string Date = reader["GoodsDate"].ToString();
                            string Item = reader["NoOfItems"].ToString();
                            string GoCat = reader["Category"].ToString();
                            string GODes = reader["DonationDescription"].ToString();
                            string NuCat = reader["NewCategory"].ToString();

                            string[] dataRow = { Date, Item, GoCat, GODes, NuCat };
                            good_Donations.Add(dataRow);

                        }
                    }

                }
            }

            return good_Donations;

        }



        public IActionResult OnnGet()
        {

            List<string[]> good_Donations = GetGoodsDonationData();

            ViewData["GoodsDonation"] = good_Donations;
            return Page();
        }



        public void OnnPost()
        {

            string stDate = Request.Form["startDate"];
            string enDate = Request.Form["endDate"];
            string dLoc = Request.Form["disLocation"];
            string dDes = Request.Form["disDescription"];
            string rAid = Request.Form["reqAid"];


            string connectionString = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "INSERT INTO Disaster (StartDate, EndDate, Location, DisasterDescription, RequiredAid) VALUES (" + "'" + stDate + "'" + "," + "'" + enDate + "'" + "," + "'" + dLoc + "'" + "," + "'" + dDes + "'" + "," + "'" + rAid + "'" + ")";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();



        }

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
        /*
        public IActionResult OnnnGet()
        {

            List<string[]> disas = GetGetDisasterData();

               object ViewData = null;
                ViewData["Disaster"] = disas;
            return Page();
        }

    }*/
    }
}



