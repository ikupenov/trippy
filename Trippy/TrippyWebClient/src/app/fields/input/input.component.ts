import { Component, Output, EventEmitter, Input } from "@angular/core";

@Component({
    selector: "tpy-input",
    templateUrl: "./input.component.html"
})
export class InputComponent {

    @Input() type = "text";
    @Input() name: string;
    @Input() label: string;
    @Input() hint: string;
    @Input() required: boolean;
    @Input() readonly: boolean;
    @Input() disabled: boolean;
    @Input() autofocus: boolean;
    @Input() placeholder: string;
    @Input() errorMessage: string;
    @Input() minlength: number;
    @Input() maxlength: number;
    @Input() pattern: string;

    @Output() input = new EventEmitter<string>();
    @Output() enter = new EventEmitter<string>();
    @Output() focus = new EventEmitter<void>();
    @Output() blur = new EventEmitter<void>();
    @Output() clear = new EventEmitter<void>();

    onBlur() {
        this.blur.emit();
    }

    onFocus() {
        this.focus.emit();
    }

    onInput(value: string) {
        this.input.emit(value);
    }

    onEnter(value: string) {
        this.input.emit(value);
    }
}
