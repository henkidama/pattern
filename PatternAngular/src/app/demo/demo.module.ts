import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DashboardService } from '../dashboard.service';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    DashboardComponent,
  ],
  imports: [
    CommonModule, FormsModule
  ],
  exports: [DashboardComponent],
  providers: [DashboardService]
})
export class AdminModule { }
