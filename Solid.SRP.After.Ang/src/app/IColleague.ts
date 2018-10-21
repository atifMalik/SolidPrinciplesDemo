import { Mediator } from "@app/Mediator";

export interface IColleague {
  mediator: Mediator;
  messageNotification(message: string, args: object);
}
