import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { SmoothScrollToDirective, SmoothScrollDirective } from "ng2-smooth-scroll";

import { SlickModule } from 'ngx-slick';

import { FixOnTopDirective } from '../directives/fix-on-top.directive';

import { LandingPageComponent } from './lp.component';
import { LpCoverComponent } from './components/cover/lp-cover.component';
import { LpMenuComponent } from './components/menu/lp-menu.component';
import { LpMiddleComponent } from './components/middle/lp-middle.component';
import { LpWwhComponent } from './components/wwh/lp-wwh.component';
import { LpKitsComponent } from './components/kits/lp-kits.component';
import { LpProductsComponent } from './components/products/lp-products.component';
import { LpCarouselComponent } from './components/carousel/lp-carousel.component';
import { LpContactComponent } from './components/contact/lp-contact.component';
import { LpProductsModalComponent } from './components/products-modal/lp-products-modal.component'

@NgModule({
    declarations: [
        SmoothScrollToDirective,
        SmoothScrollDirective,
        FixOnTopDirective,
        LandingPageComponent,
        LpCoverComponent,
        LpMenuComponent,
        LpMiddleComponent,
        LpWwhComponent,
        LpKitsComponent,
        LpProductsComponent,
        LpCarouselComponent,
        LpContactComponent,
        LpProductsModalComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        SlickModule.forRoot()
    ],
    providers: [],
    bootstrap: [LandingPageComponent]
})
export class LpModule { }
