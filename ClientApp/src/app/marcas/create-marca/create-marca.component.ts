import { Component, Input, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { MarcaService } from "../marca.service";
import { Router } from "@angular/router";

@Component({
    selector: 'app-create',
    templateUrl: 'create-marca.component.html',
    styleUrls: ['./../marca/marcas.component.css']
})
export class CreateMarcaComponent implements OnInit{
    @Input() title: string = "Adicionar Marcas"
    
    marcaForm: FormGroup;
    file: File;
    preview: string;

    constructor(private service :MarcaService, private formBuilder: FormBuilder, private router: Router){ }
    
    ngOnInit(){
        this.marcaForm = this.formBuilder.group({
            NOME: ['', Validators.required],
            IMAGEM: ['', Validators.required]
        });
    }

    handleFile(file: File){
        this.file = file;
        const reader = new FileReader;
        reader.onload = (event:any) => this.preview = event.target.result
        reader.readAsDataURL(this.file);

    }

    createMarca(){
        const marca = this.marcaForm.getRawValue();
        marca.IMAGEM = this.preview;
        this.service.createMarca(marca).subscribe(result => {
            console.log(result);
            this.router.navigate(['']);
          }, error => console.error(error));
    }

}
