using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility.ViewModels
{
    public abstract class BaseVM : INotifyPropertyChanged, IColleague
    {

        #region Data members
        /// <summary>
        /// Example of Singleton pattern
        /// </summary>
        static Mediator mediatorInstance = new Mediator();
        #endregion

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Event raised to notify that a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The property name</param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        /// <summary>
        /// Notification from the Mediator
        /// </summary>
        /// <param name="message">The message type</param>
        /// <param name="args">Arguments for the message</param>
        public abstract void MessageNotification(string message, object args);

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseVM()
        {
            Mediator = mediatorInstance;
        }

        public Mediator Mediator { get; private set; }

    }
}
