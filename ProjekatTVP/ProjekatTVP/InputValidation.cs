using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjekatTVP
{
    internal class InputValidation
    {
        public static void ValidateState(Label showErrorState, TextBox inputState)
        {
           if (!string.IsNullOrEmpty(inputState.Text) && !Regex.IsMatch(inputState.Text, @"^[a-zA-Z\s]+$"))
            {
                showErrorState.Visible = true;
                showErrorState.Text = "Ime države sme sadržati samo slova.";
            }
            else
            {
                showErrorState.Visible = false;
            }
        }
        public static void ValidateCity(Label showErrorCity, TextBox inputCity)
        {
            if (!string.IsNullOrEmpty(inputCity.Text) && !Regex.IsMatch(inputCity.Text, @"^[a-zA-Z\s]+$"))
            {
                showErrorCity.Visible = true;
                showErrorCity.Text = "Ime grada sme sadržati samo slova.";
            }
            else
            {
                showErrorCity.Visible = false;
            }
        }
        public static void ValidateName(Label showErrorName, TextBox inputName)
        {
            if (!string.IsNullOrEmpty(inputName.Text) && !Regex.IsMatch(inputName.Text, @"^[a-zA-Z\s]+$"))
            {
                showErrorName.Visible = true;
                showErrorName.Text = "Ime sme sadržati samo slova.";
            }
            else
            {
                showErrorName.Visible = false;
            }
        }
        public static void ValidateSurname(Label showErrorSurname, TextBox inputSurname)
        {
            if (!string.IsNullOrEmpty(inputSurname.Text) && !Regex.IsMatch(inputSurname.Text, @"^[a-zA-Z\s]+$"))
            {
                showErrorSurname.Visible = true;
                showErrorSurname.Text = "Prezime sme sadržati samo slova.";
            }
            else
            {
                showErrorSurname.Visible = false;
            }
        }
        public static void ValidateUsername(Label showErrorUsername, TextBox inputUserName)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            if (!string.IsNullOrEmpty(inputUserName.Text) && string.IsNullOrWhiteSpace(inputUserName.Text))
            {
                showErrorUsername.Visible = true;
                showErrorUsername.Text = "Korisničko ime je obavezno.";
            }
            else if(!Regex.IsMatch(inputUserName.Text, pattern))
            {
                showErrorUsername.Visible = true;
                showErrorUsername.Text = "Korisničko ime sme sadržati samo slova i brojeve.";
                showErrorUsername.Visible = false;
            }
        }
        public static void ValidatePassword(Label showErrorPassword, TextBox inputPassword, Label? showConfirmErrorPassword2 = null, TextBox? confirmInputPassword2 = null)
        {
            if (!string.IsNullOrEmpty(inputPassword.Text))
            {
                if (inputPassword.Text.Length < 6)
                {
                    showErrorPassword.Visible = true;
                    showErrorPassword.Text = "Lozinka mora sadržati najmanje 6 karaktera!";
                }
                else
                {
                    showErrorPassword.Visible = false;
                }
            }

            if (showConfirmErrorPassword2 != null && confirmInputPassword2 != null && confirmInputPassword2.Focused)
            {
                if (!string.IsNullOrWhiteSpace(confirmInputPassword2.Text) && !string.IsNullOrWhiteSpace(inputPassword.Text))
                {
                    if (inputPassword.Text != confirmInputPassword2.Text)
                    {
                        showConfirmErrorPassword2.Visible = true;
                        showConfirmErrorPassword2.Text = "Lozinke se ne podudaraju!";
                    }
                    else
                    {
                        showConfirmErrorPassword2.Visible = false;
                    }
                }
            }

        }
        public static void ValidateIntegerNumber(Label showErrorInteger, TextBox inputInteger)
        {
            int parsedValue = 0;
            if (!string.IsNullOrEmpty(inputInteger.Text) && !int.TryParse(inputInteger.Text, out parsedValue))
            {
                showErrorInteger.Text = "Polje sme sadržati samo broj!";
                showErrorInteger.Visible = true;
                return;
            }
            else if (parsedValue < 0)
            {
                showErrorInteger.Text = "Broj mora biti pozitivan!";
                showErrorInteger.Visible = true;
                return;
            }
            else
                showErrorInteger.Visible = false;
        }
        public static void ValidateDoubleNumber(Label showErrorDouble, TextBox inputDouble)
        {
            Double parsedValue = 0;
            if (!string.IsNullOrEmpty(inputDouble.Text) && !Double.TryParse(inputDouble.Text, out parsedValue))
            {
                showErrorDouble.Text = "Polje sme sadržati samo broj!";
                showErrorDouble.Visible = true;
                return;
            }
            else if (parsedValue < 0)
            {
                showErrorDouble.Text = "Broj mora biti pozitivan!";
                showErrorDouble.Visible = true;
                return;
            }
            else
                showErrorDouble.Visible = false;

        }
 
    }
}
