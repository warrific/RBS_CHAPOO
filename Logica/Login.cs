using DAL;

namespace Logica
{
    public class Login
    {
        public bool check_wachtwoord(string invoer_wachtwoord)
        {
            // Check of de wachtwoord lengte klopt
            if (invoer_wachtwoord.Length == 4)
            {
                DALLogin loginCheck = new DALLogin();
                if (int.Parse(invoer_wachtwoord) == loginCheck.GetPassword(invoer_wachtwoord))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
