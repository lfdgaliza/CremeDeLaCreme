import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
import { Contact } from "app/landing-page/components/contact/contact";

@Component({
    selector: 'cdlc-lp-contact',
    templateUrl: './lp-contact.component.html',
    styleUrls: ['./lp-contact.component.css', './lp-contact-mobile.component.css']
})
export class LpContactComponent implements OnInit {
    constructor(private _httpService: Http) { }

    public contact: Contact;

    ngOnInit() {
        this.contact = new Contact();
    }

    submitForm() {
        console.log(this.contact);
        this._httpService
            .post('/api/contact', this.contact)
            .subscribe(r => {
                alert("Mensagem enviada com sucesso!");
                this.contact = new Contact();
            });
    }

}