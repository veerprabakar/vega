import { Component, OnInit } from '@angular/core';
import { VehicleService } from './../../services/vehicle.service';
import { ToastyService } from "ng2-toasty";
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/Observable/forkJoin';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models: any[];
  features: any[];
  
  vehicle: any = {
    features: [],
    contact:{}
  };
  index: any;

  constructor(
    private vehicleService: VehicleService,
    private toastyService: ToastyService
  ) { }

  ngOnInit() {

    //RxJs Observable for calling the services
    Observable.forkJoin([
        this.vehicleService.getMakes(),
        this.vehicleService.getFeatures()
    ]).subscribe(data => { 
        this.makes = data[0];
        this.features = data[1];
    }, err => {
      if(err.status == 404)
        console.log(err);
        //this.router.navigate(['/home']); //not working for some reson
    });

    // this.vehicleService.getMakes().subscribe(makes =>
    //   this.makes = makes);

    //  this.vehicleService.getFeatures().subscribe(features =>
    //    this.features = features);
  }

  onMakeChange() {
    var selectedMake = this.makes.find(m => m.id == this.vehicle.makeId);
    this.models = selectedMake?selectedMake.models:[];
    delete this.vehicle.modelId;
  }

  onFeatureToggle(featureName: any, $event: any) {
    if($event.target.checked)
      this.vehicle.features.push(featureName);
    else{
      this.index = this.vehicle.features.indexOf(featureName);
      this.vehicle.features.splice(this.index, 1);
    }
  }

  submit() {
      this.vehicleService.create(this.vehicle)
          .subscribe(
            x => console.log(x),
            err => {
              this.toastyService.error({
                title: 'Error',
                msg: 'Dont worry!.. This is a test error message from tosty !.',
                theme: 'bootstrap',
                showClose: true,
                timeout: 5000
              });
            }
          );
    }
}

