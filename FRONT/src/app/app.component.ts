import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DataService } from './data.service';
import * as _ from 'lodash';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  displayedColumns = ['user','nombres','apellidos','departamento','cargo','email','accion'];
  dataSource!:MatTableDataSource<any>;
  apiResponse:any = [];

  @ViewChild('paginator') paginator! : MatPaginator; 
  @ViewChild(MatSort) matSort! : MatSort;

  constructor(private service: DataService) {}

  ngOnInit() {
    this.service.getUserData().subscribe((response:any) =>{
      console.log(response)
      this.apiResponse = response;
      this.dataSource = new MatTableDataSource(response);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.matSort;
    })
  }


  editar(a:any){
    console.log(a)
  }
  
  eliminar(a:any){
    console.log(a)
  }

  onChange($event:any){
    let filteredData = _.filter(this.apiResponse,(item) =>{
      return item.departamento.toLowerCase() ==  $event.value.toLowerCase();
    })
    this.dataSource = new MatTableDataSource(filteredData);
  }

  onChange2($event:any){
    let filteredData = _.filter(this.apiResponse,(item) =>{
      return item.cargo.toLowerCase() ==  $event.value.toLowerCase();
    })
    this.dataSource = new MatTableDataSource(filteredData);
  }


}
