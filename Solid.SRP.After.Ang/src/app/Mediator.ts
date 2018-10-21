/// <summary>
/// Mediator for all View Models
/// </summary>

import { MultiDictionary } from "@app/MultiDictionary";
import { IColleague } from "@app/IColleague";

export class Mediator {
  private internalList: MultiDictionary<string, IColleague> = new MultiDictionary<string, IColleague>();

  // Registers a Colleague to a specific message
  register(colleague: IColleague, messages: string[]): void {

    for (let message of messages) {
      this.internalList.addValue(message, colleague);
    }
  }

  // Notify all colleagues that are registed to the specific message
  notifyColleagues(message: string, args: object): void {
    if (this.internalList.containsKey(message)) {

      //forward the message to all listeners
      for (let colleage of this.internalList.getValue(message)) {
        colleage.messageNotification(message, args);
      }
    }
  }
}
