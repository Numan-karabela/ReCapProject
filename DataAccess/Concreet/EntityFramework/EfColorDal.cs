using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context; 
using Color = Entities.Concreet.Color;

namespace DataAccess.Concreet.EntityFramework
{
    public class EfColorDal:EfFrameworkRepositoryBase<Color,CarContext>,IColorDal
    {
    }
}
