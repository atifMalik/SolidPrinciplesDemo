import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ColorComboBoxVM } from './ViewModels/ColorComboBox.component';

@NgModule({
  declarations: [
    AppComponent,
    ColorComboBoxVM
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
