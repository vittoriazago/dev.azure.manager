import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NgxMaskModule } from 'ngx-mask';
import { NgxCaptchaModule } from 'ngx-captcha';
import { NgxLoadingModule } from 'ngx-loading';
import { NavComponent } from './nav/nav.component';
import { DateTimeFormatPipePipe } from './_helps/DateTimeFormatPipe.pipe';
import { SafePipe } from './util/pipe/safe.pipe';
import { ReleasesLoginComponent } from './releases/releases-login/releases-login.component';
import { FormFieldErrorComponent } from './_shared/form-field-error/form-field-error.component';
import { ReleasesComponent } from './releases/releases.component';
import { TituloComponent } from './_shared/titulo/titulo.component';
import { BsDropdownModule, BsDatepickerModule, TooltipModule, ModalModule, TabsModule } from 'ngx-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    TituloComponent,
    ReleasesComponent,
    FormFieldErrorComponent,
    DateTimeFormatPipePipe,
    SafePipe,
    ReleasesLoginComponent
  ],
  imports: [
    BrowserModule,
    BsDropdownModule.forRoot(),
    BsDatepickerModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    TabsModule.forRoot(),
    NgxMaskModule.forRoot(),
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
       timeOut: 10000,
       positionClass: 'toast-bottom-right',
       preventDuplicates: true
    })
  ],
  providers: [],
  bootstrap: [AppComponent],
  exports: [
    FormFieldErrorComponent,
  ],
  entryComponents: [
    ReleasesLoginComponent
  ]
})
export class AppModule { }
