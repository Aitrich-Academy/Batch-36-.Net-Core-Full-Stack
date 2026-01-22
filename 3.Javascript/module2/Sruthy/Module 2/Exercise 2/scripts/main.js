var applicantList = [
    { name: "Alen", image: "images/m1.png",  experience: "3 years", location: "Banglore", qualification: "MCA" },
    { name: "Sarah", image: "./images/girl.png",  experience: "2 years", location: "Chennai", qualification: "MSc"  },
    { name: "Vivek", image: "./images/Vivek.png", experience: "5 years", location: "Thiruvananthapuram", qualification: "Btech"  },
    { name: "Deepak Joy", image: "./images/Deepak.png", experience: "2 years", location: "Calicut", qualification: "Btech"  }
];
listApplicants();
function listApplicants() {
    var contentDiv = document.getElementById('card');
    var content = document.getElementById('content');
   
   for(let value in applicantList) {

        //creating div for each item in the array
        var cardDiv = document.createElement('p');
        var image = document.createElement('img');
        image.src = applicantList[value].image;
        var name=document.createElement('b');
        name.textContent = applicantList[value].name;
        var experience=document.createElement('p');
        var qualification=document.createElement('p');
        qualification.textContent="Qualification: "+applicantList[value].qualification;
        experience.textContent="Experience: " +applicantList[value].experience;
        var location=document.createElement('p');
        location.textContent="Location: "+applicantList[value].location;
        

        // console.log(item.image);
        cardDiv.appendChild(image);
        cardDiv.appendChild(name);
        cardDiv.appendChild(qualification);
        cardDiv.appendChild(experience);
        cardDiv.appendChild(location);
        
        contentDiv.appendChild(cardDiv);
   
  }
   
}
