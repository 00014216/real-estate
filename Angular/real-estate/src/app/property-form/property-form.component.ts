import { Component } from '@angular/core';
import { PropertyService } from '../services/property.service';
import { Property } from '../services/property.service';  // Import the Property interface
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-property-form',
  templateUrl: './property-form.component.html',
  styleUrls: ['./property-form.component.css'],
  imports: [FormsModule]
})
export class PropertyFormComponent {
  newProperty: Property = {
    propertyID: 0,   // Initialize with a default value
    title: '',
    description: '',
    price: 0,
    location: '',
    propertyType: '',
    bathrooms: 0,
    bedrooms: 0,
    squareFeet: 0,
    dateListed: new Date(),
  };

  constructor(private propertyService: PropertyService) {}

  addProperty(): void {
    this.propertyService.addProperty(this.newProperty).subscribe({
      next: (response) => {
        console.log('Property added successfully', response);
        this.resetForm();  // Optionally reset the form after adding
      },
      error: (err) => {
        console.error('Error adding property', err);
      }
    });
  }

  resetForm(): void {
    this.newProperty = {
      propertyID: 0,
      title: '',
      description: '',
      price: 0,
      location: '',
      propertyType: '',
      bathrooms: 0,
    bedrooms: 0,
    squareFeet: 0,
      dateListed: new Date(),
    };
  }
}
