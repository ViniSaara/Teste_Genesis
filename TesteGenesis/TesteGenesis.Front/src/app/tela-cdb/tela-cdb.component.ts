import { Component } from '@angular/core';
import { CdbModel } from './cdb.model';
import { CdbService } from '../cdb.service';

@Component({
  selector: 'app-tela-cdb',
  templateUrl: './tela-cdb.component.html',
  styleUrls: ['./tela-cdb.component.scss']
})

export class TelaCdbComponent {

constructor(private cdbService:CdbService) { }


  cdb: CdbModel = new CdbModel();

  calcularCdb(event: Event){
    this.cdb.ValorBruto = 0;
    this.cdb.ValorLiquido = 0;

    this.cdbService.calcularCdb(this.cdb.meses, this.cdb.valorInicial).subscribe(data => {
      if (data.Mensagem != null && data.Mensagem != ''){
        this.cdb.Mensagem = data.Mensagem;
      }
      else {
        this.cdb.ValorLiquido = data.ValorLiquido;
        this.cdb.ValorBruto = data.ValorBruto;
        this.cdb.Mensagem = '';
      }
    });
  }
}
