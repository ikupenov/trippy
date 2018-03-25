import { NgModule } from "@angular/core";

import { LocationService } from "./location.service";
import { SharedModule } from "@tpy/shared";

@NgModule({
    declarations: [],
    imports: [SharedModule],
    exports: [],
    providers: [LocationService],
})
export class LocationModule { }
