import { Injectable } from '@angular/core';
import { Actions, Effect } from '@ngrx/effects';
import { UserService } from "./../services/user.service";
import { Observable } from "rxjs/Observable";
import { Action } from './../reducers/action.interface';
import * as UserAction from './../actions/user.actions';
import { User } from "./../models/user";
import * as _ from 'lodash';
import { UserRole } from 'app/models/userRole';

@Injectable()
export class UserEffects {

    constructor(private actions$: Actions,
        private userService: UserService
    ) { }

    @Effect()
    add_user$: Observable<Action> = this.actions$
        .ofType(UserAction.ActionTypes.ADD_USER)
      .switchMap((action: Action) => {
          debugger;
          let userRole: UserRole[] = [];
          _.forEach(action.payload.userRole, function (value) {
            if (value.selected) {
                debugger;
                userRole.push({ UserRolesID: 0, UserID: 0, RoleID: value.id });
              }
          });
          return this.userService.addUser(action.payload,userRole);
        })
      .map((data) => {
            debugger;
            var user = data as User;
            return new UserAction.AddUserSuccessAction(user);
        });

    @Effect()
    get_all_users$: Observable<Action> = this.actions$
        .ofType(UserAction.ActionTypes.GET_ALL_USERS)
        .switchMap((action: Action) => {
            return this.userService.getAllUsers();
        })
        .map((data) => {
            var users = data as User[];
            return new UserAction.GetAllUserSuccessAction(users);
        });

}
