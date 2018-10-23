import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Mediator } from "@app/Mediator";

@Component({
  selector: 'mn-ColorListView',
  templateUrl: '../Views/ColorListView.component.html',
  styleUrls: ['../Styles/ColorListView.component.css']
})
export class ColorListViewVM extends BaseVM {
  constructor() {
    super();

    // this.mediator.register(this, ['one', 'two']);
  }

  colorItems: any[] = [
    {
      backColor: 'Red',
      foreColor: 'Black',
      text: 'Red'
    },
    {
      backColor: 'Green',
      foreColor: 'Black',
      text: 'Green'
    },
    {
      backColor: 'Black',
      foreColor: 'White',
      text: 'Black'
    },
    {
      backColor: 'White',
      foreColor: 'Black',
      text: 'White'
    }
  ];

  backColor: string = 'Red';
  foreColor: string = 'Black';

  messageNotification(message: string, args: object) {

  }
}
