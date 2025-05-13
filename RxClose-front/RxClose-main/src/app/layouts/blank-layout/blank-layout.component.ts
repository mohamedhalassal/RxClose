import { Component } from '@angular/core';
import { FooterComponent } from '../../components/footer/footer.component';
import { NavBlankComponent } from '../../components/nav-blank/nav-blank.component';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-blank-layout',
  imports: [FooterComponent, NavBlankComponent, RouterOutlet],
  templateUrl: './blank-layout.component.html',
  styleUrl: './blank-layout.component.scss'
})
export class BlankLayoutComponent {

}
