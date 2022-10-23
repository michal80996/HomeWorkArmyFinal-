import { Component, OnInit } from '@angular/core';
import { CoronaDetails } from 'src/app/Classes/CoronaDetails';
import { UserNameService } from 'src/app/Servises/user-name.service';
import { Chart } from 'chart.js';
@Component({
  selector: 'app-corona-details',
  templateUrl: './corona-details.component.html',
  styleUrls: ['./corona-details.component.scss']
})
export class CoronaDetailsComponent implements OnInit {


  public coronaDetails: CoronaDetails[] = []
  public idForDetails: string = ""
  public openDetails: boolean = false

  public numsActivesCorona: number = 0
  public numOfVaccinators: number[] = []

  public vaccineInMonth:number[]=[]




  constructor(private UserNameServ: UserNameService) { }


  ngOnInit(): void {

    this.refreshCoronaDetails()
  }


  refreshCoronaDetails() {
    this.UserNameServ.GetCoronaDetailsDataFromServer().subscribe(
      (data) => {
        this.coronaDetails = data
        console.log(this.coronaDetails)
      })

      this.UserNameServ.numberOfVaccinatorsInMonth().subscribe(
        (data) => {
          this.vaccineInMonth = data
          console.log(this.vaccineInMonth)
        })


  }

  //בודק את מס' החולים הפעילים
  onCheckNumOfThePositive() {
    this.coronaDetails.forEach(element => {
      if (element.PositiveForCorona && !element.RecoveringFromCorona)
        this.numsActivesCorona++;
    });
    this.openDetails = !this.openDetails
  }


  //בודק את מס' המתחסנים כל יום בחודש האחרון
  onCheckTheNumberOfVaccinators() {
    this.openDetails=!this.openDetails
    console.log(this.vaccineInMonth)
  }
}
