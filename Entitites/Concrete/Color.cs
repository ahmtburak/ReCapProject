using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string Name { get; set; }

    }
}
