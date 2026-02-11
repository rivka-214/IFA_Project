import { Component } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { User } from '../../models/user';
import { UserService } from '../../services/user.service';
@Component({
  selector: 'app-user-list',
  imports: [NgFor,NgIf],
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent {
arr:number[]=[1,2,3,4,5,6,7,8,9,10];
MockUsers:User[]=[
  {id:1,name:'John'},
  {id:2,name:'Jane'},
  {id:3,name:'Doe'},
]
users:User[]=[]
loading = false;
errorMessage = '';
constructor(private userService: UserService) {}

loadUsersFromServer(): void {
  this.loading = true;
  this.errorMessage = '';

  this.userService.getUsers().subscribe({
    next: (data) => {
      console.log('Users loaded successfully:', data);
      this.users = data;
      this.loading = false;
      this.errorMessage = '';
    },
    error: () => {
      this.errorMessage = 'Failed to load users';
      this.loading = false;
    }
  });
}
}
