using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using xamarin_msp_3.Interface;
using xamarin_msp_3.Model;


namespace xamarin_msp_3.Views
{
    public class CreatePage : ContentPage
    {
        public CreatePage()
        {
            Editor edit = new Editor { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
            Button createBtn = new Button { Text = "생성", HorizontalOptions = LayoutOptions.FillAndExpand };
            Button cancelBtn = new Button { Text = "취소", HorizontalOptions = LayoutOptions.FillAndExpand };

            noteModel model = new noteModel();
            noteQuery query = new noteQuery();

            createBtn.Clicked += delegate
            {
                DateTime t = DateTime.Now;
                model.Note = edit.Text;
                model.Date = t.ToString();
                query.InsertDetails(model);
                DisplayAlert("Alert", "saved successfully", "OK");
                Navigation.PopAsync();
            };

            cancelBtn.Clicked += delegate
            {
                Navigation.PopAsync();
            };


            var btnStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    createBtn,cancelBtn
                }
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    edit,btnStack
                }
            };

        }
    }
}
