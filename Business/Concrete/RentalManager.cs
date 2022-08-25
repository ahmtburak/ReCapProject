using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r=>r.Id==rental.Id && r.ReturnDate!=null);
            if(result != null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.AddedInfo);
            }
            return new ErrorResult(Messages.RentalFailed);
            
        }

        public IResult Remove(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletedInfo);
        }

        public IDataResult<Rental> Get(int rentId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentId),Messages.Succeed);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.Succeed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdatedInfo);
        }
    }
}
