System.register(["angular2/core","angular2/router"],function(t,e){"use strict";var o,n,c,r=(e&&e.id,this&&this.__decorate||function(t,e,o,n){var c,r=arguments.length,a=r<3?e:null===n?n=Object.getOwnPropertyDescriptor(e,o):n;if("object"==typeof Reflect&&"function"==typeof Reflect.decorate)a=Reflect.decorate(t,e,o,n);else for(var i=t.length-1;i>=0;i--)(c=t[i])&&(a=(r<3?c(a):r>3?c(e,o,a):c(e,o))||a);return r>3&&a&&Object.defineProperty(e,o,a),a}),a=this&&this.__metadata||function(t,e){if("object"==typeof Reflect&&"function"==typeof Reflect.metadata)return Reflect.metadata(t,e)};return{setters:[function(t){o=t},function(t){n=t}],execute:function(){c=function(){function t(t){this._router=t,this.contact=null}return t.prototype.onMore=function(t){console.log("Contact"),console.log(t),this._router.navigate(["About",{contactid:t.id}])},t=r([o.Component({selector:"contact",templateUrl:"../dev/contacts/contact.component.html",inputs:["contact"]}),a("design:paramtypes",[n.Router])],t)}(),t("ContactComponent",c)}}});