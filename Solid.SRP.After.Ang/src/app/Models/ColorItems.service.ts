import { Injectable } from '@angular/core';
import { IColorItem } from '@app/Models/ColorItem';

@Injectable()
export class ColorItemsService {
  getAllItems(): IColorItem[] {
    return [
      { text: 'Red', backgroundColor: 'Red', foregroundColor: 'White', image: '../Images/Red.jpg' },
      { text: 'Orange', backgroundColor: 'Orange', foregroundColor: 'Black', image: '../Images/Orange.jpg' },
      { text: 'Cyan', backgroundColor: 'Cyan', foregroundColor: 'Black', image: '../Images/Cyan.jpg' },
      { text: 'Green', backgroundColor: 'Green', foregroundColor: 'White', image: '../Images/Green.jpg' },
      { text: 'Blue', backgroundColor: 'Blue', foregroundColor: 'White', image: '../Images/Blue.jpg' },
      { text: 'Purple', backgroundColor: 'Purple', foregroundColor: 'White', image: '../Images/Purple.jpg' },
      { text: 'Yellow', backgroundColor: 'Yellow', foregroundColor: 'Black', image: '../Images/Yellow.jpg' },
      { text: 'White', backgroundColor: 'White', foregroundColor: 'Black', image: '../Images/White.jpg' },
      { text: 'Black', backgroundColor: 'Black', foregroundColor: 'White', image: '../Images/Black.jpg' },
      { text: 'Brown', backgroundColor: 'Brown', foregroundColor: 'White', image: '../Images/Brown.jpg' }
    ];
  }
}
