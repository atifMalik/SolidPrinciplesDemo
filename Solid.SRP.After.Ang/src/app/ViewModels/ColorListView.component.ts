import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Mediator } from "@app/Mediator";
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
    this.mediator.register(this, [ Messages.Combobox_Color_Selected ] );
  }

  colorItems: IColorItem[] = [
    {
      text: 'Red',
      backgroundColor: 'Red',
      foregroundColor: 'Black',
      image: ''
    },
    {
      text: 'Green',
      backgroundColor: 'Green',
      foregroundColor: 'Black',
      image: ''
    },
    {
      text: 'Black',
      backgroundColor: 'Black',
      foregroundColor: 'White',
      image: ''
    },
    {
      text: 'White',
      backgroundColor: 'White',
      foregroundColor: 'Black',
      image: ''
    }
  ];

  backColor: string = 'Red';
  foreColor: string = 'Black';

  messageNotification(message: string, args: object) {
    if (message === Messages.Combobox_Color_Selected) {
      this.colorItems.push(args as IColorItem);
    }
  }
}
