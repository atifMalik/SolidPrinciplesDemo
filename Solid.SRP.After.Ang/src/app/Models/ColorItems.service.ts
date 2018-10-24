import { Injectable } from '@angular/core';
import { IColorItem } from '@app/Models/ColorItem';

@Injectable()
export class ColorItemsService {
  getAllItems(): IColorItem[] {
    return [
      { text: 'Red', backgroundColor: 'Red', foregroundColor: 'White', image: 'assets/Images/Red.jpg' },
      { text: 'Orange', backgroundColor: 'Orange', foregroundColor: 'Black', image: 'assets/Images/Orange.jpg' },
      { text: 'Cyan', backgroundColor: 'Cyan', foregroundColor: 'Black', image: 'assets/Images/Cyan.jpg' },
      { text: 'Green', backgroundColor: 'Green', foregroundColor: 'White', image: 'assets/Images/Green.jpg' },
      { text: 'Blue', backgroundColor: 'Blue', foregroundColor: 'White', image: 'assets/Images/Blue.jpg' },
      { text: 'Purple', backgroundColor: 'Purple', foregroundColor: 'White', image: 'assets/Images/Purple.jpg' },
      { text: 'Yellow', backgroundColor: 'Yellow', foregroundColor: 'Black', image: 'assets/Images/Yellow.jpg' },
      { text: 'White', backgroundColor: 'White', foregroundColor: 'Black', image: 'assets/Images/White.jpg' },
      { text: 'Black', backgroundColor: 'Black', foregroundColor: 'White', image: 'assets/Images/Black.jpg' },
      { text: 'Brown', backgroundColor: 'Brown', foregroundColor: 'White', image: 'assets/Images/Brown.jpg' }
    ];
  }
}
