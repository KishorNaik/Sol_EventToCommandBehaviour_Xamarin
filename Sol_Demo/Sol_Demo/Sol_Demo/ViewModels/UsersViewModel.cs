using Sol_Demo.Models;
using Sol_Demo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class UsersViewModel : INotifyPropertyChanged
    {
        #region Declaration
        private readonly UserService userService = null;
        #endregion 

        #region Property Changed Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Contructor
        public UsersViewModel()
        {
            userService = new UserService();
            ListUsers = new ObservableCollection<UsersModel>(userService.GetUserData());

            OnSelectedItem();
        }
        #endregion 

        #region Property
        private UsersModel _users;
        public UsersModel Users
        {
            get => _users;
            set
            {
                _users = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        public ObservableCollection<UsersModel> ListUsers { get; set; }

        private string _selectedUserData;
        public String SelectedUserData
        {
            get => _selectedUserData;
            set
            {
                _selectedUserData = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedUserData)));
            }
        }
        
        #endregion

        #region Command

        public Command OnSelectedItemCommand { get; set; }

        #endregion

        #region Private Method
        private void OnSelectedItem()
        {
            OnSelectedItemCommand = new Command<UsersModel>((leObj) => {

                SelectedUserData = $"{leObj.FirstName} {leObj.LastName}";
            
            });
        }
        #endregion 


    }
}
