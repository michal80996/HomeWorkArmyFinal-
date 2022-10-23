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

  public dateNow: Date = new Date()




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
    debugger
    this.coronaDetails.forEach(element => {
      if (element.CoronaVaccine) {
        console.log(element.CoronaVaccine.getFullYear)
        if (element.CoronaVaccine.getFullYear == this.dateNow.getFullYear
          && element.CoronaVaccine.getMonth == this.dateNow.getMonth) {
          this.numOfVaccinators[element.CoronaVaccine.getDay()]++;
        }
      }
      if (element.CoronaVaccine_2) {
        if (element.CoronaVaccine_2.getFullYear == this.dateNow.getFullYear
          && element.CoronaVaccine_2.getMonth == this.dateNow.getMonth) {
          this.numOfVaccinators[element.CoronaVaccine_2.getDay()]++;
        }
      } if (element.CoronaVaccine_3) {
        if (element.CoronaVaccine_3.getFullYear == this.dateNow.getFullYear
          && element.CoronaVaccine_3.getMonth == this.dateNow.getMonth) {
          this.numOfVaccinators[element.CoronaVaccine_3.getDay()]++;
        }
      }
      if (element.CoronaVaccine_4) {
        if (element.CoronaVaccine_4.getFullYear == this.dateNow.getFullYear
          && element.CoronaVaccine_4.getMonth == this.dateNow.getMonth) {
          this.numOfVaccinators[element.CoronaVaccine_4.getDay()]++;
        }
      }
    })
  }

}
