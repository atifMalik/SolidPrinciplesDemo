import { Mediator } from "@app/Business/Mediator";

export interface IColleague {
  mediator: Mediator;
  messageNotification(message: string, args: object);
}
