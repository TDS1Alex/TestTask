import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Console } from 'console';
import { ApplicationHCS } from './application';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})

export class MainComponent implements OnInit{

  public list: ApplicationHCS[];
  constructor(private http: HttpClient){}

  ngOnInit(): void {
    this.http.get<ApplicationHCS[]>('/test/listHcs')
    .subscribe(list=>{this.list = list;})
  }
}
