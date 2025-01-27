using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarCipherGUI.Utility
{
    internal class NavigationHelper
    {
        public static void NavigateHome(Form _currentForm)
        {
            CaesarCipherForm home = new CaesarCipherForm();

            // Ensuring that we can exit the application now we have gone home!
            home.FormClosed += (s, args) => Application.Exit();

            _currentForm.Hide();                            // Hiding the current form
            home.Show();                                    // Showing the Home Page
        }

        public static void NavigateToNewPageFromHome(Form _home, Form _formToNavigateTo)
        {
            // Ensuring that we can exit the application from the new form!
            _formToNavigateTo.FormClosed += (s, args) => Application.Exit();

            _home.Hide();                                   // Hiding the current form
            _formToNavigateTo.Show();                       // Showing the new page
        }
    }
}