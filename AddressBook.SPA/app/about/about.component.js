System.register(["angular2/core","angular2/router","../contacts/contact.service"],function(t,e){"use strict";var o,n,c,r,i=(e&&e.id,this&&this.__decorate||function(t,e,o,n){var c,r=arguments.length,i=r<3?e:null===n?n=Object.getOwnPropertyDescriptor(e,o):n;if("object"==typeof Reflect&&"function"==typeof Reflect.decorate)i=Reflect.decorate(t,e,o,n);else for(var a=t.length-1;a>=0;a--)(c=t[a])&&(i=(r<3?c(i):r>3?c(e,o,i):c(e,o))||i);return r>3&&i&&Object.defineProperty(e,o,i),i}),a=this&&this.__metadata||function(t,e){if("object"==typeof Reflect&&"function"==typeof Reflect.metadata)return Reflect.metadata(t,e)};return{setters:[function(t){o=t},function(t){n=t},function(t){c=t}],execute:function(){r=function(){function t(t,e,o){this._contactService=t,this._router=e,this._routeParams=o,this._contact=null,this.id=null}return t.prototype.ngOnInit=function(){var t=this;this.id=this._routeParams.get("contactid"),this._contactService.getContactById(this.id).then(function(e){e&&(console.log("About"),console.log(e),t._contact=e)})},t=i([o.Component({selector:"about",providers:[c.ContactService],directives:[n.ROUTER_DIRECTIVES],templateUrl:"../dev/about/about.component.html"}),a("design:paramtypes",[c.ContactService,n.Router,n.RouteParams])],t)}(),t("AboutComponent",r)}}});