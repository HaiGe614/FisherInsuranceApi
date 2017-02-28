import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import 'rxjs/Rx';

// import our application component
import { HomeComponent } from './components/home/home.components';
import { AppComponent } from './app.components';
import{NavBarComponent} from './components/navbar/navbar.component'

@NgModule({
    declarations: [
         AppComponent,
         HomeComponent,
         NavBarComponent
         ],
    imports: [
        BrowserModule,
        HttpModule 
        ], 
    providers: [
        ],
    bootstrap: [
         AppComponent
         ], }) 
export class AppModule { }