using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Seguimiento : IIdentifiable
    {
        #region Fields/Properties
        private string m_idSeguimiento;
        private User m_usuario;
        private DateTime m_fechaSeguimiento;
        private string m_observacion;
        private Animal m_animal;

        public string ID
        {
            get { return m_idSeguimiento; }
            set { m_idSeguimiento = value; }
        }
        public User Usuario
        {
            get { return m_usuario; }
            set { m_usuario = value; }
        }

        public DateTime FechaSeguimiento
        {
            get { return m_fechaSeguimiento; }
            set { m_fechaSeguimiento = value; }
        }

        public string Observacion
        {
            get { return m_observacion; }
            set { m_observacion = value; }
        }
        #endregion

        #region Constructor
        public Seguimiento(string idSeguimiento, User usuario, DateTime fechaSeguimiento, string observacion, Animal animal)
        {
            m_idSeguimiento = idSeguimiento;
            m_usuario = usuario;
            m_fechaSeguimiento = fechaSeguimiento;
            m_observacion = observacion;
            m_animal = animal;
        }
        #endregion
    

    #region CRUD
        /*
    public void crearSeguimiento()
        {
            int idSeguimiento = 0;
            DateTime fechaSeguimiento = DateTime.Now;
            Console.WriteLine("Ingrese la observación: ");
            string observacion = Console.ReadLine();
            User usuario = new User();
            Animal animal = new Animal(); 
            Seguimiento seguimiento = new Seguimiento(idSeguimiento,usuario,fechaSeguimiento, observacion, animal);
            Console.WriteLine("El seguimiento ha sido creado.");

        }
        public void mostrarSeguimiento(Seguimiento seguimiento)
        {
            Console.WriteLine($"ID de seguimiento: {seguimiento.ID}");
            Console.WriteLine($"Fecha de seguimiento: {seguimiento.FechaSeguimiento}");
            Console.WriteLine($"Observación: {seguimiento.Observacion}");
            Console.WriteLine($"Usuario: {seguimiento.Usuario.Name} ({seguimiento.Usuario.DNI})");
           // Console.WriteLine($"Animal: {seguimiento.Animal.Name} ({seguimiento.Animal.Species})");


        }
        public void modificarSeguimiento(Seguimiento seguimiento)
        {
            Console.WriteLine("Ingrese la nueva observación: ");
            string nuevaObservacion = Console.ReadLine();
            seguimiento.Observacion = nuevaObservacion;
            Console.WriteLine("El seguimiento ha sido modificado.");
        }
        public void eliminarSeguimiento(Seguimiento seguimiento)
        {
            //Que hago acá?
            Console.WriteLine("El seguimiento ha sido eliminado.");
        }
    }
        */
    #endregion

}
