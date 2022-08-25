using Core.Utilities.Results;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorId(int colorId);
        IResult Add(Color color);
        IResult Remove(Color color);
        IResult Update(Color color);
    }
}
