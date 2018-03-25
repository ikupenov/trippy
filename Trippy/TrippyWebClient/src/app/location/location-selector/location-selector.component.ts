import { Component, OnInit } from "@angular/core";

import { LocationService } from "../location.service";

@Component({
    selector: "tpy-location-selector",
    templateUrl: "./location-selector.component.html"
})
export class LocationSelectorComponent implements OnInit {

    cities: string[];

    constructor(public locationService: LocationService) { }

    ngOnInit(): void {
        this.locationService.getCities()
            .then(c => this.cities = c);
    }
}
