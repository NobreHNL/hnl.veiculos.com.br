import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarcaComponent } from './marca/marca.component';
import { MarcaService } from './marca/marca.service';
import { ListMarcaComponent } from './list-marca/list-marca.component';
import { FotosModule } from '../components/fotos/fotos.module';

@NgModule({
  imports: [
    CommonModule,
    FotosModule      
  ],
  exports:[
    ListMarcaComponent
  ],
  declarations: [
    MarcaComponent,
    ListMarcaComponent
  ],
  providers:[
    MarcaService
  ]
})
export class MarcasModule { }
