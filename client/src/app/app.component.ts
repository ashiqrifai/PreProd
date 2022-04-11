import { HttpClient, HttpClientModule } from '@angular/common/http'
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Human Resource - Payroll Application';
  employees: any;
  constructor(private http: HttpClient){

  }
  ngOnInit()  {

      this.getEmployees();


  }

  getEmployees(){

    this.http.get('https://localhost:5001/api/employees').subscribe(response => {

      this.employees = response;

    }, error => {

      console.log(error);

    })

  }
}
