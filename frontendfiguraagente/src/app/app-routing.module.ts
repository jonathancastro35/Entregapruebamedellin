import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { FiguraagenteComponent } from './Components/figuraagente/figuraagente.component';
import { FiguraagentecComponent } from './Components/figuraagentec/figuraagentec.component';
import { TendenciacentralComponent } from './Components/tendenciacentral/tendenciacentral.component';

const routes: Routes = [
  { path:'', pathMatch: 'full', redirectTo: 'listarfiguraescalera'},
  { path: 'listarfiguraescalera', component:FiguraagenteComponent},
  { path: 'listarfiguraescaleraagentec', component:FiguraagentecComponent },
  { path: 'tendenciacentral', component:TendenciacentralComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
