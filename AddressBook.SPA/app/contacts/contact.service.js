System.register(["angular2/core","./data"],function(t,e){"use strict";var n,r,o,c=(e&&e.id,this&&this.__decorate||function(t,e,n,r){var o,c=arguments.length,i=c<3?e:null===r?r=Object.getOwnPropertyDescriptor(e,n):r;if("object"==typeof Reflect&&"function"==typeof Reflect.decorate)i=Reflect.decorate(t,e,n,r);else for(var f=t.length-1;f>=0;f--)(o=t[f])&&(i=(c<3?o(i):c>3?o(e,n,i):o(e,n))||i);return c>3&&i&&Object.defineProperty(e,n,i),i}),i=this&&this.__metadata||function(t,e){if("object"==typeof Reflect&&"function"==typeof Reflect.metadata)return Reflect.metadata(t,e)};return{setters:[function(t){n=t},function(t){r=t}],execute:function(){o=function(){function t(){}return t.prototype.getContacts=function(){return Promise.resolve(r.CONTACTS)},t.prototype.getContactById=function(t){return Promise.resolve(r.CONTACTS.find(function(e){return e.id==t}))},t.prototype.insertContact=function(t){Promise.resolve(r.CONTACTS).then(function(e){return e.push(t)})},t=c([n.Injectable(),i("design:paramtypes",[])],t)}(),t("ContactService",o)}}});