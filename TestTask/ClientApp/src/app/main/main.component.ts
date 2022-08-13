import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Application } from './application';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})

export class MainComponent implements OnInit{

  applicationsHCS: Array<Application[]>;
  applicationsSP: Array<Application[]>;
  
  constructor(private http: HttpClient){}
  
  ngOnInit(){
    this.listHCS();
    this.listSP();
  }

  listHCS(){
    return this.http.post('/test/listHCS', {})
    .subscribe((data: any) => {this.applicationsHCS = data;
    });
  }

  listSP(){
    return this.http.post('/test/listSP', {})
    .subscribe((data: any) => {this.applicationsSP = data;
    });
  }
}