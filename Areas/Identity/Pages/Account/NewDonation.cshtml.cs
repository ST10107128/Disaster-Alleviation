using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;


namespace Disaster_Alleviation.Areas.Identity.Pages
{
    public class NewDonationModel : PageModel
    {


        public void OnPost()
        {

            string mondate = Request.Form["moneydate"];
            string monamount = Request.Form["moneyamount"];
            string anon = Request.Form["anony"];


            string connectionString = "Server=tcp:djpromo1.database.windows.net,1433;Initial Catalog=DjPromoDatabase;Persist Security Info=False;User ID=djadmin;Password=876227751Az;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string sqlQuery = "INSERT INTO MonetaryDonation (MoneyDate, Amount, DonateeName) VALUES  (" + "'" + mondate + "'" + "," + "'" + monamount + "'" + "," + "'" + anon + "'" + ")";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();



        }
        /*
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

            }*/
    }

}

