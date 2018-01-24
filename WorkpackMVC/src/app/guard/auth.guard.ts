import { Subscription } from 'rxjs/Subscription';
import * as fromRoot from './../reducers/index';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs/Observable';
import { Injectable, OnDestroy } from '@angular/core';
import { Router, CanActivate } from '@angular/router';


@Injectable()
export class CanActivateViaAuthGuard implements CanActivate, OnDestroy {
  isAuthenticated: boolean;
  subscription: Subscription;

  constructor(private store: Store<fromRoot.AppState>,
    private router: Router) {
  }

  canActivate() {
    this.subscription = this.store
      .select(fromRoot.getAuthStatus)
      .subscribe(isAuthenticated => {
        this.isAuthenticated = isAuthenticated;
        if (!isAuthenticated) {
          this.router.navigate(['/auth/login']);
        }
      });
    return this.isAuthenticated;
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

}
