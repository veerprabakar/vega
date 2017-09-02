import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {

  constructor(private http: Http) { }

  getMakes(){
      return this.http.get('/api/vehicle/makes')
                    .map(res => res.json());   
  }

  getFeatures(){
      return this.http.get('/api/vehicle/features')
            .map(res => res.json());
  }
}
