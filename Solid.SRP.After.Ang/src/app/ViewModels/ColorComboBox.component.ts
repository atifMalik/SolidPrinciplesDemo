import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Mediator } from "@app/Mediator";

@Component({
    selector: 'mn-ColorCombo',
    templateUrl: '../Views/ColorComboBox.component.html'
})
export class ColorComboBoxVM extends BaseVM {

  constructor() {
    super();

    // this.mediator.register(this, ['one', 'two']);
  }

  selectedColor: string = 'Some Color';
  colorItems: any[] = [
    {
      "text": "Red"
    },
    {
      "text": "Green"
    },
    {
      "text": "Black"
    },
    {
      "text": "White"
    }
  ];

  selectColor(color) : void {
    this.selectedColor = color;
  }

  public messageNotification(message: string, args: object) {
    throw new Error("Method not implemented.");
  }
}
