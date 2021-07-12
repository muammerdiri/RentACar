using Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiy.Concrete
{
    class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
