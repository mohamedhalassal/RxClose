import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { BlankLayoutComponent } from './layouts/blank-layout/blank-layout.component';
import { HomeComponent } from './components/home/home.component';
import { MostsearchListComponent } from './features/searchpage/components/mostsearch-list/mostsearch-list.component';
import { ContactpageComponent } from './features/contactuspage/contactpage/contactpage.component';
import { CartListComponent } from './features/cart/components/cart-list/cart-list.component';
import { CaregorylistComponent } from './features/category/caregorylist/caregorylist.component';
import { ConvertAiComponent } from './features/ai/convert-ai/convert-ai.component';
import { ProductDetailsComponent } from './features/product-details/product-details.component';



import { ProfileComponent } from './profile/profile.component';

export const routes: Routes = [
  { path: '', redirectTo: 'auth/home', pathMatch: 'full' },
  { path: 'signin', component: LoginComponent },
  { path: 'signup', component: RegisterComponent },
  
  {
    path: 'auth',
    component: AuthLayoutComponent,
    children: [
      { path: 'home', component: HomeComponent },
      { path: 'search', component: MostsearchListComponent },
      { path: 'Contactus', component: ContactpageComponent },
      { path: 'cart', component: CartListComponent },
      { path: 'category', component: CaregorylistComponent, children: [
        { path: '', component: CaregorylistComponent },
        { path: 'drugs', component: CaregorylistComponent },
        { path: 'medical-supplies', component: CaregorylistComponent },
        { path: 'fitness-nutrition', component: CaregorylistComponent },
        { path: 'organic', component: CaregorylistComponent },
        { path: 'home-care', component: CaregorylistComponent },
      ]},
      { path: 'product-details', component: ProductDetailsComponent },
      { path: 'convert', component: ConvertAiComponent },

      // ✅ أهو هنا بنضيف البروفايل
      { path: 'profile', component: ProfileComponent },
    ]
  },

  { path: 'blank', component: BlankLayoutComponent, children: [] },
  { path: '**', component: NotfoundComponent }
];
