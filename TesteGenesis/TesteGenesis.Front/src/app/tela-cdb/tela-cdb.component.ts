import { Component } from '@angular/core';
import { CdbModel } from './cdb.model';
import { CdbService } from '../cdb.service';

@Component({
  selector: 'app-tela-cdb',
  templateUrl: './tela-cdb.component.html',
  styleUrls: ['./tela-cdb.component.scss']
})

export class TelaCdbComponent {

// constructor(private _cdbService: CdbService){
//   _cdbService.calcularCdb().subscribe(data => {
//     console.log(data);
//   })
// }

constructor(private cdbService:CdbService) { }


  cdb: CdbModel = new CdbModel();
  //cdbService: CdbService = new CdbService();

  calcularCdb(event: Event){
    debugger;
    alert('Antes da chamada');
    this.cdbService.calcularCdb(this.cdb.meses, this.cdb.valorInicial).subscribe(data => {
      //console.log(data);
      alert('resultado: ' + data);
    });
    alert('Depois da chamada');

    // console.log('Evento: ', event);
    // console.log('CDB : ', this.cdb);
    // this.cdb.valorBruto = 1;
    // this.cdb.valorLiquido = 1;
  }
}
