import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-create-hcs',
  templateUrl: './create-hcs.component.html',
  styleUrls: ['./create-hcs.component.css']
})

export class CreateHcsComponent{

  constructor(private http: HttpClient){}

  addHcs(FIOApplicant: HTMLInputElement, PassportInfo: HTMLInputElement, DateBirth: HTMLInputElement,
    FIOChildOfApplicant: HTMLInputElement, BirthCertificate: HTMLInputElement, DateBirthCildOfApplicant: HTMLInputElement, 
    AvailabilityOfBenefits: HTMLInputElement){

    let applicationhcs = {
      fioApplicant: FIOApplicant.value,
      passportInfo: PassportInfo.value,
      dateBirth: DateBirth.value,
      fioChildOfApplicant: FIOChildOfApplicant.value,
      birthCertificate: BirthCertificate.value,
      dateBirthCildOfApplicant: DateBirthCildOfApplicant.value,
      availabilityOfBenefits: AvailabilityOfBenefits.value
    }
    console.log(applicationhcs);
    
    this.http.post('/test/addHCS', applicationhcs)
    .subscribe(response =>{console.log(response);})  
  }
}