using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class OrderException:Exception
    {
        private string erroinfo;
        public OrderException(string info) : base(info) { }
    }
}
