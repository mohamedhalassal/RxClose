import { Component } from '@angular/core';
import { FormBuilder, Validators, ReactiveFormsModule, FormGroup } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { trigger, transition, animate, style } from '@angular/animations';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss',
  animations: [
    trigger('slideInOut', [
      transition(':enter', [
        style({ transform: 'translateX(100%)', opacity: 0 }),
        animate('300ms ease-in', style({ transform: 'translateX(0)', opacity: 1 }))
      ]),
      transition(':leave', [
        animate('300ms ease-out', style({ transform: 'translateX(-100%)', opacity: 0 }))
      ])
    ])
  ]
})
export class LoginComponent {
  loginForm!:FormGroup;

constructor(private router: Router, private fb : FormBuilder){}
navigateToSignUp() {
  this.router.navigate(['auth/signup']);
}
  ngOnInit(){
    this.initializeForm();
  }

  initializeForm(){
    this.loginForm = this.fb.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    })
  }

  onSubmit(){
    console.log(this.loginForm.value);
    this.loginForm.reset();
  }

  get email() { return this.loginForm.get('email'); }
  get password() { return this.loginForm.get('password'); }
}
