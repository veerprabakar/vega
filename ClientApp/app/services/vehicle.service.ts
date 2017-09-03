import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {

  constructor(private http: Http) { }

  getMakes(){
      return this.http.get('/api/vehicleModel/makes')
                    .map(res => res.json());   
  }

  getFeatures(){
      return this.http.get('/api/vehicleModel/features')
            .map(res => res.json());
  }

  create(vehicle: any){
    return this.http.post('/api/vehicle', vehicle)
                    .map(res => res.json());
  }
}
