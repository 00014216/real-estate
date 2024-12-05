import {NgModule} from '@angular/core'; 
import {RouterModule, Routes} from '@angular/router' 
import { PropertyFeatureFormComponent } from "./property-feature-form/property-feature-form.component"; 
import { PropertyFormComponent } from "./property-form/property-form.component"; 
import { PropertyListComponent } from "./property-list/property-list.component"; 
import { PropertyUpdateComponent } from './property-update/property-update.component';
import { PropertyDetailsComponent } from './property-details/property-details.component';
 
 
export const routes: Routes = [ 
    {path: '', component: PropertyListComponent}, 
    {path:'property-update/:id', component: PropertyUpdateComponent}, 
    {path: 'property-form', component: PropertyFormComponent},
    {path: 'property-feature-form', component: PropertyFeatureFormComponent},
    {path: 'property-form/:id', component: PropertyDetailsComponent} 
]; 
 @NgModule({ 
    imports: [RouterModule.forRoot(routes)], 
    exports: [RouterModule], 
 }) 
 
 export class AppRoutingModule {}