import {Component} from "angular2/core";
import {OnInit} from "angular2/core";
import {ContactComponent} from "./contact.component";
import {ContactService} from "./contact.service";
import {Contact} from "./contact";

@Component({
  selector: "contact-list",
  templateUrl: "../dev/contacts/contact-list.component.html",
  directives: [ContactComponent],
  providers:[ContactService],
  styleUrls:["../src/css/app.css"]
})

export class ContactListComponent implements OnInit{
  public contacts : Contact[];

  public selectedContact = null;

  public onNameClick(contact){
        this.selectedContact = contact;
  }
 
  constructor(private _contactService: ContactService){
      this.getContacts();
  }

  getContacts(){
    this._contactService.getContacts().then((contacts:Contact[])=>this.contacts = contacts);
  }

  ngOnInit () :any {
      this.getContacts();
  }
}
