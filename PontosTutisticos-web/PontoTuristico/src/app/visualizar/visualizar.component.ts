import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PontoTuristico } from '../cadastro/models/PontoTuristico';
import { VizualizarService } from './service/visualizarService';


@Component({
  selector: 'app-visualizar',
  templateUrl: './visualizar.component.html',
  styleUrls: ['./visualizar.component.css'],
  providers:[VizualizarService]
})


export class VisualizarComponent implements OnInit {

  pontoTuristicoModel:any ;
  estados: any;
  nomeEstado:string = '';
  public id: number = 0;
  constructor(private visualizarService:VizualizarService,   private route: ActivatedRoute) { 
    this.route.params.subscribe((result) => (this.id = result['id']));
  }

  ngOnInit(): void {

    this.visualizarService.obterPorID(this.id).subscribe(
      result=> {
        this.pontoTuristicoModel = Object.assign({}, result);

        this.visualizarService.obterCidades(this.pontoTuristicoModel.estado).subscribe(
          elemet=> {
              this.estados = Object.assign({}, elemet);;
              this.nomeEstado = this.estados.sigla;
          }
        )
      }
    );

    // console.log(this.pontoTuristicoModel.);
    


    

   

    
  }

}
