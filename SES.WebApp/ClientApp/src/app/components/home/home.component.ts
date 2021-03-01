import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormArray, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { DemandRequest } from '../../models/DemandRequest';

import { DemandRequestService } from '../../services/demand-request.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public demandRequestFormGroup: FormGroup;
  public model: DemandRequest = new DemandRequest();

  constructor(private formBuilder: FormBuilder,
    private demandRequestService: DemandRequestService,
    private router: Router) { }

  ngOnInit() {
    this.demandRequestFormGroup = this.formBuilder.group({
      FirstName: this.model.firstName,
      LastName: this.model.lastName
    });
  }
  save() {
    Object.assign(this.model, this.demandRequestFormGroup.value);
    this.demandRequestService.createDemandRequest(this.model)
      .subscribe((data) => {
        this.router.navigate(['/demand-request']);
      }, (err) => console.error(err));
  }
}
