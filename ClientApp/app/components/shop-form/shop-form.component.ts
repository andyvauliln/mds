import { ShopService } from './../../services/shop.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shop-form',
  templateUrl: './shop-form.component.html',
  styleUrls: ['./shop-form.component.css']
})
export class ShopFormComponent implements OnInit {

  //shops : any[];
  constructor(private shopService : ShopService) { }

  ngOnInit():void {

    this.shopService.getShops().subscribe(res => {
     // this.shops = res;
     // console.log(this.shops);
    });
    
    

    
    
  }



}
