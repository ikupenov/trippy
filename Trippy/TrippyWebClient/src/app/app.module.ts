import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { CoreModule } from "@tpy/core";
import { LocationModule } from "@tpy/location";
import { SharedModule } from "@tpy/shared";

import { AppComponent } from "./app.component";
import { AppRoutesModule } from "./app.routes";

@NgModule({
    declarations: [AppComponent],
    imports: [
        SharedModule.forRoot(),
        AppRoutesModule,
        BrowserModule,
        CoreModule,
        LocationModule
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
