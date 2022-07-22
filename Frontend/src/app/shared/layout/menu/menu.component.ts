import { Component, OnInit } from '@angular/core';
import { navbarData } from './navbarData';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {

  collapsed = false;
  navData = navbarData

  constructor() { }

  ngOnInit(): void {
  }

}
