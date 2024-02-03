import { Component, OnInit, NgZone } from '@angular/core';
import { Router } from '@angular/router';
import { TendenciaService } from 'src/app/Services/tendencia.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-tendenciacentral',
  templateUrl: './tendenciacentral.component.html',
  styleUrls: ['./tendenciacentral.component.css']
})
export class TendenciacentralComponent implements OnInit{

  tendenciaForm:any=FormGroup;
  Listado:any = [];

  ngOnInit(){
    this.addingresotendencia();
    this.listado();
  }

  constructor(
    public fb: FormBuilder,
    private ngZone:NgZone,
    private router:Router,
    public tendenciacentral:TendenciaService
  ){}

  

  addingresotendencia(){
    return this.tendenciaForm = this.fb.group({
      
      Funcionalidad:['', Validators.required],
      
    });
  }

  listado(){
    return this.tendenciacentral.Generartendencia(this.tendenciaForm.value).subscribe((data:{}) => {
      this.Listado = data;
    })
    }

}


























