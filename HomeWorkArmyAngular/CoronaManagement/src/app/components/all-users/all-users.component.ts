import { Component, OnInit, ViewChild } from '@angular/core';
import { CoronaDetails } from 'src/app/Classes/CoronaDetails';
import { UserName } from 'src/app/Classes/UserName';
import { UserNameService } from 'src/app/Servises/user-name.service';


@Component({
  selector: 'app-all-users',
  templateUrl: './all-users.component.html',
  styleUrls: ['./all-users.component.scss']
})
export class AllUsersComponent implements OnInit {

  //משתני עזר לפרטי משתמש
  public allUsers:Array<UserName>=[] 
  public isStatusUpdate:boolean=false
  public updateUser:UserName=new UserName("")

   public dateNow:Date=new Date();


  //משתני עזר לפרטי קורונה
   coronaDetails:CoronaDetails[]=[]
   openDetails:boolean=false
   oneCoronaDetails:CoronaDetails=new CoronaDetails("")
  
  constructor(
    private UserNameServ:UserNameService
   ) {}

  ngOnInit(): void {
    this.refreshUserName()
  }
  //בעת טעינת הקומפוננטה יתבצע ייבוא פרטי משתמשים למשתנה מקומי
  refreshUserName(){
    this.UserNameServ.GetUsersDataFromServer().subscribe(
      data=>this.allUsers=data)
    console.log(this.allUsers)
    this.UserNameServ.GetCoronaDetailsDataFromServer().subscribe(
        data=>this.coronaDetails=data
      )
  }

  //ייבוא פרטי קורונה לפי ת.ז
  onCoronaDetailsClick(id:string){
    this.UserNameServ.GetCoronaDetailsByIdFromServer(id).subscribe(
      (data)=>this.oneCoronaDetails=data
      ,
      (err)=>console.log('error')
      )
    
    this.openDetails=!this.openDetails
  }

  //עידכון פרטי קורונה
  onUpdateCoronaDetails(coronaDetails:CoronaDetails){
    if(coronaDetails.PersonId!="")
    debugger
      this.UserNameServ.updateCoronaDetails(coronaDetails.PersonId,coronaDetails).subscribe(
        ()=>{console.log(coronaDetails)} 
      )
      console.log(coronaDetails)
      location.reload();
  }
  //עידכון פרטי משתמש
  onOpenUpdateClick(user:UserName){
    this.isStatusUpdate=true
    this.updateUser=user
  }

  onUpdateClick(user:UserName){
    this.UserNameServ.updatePerson(user.PersonId,user).subscribe(
      ()=>{console.log('Update')},
    (err)=>{console.log('error')}
    )
    location.reload();
  }

  //פונקציות למחיקת משתמש 
  onDeleteClick(id:string){
    if(id!="")
      this.UserNameServ.DeletePersonByIdFromServer(id).subscribe(
      ()=>{alert("User deleted successfully")}
    )
    location.reload();
  }
}
