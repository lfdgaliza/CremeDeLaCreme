import { Directive, ElementRef, Input, Output, EventEmitter } from '@angular/core';

@Directive({
    selector: '[fix-on-top]',
    host: {
        '(window:scroll)': 'configureState()',
        '(window:load)': 'configureState()'
    }
})
export class FixOnTopDirective {
    constructor(private _el: ElementRef) { }

    @Output() visibilityChangedByScroll = new EventEmitter();
    @Input('componentHeight') targetHeight: number = 0;

    private _previousState: boolean;
    private _sizeFactor: number;

    configureState() {
        let actualState = (this._el.nativeElement.offsetTop - window.scrollY) < this._sizeFactor;
        if(this._previousState != actualState)
        {
            this._sizeFactor = actualState ? 0 : this.targetHeight;
            this._previousState = actualState;
            this.visibilityChangedByScroll.emit(actualState);
        }
    }
}