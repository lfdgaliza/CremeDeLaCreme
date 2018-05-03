import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'cdlc-lp-products',
    templateUrl: './lp-products.component.html',
    styleUrls: ['./lp-products.component.css']
})
export class LpProductsComponent implements OnInit {
    constructor(private _httpService: Http) { }

    products: {}[] = [];
    public showDialog: boolean = false;

    ngOnInit() {
        this._httpService.get('/api/products/featured').subscribe(values => {
            this.products = values.json() as {}[];
        });
    }

    mostrarModalProdutos() {
        this.showDialog = true;
    }

    closeDialog() {
        this.showDialog = false;
    }
}