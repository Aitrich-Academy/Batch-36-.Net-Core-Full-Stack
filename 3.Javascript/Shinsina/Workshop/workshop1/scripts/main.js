// function validateForm()
// {
    
//     var jobTitle=document.myForm.jobTitle.value;  
//     var description=document.myForm.jobDescription.value;  
//     var salary=document.myForm.salary.value; 
//     var location=document.myForm.location.value; 

//     if(jobTitle==null || jobTitle=="")
//     {
//         alert(jobTitle+"Please enter your job title");
//         return false;
//     }
//      if(description==null || description=="")
//     {
//         alert("Please enter your job description");
//         return false;

//     }
//     if(salary==null || salary=="")
//     {
//         alert("Please enter your salary");
//         return false;

//     }
//     if(location==null ||location=="")
//     {
//         alert("Please enter your location");
//         return false;

//     }
    

// }

// function validateCharacter(inputChar)
// {
   
//     const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
//     if(!regex.test(inputChar))
//     {
//         alert("Allowed alphabets")
//         return false;
//     }

// }
// function validateSalary(salary) {
//      if (!regex.test(salary)) {
//         alert("Salary must be in digits only");
//         return false;
//     }
//     return true;
// }

function validateForm() {

    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 


    // Pattern for Title/Location: Letters, numbers, spaces, and basic punctuation
    const basicTextRegex = /^[a-zA-Z0-9\s,.'-]+$/;
    // const basicTextRegex = /^[a-zA-Z]+$/;
    const digitRegex = /^\d+$/;
      


    // 1. Validate Job Title
    if (jobTitle == "") {
        alert("Please enter a job title.");
        return false;
     } 
    else if (!basicTextRegex.test(jobTitle)) {
        alert("Job title contains invalid characters.");
        return false;
    }

    // 2. Validate Description
    if (description == "") {
        alert("Please enter a job description.");
        return false;
    } else if (description.length < 10) {
        // Professional descriptions usually require a minimum length
        alert("Description must be at least 10 characters long.");
        return false;
    }
     else if (!basicTextRegex.test(description)) {
        alert("description contains invalid characters.");
        return false;
    }

    //  Salary Digit Validation
    if (salary == null || salary == "") {
        alert("Please enter your salary");
        return false;
    } else if (!digitRegex.test(salary)) {
        alert("Salary must contain only digits (numbers)");
        return false;
    }

    // 3. Validate Location
    if (location == "") {
        alert("Please enter a location.");
        return false;
    } else if (!basicTextRegex.test(location)) {
        alert("Location contains invalid characters.");
        return false;
    }
    alert("Form submitted successfully!");
    return true; 

     
   
}

function validateCharacter(inputChar)
{
   
    const regex = /^[a-zA-Z]+$/; // regular expression pattern for alphabetical characters
    if(!regex.test(inputChar))
    {
        alert("Allowed alphabets")
        return false;
    }

}