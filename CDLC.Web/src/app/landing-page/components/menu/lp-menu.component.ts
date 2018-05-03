import { Component } from '@angular/core';

@Component({
    selector: 'cdlc-lp-menu',
    templateUrl: './lp-menu.component.html',
    styleUrls: ['./lp-menu.component.css', './lp-menu-mobile.component.css']
})
export class LpMenuComponent {
    public isFixed: boolean = false;
    public isActive: boolean = false;

    getVisibilityMenu(isHidden) {
        this.isFixed = isHidden;
    }

    btnMenu_Click() {
        this.isActive = !this.isActive;
    }

    closeMenu() {
        this.isActive = false;
    }
}