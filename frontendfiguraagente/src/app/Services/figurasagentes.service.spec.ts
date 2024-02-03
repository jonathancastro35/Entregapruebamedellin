import { TestBed } from '@angular/core/testing';

import { FigurasagentesService } from './figurasagentes.service';

describe('FigurasagentesService', () => {
  let service: FigurasagentesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FigurasagentesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
