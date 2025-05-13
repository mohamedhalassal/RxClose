import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { trigger, transition, animate, style } from '@angular/animations';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-register',
  imports: [ReactiveFormsModule, CommonModule, RouterLink],
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss',
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
export class RegisterComponent {
  registerForm!: FormGroup;
  constructor(private fb: FormBuilder) {}

  
  ngOnInit() {
    this.initializeForm();
  }

  initializeForm(){
    this.registerForm = this.fb.group({

      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(8)]],
    });
  }


  onSubmit() {
    if (this.registerForm.valid) {
      console.log('Form data:', this.registerForm.value);
      // Add your registration API call here
      this.registerForm.reset();
    }
  }

  get userName() { return this.registerForm.get('userName'); }
  get email() { return this.registerForm.get('email'); }
  get password() { return this.registerForm.get('password'); }
}
