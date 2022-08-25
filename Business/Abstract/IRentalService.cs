using Core.Utilities.Results;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int rentId);
        IResult Add(Rental rental);
        IResult Remove(Rental rental);
        IResult Update(Rental rental);
    }
}
