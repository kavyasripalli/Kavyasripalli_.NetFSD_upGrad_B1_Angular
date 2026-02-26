class User {

    constructor(username, password) {
        this.username = username;
        this._password = "";
        this.password = password;
    }

    set password(newPassword) {
        if (newPassword.length >= 6) {
            this._password = newPassword;
            console.log("Password set successfully.");
        } else {
            console.log("Password must be at least 6 characters long.");
        }
    }

    get password() {
        return this._password;
    }

}

let user1 = new User("Kavya", "370521");

console.log("Stored Password:", user1.password);

user1.password = "123";
console.log("Stored Password After Invalid Attempt:", user1.password);

user1.password = "abcdefg";
console.log("Updated Password:", user1.password);