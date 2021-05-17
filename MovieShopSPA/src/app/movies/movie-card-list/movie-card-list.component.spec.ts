import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MovieCardListComponent } from './movie-card-list.component';

// Added imports
import { Movie } from 'src/app/shared/models/movie';
import { MovieService } from 'src/app/core/services/movie.service';
import { ActivatedRoute } from '@angular/router';

describe('MovieCardListComponent', () => {
  let component: MovieCardListComponent;
  let fixture: ComponentFixture<MovieCardListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovieCardListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MovieCardListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
