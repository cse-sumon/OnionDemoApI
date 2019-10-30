import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminpanelComponent } from './adminpanel/adminpanel.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CourseComponent } from './course/course.component';
import { ProductComponent } from './product/product.component';


const routes: Routes = [

  { path: '', redirectTo:'dashboard',pathMatch:'full'},
  {path:'dashboard',component:HomeComponent},
  {path:'course', component:CourseComponent },
  {path:'product', component:ProductComponent},



   
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
