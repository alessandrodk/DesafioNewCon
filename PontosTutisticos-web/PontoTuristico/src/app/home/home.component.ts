import { Component, OnInit } from '@angular/core';
import { Estados } from '../cadastro/models/estados';
import { CadastroService } from '../cadastro/service/CadastroService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  page: number = 1;
  count: number = 0;
  tableSize: number = 2;
  search: string = "";

  tableSizes: any[] = [];

  constructor(private visualizarService: CadastroService) {
    this.consulta();
  }

  consulta() {
    this.visualizarService.obterTodos().subscribe(
      result => {

        result.forEach(x => {
          this.tableSizes.push({id: x.id, nome: x.nome, descricao: x.descricao });
        })

        console.log(this.tableSizes)
      }
    )
  }
  filtrar() {
    if (this.search != '') {
      this.visualizarService.obterPorNome(this.search.toString()).subscribe(
        result => {
          this.tableSizes = [];
          result.forEach(x => {
            this.tableSizes.push({id: x.id, nome: x.nome, descricao: x.descricao });

          })
        }
      )
    } else {

      this.tableSizes = [];

      this.consulta();
    }

  }

  ngOnInit(): void {



  }

  onTableDataChange(event: any) {
    this.page = event;

  }
  onTableSizeChange(event: any): void {
    this.tableSize = event.target.value;
    this.page = 1;

  }
}
