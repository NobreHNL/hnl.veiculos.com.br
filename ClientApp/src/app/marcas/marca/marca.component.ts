import { Component, OnInit } from '@angular/core';
import { MarcaService } from './marca.service';
import { ActivatedRoute } from '@angular/router';
import { Marca } from './marca.interface';

@Component({
  selector: 'app-marca',
  templateUrl: './marca.component.html',
  styleUrls: ['./marca.component.css']
})
export class MarcaComponent implements OnInit {
  marca: Marca;
  pId: number;
  constructor(private service: MarcaService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.pId = parseInt(this.route.snapshot.paramMap.get('id'));

    this.service.getMarcaById(this.pId).subscribe(result => {
      this.marca = result;
      console.log(this.marca);
    }, error => console.error(error));
  }

}
