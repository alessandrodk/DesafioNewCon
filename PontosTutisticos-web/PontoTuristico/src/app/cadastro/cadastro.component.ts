import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { API_URL } from 'src/environments/environment';

import { Estados } from './models/estados';
import { PontoTuristico } from './models/PontoTuristico';
import { CadastroService } from './service/CadastroService';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {


  estados: Estados[] = [];
  PontoTuristicoForm!: FormGroup;
  cidade: any = '';
  pontoTuristicoModel:PontoTuristico = new PontoTuristico();
  constructor(private cadastroService: CadastroService, private fb: FormBuilder,) {

    this.PontoTuristicoForm = this.fb.group({
      nome: [''],
      estado: ['', Validators.required],
      cidade: ['', Validators.required],
      referencia: [''],
      descricao: [''],
    });
  }
  ngOnInit(): void {
    this.cadastroService.obterCidades().subscribe(
      result => this.estados = Object.assign(this.estados, result)
    )

  }

  cadastrarPontoTuristico() {
    var Objeto = Object.assign(this.pontoTuristicoModel, this.PontoTuristicoForm.value);
    
    this.cadastroService.adicionar(API_URL, Objeto).subscribe(
      result=> {
        alert('Ponto Turístico Cadastrado com sucesso!')
      },
      erro=> console.log(erro)
    );
    console.log(Objeto);
  }


  buscarCidade(event: any) {
    this.cidade = this.estados.find(x => x.id == event.value)?.nome;

    
  }
}
