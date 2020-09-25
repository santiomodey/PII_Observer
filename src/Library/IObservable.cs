using System;

namespace Observer
{
    public interface IObservable
    {
        //Conocer los observadores interesados ​​en cambios de este objeto	Observador
        void Subscribe(IObservador observer); //Agregar un observador
        void Unsubscribe(IObservador observer); //Remover un observador previamente agregado
        void GetTemperature();
        Temperature Current { get;}


   
    }
}