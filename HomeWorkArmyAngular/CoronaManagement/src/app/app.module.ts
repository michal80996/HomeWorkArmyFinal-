
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllUsersComponent } from './components/all-users/all-users.component';
import { CoronaDetailsComponent } from './components/corona-details/corona-details.component';
import {UserNameService} from './Servises/user-name.service';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { AddUpdateUserComponent } from './components/all-users/add-update-user/add-update-user.component';


@NgModule({
  declarations: [
    AppComponent,
    AllUsersComponent,
    CoronaDetailsComponent,
    AddUpdateUserComponent,
    
 

    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
   
   
  ],
  providers: [UserNameService],
  bootstrap: [AppComponent]
})
export class AppModule { }
