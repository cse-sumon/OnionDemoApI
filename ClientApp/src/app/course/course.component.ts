import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {
courses:any[];


  constructor(private http:HttpClient) { }

  ngOnInit() {
    var res = this.http.get('https://localhost:44378/api/course').subscribe(
      res => {
        this.courses=<any[]>res;
      },
      error => {
        console.log(error);
      }
    );
  }


}
