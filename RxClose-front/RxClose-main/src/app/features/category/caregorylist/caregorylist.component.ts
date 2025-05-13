import { Component } from '@angular/core';
import { SearchInputComponent } from "../../searchpage/components/search-input/search-input.component";
import { CaregorycartComponent } from "../caregorycart/caregorycart.component";
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-caregorylist',
  imports: [SearchInputComponent, CaregorycartComponent],
  templateUrl: './caregorylist.component.html',
  styleUrl: './caregorylist.component.scss'
})
export class CaregorylistComponent {

}
