using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ContactApp.ModelViews
{
    public class ContactViewModel: AddContactViewModel
    {
        public ICommand DeleteCommand { get; set; }
        public ContactViewModel()
        {
            DeleteCommand = new Command<Contact>((param) =>
            {
                Contacts.Remove(param);
            });

        }
    }   
}
