using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility
{
    // Disclaimer:  *Not Original* --------------
    // Source:      Article by Marlon from Thynk Software
    // More Info:   https://marlongrech.wordpress.com/2008/03/20/more-than-just-mvc-for-wpf/

    /// <summary>
    /// Colleague that can register to messages from the Mediator
    /// </summary>
    public interface IColleague
    {
        /// <summary>
        /// Gets or sets the mediator for this controller
        /// </summary>
        Mediator Mediator { get; }

        /// <summary>
        /// Notification from the Mediator
        /// </summary>
        /// <param name="message">The message type</param>
        /// <param name="args">Arguments for the message</param>
        void MessageNotification(string message, object args);
    }
}
