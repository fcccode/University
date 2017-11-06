using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_1_1
{
   
    public class Student 
    {
      
        #region Свойства

        /// <summary>
        /// Имя студента
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Оценка по предмету ПВС
        /// </summary>
        public int PvsValue { get; set; }

        /// <summary>
        /// Оценка по предмету ТРАРИЗ
        /// </summary>
        public int TrarizValue { get; set; }

        /// <summary>
        /// Оценка по предмету СП
        /// </summary>
        public int SpValue { get; set; }

        /// <summary>
        /// Оценка по предмету ОЕМ
        /// </summary>
        public int OetValue { get; set; }

        /// <summary>
        /// Оценка по предмету ИПЗ
        /// </summary>
        public int IpzValue { get; set; }

        
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
        public Student(string n, string s, int pvs, int ipz, int oet, int trariz, int sp)
        {
            Name        = n;
            Surname     = s;
            PvsValue    = pvs;
            IpzValue    = ipz;
            OetValue    = oet;
            SpValue     = sp;
            TrarizValue = trariz;
        }


        public Student()
        { }
        #endregion
    }
}
