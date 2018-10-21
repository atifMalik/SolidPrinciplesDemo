/// <summary>
/// Defines a list of messages that the ViewModels use to communicate with each other
/// </summary>
export class Messages {
  // Message to notify that a color was selected in Combobox ViewModel
  static Combobox_Color_Selected: string = "Combobox_Color_Selected";

  // Message to notify that a color was selected in ListView ViewModel
  static ListBox_Color_Selected: string = "ListBox_Color_Selected";

  // Message to notify that an image was selected in Image ViewModel
  static Image_Selected: string = "Image_Selected";
}

