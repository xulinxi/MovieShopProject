import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateCastComponent } from './admin/create-cast/create-cast.component';
import { CreateMovieComponent } from './admin/create-movie/create-movie.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { HomeComponent } from './home/home.component';
import { MovieCardListComponent } from './movies/movie-card-list/movie-card-list.component';

// specify all the routes belonging to Angular appllication
const routes: Routes = 
[
  // when path is empty -> Home page/component
{ path: "", component: HomeComponent }, // reroutes to component view when the link is clicked
{ path: "login", component: LoginComponent },
{ path: "register", component: RegisterComponent },
{ path: "genres/:id", component: MovieCardListComponent },
{ path: "admin/createmovie", component: CreateMovieComponent },
{ path: "admin/createcase", component: CreateCastComponent }

];

// // specify all the routes belonging to Angular application
// const routes: Routes =
//   [
//     { path: "", component: HomeComponent },
//     { path: "login", component: LoginComponent },
//     { path: "register", component: RegisterComponent },
//     { path: "admin/createmovie", component: CreateMovieComponent },
//     { path: "admin/createcasr", component: CreateCastComponent }
//   ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
