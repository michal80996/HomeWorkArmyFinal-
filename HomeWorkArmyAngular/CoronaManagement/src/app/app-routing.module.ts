import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddUpdateUserComponent } from './components/all-users/add-update-user/add-update-user.component';

import { AllUsersComponent } from './components/all-users/all-users.component';
import { CoronaDetailsComponent } from './components/corona-details/corona-details.component';

const routes: Routes = [
  {path:'CoronaDatails',component:CoronaDetailsComponent},
  {path:'UserName',component:AllUsersComponent},
  {path:'addUser',component:AddUpdateUserComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
