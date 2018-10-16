import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FotosModule } from './components/fotos/fotos.module';
import { MarcasModule } from './marcas/marcas.module';
import { MarcaComponent } from './marcas/marca/marca.component';
import { ListMarcaComponent } from './marcas/list-marca/list-marca.component';
import { CommonModule } from '@angular/common';
import { CreateMarcaComponent } from './marcas/create-marca/create-marca.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
  ],
  imports: [
    CommonModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    FotosModule,
    MarcasModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'marcas', component: ListMarcaComponent },
      { path: 'marcas/create', component: CreateMarcaComponent },
      { path: 'marcas/marca/:id', component: MarcaComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
