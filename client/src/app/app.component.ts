import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Dating app';
  
  constructor(private http: HttpClient) {}
  
  // Get all users from the server and store them in this component's property "users
  users:  any;
  
  ngOnInit(): void {
    this.http.get("https://localhost:5001/api/users").subscribe({
      next: response => this.users = response,
      error: err => console.log(err),
      complete: () => console.log('Users loaded')
    });
  }
}
