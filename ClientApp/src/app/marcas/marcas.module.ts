import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarcaComponent } from './marca/marca.component';
import { MarcaService } from './marca/marca.service';
import { ListMarcaComponent } from './list-marca/list-marca.component';
import { FotosModule } from '../components/fotos/fotos.module';
import { CreateMarcaComponent } from './marca/create-marca.component';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FotosModule      
  ],
  exports:[
    ListMarcaComponent
  ],
  declarations: [
    MarcaComponent,
    ListMarcaComponent,
    CreateMarcaComponent
  ],
  providers:[
    MarcaService
  ]
})
export class MarcasModule { }
