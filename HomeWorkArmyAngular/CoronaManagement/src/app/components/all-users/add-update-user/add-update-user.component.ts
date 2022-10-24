import { Component, OnInit, ViewChild } from '@angular/core';
import { Form } from '@angular/forms';
import { UserName } from 'src/app/Classes/UserName';
import { UserNameService } from 'src/app/Servises/user-name.service';


@Component({
  selector: 'app-add-update-user',
  templateUrl: './add-update-user.component.html',
  styleUrls: ['./add-update-user.component.scss']
})
export class AddUpdateUserComponent implements OnInit {

  @ViewChild('f') form!: any

  public isStatusAdded: boolean = true
  public addUser: UserName = new UserName("")
  public idForUpdate: string = ""

  public selectedFile!: File;
  public dateNow:Date=new Date()

  constructor(private servUser: UserNameService) { }

  ngOnInit(): void {

  }
//הוספת משתמש חדש
  onAddedClick() {
    
    if (this.form.valid) {
      this.isStatusAdded = true
      this.servUser.AddPersonToServer(this.addUser).subscribe(
        () => {
          console.log('added')
          alert("The user has been successfully added")
        },
        () => { console.log('error') }
      )
      console.log(this.addUser)
      location.reload();
    } else
        this.isStatusAdded = false
      
  }


//פונקציות הוספת תמונה
  onFileChanged(event: any) {
    this.selectedFile = event.target.files[0]
  }

  onUpload(id: string) {
    const fd = new FormData()
    fd.append('myImage', this.selectedFile, this.selectedFile.name)
    this.servUser.uploadFile(id, fd).subscribe(
      (res) => console.log(res),
      (err) => console.log(err)
    )
  }





  	
 public	url: any; 
 public	msg = "";
	
	
	selectFile(event: any) {
		if(!event.target.files[0] || event.target.files[0].length == 0) {
			this.msg = 'You must select an image';
			return;
		}
		
		var mimeType = event.target.files[0].type;
		
		if (mimeType.match(/image\/*/) == null) {
			this.msg = "Only images are supported";
			return;
		}
		
		var reader = new FileReader();
		reader.readAsDataURL(event.target.files[0]);
		
		reader.onload = (_event) => {
			this.msg = "";
			this.url = reader.result; 
		}
	}

}
