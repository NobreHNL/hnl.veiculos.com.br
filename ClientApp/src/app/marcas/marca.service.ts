import { Inject, Injectable } from "@angular/core";
import { HttpClient, HttpRequest } from "@angular/common/http";
import { Marca } from "./marca/marca.interface";
import { Modelo } from "./marca/modelo.interface";


@Injectable()
export class MarcaService{
    constructor(private http: HttpClient,  @Inject('BASE_URL') private BASE_URL: string){}

    listMarcas(){
        return this.http.get<Marca[]>(this.BASE_URL + 'api/Marca/ListMarcas');
    }

    getMarcaById(pId: string){
        return this.http.get<Marca>(this.BASE_URL + 'api/Marca/GetMarcaById?pId=' + pId);
    }

    createMarca(marca: Marca){
        return this.http.post<Marca>(this.BASE_URL + 'api/Marca/CreateMarca', marca);
    }

    GetModeloByMarcaId(pId: string){
        return this.http.get<Modelo[]>(this.BASE_URL + 'api/Modelo/GetModeloByMarcaId?pId=' + pId);
    }

    removeMarca(pId: string): any {
        return this.http.delete(this.BASE_URL + 'api/Marca/DeleteMarca?pId=' + pId);
      }
}