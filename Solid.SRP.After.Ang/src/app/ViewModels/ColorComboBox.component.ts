import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Mediator } from "@app/Mediator";

@Component({
    selector: 'mn-ColorCombo',
    templateUrl: '../Views/ColorComboBox.component.html'
})

export class ColorComboBoxVM extends BaseVM {

  public messageNotification(message: string, args: object) {
        throw new Error("Method not implemented.");
  }

    selectedColor: string = 'Some Color';
    colorItems: any[] = [
    {
      "text": "Black"
    },
    {
      "text": "Blue"
    },
    {
      "text": "Red"
    },
    {
      "text": "Green"
    }
  ];

  selectColor(color) : void {
    this.selectedColor = color;
  }
}
