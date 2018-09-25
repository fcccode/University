﻿using System;
using Client.Auxiliary;

namespace Client.Model
{
    [Serializable]
    public class ExchangeData : BindingProperty
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
            }
        }

        private string _other;
        public string Other
        {
            get { return _other; }
            set
            {
                _other = value;
                OnPropertyChanged(nameof(Other));
            }
        }

        public ExchangeData() { }

        public byte[] GetBytes()
        {
            return new byte[2];
        }
    }
}
