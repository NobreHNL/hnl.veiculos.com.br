import { NgModule } from "@angular/core";
import { FotoComponent } from "./foto/foto.component";
import { CommonModule } from "@angular/common";
import { RouterModule } from "@angular/router";

@NgModule({
    declarations: [FotoComponent],
    exports: [FotoComponent],
    imports: [CommonModule, RouterModule]
})

export class FotosModule{

}