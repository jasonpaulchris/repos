import { Component} from '@angular/core';
import { Http } from "@angular/http";

@Component({
    selector: 'orders',
    template: require('./orders.component.html')
})

export class OrdersComponent {   
    public order: Orders[] = [];
    myName: string;
    constructor(http: Http) {
        this.myName = "Shanu";
        http.get('/api/OrdersAPIController/Orders').subscribe(result => {
            this.order = result.json();
        });
    }
}
export interface Orders {
    Id: number;
    FirstName: string;
    LastName: string;
    CustomerID: number;
    CustomerAddress: string;
    HasTipped: boolean;
    OrderAmount: number;
    RestaurantName: string;
    RestaurantAddress: string;
    TippingHistory: number;
    OrderTime: Date;
} 