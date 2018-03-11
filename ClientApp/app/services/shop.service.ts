import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class ShopService {

  constructor(private http: Http) {

   }

   getShops(){
     return this.http.get('/api/shops').map(res => res.json());
   }

}
