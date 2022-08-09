import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-create-sp',
  templateUrl: './create-sp.component.html',
  styleUrls: ['./create-sp.component.css']
})

export class CreateSpComponent {

  constructor(private http: HttpClient){}

  addSP(FIOApplicant: HTMLInputElement, PassportInfo: HTMLInputElement, DateBirth: HTMLInputElement,
    FIOChildOfApplicant: HTMLInputElement, BirthCertificate: HTMLInputElement, DateBirthCildOfApplicant: HTMLInputElement, 
    BankAccountNumber: HTMLInputElement){

    let applicationsp = {
      fioApplicant: FIOApplicant.value,
      passportInfo: PassportInfo.value,
      dateBirth: DateBirth.value,
      fioChildOfApplicant: FIOChildOfApplicant.value,
      birthCertificate: BirthCertificate.value,
      dateBirthCildOfApplicant: DateBirthCildOfApplicant.value,
      bankAccountNumber: BankAccountNumber.value
    }
    console.log(applicationsp);
    
    this.http.post('/test/addSP', applicationsp)
    .subscribe(response =>{console.log(response);})  
  }
}

