using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility
{
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
