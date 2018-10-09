import { Component, Inject, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-foto',
  templateUrl: './foto.component.html',
  host:{
    '(click)': 'link($event.target)'
  },
})

export class FotoComponent {
  @Input() id='';
  @Input() nome='';
  @Input() imagem='';
  @Input() url='';

  link(target){
    
  }

}
