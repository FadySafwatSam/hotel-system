

window.onload = function () {


    let btn = document.getElementById("mybtn");
    var maincard = document.getElementById("mainCard");
    var myData = {};

    let button = btn.addEventListener("click", (e) => {
        e.preventDefault();

        console.log("i am here");
        const login = "http://localhost:60216/Home/List";

        fetch(login).then(response => response.json())
            .then(data =>
                myData = data);
      

        GetData(myData)

    });


    function GetData(data) {



        var count = Object.keys(data).length;

        for (let i = 0; i < count; i++) {

            var divcard = document.createElement("div");
            var myimg = document.createElement("img");
            var cardbody = document.createElement("div");
            var head = document.createElement("h5");
            var myp = document.createElement("p");
            var bookbtn = document.createElement("input");


            divcard.className = "card";
            bookbtn.value = "Book";
            bookbtn.type = "submit";
            bookbtn.id = data[i].roomId;
            bookbtn.className = "btn btn-primary";
            bookbtn.name = "btnbook";
            myimg.src = data[i].imgUrl;
            myimg.className = "card-img-top";
            cardbody.className = "card-body";
            head.className = "card-title";
            myp.className = "card-text";
            myp.innerText = "this is a " + data[i].roomType + " one of our best rooms";
            head.innerText = "price " + data[i].price;



            divcard.appendChild(myimg);
            cardbody.appendChild(head);
            cardbody.appendChild(myp);
            if (!data[i].isBooked) {
                cardbody.appendChild(bookbtn);

             

            } else {

                var heading = document.createElement("h6");
                heading.innerText = "this Room is booked";
                heading.className = "isbooked";
                cardbody.appendChild(heading);

            }

            
            divcard.appendChild(cardbody);
            maincard.appendChild(divcard);

            let butto = bookbtn.addEventListener("click", (e) => {
                e.preventDefault();
               
                console.log("buton work fine" + e.target.id + "good" );
                let update = { RoomID : e.target.id , id: "id"};

                fetch('http://localhost:60216/Home/DoBook', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(update),
                })
                    .then(data => {
                        if (!data.ok) {
                            throw Error(data.status);
                        }
                        return data.json();
                    }).then(update => {
                        console.log(update);
                  
                    }).catch(e => {
                        console.log(e);
                    });




     


            });


        };



 


   


    }


    

  
        

}

