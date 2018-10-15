import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-foto',
  templateUrl: './foto.component.html',
  styleUrls: ['./foto.component.css'],
  host:{
    '(click)': 'link($event.target)'
  },
})

export class FotoComponent {
  @Input() id='';
  @Input() nome='';
  @Input() imagem='';
  @Input() url='';
}
