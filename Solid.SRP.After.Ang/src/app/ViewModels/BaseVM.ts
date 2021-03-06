import { IColleague } from "@app/Business/IColleague";
import { Mediator } from "@app/Business/Mediator";

export abstract class BaseVM implements IColleague
{
  static mediatorInstance: Mediator = new Mediator();
  private _mediator: Mediator;

  constructor() {
    this._mediator = BaseVM.mediatorInstance;
  }

  public abstract messageNotification(message: string, args: object);

  public get mediator(): Mediator {
    return this._mediator;
  }
}
