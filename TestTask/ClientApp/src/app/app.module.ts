import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { CreateHcsComponent } from './create-hcs/create-hcs.component';
import { CreateSpComponent } from './create-sp/create-sp.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    CreateHcsComponent,
    CreateSpComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "", component: MainComponent },
      { path: "create_hcs", component: CreateHcsComponent },
      { path: "create_sp", component: CreateSpComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
