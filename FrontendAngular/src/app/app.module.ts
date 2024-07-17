import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomeComponent } from './Home/home/home.component';
import { FavoriteComponent } from './Favorite/favorite/favorite.component';
import { LoginComponent } from './Login/login/login.component';
import { ReviewComponent } from './Review/review/review.component';
import { SearchComponent } from './Search/search/search.component';
import { RecommendComponent } from './Recommend/recommend/recommend.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthModule } from '@auth0/auth0-angular';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { RouterModule } from '@angular/router';
import { PricingComponent } from './pricing/pricing/pricing.component';
import { FeaturesComponent } from './features/features/features.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ImdbService } from './services/imdb.service';
import { FavoriteItemComponent } from './favorite-item/favorite-item.component';
import { ListReviewComponent } from './list-review/list-review.component';
import { ListReviewItemComponent } from './list-review-item/list-review-item.component';
import { StreamingLinkComponent } from './streaming-link/streaming-link.component';
import { ListRecommendComponent } from './list-recommend/list-recommend.component';
import { CorsInterceptorService } from './services/cors-interceptor.service';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FavoriteComponent,
    LoginComponent,
    ReviewComponent,
    SearchComponent,
    RecommendComponent,
    NavBarComponent,
    PricingComponent,
    FeaturesComponent,
    FavoriteItemComponent,
    ListReviewComponent,
    ListReviewItemComponent,
    StreamingLinkComponent,
    ListRecommendComponent
  ],
  imports: [
    NgbModule,
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AuthModule.forRoot({
      clientId:"ylc2Bk1RtqVm7MLmdYotdddAeRSbrUc5",
      domain:"dev-3g3556dl.us.auth0.com"
    }),
    RouterModule.forRoot([
      {path: "search", component:SearchComponent},
      {path: "pricing", component:PricingComponent},
      {path: "features", component:FeaturesComponent},
      {path: "review", component:ReviewComponent},
      {path: "favorite", component:FavoriteComponent},
      {path: "reviewlist", component:ListReviewComponent},
      {path: "recommend", component:RecommendComponent},
      {path: "**", component:HomeComponent}
    ])
  ],
  providers: [ImdbService, {provide: HTTP_INTERCEPTORS, useClass: CorsInterceptorService, multi: true}],
  bootstrap: [AppComponent]
})
export class AppModule { }
