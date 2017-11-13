using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_1_2
{
    public class Liver
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Год рождения
        /// </summary>
        public int BDay { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="n">Имя</param>
        /// <param name="s">Фамилия</param>
        /// <param name="a">Год рождения</param>
        public Liver(string n, string s,int a)
        {
            Name = n;
            Surname = s;
            BDay = a;
        }
    }
}
