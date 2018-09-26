using System;
using System.Text;
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

            StringBuilder builder = new StringBuilder();
            if (string.IsNullOrEmpty(UserName))
            { return null; }

            builder.AppendFormat("Имя {0}", UserName);
            builder.Append(Environment.NewLine);

            if (string.IsNullOrEmpty(PhoneNumber))
            { return null; }

            builder.AppendFormat("Номер телефона {0}", PhoneNumber);
            builder.Append(Environment.NewLine);

            if (string.IsNullOrEmpty(Department))
            { return null; }

            builder.AppendFormat("Отдел {0}", Department);
            builder.Append(Environment.NewLine);

            if (string.IsNullOrEmpty(Other))
            { Other = string.Empty;}

            builder.AppendFormat("Дополнительно {0}", Other);
            builder.Append(Environment.NewLine);
            return Encoding.UTF8.GetBytes(builder.ToString());
        }

    }
}
