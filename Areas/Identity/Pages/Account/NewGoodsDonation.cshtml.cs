using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace Disaster_Alleviation.Areas.Identity.Pages
{
    public class NewGoodsDonationModel : PageModel
    {


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
        /*
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



                public IActionResult OnGet()
                {

                    List<string[]> good_Donations = GetGoodsDonationData();

                    ViewData["GoodsDonation"] = good_Donations;
                    return Page();
                }

            }*/

    }

}

