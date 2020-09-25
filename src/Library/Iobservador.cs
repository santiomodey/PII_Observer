using System;

//Recibir actualizaciones cuando haya cambios en el objeto recibido	
namespace Observer
{
    public interface IObservador
    {
        void Update();
    }
}