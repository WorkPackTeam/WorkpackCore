import { Injectable } from '@angular/core';
import { Actions, Effect } from '@ngrx/effects';
import { UserService } from "./../services/user.service";
import { Observable } from "rxjs/Observable";
import { Action } from './../reducers/action.interface';
import * as UserAction from './../actions/user.actions';
import { User } from "./../models/user";

@Injectable()
export class UserEffects {

    constructor(private actions$: Actions,
        private userService: UserService
    ) { }

    @Effect()
    add_user$: Observable<Action> = this.actions$
        .ofType(UserAction.ActionTypes.ADD_USER)
        .switchMap((action: Action) => {
            return this.userService.addUser(action.payload);
        })
        .map((data) => {
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
