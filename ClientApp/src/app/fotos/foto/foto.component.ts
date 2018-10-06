import { Component, Inject, Input } from '@angular/core';

@Component({
  selector: 'app-foto',
  templateUrl: './foto.component.html'
})
export class FotoComponent {
  @Input() id='';
  @Input() nome='';
  @Input() imagem='';
}
