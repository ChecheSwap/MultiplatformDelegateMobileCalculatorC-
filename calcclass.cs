using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculator
{
    class calcclass:ContentPage
    {
        double after = 0;
        double before = 0;

        public Label box;
        
        public xbutton btn0;
        public xbutton btn1;
        public xbutton btn2;
        public xbutton btn3;
        public xbutton btn4;
        public xbutton btn5;
        public xbutton btn6;
        public xbutton btn7;
        public xbutton btn8;
        public xbutton btn9;
        public xbutton btnpoint;
        public xbutton btnclear;
        public xbutton btnequal;
        public xbutton btnsum;
        public xbutton btnrest;
        public xbutton btnmult;
        public xbutton btnexp;
        public xbutton btndiv;
        public xbutton btndel;
        public Label boxbefore;

        string myoperator;
        public calcclass()
        {
            

            Title = "Basic Calculator (C#).";
            BackgroundColor = Color.Black;
            this.box = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                IsEnabled = false,
                FontSize = 120,
                HorizontalTextAlignment = TextAlignment.End,
                Text = "0",
           
            };

           

            this.boxbefore = new Label
            {
                FontSize = 60,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.FromHex("#F0EFEF")
            };
           
            var xgrid = new Grid();
            
            xgrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            xgrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            xgrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            xgrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            xgrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            xgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            xgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            xgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            xgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            xgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            this.btn0 = new xbutton("0",Color.Silver);
            this.btn1 = new xbutton("1", Color.Silver);
            this.btn2 = new xbutton("2", Color.Silver);
            this.btn3 = new xbutton("3", Color.Silver);
            this.btn4 = new xbutton("4", Color.Silver);
            this.btn5 = new xbutton("5", Color.Silver);
            this.btn6 = new xbutton("6", Color.Silver);
            this.btn7 = new xbutton("7", Color.Silver);
            this.btn8 = new xbutton("8", Color.Silver);
            this.btn9 = new xbutton("9", Color.Silver);
            this.btnpoint = new xbutton(".", Color.Silver);
            this.btnclear = new xbutton("C", Color.Yellow);
            this.btnequal = new xbutton("=", Color.Yellow);
            this.btnsum = new xbutton("+", Color.FromHex("#E8AD00"));
            this.btnrest = new xbutton("-", Color.FromHex("#E8AD00"));
            this.btnmult = new xbutton("*", Color.FromHex("#E8AD00"));
            this.btnexp = new xbutton("^", Color.FromHex("#E8AD00"));
            this.btndiv = new xbutton("/", Color.FromHex("#E8AD00"));
            this.btndel = new xbutton("<", Color.Yellow);

            xgrid.Children.Add(btn0.mibase, 0, 5);
            xgrid.Children.Add(btnpoint.mibase, 1, 5);
            xgrid.Children.Add(btnclear.mibase, 2, 5);
            xgrid.Children.Add(btnequal.mibase, 3, 5);

            Grid.SetColumnSpan(btnequal.mibase, 2);

            xgrid.Children.Add(btn1.mibase, 0, 4);
            xgrid.Children.Add(btn2.mibase, 1, 4);
            xgrid.Children.Add(btn3.mibase, 2, 4);
            xgrid.Children.Add(btnsum.mibase, 3, 4);
            xgrid.Children.Add(btnrest.mibase, 4, 4);

            xgrid.Children.Add(btn4.mibase, 0, 3);
            xgrid.Children.Add(btn5.mibase, 1, 3);
            xgrid.Children.Add(btn6.mibase, 2, 3);
            xgrid.Children.Add(btnmult.mibase, 3, 3);
            xgrid.Children.Add(btndiv.mibase, 4, 3);

            xgrid.Children.Add(btn7.mibase, 0, 2);
            xgrid.Children.Add(btn8.mibase, 1, 2);
            xgrid.Children.Add(btn9.mibase, 2, 2);
            xgrid.Children.Add(btnexp.mibase, 3, 2);
            xgrid.Children.Add(btndel.mibase, 4, 2);
            
            xgrid.Children.Add(boxbefore, 0, 0);
            Grid.SetColumnSpan(boxbefore, 5);
            xgrid.Children.Add(box, 0, 1);
            Grid.SetColumnSpan(box, 5);
            
            
            

            btnsum.mibase.Clicked += btnsumaOnclick;
            btnrest.mibase.Clicked += btnrestaOnclick;
            btnmult.mibase.Clicked += btnmultOnclick;
            btndiv.mibase.Clicked += btndivOnclick;
            btnexp.mibase.Clicked += btnexpOnclick;
            btnpoint.mibase.Clicked += btnOnpoint;
            btn0.mibase.Clicked += btn0OnClick;
            btn1.mibase.Clicked += btn1OnClick;
            btn2.mibase.Clicked += btn2OnClick;
            btn3.mibase.Clicked += btn3OnClick;
            btn4.mibase.Clicked += btn4OnClick;
            btn5.mibase.Clicked += btn5OnClick;
            btn6.mibase.Clicked += btn6OnClick;
            btn7.mibase.Clicked += btn7OnClick;
            btn8.mibase.Clicked += btn8OnClick;
            btn9.mibase.Clicked += btn9OnClick;
            btnclear.mibase.Clicked += btnclearOnclick;
            btnequal.mibase.Clicked += btnequalOnclick;
            btndel.mibase.Clicked += btndelOnclick;
            
            Content = xgrid;
        }
        public void btndelOnclick(object sender, EventArgs args)
        {
            String text = box.Text;

            if (text.Length > 1)
            {
                text = text.Remove(text.Length - 1, 1);
                box.Text = text;
            }
            
        }
        public void btnsumaOnclick(Object sender, EventArgs args)
        {
            this.myoperator = "+";
            control(myoperator);
        }
        public void btnrestaOnclick(Object sender, EventArgs args)
        {
            this.myoperator = "-";
            control(myoperator);
        }
        public void btnmultOnclick(Object sender, EventArgs args)
        {
            this.myoperator = "*";
            control(myoperator);
        }
        public void btndivOnclick(Object sender, EventArgs args)
        {
            this.myoperator = "/";
            control(myoperator);
        }
        public void btncuadraOnclick(Object sender, EventArgs args)
        {
            this.myoperator = "^";
            control(myoperator);
        }
        public void btn0OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "0";
        }
        public void btn1OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "1";
        }
        public void btn2OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "2";
        }
        public void btn3OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "3";
        }
        public void btn4OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "4";
        }
        public void btn5OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "5";
        }
        public void btn6OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "6";
        }
        public void btn7OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "7";
        }
        public void btn8OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "8";
        }
        public void btn9OnClick(Object sender, EventArgs args)
        {
            box.Text = box.Text + "9";
        }
        public void btnOnpoint(Object sender, EventArgs args)
        {
            box.Text = box.Text + ".";
            this.btnpoint.mibase.IsEnabled = false;

        }
        public void btnclearOnclick(object sender , EventArgs args)
        {
            clearbtn();
        }
        public void btnexpOnclick(object sender, EventArgs args)
        {
            myoperator = "^";
            control(myoperator);
        }
        public void clearbtn()
        {
            disableoperations(true);
            pointisenabled();
            after = 0;
            before = 0;
            box.Text = "0";
            boxbefore.Text = "";
            myoperator = "";
        }
        public void control(string add)
        {
            switch(add)
            {
                case ("+"):
                    {
                        pointisenabled();
                        disableoperations(false);
                        before = Convert.ToDouble(this.box.Text.Trim());
                        this.boxbefore.Text = this.box.Text + add;
                        this.box.Text = "0";
                        break;
                    }
                case ("-"):
                    {
                        pointisenabled();
                        disableoperations(false);
                        before = Convert.ToDouble(this.box.Text.Trim());
                        this.boxbefore.Text= this.box.Text + add;
                        this.box.Text = "0";
                        break;
                    }
                case ("*"):
                    {
                        pointisenabled();
                        disableoperations(false);
                        before = Convert.ToDouble(this.box.Text.Trim());
                        this.boxbefore.Text = this.box.Text + add;
                        this.box.Text = "0";
                        break;
                    }
                case ("/"):
                    {
                        pointisenabled();
                        disableoperations(false);
                        before = Convert.ToDouble(this.box.Text.Trim());
                        this.boxbefore.Text = this.box.Text + add;
                        this.box.Text = "0";
                        break;
                    }
                case ("^"):
                    {
                        pointisenabled();
                        disableoperations(false);
                        before = Convert.ToDouble(this.box.Text.Trim());
                        this.boxbefore.Text = this.box.Text + add;
                        this.box.Text = "0";
                        break;
                    }
            }
        }

        public void pointisenabled()
        {
            if(!(this.btnpoint.mibase.IsEnabled==true))
                this.btnpoint.mibase.IsEnabled = true;
        }

        public void disableoperations(bool edo)
        {
            if(!(box.Text.Trim() == null))
            {
                this.btnsum.mibase.IsEnabled = edo;
                this.btnrest.mibase.IsEnabled = edo;
                this.btnmult.mibase.IsEnabled = edo;
                this.btndiv.mibase.IsEnabled = edo;
                this.btnexp.mibase.IsEnabled = edo;
            }
        }

        public void btnequalOnclick(object sender, EventArgs args)
        {
            if (!(box.Text.Trim() == null))
            {
                after = Convert.ToDouble(box.Text.Trim());

                switch(this.myoperator)
                {
                    case ("+"):
                        {
                            before = before + after;
                            break;
                        }
                    case ("-"):
                        {
                            before = before - after;
                            break;
                        }
                    case ("*"):
                        {
                            before = before * after;
                            break;
                        }
                    case ("/"):
                        {
                            before = before / after;
                            break;
                        }
                    case ("^"):                 
                        {
                            before = Math.Pow(before, after);
                            break;
                        }
                }
                disableoperations(true);
                boxbefore.Text = "";
                box.Text = before.ToString();
                btnpoint.mibase.IsEnabled = true;
                myoperator = "";
            }
            else
            {
                clearbtn();
            }
            
        }




        //this.before = Convert.ToDouble((box.Text.Trim()));
    }
}
