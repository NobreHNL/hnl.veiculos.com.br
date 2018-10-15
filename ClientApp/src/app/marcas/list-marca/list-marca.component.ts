import { Component, OnInit, Input } from '@angular/core';
import { Marca } from '../marca/marca.interface';
import { MarcaService } from '../marca/marca.service';

@Component({
  selector: 'app-list-marca',
  templateUrl: './list-marca.component.html',
  styleUrls: ['./list-marca.component.css']
})
export class ListMarcaComponent implements OnInit {
  public marcas: Marca[];
  @Input() title:string = 'Minhas Marcas';   
  @Input() action_add:boolean = true;

  constructor(private service: MarcaService) { }

  ngOnInit() {
    this.service.listMarcas().subscribe(result => {
      this.marcas = result;
    }, error => console.error(error));
  }

}
