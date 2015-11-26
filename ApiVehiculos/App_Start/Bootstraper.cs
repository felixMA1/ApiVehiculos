using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;

namespace ApiVehiculos.App_Start
{
    public class Bootstraper
    {

        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext,TallerEntities1>();
            container.RegisterType<IRepositorio<Tipo, TipoViewModel>, RepositorioEntity<Tipo, TipoViewModel>>();
            container.RegisterType<IRepositorio<Vehiculo, VehiculoViewModel>, RepositorioEntity<Vehiculo, VehiculoViewModel>>();
        }
    }
}
