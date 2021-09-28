import { PositionComponent } from './position/position.component';
import { EmployeeComponent } from './employee/employee.component';
import { AppComponent } from './app.component';
import { DepartmentComponent } from './department/department.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'department', component: DepartmentComponent},
  {path: 'employee', component: EmployeeComponent},
  {path: 'position', component: PositionComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
