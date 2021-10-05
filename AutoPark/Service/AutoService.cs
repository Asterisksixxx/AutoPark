using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPark.Data;
using AutoPark.Models;

namespace AutoPark.Service
{
  public  interface IAutoService
    {
        public IEnumerable<Auto> Get();
        public Auto Get(Guid IDCars);
        public void Create(Auto cars);
        public void Edit(Auto cars);
        public void Delete(Guid IDCars);
    }
    public class AutoService:IAutoService
    {
        private readonly AppDataContext _appDataContext;

        public AutoService(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public  IEnumerable<Auto> Get()
        {
            return _appDataContext.autos;
        }

        public Auto Get(Guid IDCars)
        {
            return _appDataContext.autos.FirstOrDefault(cars => cars.IDCars == IDCars);
        }

        public void Create(Auto cars)
        {
            _appDataContext.autos.Add(cars);
            _appDataContext.SaveChanges();
        }

        public void Edit(Auto cars)
        {
            _appDataContext.autos.Update(cars);
            _appDataContext.SaveChanges();
        }

        public void Delete(Guid IDCars)
        {
            _appDataContext.autos.Remove(_appDataContext.autos.FirstOrDefault(cars=>cars.IDCars==IDCars));
            _appDataContext.SaveChanges();
        }
    }
}
