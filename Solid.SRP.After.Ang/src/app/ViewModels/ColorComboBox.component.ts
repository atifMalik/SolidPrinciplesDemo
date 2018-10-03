import { Component } from "@angular/core";

@Component({
    selector: 'mn-ColorCombo',
    templateUrl: '../Views/ColorComboBox.component.html'
})

export class ColorComboBoxVM {
  selectedColor: any = 'Some Color';
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
