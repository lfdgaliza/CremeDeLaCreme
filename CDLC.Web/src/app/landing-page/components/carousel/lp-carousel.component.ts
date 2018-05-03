import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'

@Component({
    selector: 'cdlc-lp-carousel',
    templateUrl: './lp-carousel.component.html',
    styleUrls: ['./lp-carousel.component.css']
})
export class LpCarouselComponent implements OnInit {
    constructor(private _httpService: Http) { }

    images: string[] = [];

    ngOnInit() {
        this._httpService.get('/api/assets/carousel/img').subscribe(values => {
            this.images = values.json() as string[];
        });
    }

    slides = [
        { img: "http://placehold.it/350x150/000000" },
        { img: "http://placehold.it/350x150/111111" },
        { img: "http://placehold.it/350x150/333333" },
        { img: "http://placehold.it/350x150/666666" }
    ];
    slideConfig = {
        "slidesToShow": 4,
        "slidesToScroll": 4,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 700,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2,
                    arrows: false,
                    dots: true
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    dots: true
                }
            }
        ]
    };

    addSlide() {
        this.slides.push({ img: "http://placehold.it/350x150/777777" })
    }

    removeSlide() {
        this.slides.length = this.slides.length - 1;
    }

    afterChange(e) {
        
    }
}