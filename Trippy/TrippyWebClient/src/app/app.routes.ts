import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { TestComponent } from "@tpy/core";
import { LocationSelectorComponent } from "@tpy/location";

const routes: Routes = [
    { path: "test", component: TestComponent },
    { path: "location", component: LocationSelectorComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutesModule { }
