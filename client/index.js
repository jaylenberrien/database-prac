function edit(){

    alert("edit")

}

function deleteEntry(){

    alert("deleted")

}

async function postEntry(){ 
    
    const form = document.getElementById("main-form")
    form.addEventListener("submit", function(evt){
        evt.preventDefault()
    });

    const input = document.getElementById("main-input").value
    
    try{
        const response = await fetch("http://localhost:3000/api/post", {
            method: "POST",
            body: JSON.stringify({message: input}),
            // headers: {
            //     " "
            // }
        })

        if (!response.ok){
            throw new Error(`Reponse status ${response.status}`)
        }

        const json = await response.json()
        console.log(json)

    } catch (error) {
        console.error(error.message);

    }




 


    // try {
    //     response = await axios.post("http://localhost:3000/post", data={message: input})
    //     console.log(response.data)
        
    // } catch (error) {    
    //     alert("there was an error, check console")
    //     console.log(response.data)

    // }
    
}
 
//work on connecting to db
//work on downloading and using dapper for db work

//working on model 
//working on routes
//working on controllers



//we are going to make a csproj for the client so we can add packages that we need from docs
//we are going to work getting the packages that we need for the controllers to work for the backend

