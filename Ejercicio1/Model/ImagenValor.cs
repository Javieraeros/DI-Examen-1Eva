using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Ejercicio1.Model
{
    /// <summary>
    /// Clase en la que guardaremos una imagen y un valor, de tal forma que compararemos dos valores de dos imagenes, 
    /// y en caso de que los dos valores sean iguales, el arma corresponderá a esa persona.
    /// </summary>
    public class ImagenValor:INotifyClass
    {
        #region Atributos
        private int valor;
        private String rutaImagen;
        private Visibility visibilidad;

        #endregion

        #region Constructores
        public ImagenValor()
        {
            valor = 0;
            rutaImagen = "ms-appx:///Assets/StoreLogo.png";
            visibilidad = Visibility.Collapsed;
        }

        public ImagenValor(int valor,string ruta)
        {
            this.valor = valor;
            rutaImagen = ruta;
            visibilidad = Visibility.Collapsed;
        }
        #endregion

        #region Propiedades
        public int Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
                NotifyPropertyChanged("Valor");
            }
        }

        public string RutaImagen
        {
            get
            {
                return rutaImagen;
            }

            set
            {
                rutaImagen = value;
                NotifyPropertyChanged("RutaImagen");
            }
        }

        public Visibility Visibilidad
        {
            get
            {
                return visibilidad;
            }

            set
            {
                visibilidad = value;
                NotifyPropertyChanged("Visibilidad");
            }
        }

        #endregion
    }
}
