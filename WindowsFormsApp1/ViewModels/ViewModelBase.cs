using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.ViewModels
{
    /// <summary>
    /// Abstrakte Basisklasse für die Definition von Viewmodels
    /// </summary>
    /// <typeparam name="T">Der Typparameter legt fest, welches Model dem Viewmodel zugrunde liegt. 
    /// Er ist eingeschränkt auf Ableitungen von <see cref="ModelBase"/></typeparam>
    public abstract class ViewModelBase<T> : ViewModelBase where T : class
    {
        private readonly T _model;

        /// <summary>
        /// Erzeugt ein neues <see cref="ViewModelBase{T}"/>-Objekt
        /// </summary>
        /// <param name="model">Ein Objekt vom Typ des <typeparamref name="T"/></param>
        /// <exception cref="ArgumentNullException">Wird ausgelöst, wenn <paramref name="model"/>
        /// null ist.</exception>
        protected ViewModelBase(T model)
        {
            if (null == model)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _model = model;
        }

        /// <summary>
        /// Gibt das, bei der Erzeugung übergebene Objekt zurück
        /// </summary>
        internal T Model { get { return _model; } }

    }

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Implmentierung von <see cref="INotifyPropertyChanged"/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
