import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { SharedModule } from "@tpy/shared";

import { InputComponent } from "./input/input.component";

@NgModule({
    declarations: [InputComponent],
    imports: [
        SharedModule,
        FormsModule
    ],
    exports: [InputComponent]
})
export class FieldsModule { }
