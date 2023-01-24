import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  widthImg: number = 100;
  marginImg: number = 2;
  mostrarImg: boolean = true;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  exibirImg() {
    this.mostrarImg = !this.mostrarImg;
  }

  public getEventos(): void {
    this.http.get('https://localhost:44363/api/eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    );
  }

}
