import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroComponent } from './cadastro/cadastro.component';
import { HomeComponent } from './home/home.component';
import { VisualizarComponent } from './visualizar/visualizar.component';

const routes: Routes = [ {path:'', component:HomeComponent}, {path:'cadastro', component:CadastroComponent},{path:'visualizar/:id', component:VisualizarComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
