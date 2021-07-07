import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AcoountService } from '../_services/acoount.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  // @Input() usersFromHomeComponet: any;
  @Output() cancelRegister = new EventEmitter();


  model: any = {};

  constructor(private accountService: AcoountService) { }

  ngOnInit(): void {
  }

  register(){
    this.accountService.register(this.model).subscribe(response =>{
      console.log(response);
      this.cancel();
    }, error => {
      console.log(error);
    })
  }

  cancel() {
    this.cancelRegister.emit(false);
  }
}
