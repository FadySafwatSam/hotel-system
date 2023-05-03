
window.onload = function () {
    const form = {
        userName: document.querySelector("#userName"),
        password: document.querySelector("#password"),
        submit: document.getElementById("sub"),
        messages: document.getElementById("form-messages"),
    };
    var elem = document.getElementById("good");

    let button = form.submit.addEventListener("click", (e) => {
        e.preventDefault();
        const login = "http://localhost:60216/Account/Register";
        console.log(form.userName.value);

        fetch(login, {
            method: "POST",
            headers: {
                Accept: "application/json, text/plain, */*",
                "Content-Type": "application/json",
            },
            body: JSON.stringify({
                userName: form.userName.value,
                password: form.password.value,
            }),
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data);

                elem.innerHTML = data[0];

                // code here //
                if (data.error) {
                    alert("Error Password or Username"); /*displays error message*/
                } else {
                    window.open(
                        "Home.html"
                    ); /*opens the target page while Id & password matches*/
                }
            })
            .catch((err) => {
                console.log(err);
            });
    });

}