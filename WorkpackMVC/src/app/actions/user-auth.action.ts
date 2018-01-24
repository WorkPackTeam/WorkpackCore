﻿import { Action } from './../reducers/action.interface';

export const ActionTypes = {
    LOGIN: '[User] Login',
    LOGIN_SUCCESS: '[User] Login Success',
    LOGOUT: '[User] Logout',
    LOGOUT_SUCCESS: '[User] Logout Success',
    SERVER_LOGIN: '[User] Server Login',
    SERVER_LOGIN_SUCCESS: '[User] Server Login Success',
    SERVER_LOGOUT: '[User] Server Logout',
    SERVER_LOGOUT_SUCCESS: '[User] Server Logout Success',
    SERVER_SIGNUP: '[User] Server Signup',
    SERVER_SIGNUP_SUCCESS: '[User] Server Signup Success',
    GET_HEADER_NOTIFICATION: 'Get Header Notification',
    GET_HEADER_NOTIFICATION_SUCCESS: 'Get Header Notification Success',
}

export class LoginAction implements Action {
    type = ActionTypes.LOGIN;
    constructor() { }
}
export class LoginSuccessAction implements Action {
    type = ActionTypes.LOGIN_SUCCESS;
    constructor(public payload: any) { }
}
export class LogoutAction implements Action {
    type = ActionTypes.LOGOUT;
    constructor() { }
}
export class LogoutSuccessAction implements Action {
    type = ActionTypes.LOGOUT_SUCCESS;
    constructor() { }
}

// Actions for Api connection

export class ServerLoginAction implements Action {
    type = ActionTypes.SERVER_LOGIN;
    constructor(public payload: any) { }
}
export class ServerLoginSuccessAction implements Action {
    type = ActionTypes.SERVER_LOGIN_SUCCESS;
    constructor(public payload: any) { }
}
export class ServerLogoutAction implements Action {
    type = ActionTypes.SERVER_LOGOUT;
    constructor() { }
}
export class ServerLogoutSuccessAction implements Action {
    type = ActionTypes.SERVER_LOGOUT_SUCCESS;
    constructor() { }
}
export class GetHeaderNotificationAction implements Action {
    type = ActionTypes.GET_HEADER_NOTIFICATION;
    constructor(public payload: any) { }
}
export class GetHeaderNotificationSuccessAction implements Action {
    type = ActionTypes.GET_HEADER_NOTIFICATION_SUCCESS;
    constructor(public payload: any) { }
}
