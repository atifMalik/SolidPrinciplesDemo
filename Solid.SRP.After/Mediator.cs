using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.SingleResponsibility
{
    /// <summary>
    /// Mediator for all sub controllers
    /// </summary>
    public class Mediator
    {
        #region Data members
        Dictionary<string, IColleague> internalList
            = new Dictionary<string, IColleague>();
        #endregion

        /// <summary>
        /// Registers a Colleague to a specific message
        /// </summary>
        /// <param name="colleague">The colleague to register</param>
        /// <param name="messages">The message to register to</param>
        public void Register(IColleague colleague, IEnumerable<string> messages)
        {
            foreach (string message in messages)
                if(!internalList.ContainsKey(message))
                    internalList.Add(message, colleague);
        }

        /// <summary>
        /// Notify all colleagues that are registered to the specific message
        /// </summary>
        /// <param name="message">The message for the notify by</param>
        /// <param name="args">The arguments for the message</param>
        public void NotifyColleagues(string message, object args)
        {
            if (internalList.ContainsKey(message))
            {
                //forward the message to all listeners
                foreach (IColleague colleague in internalList.Values)
                    colleague.MessageNotification(message, args);
            }
        }
    }
}
