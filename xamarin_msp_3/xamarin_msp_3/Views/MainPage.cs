using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using xamarin_msp_3.Model;

namespace xamarin_msp_3.Views
{
    public class MainPage : ContentPage
    {
        ListView lstView;
        noteModel model = new noteModel();
        noteQuery query = new noteQuery();
        public MainPage()
        {
            this.Title = "Main Page";
            lstView = new ListView();
            lstView.ItemTemplate = new DataTemplate(typeof(NoteItemCell));


            Button createBtn = new Button();
            createBtn.Clicked += delegate
            {
                Navigation.PushAsync(new CreatePage());
            };


            Content = new StackLayout
            {
                Children = {
                    createBtn, lstView
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstView.ItemsSource = query.GetAllNotes();
        }


    }
}
