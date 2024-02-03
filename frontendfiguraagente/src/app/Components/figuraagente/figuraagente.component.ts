import { Component, OnInit, NgZone } from '@angular/core';
import { Router } from '@angular/router';
import { FigurasagentesService } from 'src/app/Services/figurasagentes.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-figuraagente',
  templateUrl: './figuraagente.component.html',
  styleUrls: ['./figuraagente.component.css']
})

export class FiguraagenteComponent implements OnInit{

  figuraForm:any=FormGroup;
  Listado:any = [];

  ngOnInit(){
    this.addingresofigura();
    this.listado();
  }

  constructor(
    public fb: FormBuilder,
    private ngZone:NgZone,
    private router:Router,
    public figurasagentesService:FigurasagentesService
  ){}

  

  addingresofigura(){
    return this.figuraForm = this.fb.group({
      Nombrefuncionalidad:['Escalera', Validators.required],
      Nombreagente:['', Validators.required],
      Numn:['', Validators.required]
    });
  }

  listado(){
    return this.figurasagentesService.Generarfigura(this.figuraForm.value).subscribe((data:{}) => {
      this.Listado = data;
    })
    }

}


























