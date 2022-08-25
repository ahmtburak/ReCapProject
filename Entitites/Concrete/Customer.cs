using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Customer:User,IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
