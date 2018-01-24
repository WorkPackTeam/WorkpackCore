import { Component, OnInit, ViewChild } from '@angular/core';
import { ToasterService, Toast, ToasterConfig } from 'angular2-toaster';
import { HotRegisterer } from 'angular-handsontable';
import { Store } from '@ngrx/store';
import { Router } from '@angular/router';
import * as fromRoot from './../../../../reducers/index';
import { GetAllUserAction } from './../../../../actions/user.actions';
import { Observable } from 'rxjs/Observable';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import * as _ from 'lodash';
import { User } from "app/models/user";


@Component({
    selector: 'app-userlist',
    templateUrl: './userlist.component.html'
})
export class UserListComponent implements OnInit {

    instance: string = "hotUserInstance";
    @BlockUI('blockUI-list') blockUI: NgBlockUI;

    private data: any[];
    private colHeaders: string[];
    private columns: any[];
    private options: any;
    private colWidths: any;

    userList$: Observable<User[]>;

    public toasterConfig: ToasterConfig = new ToasterConfig({
        positionClass: 'toast-top-center'
    });

    constructor(private store: Store<fromRoot.AppState>,
        private _hotRegisterer: HotRegisterer,
        private toastr: ToasterService,
        private router: Router) {
        this.userList$ = this.store.select(fromRoot.getAllUsers);
        this.store.dispatch(new GetAllUserAction());
        this.HTInit();
    }

    ngOnInit() {
    }

    HTInit() {
        debugger;
        this.userList$.subscribe(
            data => {
                if (data !== null) {
                    const vData = _.clone(data);
                    this.HtLoadData(vData);
                }
            }
        )
    }

    HtLoadData(vData) {
        debugger;
        this.data = vData.filter(function (e) { return e.FirstName });
        this.colWidths = [21, 21, 21, 21, 14];
        this.colHeaders = ['First Name', 'Last Name', 'Dept.', 'Desig.', ''];
        this.columns = [
            { data: 'FirstName', type: 'text' },
            { data: 'LastName', type: 'text' },
            { data: 'DepartmentName', type: 'text' },
            { data: 'DesignationName', type: 'text' },
            {
                data: '',
                renderer: function percentRenderer(instance, td, row, col, prop, value, cellProperties) {
                    var rowData = instance.getSourceDataAtRow(row);
                    td.innerHTML = "<a class='btn btn-xs green' href= 'javascript:void(0);' userId='" + rowData.UserID + "' style= 'cursor:pointer; text-align:center' id= 'editUser' > Edit <i class='fa fa-pencil'></i></a>&nbsp;" +
                        "<a class='btn btn-xs red' href= 'javascript:void(0);' userId='" + rowData.UserID + "' style= 'cursor:pointer; text-align:center' id= 'btndepartmentdelete' > Delete <i class='fa fa-trash' > </i></a> ";
                },
                readOnly: true
            }
        ];
        this.options = {
            height: 396,
            rowHeaders: true,
            stretchH: 'all',
            columnSorting: true,
            contextMenu: true,
            className: 'htCenter htMiddle',
            fillHandle: false
        };

        this.blockUI.stop();

    }

    private mousedown(e: any) {
        debugger;
        if (e.target.id === 'editUser') {
            const id = e.target.attributes["userid"].value;
            if (id) {
                this.router.navigate(['/userManagement/user', id]);
            }
        }
        //if (e.target.id === 'editUser') {
        //    this.blockUI.start('Loading...');
        //    const indexArr = this.hotTableComponent.inst.getSelected();
        //    const selectedData = this.hotTableComponent.inst.getSourceDataAtRow(indexArr[0]);

        //    const dept = [
        //        {
        //            DepartmentID: selectedData.DepartmentID ? 0 : selectedData.DepartmentID,
        //            DepartmentName: selectedData.DepartmentName,
        //            DepartmentCode: selectedData.DepartmentCode
        //        }
        //    ];

        //    this.store.dispatch(new AddDepartmentAction(dept));
        //    this.blockUI.stop();
        //    let toast: Toast = {
        //        type: 'success',
        //        title: 'Here is a Toast Title',
        //        body: 'Here is a Toast Body',
        //        showCloseButton: true,
        //        toasterConfig: this.toasterConfig
        //    };
        //    this.toastr.pop(toast);


        //    // this.hotTableComponent.data.push(selectedData);
        //    // this.hotTableComponent.data[this.hotTableComponent.inst.getData().length - 1] = [];
        //    // this.hotTableComponent.inst.render();
        //}

        //else if (e.target.id === 'btndepartmentdelete') {
        //    this.blockUI.start('Loading...');
        //    //debugger;
        //    const indexArr = this.hotTableComponent.inst.getSelected();
        //    const selectedData = this.hotTableComponent.inst.getSourceDataAtRow(indexArr[0]);
        //    this.hotTableComponent.inst.alter('remove_row', indexArr[0]);
        //    const dept = [
        //        {
        //            DepartmentID: selectedData.DepartmentID,
        //            DepartmentName: selectedData.DepartmentName,
        //            DepartmentCode: selectedData.DepartmentCode
        //        }
        //    ];

        //    this.store.dispatch(new DeleteDepartmentAction(dept));

        //    this.blockUI.stop();

        //    let toast: Toast = {
        //        type: 'success',
        //        title: 'Here is a Toast Title',
        //        body: 'Here is a Toast Body',
        //        showCloseButton: true,
        //        toasterConfig: this.toasterConfig
        //    };
        //    this.toastr.pop(toast);
        //    // this.hotTableComponent.data.push(selectedData);
        //    // this.hotTableComponent.data[this.hotTableComponent.inst.getData().length - 1] = [];
        //    // this.hotTableComponent.inst.render();
        //}
    }

}
