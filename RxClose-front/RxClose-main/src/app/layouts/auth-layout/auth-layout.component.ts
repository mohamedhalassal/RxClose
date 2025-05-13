import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavAuthComponent } from '../../components/nav-auth/nav-auth.component';
import { FooterComponent } from '../../components/footer/footer.component';
import { ChatWidgetComponent } from '../../shared/components/chat-widget/chat-widget.component';

@Component({
  selector: 'app-auth-layout',
  imports: [RouterOutlet, NavAuthComponent, FooterComponent, ChatWidgetComponent],
  templateUrl: './auth-layout.component.html',
  styleUrl: './auth-layout.component.scss'
})
export class AuthLayoutComponent {

}
