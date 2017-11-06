using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_1
{
    public class Student : INotifyPropertyChanged
    {
        #region Переменные

        /// <summary>
        /// Имя студента
        /// </summary>
        private string name;

        /// <summary>
        /// Фамилия студента
        /// </summary>
        private string surname;

        /// <summary>
        /// Оценка по предмету ПВС
        /// </summary>
        private int pvsValue;

        /// <summary>
        /// Оценка по предмету ТРАРИЗ
        /// </summary>
        private int trarizValue;

        /// <summary>
        /// Оценка по предмету СП
        /// </summary>
        private int spValue;

        /// <summary>
        /// Оценка по предмету ОЕМ
        /// </summary>
        private int oemValue;

        /// <summary>
        /// Оценка по предмету ИПЗ
        /// </summary>
        private int ipzValue;

        #endregion

        #region Свойства

        /// <summary>
        /// Имя студента
        /// </summary>
        public  string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Фамилия студента
        /// </summary>
        private string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        /// <summary>
        /// Оценка по предмету ПВС
        /// </summary>
        private int PvsValue
        {
            get { return pvsValue; }
            set
            {
                pvsValue = value;
                OnPropertyChanged("PvsValue");
            }
        }

        /// <summary>
        /// Оценка по предмету ТРАРИЗ
        /// </summary>
        private int TrarizValue
        {
            get { return trarizValue; }
            set
            {
                trarizValue = value;
                OnPropertyChanged("TrarizValue");
            }
        }

        /// <summary>
        /// Оценка по предмету СП
        /// </summary>
        private int SpValue
        {
            get { return spValue; }
            set
            {
                spValue = value;
                OnPropertyChanged("SpValue");
            }
        }

        /// <summary>
        /// Оценка по предмету ОЕМ
        /// </summary>
        private int OemValue
        {
            get { return oemValue; }
            set
            {
                oemValue = value;
                OnPropertyChanged("OemValue");
            }
        }

        /// <summary>
        /// Оценка по предмету ИПЗ
        /// </summary>
        private int IpzValue
        {
            get { return ipzValue; }
            set
            {
                ipzValue = value;
                OnPropertyChanged("IpzValue");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Конструктор

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <param name="pvs"></param>
        /// <param name="ipz"></param>
        /// <param name="oem"></param>
        /// <param name="trariz"></param>
        /// <param name="sp"></param>
        public Student(string n, string s, int pvs, int ipz, int oem, int trariz, int sp)
        {
            Name        = name;
            Surname     = s;
            PvsValue    = pvs;
            IpzValue    = ipz;
            OemValue    = oem;
            SpValue     = sp;
            TrarizValue = trariz;
        }
        
        #endregion
    }
}
