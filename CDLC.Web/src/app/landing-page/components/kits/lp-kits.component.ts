import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'cdlc-lp-kits',
    templateUrl: './lp-kits.component.html',
    styleUrls: ['./lp-kits.component.css']
})
export class LpKitsComponent implements OnInit {
    //constructor(private _httpService: Http) { }

    kits: object[] = [
        { colour: "#fab31c", iconPath: "10.png" },
        { colour: "#3f2314", iconPath: "20.png" },
        { colour: "#35b5b8", iconPath: "30.png" },
        { colour: "#ffffff", iconPath: "50.png" },
        { colour: "#e84c5e", iconPath: "coffee.png" },
    ];

    ngOnInit() {
        // this._httpService.get('/api/assets/kits').subscribe(values => {
        //     this.images = values.json() as string[];
        // });
    }
}