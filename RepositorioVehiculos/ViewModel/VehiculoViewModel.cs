using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class VehiculoViewModel:IViewModel<Vehiculo>
    {
        public int idVehiculo { get; set; }
        public string matricula { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double coste { get; set; }
        public int idTipo { get; set; }

        public Vehiculo ToBaseDatos()
        {
            return new Vehiculo()
            {
                idVehiculo = idVehiculo,
                matricula = matricula,
                marca = marca,
                modelo = modelo,
                coste = coste,
                idTipo = idTipo
            };
        }

        public void FromBaseDatos(Vehiculo model)
        {
            idVehiculo = model.idVehiculo;
            matricula = model.matricula;
            marca = model.marca;
            modelo = model.modelo;
            coste = model.coste;
            idTipo = model.idTipo;
        }

        public void UpdateBaseDatos(Vehiculo model)
        {
            model.idVehiculo = idVehiculo;
            model.matricula = matricula;
            model.marca = marca;
            model.modelo = modelo;
            model.coste = coste;
            model.idTipo = idTipo;
        }

        public object[] GetKeys()
        {
            return new object[] {idVehiculo};
        }
    }
}
