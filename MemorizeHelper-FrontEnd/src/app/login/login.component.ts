import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from '../../environments/environment';
var apiUrl = environment.apiUrl;
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private httpClient:HttpClient,private router: Router) { }
  
  
  

  ngOnInit() {
  }

  onFormSubmit(data) {

    var name=data.name;
 var password=data.password;
 //console.log("name"+name+" password"+password);
    console.log(data);
    var parameter = JSON.stringify({username:name, password:password});
  console.log("apiUrl"+apiUrl);
  const headers = new HttpHeaders().append('Content-Type' , 'application/json')
  var postd=this.httpClient.post(apiUrl+"/auth/login", parameter,{ headers: headers })

  .subscribe(
    (Data : any) => {
		
	
	
	localStorage.setItem('isLoggedIn', "true");
	
	localStorage.setItem('Username', Data.username);
	
   var token=JSON.stringify(Data);
   console.log("data"+token);
   this.router.navigateByUrl('/myprofile');
   }
,
   err =>
   {
    console.log("err"+JSON.stringify(err.statusText));
 if(JSON.stringify(err.statusText).indexOf("Unauthorized")!=-1){
     //alert("Unregistered User");
     document.getElementById("SIAnchor").textContent = "Invaild Username or password ,please click here to sign up! "; 
     document.getElementById("SIAnchor").style.color = "#ff0000";
     
   }
  }  
 
  )
}

    
    //this.router.navigateByUrl('/user');
  }

