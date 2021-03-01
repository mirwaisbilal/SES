import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DemandRequest } from 'src/app/models/DemandRequest';
import { DemandRequestService } from 'src/app/services/demand-request.service';

@Component({
  selector: 'app-demand-request',
  templateUrl: './demand-request.component.html'
})
export class FetchDataComponent {
  demands: DemandRequest[];

  constructor(private demandRequestService: DemandRequestService) { }

  ngOnInit(): void {
    this.demandRequestService.getDemandRequest().subscribe(result => {
      this.demands = result;
    }, error => console.error(error))
  }
}
