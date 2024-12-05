import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Property {
  propertyID: number;
  title: string;
  description: string;
  price: number;
  location: string;
  propertyType: string;
  bedrooms?: number;
  bathrooms?: number;
  squareFeet?: number;
  dateListed: Date;
}



@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  private apiUrl = 'https://localhost:7245/api/Property'; 

  constructor(private http: HttpClient) {}

  getProperties(): Observable<Property[]> {
    return this.http.get<Property[]>(this.apiUrl);
  }

  addProperty(property: Property): Observable<Property> {
    return this.http.post<Property>(this.apiUrl, property);
  }
}

