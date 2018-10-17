import { Inject, Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Marca } from "./marca.interface";
import { Modelo } from "./modelo.interface";


@Injectable()
export class MarcaService{

    constructor(private http: HttpClient,  @Inject('BASE_URL') private BASE_URL: string){}

    listMarcas(){
        return this.http.get<Marca[]>(this.BASE_URL + 'api/Marca/ListMarcas');
    }

    getMarcaById(pId: number){
        return this.http.get<Marca>(this.BASE_URL + 'api/Marca/GetMarcaById?pId=' + pId);
    }

    createMarca(marca: Marca){
        const formData = new FormData();
        formData.append('nome', marca.nome);
        formData.append('imagem', marca.imagem);
        return this.http.post(this.BASE_URL + 'api/Marca/CreateMarca', formData);
    }

    GetModeloByMarcaId(pId: number){
        return this.http.get<Modelo[]>(this.BASE_URL + 'api/Modelo/GetModeloByMarcaId?pId=' + pId);
    }
}