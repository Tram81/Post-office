<template>
    <div>
      <h1>Users</h1>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="user in users" :key="user.id">
            <td>{{ user.id }}</td>
            <td>{{ user.name }}</td>
            <td>{{ user.email }}</td>
            <td>
              <button @click="editUser(user)">Edit</button>
              <button @click="deleteUser(user.id)">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
      <button @click="showAddUserForm">Add User</button>
    </div>
  </template>
  
  <script>
//   import axios from 'axios';
  
//   export default {
//     name: 'Users',
//     data() {
//       return {
//         users: []
//       }
//     },
//     created() {
//       this.fetchUsers();
//     },
//     methods: {
//       fetchUsers() {
//         axios.get('/api/users')
//           .then(response => {
//             this.users = response.data;
//           })
//           .catch(error => {
//             console.error('There was an error!', error);
//           });
//       },
//       editUser(user) {
//         // Logic to display edit form
//       },
//       deleteUser(id) {
//         axios.delete(`/api/users/${id}`)
//           .then(response => {
//             this.fetchUsers();
//           })
//           .catch(error => {
//             console.error('There was an error!', error);
//           });
//       },
//       showAddUserForm() {
//         // Logic to show add form
//       }
//     }
//   }
  </script>
  