import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserName } from '../Classes/UserName';
import { Observable } from 'rxjs';
import { CoronaDetails } from '../Classes/CoronaDetails';

@Injectable({
  providedIn: 'root'
})
export class UserNameService {

  
  readonly myUrlService="https://localhost:44390/api"
  constructor(
    //הזרקת הסרוויס המאפשר גישה לשרתים
    private myHttp: HttpClient
  ) { 
  }

    //גישה לשרת וקבלת כל המשתמשים
    GetUsersDataFromServer(): Observable<UserName[]> {
      return this.myHttp.get<any>(`${this.myUrlService}/${'UserName/GetAllUserName'}`);
    }

     //גישה לשרת וקבלת כל המשתמשים
     GetUserByIdFromServer(id:string): Observable<UserName> {
      return this.myHttp.get<UserName>(`${this.myUrlService}/${'UserName/getUserById'}/${id}`);
    }

    //עידכון משתמש למערך האנשים בשרת המקומי
   AddPersonToServer(user:UserName):Observable<void> {
    return this.myHttp.post<void>(`${this.myUrlService}/${'UserName/AddUserName'}`,user)
  }

     //הוספת משתמש למערך האנשים בשרת המקומי
     updatePerson(id:string,user:UserName):Observable<void> {
      return this.myHttp.put<void>(`${this.myUrlService}/${'UserName/UpdateUserName'}/${id}`,user)
    }
  // מחיקת משתמש מהשרת מהמקומי
   DeletePersonByIdFromServer(id: string):Observable<void>{
  
   return this.myHttp.delete<void>(`${this.myUrlService}/${'UserName/DeleteUserName'}/${id}`)
  }


   //גישה לשרת וקבלת כל פרטי קורונה
   GetCoronaDetailsDataFromServer(): Observable<CoronaDetails[]> {
    return this.myHttp.get<any>(`${this.myUrlService}/${'CoronaDetails/GetAllCoronaDetails'}`);
  }
 

// גישה לשרת וקבלת פרטי קורונה לפי ת.ז
GetCoronaDetailsByIdFromServer(id:string): Observable<CoronaDetails> {
  return this.myHttp.get<CoronaDetails>(`${this.myUrlService}/${'CoronaDetails/getCoronaDetailById'}/${id}`);
}
   //עידכון פרטי קורונה בשרת המקומי
   updateCoronaDetails(personId:string ,coronaDetails:CoronaDetails):Observable<void> {
    return this.myHttp.put<void>(`${this.myUrlService}/${'CoronaDetails/UpdateCoronaDetails'}/${personId}`,coronaDetails)
  }

  
  //העלאת תמונה של המשתמש לשרת
  uploadFile(id:string,fd:FormData):Observable<void>{
     return this.myHttp.post<void>(`${this.myUrlService}/${'UserName/uploadFile'}/${id}`, fd);
  }

  numberOfVaccinatorsInMonth():Observable<number[]>{
    return this.myHttp.get<any[]>(`${this.myUrlService}/${'CoronaDetails/numberOfVaccinatorsInMonth'}`);
  }

}
