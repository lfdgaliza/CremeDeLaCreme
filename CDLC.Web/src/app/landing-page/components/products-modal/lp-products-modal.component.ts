import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'cdlc-lp-products-modal',
    templateUrl: './lp-products-modal.component.html',
    styleUrls: ['./lp-products-modal.component.css']
})
export class LpProductsModalComponent implements OnInit {
    constructor(private _httpService: Http) { }

    products: {}[] = [];

    @Output() closeDialog = new EventEmitter<boolean>();

    ngOnInit() {
        this._httpService.get('/api/products/all').subscribe(values => {
            this.products = values.json() as {}[];
        });
    }

    fecharModal() {
        this.closeDialog.emit(true);
    }
}