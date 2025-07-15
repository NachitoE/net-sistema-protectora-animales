using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Adopcion : IIdentifiable
    {
        #region Fields/Properties
        private string m_IdAdopcion;
        private List<Animal> m_animales;
        private User m_user;
        private DateTime m_fechaAdopcion;
        private string m_estado;
        private string m_descripcion;

        public string ID
        {
            get { return m_IdAdopcion; }
            set { m_IdAdopcion = value; }
        }
        public List<Animal> Animales
        {
            get { return m_animales; }
            set { m_animales = value; }
        }
        public User Usuario
        {
            get { return m_user; }
            set { m_user = value; }
        }

        public DateTime FechaAdopcion
        {
            get { return m_fechaAdopcion; }
            set { m_fechaAdopcion = value; }
        }

        public string Estado
        {
            get { return m_estado; }
            set { m_estado = value; }
        }

        public string Descripcion
        {
            get { return m_descripcion; }
            set { m_descripcion = value; }
        }
        private int getNextId()
        {
            //indice autoincremental, falta hacer
            return 0;
        }

    
    #endregion
    #region Constructor
    public Adopcion(string idAdopcion, List<Animal> animales, User usuario, DateTime fechaAdopcion, string estado, string descripcion)
        {
            m_IdAdopcion = idAdopcion;
            m_animales = animales;
            m_user = usuario;
            m_fechaAdopcion = fechaAdopcion;
            m_estado = estado;
            m_descripcion = descripcion;
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
