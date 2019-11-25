import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgxWheelModule } from 'ngx-wheel'; 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgxWheelModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
