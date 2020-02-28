using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactApp.ModelViews
{
    public class AddContactViewModel
    {
        public string xName { get; set; }
        public long xNumber { get; set; }
        public ICommand ContactPageCommand { get; set; }
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();
        public AddContactViewModel()
        {
            ContactPageCommand = new Command(async () => {

                if (string.IsNullOrEmpty(xName))

                {
                    Contacts.Add(new Contact { Name = xName, Number = xNumber, Photo = "contact.png"});
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Empty fields", "Ok");
                }
                await App.Current.MainPage.Navigation.PushAsync(new ContactPage());

            });
        }
    }
}
