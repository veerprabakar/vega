import * as Raven from 'raven-js';
import { AppErrorHandler } from './app.error.handler';
import { ErrorHandler } from '@angular/core';
//core
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { ToastyModule } from 'ng2-toasty';

//componenets
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { VehicleFormComponent } from './components/vehicle-form/vehicle-form.component';

//services
import { VehicleService } from './services/vehicle.service';
import { FileUploadComponent } from './components/file-upload/file-upload.component';
import { FileDropDirective, FileSelectDirective } from 'ng2-file-upload';

Raven.config('https://627eb835e9d541098a3f5d04a9f3693b@sentry.io/230334').install();

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        VehicleFormComponent,
        FileUploadComponent,    
        FileDropDirective,
        FileSelectDirective
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'vehicle/new', component: VehicleFormComponent },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'file-upload', component: FileUploadComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        ToastyModule.forRoot(),
    ],
    providers: [
        VehicleService,
        { provide: ErrorHandler, useClass: AppErrorHandler }
    ]
})
export class AppModuleShared {
}
