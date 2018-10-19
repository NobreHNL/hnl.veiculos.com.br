import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarcaComponent } from './marca/marca.component';
import { MarcaService } from './marca.service';
import { ListMarcaComponent } from './list-marca/list-marca.component';
import { FotosModule } from '../components/fotos/fotos.module';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { CreateMarcaComponent } from './create-marca/create-marca.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FotosModule,
    CommonModule,
    ReactiveFormsModule,
    FormsModule      
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
