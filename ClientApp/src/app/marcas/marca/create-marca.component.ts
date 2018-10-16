import { Component, Input } from "@angular/core";

@Component({
    selector: 'app-create',
    templateUrl: 'create-marca.component.html',
    styleUrls: ['./marca.component.css']
})
export class CreateMarcaComponent{
    @Input() title: string = "Adicionar Marcas"
    
}