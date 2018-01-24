import { Component, OnInit } from '@angular/core';
import { Location } from "@angular/common";
import { Observable } from 'rxjs/Observable';
import { Department } from 'app/models/department';
import { Designation } from 'app/models/designation';
import { Store } from '@ngrx/store';
import { Form, FormBuilder, FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import * as fromRoot from './../../../../reducers/index';
import { ToasterService } from 'angular2-toaster';
import { GetDepartmentAction } from './../../../../actions/department.actions';
import { GetDesignationAction } from './../../../../actions/designation.actions';
import { GetAllUserAction } from 'app/actions/user.actions';
import { ActivatedRoute } from '@angular/router';
import { User } from 'app/models/user';
import { GetRoleAction } from 'app/actions/role.actions';
import { FilterNullPipe } from "app/pipes/filterNull.pipe";
import { UserRole } from "app/models/userRole";
import { Role } from "app/models/role";
import * as _ from 'lodash';

@Component({
  selector: 'app-userComponent',
  templateUrl: 'user.component.html'
})
export class UserComponent implements OnInit {

  userForm: FormGroup;
  departmentList$: Observable<Department[]>;
  designationList$: Observable<Designation[]>;
  reportingToList$: Observable<User[]>;
  userRole$: Observable<Role[]>;
  vUserRole: UserRole[] = [];

  user: User;
  editingStatus = false;

  constructor(private fb: FormBuilder,
    private store: Store<fromRoot.AppState>,
    private activatedRoute: ActivatedRoute,
    private toastr: ToasterService,
    private location: Location) {
    if ('id' in this.activatedRoute.snapshot.params) {
      let id = 0;
      const sub = this.activatedRoute.params.subscribe(params => {
        id = +params['id']; // (+) converts string 'id' to a number
      });
      if (id && Number(id) > 0)
        this.editingStatus = true;
    }

  }

  ngOnInit() {
    debugger;
    this.vUserRole = this.activatedRoute.snapshot.data['userRole'];
    if (this.editingStatus) {
      this.user = this.activatedRoute.snapshot.data['user'];
      this.initForm(this.user) // handles both the create and edit logic
    } else {
      this.initForm() // handles both the create and edit logic
    }

  }

  onSubmit() {
    debugger;
    alert(this.userForm.valid);
    console.log(this.userForm.value);
    if (this.userForm.valid) {
      const formValues = Object.assign({}, this.userForm.value, {
        userRole: this.userForm.value.userRole.map((s, i) => {
          return {
            id: this.vUserRole[i].RoleID,
            selected: s
          }
        })
      });
      console.log(formValues);
      // this.store.dispatch();

    }
  }

  initForm(user?: User) {
    this.departmentList$ = this.store.select(fromRoot.getDepartment);
    this.designationList$ = this.store.select(fromRoot.getDesignation);
    this.userRole$ = this.store.select(fromRoot.getRole);
    this.reportingToList$ = this.store.select(fromRoot.getAllUsers);
    this.store.dispatch(new GetDepartmentAction());
    this.store.dispatch(new GetDesignationAction());
    this.store.dispatch(new GetRoleAction());
    this.store.dispatch(new GetAllUserAction());

    let firstName = '';
    let lastName = '';
    let vEmailId = '';
    let designation = '0';
    let department = '0';
    let reportingTo = '0';
    let isActive = false;

    console.log(this.vUserRole);

    if (user) {
      firstName = user.FirstName ? user.FirstName : '';
      lastName = user.LastName ? user.LastName : '';
      vEmailId = user.EmailID ? user.EmailID : '';
      designation = (user.DesignationID ? user.DesignationID.toString() : '0');
      department = (user.DepartmentID ? user.DepartmentID.toString() : '0');
      reportingTo = (user.ReportingTo ? user.ReportingTo.toString() : '0');
      isActive = (user.isActive ? user.isActive : false);
    } else {
    }

    this.userForm = this.fb.group({
      'firstName': [firstName, [Validators.required, Validators.minLength(2)]],
      'lastName': [lastName, [Validators.required, Validators.minLength(2)]],
      'emailId': [vEmailId, [Validators.required, this.emailValidator]],
      'designation': [designation, this.selectValidator],
      'department': [department, this.selectValidator],
      'reportingTo': [reportingTo, this.selectValidator],
      'isActive': [isActive],
      'userRole': this.fb.array(
        this.vUserRole.map((data) => this.fb.control(data.RoleAssigned > 0)))
    });

  }

  userRoleCheckEvent(event, vRoleId) {
    var index = _.findIndex(this.vUserRole, { RoleID: vRoleId });
    let uRItem: UserRole[] = this.vUserRole.filter(data => data.RoleID === vRoleId);
    uRItem[0].RoleAssigned = uRItem[0].RoleAssigned > 0 && event.target.checked ? uRItem[0].RoleAssigned : (event.target.checked ? 1 : 0);
    this.vUserRole.splice(index, 1, uRItem[0]);
    console.log(this.vUserRole);
  }

  goBack() {
    this.location.back();
  }

  // validation

  emailValidator(control) {
    // RFC 2822 compliant regex
    // tslint:disable-next-line:max-line-length
    if (control.value.match(/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/)) {
      return null;
    } else {
      return { 'invalidEmailAddress': true };
    }
  }

  selectValidator(control) {
    if (control.value === "0") {
      return { 'invalidSelect': true };
    } else {
      return null;
    }
  }

  isActiveValidator(control) {
    if (control.value === false) {
      return { 'invalidIsActive': true };
    } else {
      return null;
    }
  }

  userRoleValidation(fa: FormArray) {
    let valid = false;

    for (let x = 0; x < fa.length; ++x) {
      if (fa.at(x).value) {
        valid = true;
        break;
      }
    }
    return valid ? null : {
      multipleCheckboxRequireOne: true
    };
  }

}
