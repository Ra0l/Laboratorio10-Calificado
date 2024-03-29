﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{


    public class OperacionesViewModel : ViewModelBase
    {

        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int dividir;
        public int Dividir
        {
            get { return dividir; }
            set
            {
                if (dividir != value)
                {
                    dividir = value;
                    OnPropertyChanged();
                }
            }
        }

        int multi;
        public int Multi
        {
            get { return multi; }
            set
            {
                if (multi != value)
                {
                    multi = value;
                    OnPropertyChanged();
                }
            }
        }

        int suma;
        public int Suma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resta;
        public int Resta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }
    }
    #region Comandos 
    public ICommand Sumar { protected set; get; }

    public ICommand Restar { protected set; get; }

    public ICommand Division { protected set; get; }

    public ICommand Multiplicacion { protected set; get; }
    #endregion

    #region Constructor

}
}

