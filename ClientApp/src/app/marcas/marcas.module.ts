import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarcaComponent } from './marca/marca.component';
import { MarcaService } from './marca/marca.service';
import { FotoComponent } from '../fotos/foto/foto.component';
import { FotosModule } from '../fotos/fotos.module';

@NgModule({
  imports: [
    CommonModule,
    FotosModule  
  ],
  declarations: [
    MarcaComponent    
  ],
  providers:[
    MarcaService
  ]
})
export class MarcasModule { }
