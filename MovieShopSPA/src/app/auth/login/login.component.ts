import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/shared/models/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  // two way binding - powered by angular JS
  // one way binding
  // object here

  userLogin: Login = {
    email:``, password:``
  }

  constructor() { }

  ngOnInit(): void {
  }

  login() {
    console.log(` buttun was clicked`);
  }

  // simply observing two way binding, just for testing, remove it later
  get twoWayBindingInfo() { return JSON.stringify(this.userLogin)}
  
}

