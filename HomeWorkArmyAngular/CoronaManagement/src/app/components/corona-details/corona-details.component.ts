import { Component, OnInit, ViewChild } from '@angular/core';
import { CoronaDetails } from 'src/app/Classes/CoronaDetails';
import { UserNameService } from 'src/app/Servises/user-name.service';
import {Chart} from 'chart.js';
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

  
  public  myChart = new Chart("myChart", {
    type: 'bar',
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
       
        }
      }
});


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
