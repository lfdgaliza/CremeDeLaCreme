import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'cdlc-lp-wwh',
    templateUrl: './lp-wwh.component.html',
    styleUrls: ['./lp-wwh.component.css']
})
export class LpWwhComponent implements OnInit {
    constructor(private _httpService: Http) { }

    images: string[] = [];

    ngOnInit() {
        this._httpService.get('/api/assets/offerings/img').subscribe(values => {
            this.images = values.json() as string[];
        });
    }
}