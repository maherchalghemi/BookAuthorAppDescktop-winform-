using DAL.Interface;
using DAL.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc
{
    public class Ioc
    {
        private static IUnityContainer _Container;

        public Ioc(IUnityContainer Container)
        {
            _Container = Container;
        }
        public void ResgitreType()
        {
            _Container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            _Container.RegisterType<IAuteurRepository, AuteurRepository>();
           


           




        }





    }
}
