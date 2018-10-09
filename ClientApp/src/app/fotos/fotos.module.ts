import { NgModule } from "@angular/core";
import { FotoComponent } from "./foto/foto.component";
import { CommonModule } from "@angular/common";

@NgModule({
    declarations: [FotoComponent],
    exports: [FotoComponent],
    imports: [CommonModule]
})

export class FotosModule{

}