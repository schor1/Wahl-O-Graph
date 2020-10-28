  
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GraphContentComponent } from './components/graph-content/graph-content.component';

const routes: Routes = [
  { path: 'graph', component: GraphContentComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }