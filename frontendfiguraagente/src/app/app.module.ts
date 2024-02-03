import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FigurasagentesService } from './Services/figurasagentes.service';
import { FiguraagenteComponent } from './Components/figuraagente/figuraagente.component';
import { FiguraagentecComponent } from './Components/figuraagentec/figuraagentec.component';
import { ComponentsComponent } from './components/components.component';
import { TendenciacentralComponent } from './Components/tendenciacentral/tendenciacentral.component';

@NgModule({
  declarations: [
    AppComponent,
    FiguraagenteComponent,
    FiguraagentecComponent,
    ComponentsComponent,
    TendenciacentralComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [FigurasagentesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
