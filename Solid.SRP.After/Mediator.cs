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
    /// Mediator for all View Models
    /// </summary>
    public class Mediator
    {
        #region Data members
        MultiDictionary<string, IColleague> internalList
            = new MultiDictionary<string, IColleague>();
        #endregion

        /// <summary>
        /// Registers a Colleague to a specific message
        /// </summary>
        /// <param name="colleague">The colleague to register</param>
        /// <param name="messages">The message to register to</param>
        public void Register(IColleague colleague, IEnumerable<string> messages)
        {
            foreach (string message in messages)
                internalList.AddValue(message, colleague);
        }

        /// <summary>
        /// Notify all colleagues that are registed to the specific message
        /// </summary>
        /// <param name="message">The message for the notify by</param>
        /// <param name="args">The arguments for the message</param>
        public void NotifyColleagues(string message, object args)
        {
            if (internalList.ContainsKey(message))
            {
                //forward the message to all listeners
                foreach (IColleague colleague in internalList[message])
                    colleague.MessageNotification(message, args);
            }
        }
    }
}
