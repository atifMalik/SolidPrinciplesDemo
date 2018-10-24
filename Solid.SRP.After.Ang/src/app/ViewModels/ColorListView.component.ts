import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Messages } from "@app/Messages";
import { IColorItem } from "@app/Models/ColorItem";


@Component({
  selector: 'mn-ColorListView',
  templateUrl: '../Views/ColorListView.component.html',
  styleUrls: ['../Styles/ColorListView.component.css']
})
export class ColorListViewVM extends BaseVM {
  constructor() {
    super();
    this.colorItems = new Array<IColorItem>();
    this.mediator.register(this, [ Messages.Combobox_Color_Selected ] );
  }

  colorItems: IColorItem[];

  messageNotification(message: string, args: object) {
    switch (message) {
      case Messages.Combobox_Color_Selected:
        this.colorItems.push(args as IColorItem);

      //default:
    }
  }
}
