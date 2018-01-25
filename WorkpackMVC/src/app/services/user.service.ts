import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { environment } from './../../environments/environment';
import { User } from './../models/user';
import { UserRole } from 'app/models/userRole';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class UserService {

    private apiLink: string = environment.API_ENDPOINT;

    constructor(private httpClient: HttpClient) {
    }

    addUser(user: User, userRole: UserRole[]): Observable<Object> {
        //localStorage.setItem('user', JSON.stringify(user));
        //return Observable.of(user);
      return this.httpClient.post('api/UsersData', { user: JSON.stringify(user), userRole: JSON.stringify(userRole) })
            .catch(this.handleError)
    }

    getUser(id: number): Observable<Object> {
        const User = {
            UserID: id,
            FirstName: 'Bipin' + id,
            LastName: 'Singh' + id,
            EmailID:'support@gmail.com',
            DepartmentName: 'IT',
            DepartmentID: 29,
            DesignationName: 'Team Lead',
            DesignationID: 23
        };
        return Observable.of(User);
    }

    getAllUsers(): Observable<Object> {
        debugger;
        const Users = [{
            UserID: 1,
            FirstName: 'Bipin',
            LastName: 'Singh',
            DepartmentName: 'IT',
            DesignationName: 'Team Lead'
        },
        {
            UserID: 2,
            FirstName: 'Nirmalya',
            LastName: 'Kundu',
            DepartmentName: 'IT',
            DesignationName: 'Sr.Engineer'
        },
        {
            UserID: 3,
            FirstName: 'Adil',
            LastName: 'Khan',
            DepartmentName: 'Support',
            DesignationName: 'Engineer'
        },
        {
            UserID: 4,
            FirstName: 'Pushkar',
            LastName: 'Gaikwad',
            DepartmentName: 'Project',
            DesignationName: 'COO'
        },
        ];

        return this.httpClient.get<Array<User>>('/api/UsersData');
        //return Observable.of(Users);

    }

    getUserRoleAssigned(): Observable<Object> {

        const UserRoleAssigned = [{
            RoleID: 1,
            RoleName: 'Administrator',
            RoleAssigned: 2
        },
        {
            RoleID: 2,
            RoleName: 'Support Admin',
            RoleAssigned: 0
        },
        {
            RoleID: 3,
            RoleName: 'Document Owner',
            RoleAssigned: 1
        },
        {
            RoleID: 4,
            RoleName: 'Resource Manager',
            RoleAssigned: 0
        }];

        return Observable.of(UserRoleAssigned);

        //return this.http.post('api/getUserRoleAssigned', JSON.stringify(user),this.options).map(this.extractData)
        //    .catch(this.handleError)
    }

    //private extractData(res: Response) {
    //    var array = [];
    //    let body = res.json() as User;
    //    array.push(body || {});
    //    return array;
    //}

    private handleError(error: any) {
        let errMsg = (error.message) ? error.message :
            error.status ? `${error.status} - ${error.statusText}` : 'Server error';
        console.error(errMsg);
        return Observable.throw(errMsg);
    }

}
