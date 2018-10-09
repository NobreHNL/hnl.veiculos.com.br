import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public destaque: Destaque = new Destaque();
  public marcas: Marca[];  
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    
    http.get<Marca[]>(baseUrl + 'api/Marca/ListMarcas').subscribe(result => {
      this.marcas = result;
    }, error => console.error(error));
    
    this.destaque.id = 0;
    this.destaque.nome = "As melhores Marcas";
    this.destaque.imagem = "./assets/images.jpg"
  
  }
}

interface Marca {
  id: number;
  nome: string;
  imagem: string;
}

class Destaque{
  id: number;
  nome: string;
  imagem: string;
}