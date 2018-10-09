import { Component, Inject, OnInit } from '@angular/core';
import { Marca } from '../marcas/marca/marca.interface';
import { MarcaService } from '../marcas/marca/marca.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public destaque: Destaque = new Destaque();
  public marcas: Marca[];  
  
  constructor(private service: MarcaService) {
    this.destaque.id = 0;
    this.destaque.nome = "As melhores Marcas";
    this.destaque.imagem = "./assets/images.jpg"    
  }
  
  ngOnInit(): void {
    this.service.listMarcas().subscribe(result => {
      this.marcas = result;
    }, error => console.error(error));
  }
}

class Destaque{
  id: number;
  nome: string;
  imagem: string;
}