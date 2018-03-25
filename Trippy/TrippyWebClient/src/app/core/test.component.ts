import { Component } from "@angular/core";

@Component({
    selector: "tpy-test",
    template: `
    <h1>
        Its me, {{name}}
    </h1>
    `,
    styles: [``]
})
export class TestComponent {
    name = "Mario";
}
