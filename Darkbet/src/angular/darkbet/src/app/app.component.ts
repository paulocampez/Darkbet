import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'darkbet';
  colors = [
    "red",
    "black",
    "red",
    "black",
    "red",
    "black",
    "red",
    "black",
    "red",
    "black",
    "red",
    "black",
  ];
  //10, 9, 6 ,2
  prizes = [
    "Grand prize",
    "demo 2",
    "demo 3",
    "demo 4",
    "demo 5",
    "demo 6",
    "demo 7",
    "demo 8",
    "demo 9",
    "demo 10",
    "demo 11",
    "demo 12"
  ];
  beforeSpinFn = function () {
    // alert("before");
  };
  spinOnce = false;
  afterSpinFn = function () {
    // alert("after");
  };
}

