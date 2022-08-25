using Core.Utilities.Results;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int customerId);
        IResult Add(Customer customer);
        IResult Remove(Customer customer);
        IResult Update(Customer customer);
    }
}
