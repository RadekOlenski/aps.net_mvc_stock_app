import './UserCreateForm.css'

async function CreateUser() {
    console.log("request user creation");

    const newUser = {
        Username: "Adam Bąk"
    };

    let json = JSON.stringify(newUser);

    await fetch("https://localhost:7149/api/User", {
        method: "POST", headers:{
            "Content-Type":"application/json"
        },
        body:json
    });
}

export function CreateUserForm() {
    return <button className="CreateUserForm-button" onClick={CreateUser}>Create user</button>
}
