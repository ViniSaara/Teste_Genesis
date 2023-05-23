import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TelaCdbComponent } from './tela-cdb/tela-cdb.component';
import { CdbService } from './cdb.service';

@NgModule({
  declarations: [
    AppComponent,
    TelaCdbComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [HttpClientModule, CdbService],
  bootstrap: [AppComponent]
})
export class AppModule { }
