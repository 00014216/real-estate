import { bootstrapApplication } from '@angular/platform-browser'; 
import { HttpClientModule } from '@angular/common/http';  
import { importProvidersFrom } from '@angular/core'; 
import { AppComponent } from './app/app.component'; 
import { routes } from './app/app.routes'; 
import { provideRouter } from '@angular/router'; 
 
bootstrapApplication(AppComponent, { 
  providers: [ 
    provideRouter(routes), 
    importProvidersFrom(HttpClientModule), 
  ], 
}).catch((err) => console.error(err));