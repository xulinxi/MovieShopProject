import { Component, OnInit } from '@angular/core';

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

  LoginComponent() {
    console.log(` buttun was clicked`);
  }
  
}

