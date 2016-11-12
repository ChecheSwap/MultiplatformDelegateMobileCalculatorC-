using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
    class xbutton:Button
    {
        public Button mibase;
        public xbutton(string text, Color mycolor)
        {
            mibase = new Button
            {
                BackgroundColor = mycolor,
                TextColor = Color.Red,
                FontSize = 33,
                FontFamily = "Times new Roman",
                FontAttributes = FontAttributes.Italic,
                Text = text,
                BorderRadius = 15,
                Margin = 0
            };

            
        }
    }
}
