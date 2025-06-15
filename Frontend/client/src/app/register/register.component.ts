import {
  Component,
  EventEmitter,
  inject,
  Input,
  input,
  Output,
} from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  @Input() usersFromHomeComponent: any;
  @Output() cancelFromRegister = new EventEmitter();
  model: any = {};
  private accountService = inject(AccountService);

  register() {
    this.accountService.register(this.model).subscribe({
      next: (response) => {
        console.log(response);
        this.cancel();
      },
    });
  }

  cancel() {
    this.cancelFromRegister.emit(false);
    console.log('Cancelled');
  }
}
