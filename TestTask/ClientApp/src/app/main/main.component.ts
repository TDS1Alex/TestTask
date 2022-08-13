import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Application } from './application';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})

export class MainComponent implements OnInit{

  applications: Application | undefined;

  constructor(private http: HttpClient){}
  
  ngOnInit(): void{
    this.getHCS();
  }  

  getHCS(){
    return this.http.get('/test/getHCS')
    .subscribe((data:any) => this.applications = new Application (data.FIOApplicant, data.PassportInfo, 
      data.DateBirth, data.FIOChildOfApplicant, data.BirthCertificate, data.DateBirthCildOfApplicant, 
      data.AvailabilityOfBenefitsv, data.BankAccountNumber));
  } 

  listSP(){
   return this.http.get('/test/listSP')
   .subscribe(response =>{console.log(response);})
  }
}
