using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult("Renk Eklendi");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult("Renk Silindi");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Renkler Listelendi");
        }

        public IDataResult<List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult("Renk Eklendi");
        }
    }
}
