import { Component, OnInit } from '@angular/core';
import { MarcaService } from '../marca.service';
import { ActivatedRoute, Router } from '@angular/router';
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
  pId: string;
  constructor(private service: MarcaService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.pId = this.route.snapshot.paramMap.get('id');

    this.service.getMarcaById(this.pId).subscribe(result => {
      this.marca = result;
    }, error => console.error(error));

    this.service.GetModeloByMarcaId(this.pId).subscribe(result => {
      this.modelos = result;
    }, error => console.error(error));
  }

  removeMarca(){
    this.service.removeMarca(this.pId).subscribe(result => {
      this.router.navigate(['/marcas']);
      console.log(result);
    }, error => console.error(error));
  }
}
