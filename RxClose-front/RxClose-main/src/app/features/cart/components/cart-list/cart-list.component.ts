import { Component } from '@angular/core';
import { CartItemComponent } from '../cart-item/cart-item.component';
import { CartSimilarsingsComponent } from '../cart-similarsings/cart-similarsings.component';

@Component({
  selector: 'app-cart-list',
  imports: [CartItemComponent,CartSimilarsingsComponent],
  templateUrl: './cart-list.component.html',
  styleUrl: './cart-list.component.scss'
})
export class CartListComponent {

}
