import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule, Routes } from "@angular/router";
import { CoreModule, TestComponent } from "@tpy/core";
import { SharedModule } from "@tpy/shared";

import { AppComponent } from "./app.component";

const appRoutes: Routes = [
    { path: "test", component: TestComponent }
];

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        RouterModule.forRoot(appRoutes),
        SharedModule,
        BrowserModule,
        CoreModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
