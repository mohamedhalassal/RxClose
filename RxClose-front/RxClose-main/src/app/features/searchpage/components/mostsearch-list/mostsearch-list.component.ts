import { Component } from '@angular/core';
import { SearchInputComponent } from "../search-input/search-input.component";
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-mostsearch-list',
  imports: [SearchInputComponent,RouterLink],
  templateUrl: './mostsearch-list.component.html',
  styleUrl: './mostsearch-list.component.scss'
})
export class MostsearchListComponent {

}
