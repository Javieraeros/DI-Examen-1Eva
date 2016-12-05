using Ejercicio1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Ejercicio1.ViewModel
{
    public class VMTWD:VMBase
    {
        #region Atributos
        private ObservableCollection<ImagenValor> lista;
        private ImagenValor seleccionadoUno;
        private ImagenValor seleccionadoDos;
        private ImagenValor seleccionadoGridView;

        private DelegateCommand reiniciarCommand;

        #endregion

        #region Constructores
        public VMTWD()
        {
            //Llamar a método que devuelva collection aleatorio
            lista = new ObservableCollection<ImagenValor>();
            seleccionadoUno = null;
            seleccionadoDos = null;

            BussinesLogic.Listados miListado = new BussinesLogic.Listados();
            lista=miListado.devuelveListado();

            reiniciarCommand = new DelegateCommand(ReiniciarCommand_Execute, ReiniciarCommand_CanExecute);

        }

        #endregion

        #region Propiedades
        public ObservableCollection<ImagenValor> Lista
        {
            get
            {
                return lista;
            }

            set
            {
                lista = value;
                NotifyPropertyChanged("Lista");
            }
        }

        public ImagenValor SeleccionadoUno
        {
            get
            {
                return seleccionadoUno;
            }

            set
            {
                seleccionadoUno = value;
                NotifyPropertyChanged("SeleccionadoUno");
               
            }
        }

        public ImagenValor SeleccionadoDos
        {
            get
            {
                return seleccionadoDos;
            }

            set
            {
                seleccionadoDos = value;
                NotifyPropertyChanged("SeleccionadoDos");
            }
        }


        public DelegateCommand ReiniciarCommand
        {
            get
            {
                return reiniciarCommand;
            }
        }

        public ImagenValor SeleccionadoGridView
        {
            get
            {
                return seleccionadoGridView;
            }

            set
            {
                seleccionadoGridView = value;
                NotifyPropertyChanged("SeleccionadoGridView");
                comprueba();
            }
        }

        #endregion


        #region "Métodos"
        private bool ReiniciarCommand_CanExecute()
        {
            return true;
        }

        private void ReiniciarCommand_Execute()
        {
            BussinesLogic.Listados miLista = new BussinesLogic.Listados();
            SeleccionadoUno = null;
            SeleccionadoDos = null;
            Lista = miLista.devuelveListado();
        }

        private void comprueba()
        {
            if (SeleccionadoUno == null)
            {
                if (seleccionadoGridView != null)
                {
                    seleccionadoGridView.Visibilidad = Windows.UI.Xaml.Visibility.Visible;
                    SeleccionadoUno = SeleccionadoGridView;
                }

            }
            else
            {
                //Si volvemos a pinchar en la misma imagne, no hacemos nada
                if (SeleccionadoUno == SeleccionadoGridView)
                {

                }else
                {
                    seleccionadoGridView.Visibilidad = Windows.UI.Xaml.Visibility.Visible;
                    SeleccionadoDos = SeleccionadoGridView;

                    if (SeleccionadoUno.Valor == SeleccionadoDos.Valor)
                    {
                        SeleccionadoUno = null;
                        SeleccionadoDos = null;
                    }
                    else
                    {
                        esperar();
                       
                    }
                }

                
            }
        }

        private async void esperar()
        {
            await Task.Delay(1000);
            SeleccionadoUno.Visibilidad = Windows.UI.Xaml.Visibility.Collapsed;
            SeleccionadoDos.Visibilidad = Windows.UI.Xaml.Visibility.Collapsed;
            SeleccionadoUno = null;
            SeleccionadoDos = null;
        }
        #endregion
    }
}
