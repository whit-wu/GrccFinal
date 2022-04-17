import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-order-pizza',
  templateUrl: './order-pizza.component.html',
  styleUrls: ['./order-pizza.component.css']
})
export class OrderPizzaComponent implements OnInit {

  pizzas: Pizza[] = [];
  customerOrder = new CustomerOrder();
  inputCustomerInfo: boolean = false;
  constructor() { }

  ngOnInit(): void {
  }

  addToPizzaOrder() {
    console.log('adding pizza');
    var pizza = new Pizza();
    this.pizzas.push(pizza);
  }

  removeFromPizzaOrder(event, index) {
    if (index > -1) {
      this.pizzas.splice(index, 1);
    }
  }

  proceedToCustomerInfo() {
    this.inputCustomerInfo = true;
  }

  submit() {
    this.customerOrder.pizzas = this.pizzas;
    console.log(this.customerOrder);
  }

}


class CustomerOrder {
  firstName: string;
  lastName: string;
  middleInitial: string;
  addr1: string;
  addr2: string;
  aptNum: string;
  state: string;
  zip: string;
  email: string;
  ccNum: string;
  phoneNum: string;
  pizzas: Pizza[];
}

class Pizza {
  crustType: CrustType;
  crustFlavor: CrustFlavor;
  sauceType: SauceType;
  hasExtraCheese: boolean;
  hasPepperoni: boolean;
  hasSasuage: boolean;
  hasOlives: boolean;
  hasChicken: boolean;
  hasOnions: boolean;
  hasPineapple: boolean;

}

enum CrustType {
  HandTossed,
  Pan,
  Thin,
  Cauliflower
}

enum SauceType {
  Marinara,
  BBQ,
  Pesto
}

enum CrustFlavor {
  Plain,
  GarlicButter,
  Ranch,
  Cajun
}

