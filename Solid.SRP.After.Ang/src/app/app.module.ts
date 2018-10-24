import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { ColorComboBoxVM } from './ViewModels/ColorComboBox.component';
import { ColorListViewVM } from './ViewModels/ColorListView.component';
import { ImageVM } from './ViewModels/ImageView.component';

@NgModule({
  declarations: [ AppComponent, ColorComboBoxVM, ColorListViewVM, ImageVM ],
  imports: [ BrowserModule, NgbModule.forRoot(), FormsModule ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
