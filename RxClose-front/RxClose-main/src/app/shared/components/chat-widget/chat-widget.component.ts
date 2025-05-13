import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-chat-widget',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './chat-widget.component.html',
  styleUrl: './chat-widget.component.scss'
})
export class ChatWidgetComponent {
  isOpen = false;

  toggleChat() {
    this.isOpen = !this.isOpen;
  }
}
