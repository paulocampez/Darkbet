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
    "2",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "9",
    "10",
    "11",
    "12"
  ];
  beforeSpinFn = function () {
    // alert("before");
  };
  spinOnce = false;
  afterSpinFn = function () {
    // alert("after");
  };
}

