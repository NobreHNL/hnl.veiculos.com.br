import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public marcas: Marca[];
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Marca[]>(baseUrl + 'api/Marca/ListMarcas').subscribe(result => {
      this.marcas = result;
    }, error => console.error(error));
  }
}

interface Marca {
  id: number;
  nome: string;
  imagem: string;
}
