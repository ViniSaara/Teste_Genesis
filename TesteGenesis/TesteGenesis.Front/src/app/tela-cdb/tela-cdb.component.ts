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

  calcularCdb(event: Event){
    debugger;
    this.cdbService.calcularCdb(this.cdb.meses, this.cdb.valorInicial).subscribe(data => {
      if (data.mensagem != null && data.mensagem != ''){
        this.cdb.mensagem = data.mensagem;
      }
      else {
        this.cdb.valorLiquido = data.valorLiquido;
        this.cdb.valorBruto = data.valorBruto;
        this.cdb.mensagem = '';
      }
      console.log('resultado: ' + data);
    });
  }
}
