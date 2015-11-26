using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class TipoViewModel:IViewModel<Tipo>
    {

        public int idTipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Tipo ToBaseDatos()
        {
            return new Tipo()
            {
                idTipo = idTipo,
                nombre = nombre,
                descripcion = descripcion
            };
        }

        public void FromBaseDatos(Tipo modelo)
        {
            idTipo = modelo.idTipo;
            nombre = modelo.nombre;
            descripcion = modelo.descripcion;
        }

        public void UpdateBaseDatos(Tipo modelo)
        {
            modelo.idTipo = idTipo;
            modelo.nombre = nombre;
            modelo.descripcion = descripcion;
        }

        public object[] GetKeys()
        {
            return new Object[] {idTipo};
        }
    }
}
