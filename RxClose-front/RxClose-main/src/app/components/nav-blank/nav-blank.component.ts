import { Component, PLATFORM_ID } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { isPlatformBrowser } from '@angular/common';

@Component({
  selector: 'app-nav-blank',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './nav-blank.component.html',
  styleUrl: './nav-blank.component.scss'
})
export class NavBlankComponent {
  // profileImage: any = '';
  // constructor(private _router: Router, private _authService: AuthService) {
  //   this._router.events.subscribe(() => this.closeNavbar());
  // }


  // logout() {
  //   this._authService.logout().subscribe(() => this._router.navigate(['/']));
  // }


  // closeNavbar() {
  //   let navbarCollapse: any;
  //   if(isPlatformBrowser(PLATFORM_ID)){
  //    navbarCollapse = document.querySelector('.navbar-collapse');
  //   }
  //   if (navbarCollapse) {
  //     navbarCollapse.classList.remove('show');
  //   }
  // }

  // ngOnInit(): void {
  //   if(typeof localStorage !== undefined){
  //     this.profileImage = this._authService.getUserData().imagePath;
  //   }
  // }


  // openProfilePage(){
  //   this._router.navigate([`/user-profile/${this._authService.getUserData().id}`]);
  //   this.closeNavbar();
  // }
}
