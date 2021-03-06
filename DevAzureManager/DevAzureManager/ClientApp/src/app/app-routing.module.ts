import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ReleasesComponent } from './releases/releases.component';

const routes: Routes = [

  { path: 'releases', component: ReleasesComponent },
  { path: '', redirectTo: 'releases', pathMatch: 'full' },
  { path: '**', redirectTo: 'releases', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
