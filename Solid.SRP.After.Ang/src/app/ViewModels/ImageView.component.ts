import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Messages } from "@app/Messages";
import { IColorItem } from "@app/Models/ColorItem";


@Component({
  selector: 'mn-ImageListView',
  templateUrl: '../Views/ImageView.component.html'
  //styleUrls: ['../Styles/ColorListView.component.css']
})
export class ImageViewVM extends BaseVM {
  constructor() {
    super();
    this.currentColorItem = { image: '' } as IColorItem;
    this.mediator.register(this, [Messages.Combobox_Color_Selected, Messages.ListBox_Color_Selected]);
  }

  currentColorItem: IColorItem;

  messageNotification(message: string, args: object) {
    switch (message) {
      case Messages.ListBox_Color_Selected:
      case Messages.Combobox_Color_Selected:
        this.currentColorItem = args as IColorItem;

      //default:
    }
  }
}
