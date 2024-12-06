document.addEventListener("DOMContentLoaded", function(){

    const sortOpitons = document.querySelectorAll("input[name='sort']");
    
    sortOpitons.forEach(option =>{
        option.addEventListener("change", handleSortChange);
    });

    const filterOptions = document.querySelectorAll("input[name='filter']");
    
    filterOptions.forEach(option =>{
        option.addEventListener("change", handleFilterChange);
    });

    const today = new Date();
    const formattedDate = today.toISOString().split('T')[0]; 
    document.getElementById('date').value = formattedDate;    

    
    document.getElementById("search_button_welcome").addEventListener("click", function() {
      
        document.querySelector("#search_form input[name='departure']").focus();
        let welcomeContainer = document.querySelector(".welcome_message");
        welcomeContainer.style.opacity = "0.5"; 
        welcomeContainer.style.pointerEvents = "none"; 

    });

    document.getElementById("search_button").addEventListener("click", function() {

        let welcomeContainer = document.querySelector(".welcome");
        welcomeContainer.style.display = "none";
        let main = document.querySelector(".main");
        main.style.height = "auto";
        let asideContainer = document.querySelector(".aside");
        asideContainer.style.display = "block";
        let contentContainer = document.querySelector(".content");
        contentContainer.style.display = "flex";

        
    });
});

let filteredRides = [];
let searchedRides = [];

function displayRides(rides) {

    const ridesList = document.getElementById("rides_list");
    ridesList.innerHTML = ''; 

    if (rides.length === 0) {
        const noRidesMessage = document.createElement("div");
        noRidesMessage.className = "no_rides_message";
        noRidesMessage.textContent = "Nažalost, nema vožnji za Vašu pretragu.";
        ridesList.appendChild(noRidesMessage);
        return;
    }

    rides.forEach(ride => {

        const listItem = document.createElement("li");
        listItem.className = "ride_item";

        const rideDetails = document.createElement("div");
        rideDetails.className = "ride_details";

        const rideLocation = document.createElement("div");
        rideLocation.className = "ride_info";
        rideLocation.textContent = `${ride.startLocation} - ${ride.endLocation}`;

        const rideDate = document.createElement("div");
        rideDate.className = "ride_date";
        rideDate.textContent = `Datum: ${ride.date}`;

        const rideTime = document.createElement("div");
        rideTime.className = "ride_time";
        rideTime.textContent = `Vreme Polaska: ${ride.departureTime} - Vreme Dolaska: ${ride.arrivalTime}`;

        const ridePrice = document.createElement("div");
        ridePrice.className = "ride_price";
        ridePrice.textContent = ` ${ride.price} RSD`;

        rideDetails.appendChild(rideLocation);
        rideDetails.appendChild(rideDate);
        rideDetails.appendChild(rideTime);

        listItem.appendChild(rideDetails);
        listItem.appendChild(ridePrice);

        const horizontalLine = document.createElement("hr");

        const userInfo = document.createElement("div");
        userInfo.className = "user_info";

        const userIcon = document.createElement("img");
        userIcon.className = "user_icon";
        userIcon.src = "images/user.png"; 
        userIcon.alt = "User Icon";

        const userName = document.createElement("div");
        userName.className = "user_name";
        userName.textContent = ride.customer.firstName; 

        const userExperience = document.createElement("div");
        userExperience.className = "user_experience";
        userExperience.textContent = `Iskustvo: ${ride.customer.experienceLevel}/5`;

        const userRating = document.createElement("div");
        userRating.className = "user_rating";
        userRating.textContent = `Ocena: ${ride.customer.rating}/5`;

        userInfo.appendChild(userIcon);
        userInfo.appendChild(userName);
        userInfo.appendChild(userExperience);
        userInfo.appendChild(userRating);

        listItem.appendChild(horizontalLine);
        listItem.appendChild(userInfo);

        ridesList.appendChild(listItem);
    });
}

async function searchRides(event){
    event.preventDefault();
    const formData = new FormData(event.target);

    const startLocation = formData.get("departure");
    const endLocation = formData.get("arrival");
    const date = formData.get("date"); 
    const seatsAvailable = formData.get("passengers");
    const queryString = new URLSearchParams({
        StartLocation: startLocation,
        EndLocation: endLocation,
        Date: date,
        SeatsAvailable: seatsAvailable
    }).toString();

    try{
        const response = await fetch(`http://localhost:5283/search?${queryString}`, {
            method: "GET",
            headers: {"Content-Type" : "application/json"},
        });

        filteredRides = await response.json();
        searchedRides = filteredRides;
        displayRides(filteredRides);

    }catch(error){
        console.error("Error", error)
    }
}

function handleSortChange(){
    const selectedOption = document.querySelector("input[name='sort']:checked").id;
    
    switch (selectedOption){
        case "earliest-departure":
            filteredRides = filteredRides.sort((a, b) => {
                const currentDate = new Date().toISOString().split('T')[0]; 
                const aDate = new Date(`${currentDate}T${a.departureTime}`);  
                const bDate = new Date(`${currentDate}T${b.departureTime}`);
                return aDate - bDate;
            });
            break;
        case "latest-departure":
            filteredRides = filteredRides.sort((a, b) => {
                const currentDate = new Date().toISOString().split('T')[0];
                const aDate = new Date(`${currentDate}T${a.departureTime}`);  
                const bDate = new Date(`${currentDate}T${b.departureTime}`);
                return bDate - aDate; 
            });
            break;   
        case "lowest-price":
            filteredRides = filteredRides.sort((a, b) => a.price - b.price);
            break;
        case "highest-price":
            filteredRides = filteredRides.sort((a, b) => b.price - a.price);
            break;    
    }
    displayRides(filteredRides);
}

function handleFilterChange() {
    const selectedOption = document.querySelector("input[name='filter']:checked").id;
    filteredRides = searchedRides;

    switch (selectedOption) {
        case "between 6-12":
            filteredRides = filteredRides.filter(ride => {
                const [hours] = ride.departureTime.split(':').map(Number); 
                return hours >= 6 && hours < 12;  
            });
            break;
        
        case "between 12-18":
            filteredRides = filteredRides.filter(ride => {
                const [hours] = ride.departureTime.split(':').map(Number); 
                return hours >= 12 && hours <= 18;  
            });
            break;
        
        case "after 18":
            filteredRides = filteredRides.filter(ride => {
                const [hours] = ride.departureTime.split(':').map(Number); 
                return hours > 18;  
            });
            break;
    }
    displayRides(filteredRides);  
}
