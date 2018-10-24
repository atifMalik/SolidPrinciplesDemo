import { Component } from "@angular/core";
import { BaseVM } from "@app/ViewModels/BaseVM"
import { Messages } from "@app/Messages";
import { IColorItem } from "@app/Models/ColorItem";
import { ColorItemsService } from "@app/Models/ColorItems.service";

@Component({
  selector: 'mn-ColorCombo',
  templateUrl: '../Views/ColorComboBox.component.html',
  providers: [ColorItemsService]
})
export class ColorComboBoxVM extends BaseVM {

  constructor(private colorsService: ColorItemsService) {
    super();
    this.colorItems = colorsService.getAllItems();

    // this.mediator.register(this, ['one', 'two']);
  }

  selectedColor: string = 'Some Color';
  colorItems: IColorItem[];

  selectColor(colorItem): void {
    this.selectedColor = colorItem.text;
    this.mediator.notifyColleagues(Messages.Combobox_Color_Selected, colorItem);
  }

  public messageNotification(message: string, args: object) {
    throw new Error("Method not implemented.");
  }
}
