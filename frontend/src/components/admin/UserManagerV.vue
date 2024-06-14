<template>
    <div id="app">
      <h2>User Management</h2>
      <UserForm @add-user="addUser" :editing-user="editingUser" @update-user="updateUser" />
      <UserTable :users="users" @edit-user="editUser" @delete-user="deleteUser" />
    </div>
  </template>
  
  <script>
//   import UserForm from './components/UserForm.vue'
//   import UserTable from './components/UserTable.vue'
  
//   export default {
//     name: 'App',
//     components: {
//       UserForm,
//       UserTable
//     },
//     data() {
//       return {
//         users: [],
//         editingUser: null
//       }
//     },
//     methods: {
//       addUser(user) {
//         this.users.push(user);
//       },
//       editUser(user) {
//         this.editingUser = user;
//       },
//       updateUser(updatedUser) {
//         const index = this.users.findIndex(user => user.username === updatedUser.username);
//         if (index !== -1) {
//           this.users.splice(index, 1, updatedUser);
//         }
//         this.editingUser = null;
//       },
//       deleteUser(user) {
//         this.users = this.users.filter(u => u.username !== user.username);
//       }
//     }
//   }
  </script>
  
  <style scoped>
  #app {
    font-family: Arial, sans-serif;
    text-align: center;
    margin-top: 50px;
  }
  </style>
  