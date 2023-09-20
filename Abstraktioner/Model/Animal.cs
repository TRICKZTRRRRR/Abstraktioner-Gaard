using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class Animal
    {
        #region Variables
        private bool _isDog;
        private bool _isRabbit;
        private bool _isChicken;
        #endregion

        #region Properties
        public bool IsDog { get { return _isDog; } set { _isDog = value; } } 
        public bool IsRabbit { get { return _isRabbit;} set { _isRabbit = value; } }
        public bool IsChicken { get {  return _isChicken; } set { _isChicken = value; } }
        #endregion


    }
}
