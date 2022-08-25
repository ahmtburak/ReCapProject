using Core.Utilities.Results;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int UserId);
        IResult Add(User user);
        IResult Remove(User user);
        IResult Update(User user);
    }
}
