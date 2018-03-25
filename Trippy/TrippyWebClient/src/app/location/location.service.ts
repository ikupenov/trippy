import { Injectable } from "@angular/core";

@Injectable()
export class LocationService {

    getCities(): Promise<string[]> {
        const citiesMock = ["Sofia", "Valencia"];
        return Promise.resolve(citiesMock);
    }
}
