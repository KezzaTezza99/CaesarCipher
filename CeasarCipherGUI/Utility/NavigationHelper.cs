using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarCipherGUI.Utility
{
    internal class NavigationHelper
    {
        public static void NavigateHome(Form currentForm)
        {
            CaesarCipherForm home = new CaesarCipherForm();

            // Ensuring that we can exit the application from EncryptFileForm!
            home.FormClosed += (s, args) => Application.Exit();

            currentForm.Hide();                             // Hiding the current form
            home.Show();                                    // Showing the Home Page
        }
    }
}