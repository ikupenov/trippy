import { NgModule } from "@angular/core";
import { FieldsModule } from "@tpy/fields";
import { SharedModule } from "@tpy/shared";

import { LocationSelectorComponent } from "./location-selector/location-selector.component";
import { LocationService } from "./location.service";

@NgModule({
    declarations: [LocationSelectorComponent],
    imports: [
        SharedModule,
        FieldsModule
    ],
    providers: [LocationService],
    exports: [
        LocationSelectorComponent
    ]
})
export class LocationModule { }
