import { Component, OnInit } from '@angular/core';
import { Property, PropertyService } from '../services/property.service';
import { CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.css'],
  imports: [ CommonModule, MatTableModule, MatButtonModule, RouterModule, MatIconModule ]
})
export class PropertyListComponent implements OnInit {
  properties: Property[] = [];
  displayedColumns: string[] = [
    'propertyID',
    'title',
    'price',
    'location',
    'propertyType',
    'bedrooms',
    'bathrooms',
    'squareFeet',
    'dateListed',
    'actions'
  ];

  constructor(private propertyService: PropertyService) {}

  ngOnInit(): void {
    this.propertyService.getProperties().subscribe((data) => {
      this.properties = data;
    });
  }
}
