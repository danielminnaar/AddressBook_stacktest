System.register(["angular2/core","./contact.service","angular2/router","angular2/common"],function(t,e){"use strict";var o,n,r,i,c,a=(e&&e.id,this&&this.__decorate||function(t,e,o,n){var r,i=arguments.length,c=i<3?e:null===n?n=Object.getOwnPropertyDescriptor(e,o):n;if("object"==typeof Reflect&&"function"==typeof Reflect.decorate)c=Reflect.decorate(t,e,o,n);else for(var a=t.length-1;a>=0;a--)(r=t[a])&&(c=(i<3?r(c):i>3?r(e,o,c):r(e,o))||c);return i>3&&c&&Object.defineProperty(e,o,c),c}),l=this&&this.__metadata||function(t,e){if("object"==typeof Reflect&&"function"==typeof Reflect.metadata)return Reflect.metadata(t,e)};return{setters:[function(t){o=t},function(t){n=t},function(t){r=t},function(t){i=t}],execute:function(){c=function(){function t(t,e,o){this._contactService=t,this._router=e,this._formBuilder=o,this.myForm=this._formBuilder.group({id:[Math.floor(100*Math.random()+1).toString()],firstname:["",i.Validators.required],lastname:["",i.Validators.required],email:[""]})}return t.prototype.onAddContact=function(t){console.log("Submitted value"),console.log(t),this.myForm.dirty&&this.myForm.valid&&this._contactService.insertContact(t),this._router.navigate(["Contacts"])},t=a([o.Component({templateUrl:"../dev/contacts/newcontact.component.html",providers:[n.ContactService],styles:["\n      .ng-invalid{\n        border:1px solid red;\n      }\n      table {\n        border-collapse: collapse;\n      }\n      table, th, td {\n        border: 1px solid black;\n      }\n    "]}),l("design:paramtypes",[n.ContactService,r.Router,i.FormBuilder])],t)}(),t("NewContactComponent",c)}}});