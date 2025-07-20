using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Adoption : IIdentifiable
    {
        #region Fields/Properties
        private string _id;
        private List<string> _animalIds;
        private string _userId;
        private DateTime _fechaAdopcion;
        private string _estado;
        private string _descripcion;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public List<string> AnimalsIDs
        {
            get { return _animalIds; }
            set { _animalIds = value; }
        }
        public string UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public DateTime FechaAdopcion
        {
            get { return _fechaAdopcion; }
            set { _fechaAdopcion = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private int getNextId()
        {
            //indice autoincremental, falta hacer
            return 0;
        }

    
    #endregion
    #region Constructor
    public Adoption(string idAdopcion, List<string> animalIDs, string userID, DateTime fechaAdopcion, string estado, string descripcion)
        {
            _id = idAdopcion;
            _animalIds = animalIDs;
            _userId = userID;
            _fechaAdopcion = fechaAdopcion;
            _estado = estado;
            _descripcion = descripcion;
        }
        #endregion

        /*
        #region CRUD
        public void crearAdopcion()
        {
            // Después lo programo
            Console.WriteLine("La adopción ha sido creada.");

        }

        public void mostrarAdopcion(Adopcion adopcion)
        {
            Console.WriteLine($"ID de adopción: {adopcion.ID}");
            Console.WriteLine($"Fecha de adopción: {adopcion.FechaAdopcion}");
            Console.WriteLine($"Estado: {adopcion.Estado}");
            Console.WriteLine($"Descripción: {adopcion.Descripcion}");
            Console.WriteLine("Animales adoptados:");
            foreach (var animal in adopcion.Animales)
            {
                Console.WriteLine($"- {animal.Name} ({animal.Species})");
            }
            Console.WriteLine($"Usuario: {adopcion.Usuario.Name} ({adopcion.Usuario.DNI})");
        }

        public void modificarAdopcion(Adopcion adopcion)
        {
            Console.WriteLine("Ingrese el nuevo estado de la adopción: /n nota: los estados posibles son: EN REVISION, ACEPTADA O RECHAZADA");
            string nuevoEstado = Console.ReadLine();
            adopcion.Estado = nuevoEstado;
            Console.WriteLine("Ingrese una nueva descripción para la adopción:");
            string nuevaDescripcion = Console.ReadLine();
            adopcion.Descripcion = nuevaDescripcion;
            Console.WriteLine("La adopción ha sido modificada.");
            //preguntar a los chicos si hacemos las validaciones de scripts
        }
        public void eliminarAdopcion(Adopcion adopcion)
        {
            if (adopcion == null)
            {
                Console.WriteLine("No se puede eliminar una adopción nula.");
                return;
            }
            else if (adopcion.Estado == "RECHAZADA")
                //tendría que hacer un delete de la persistencia o del arreglo en memoria no? 
                Console.WriteLine("La adopción ha sido eliminada exitosamente.");
        }

        #endregion
        */
    }
}
