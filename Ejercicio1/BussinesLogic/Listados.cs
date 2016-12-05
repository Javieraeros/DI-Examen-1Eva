using Ejercicio1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.BussinesLogic
{
    public class Listados
    {
        public ObservableCollection<ImagenValor> devuelveListado()
        {
            ObservableCollection<ImagenValor> devolver = new ObservableCollection<ImagenValor>();
            ObservableCollection<ImagenValor> aux = new ObservableCollection<ImagenValor>();
            Random miAleatorio = new Random();
            int aleatorio;

            ImagenValor AR, Ballesta, Colt, Katana, Lucille, Martillo;
            ImagenValor Daryl, Michonne, Negan, Rick, Sasha, Tyreese;

            //Creamos todos los personajes y armas
            AR = new ImagenValor(0, "/Assets/AR-15.jpg");
            Ballesta = new ImagenValor(1, "/Assets/Ballesta.jpg");
            Colt = new ImagenValor(2, "/Assets/Colt.jpg");
            Katana = new ImagenValor(3, "/Assets/Katana.jpg");
            Lucille = new ImagenValor(4, "/Assets/Lucille.jpg");
            Martillo = new ImagenValor(5, "/Assets/Martillo.jpg");

            Sasha = new ImagenValor(0, "/Assets/Sasha.jpg");
            Daryl = new ImagenValor(1, "/Assets/Daryl.jpg");
            Rick = new ImagenValor(2, "/Assets/Rick.jpg");
            Michonne = new ImagenValor(3, "/Assets/Michonne.jpg");
            Negan = new ImagenValor(4, "/Assets/Negan.jpg");
            Tyreese = new ImagenValor(5, "/Assets/Tyreese.jpg");

            aux.Add(AR); aux.Add(Ballesta); aux.Add(Colt); aux.Add(Katana); aux.Add(Lucille); aux.Add(Martillo);

            aux.Add(Sasha); aux.Add(Daryl); aux.Add(Rick); aux.Add(Michonne); aux.Add(Negan); aux.Add(Tyreese);

            for(int i = 0; i < 12; i++)
            {
                aleatorio = miAleatorio.Next(0, aux.Count-1);
                devolver.Add(aux.ElementAt(aleatorio));
                aux.RemoveAt(aleatorio);
            }
            return devolver;
        }
    }
}
