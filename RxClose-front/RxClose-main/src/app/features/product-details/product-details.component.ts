import { Component, PLATFORM_ID } from '@angular/core';
import { CommonModule, isPlatformBrowser } from '@angular/common';
import { RouterLink } from '@angular/router';
import { interval, Subscription } from 'rxjs';

@Component({
  selector: 'app-product-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-details.component.html',
  styleUrl: './product-details.component.scss'
})
export class ProductDetailsComponent {
  product = {
    name: 'VIBRAMYCINE',
    description: 'Use under medical prescription only Store in dry place',
    price: 50.00,
    code: '1919',
    inStock: true,
    quantity: 1
  };

  decreaseQuantity() {
    if (this.product.quantity > 1) {
      this.product.quantity--;
    }
  }

  increaseQuantity() {
    this.product.quantity++;
  }

  relatedProducts = [
    {
      name: 'Pandol Joint',
      description: 'Analgesic for joint pain',
      image: 'assets/images/img1.jpeg'
    },
    {
      name: 'Siimmss',
      description: 'Slimness Appetite Control',
      image: 'assets/images/img2.jpeg'
    },
    {
      name: 'Doliprane',
      description: 'To get rid of headaches',
      image: 'assets/images/img8.jpeg'
    },
    {
      name: 'Dettol',
      description: 'Dettol Nourish Handwash for effective Germ Protection',
      image: 'assets/images/img4.jpeg'
    },
    {
      name: 'Colgate Toothpaste',
      description: 'Daily freshness and cavity protection for a healthy smile',
      image: 'assets/images/img5.jpeg'
    }
  ];

  private autoScrollSubscription?: Subscription;
  private scrollAmount = 0;
  private readonly SCROLL_INTERVAL = 3000; // 3 seconds

  ngOnInit() {
    this.startAutoScroll();
  }

  ngOnDestroy() {
    this.stopAutoScroll();
  }

  startAutoScroll() {
    this.autoScrollSubscription = interval(this.SCROLL_INTERVAL).subscribe(() => {
      this.scrollRight();
    });
  }

  stopAutoScroll() {
    if (this.autoScrollSubscription) {
      this.autoScrollSubscription.unsubscribe();
    }
  }

  scrollLeft() {
    if(isPlatformBrowser(PLATFORM_ID)) {
      const container = document.querySelector('.related-products-slider');
      if (container) {
        this.scrollAmount -= 200;
        container.scrollTo({
        left: this.scrollAmount,
        behavior: 'smooth'
      });
      
      // Reset to end if reached start
      if (this.scrollAmount < 0) {
        this.scrollAmount = container.scrollWidth - container.clientWidth;
        container.scrollTo({
          left: this.scrollAmount,
          behavior: 'smooth'
        });
      }
    }
  }
  }

  scrollRight() {
    const container = document.querySelector('.related-products-slider');
    if (container) {
      this.scrollAmount += 200;
      
      // Reset to start if reached end
      if (this.scrollAmount >= container.scrollWidth) {
        this.scrollAmount = 0;
      }
      
      container.scrollTo({
        left: this.scrollAmount,
        behavior: 'smooth'
      });
    }
  }
}
