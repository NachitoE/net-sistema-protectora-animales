using System;

namespace Domain
{
    public class MedicalCheckUp
    {
        #region Fields/Properties
        private string _id;
        private string _userId;
        private DateTime _checkUpDate;
        private string _observation;
        private string _animalId;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public DateTime CheckUpDate
        {
            get { return _checkUpDate; }
            set { _checkUpDate = value; }
        }

        public string Observation
        {
            get { return _observation; }
            set { _observation = value; }
        }
        #endregion

        #region Constructor
        public MedicalCheckUp(string idSeguimiento, string userId, DateTime fechaSeguimiento, string observacion, string animalId)
        {
            _id = idSeguimiento;
            _userId = userId;
            _checkUpDate = fechaSeguimiento;
            _observation = observacion;
            _animalId = animalId;
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
}
