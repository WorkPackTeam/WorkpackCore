import { Action } from './../reducers/action.interface';
import { User } from "./../models/user";

export const ActionTypes = {
    ADD_USER: 'Add user',
    ADD_USER_SUCCESS: 'Add user success',
    EDIT_USER: 'Edit user',
    EDIT_USER_SUCCESS: 'Edit user success',
    DELETE_USER: 'Delete user',
    DELETE_USER_SUCCESS: 'Delete user success',
    GET_ALL_USERS: 'Get all users',
    GET_ALL_USERS_SUCCESS: 'Get all users success'
};

export class AddUserAction implements Action {
    type = ActionTypes.ADD_USER;
    constructor(public payload: User) { }
}

export class AddUserSuccessAction implements Action {
    type = ActionTypes.ADD_USER_SUCCESS;
    constructor(public payload: User) { }
}

export class GetAllUserAction implements Action {
    type = ActionTypes.GET_ALL_USERS;
    constructor() { }
}

export class GetAllUserSuccessAction implements Action {
    type = ActionTypes.GET_ALL_USERS_SUCCESS;
    constructor(public payload: User[]) { }
}