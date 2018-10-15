import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public destaque: Destaque = new Destaque();
  
  
  constructor() {
    this.destaque.id = 0;
    this.destaque.nome = "As melhores Marcas";
    this.destaque.imagem = "./assets/images.jpg"    
  }
  
  ngOnInit(): void {
    
  }
}

class Destaque{
  id: number;
  nome: string;
  imagem: string;
}