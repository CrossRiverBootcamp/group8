import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateAccountComponent } from './create-account/create-account.component';
import { AccountInfoComponent } from './account-info/account-info.component';
import { MaterialModule } from '../material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { OperationsHistoryComponent } from './operations-history/operations-history.component';
import { AccoutHolderInfoComponent } from './accout-holder-info/accout-holder-info.component';
import { EmailVerificationDialogComponent } from './email-verification-dialog/email-verification-dialog.component';
import { DownloadAsPdfDialogComponent } from './download-as-pdf-dialog/download-as-pdf-dialog.component';

@NgModule({
  declarations: [CreateAccountComponent,AccountInfoComponent,OperationsHistoryComponent,AccoutHolderInfoComponent,EmailVerificationDialogComponent,DownloadAsPdfDialogComponent ],
  imports: [
    CommonModule,MaterialModule,ReactiveFormsModule,FormsModule
  ],
  exports:[]
})
export class AccountModule { }