import { Component, OnInit } from '@angular/core';
import { MarcaService } from './marca.service';
import { ActivatedRoute } from '@angular/router';
import { Marca} from './marca.interface';
import { Modelo } from './modelo.interface';

@Component({
  selector: 'app-marca',
  templateUrl: './marca.component.html',
  styleUrls: ['./../marcas.component.css']
})
export class MarcaComponent implements OnInit {
  marca: Marca;
  modelos: Modelo[];
  pId: number;
  constructor(private service: MarcaService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.pId = parseInt(this.route.snapshot.paramMap.get('id'));

    this.service.getMarcaById(this.pId).subscribe(result => {
      this.marca = result;
    }, error => console.error(error));

    this.service.GetModeloByMarcaId(this.pId).subscribe(result => {
      this.modelos = result;
    }, error => console.error(error));
  }

}
