        const loginForm = document.querySelector('.form');
        const errorDisplay = document.getElementById('error-email');
        const errorDisplayPassword=document.getElementById('error-password')

        // 2. The validation function
            function validateLogin(event) {
            const email = document.getElementById('email').value.trim();
            const password = document.getElementById('password').value;
     


            // Define Validation Rules for 2026 standards
            const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            const minPasswordLength = 8;

            // Reset error display
    
            errorDisplay.textContent = "";
            errorDisplay.style.color = "red";

            errorDisplayPassword.textContent="";
            errorDisplayPassword.style.color="red";

           
          


            // // Email Check
            if (email === "") {
                event.preventDefault(); // Stop form submission
                errorDisplay.textContent = "*****Email cannot be empty*****";
                return false;
            }

            if (!emailPattern.test(email)) {
                event.preventDefault();
                errorDisplay.textContent = "Please enter a valid email address.";
                return false;
            }

            // Password Check (Minimum 8 characters)
               if (password==="") {
                event.preventDefault();
                errorDisplayPassword.textContent = `*****Password cannot be empty`;
                return false;
            }


            if (password.length < minPasswordLength) {
                event.preventDefault();
                errorDisplayPassword.textContent = `Password must be at least ${minPasswordLength} characters.`;
                return false;
            }

            // If all checks pass
           
            alert("Form submitted successfully!");
            return true;
           
    
        }

        // 3. Attach the function to the form submit event
        loginForm.addEventListener('submit', validateLogin);
    
        console.log("Validation passed. Submitting form...");



//         const loginForm1= document.querySelector('.form');

// function validateLogin(event) {
//     const email = document.getElementById('email').value.trim();
//     const password = document.getElementById('password').value;
    
//     // Target the specific error spans
//     const emailErrorSpan = document.getElementById('email-error');
//     const passwordErrorSpan = document.getElementById('password-error');

//     // Define Validation Rules
//     const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//     const minPasswordLength = 8;

//     // 1. Reset error displays at the start of every validation
//     emailErrorSpan.textContent = "";
//     passwordErrorSpan.textContent = "";
//     let isValid = true;

//     // 2. Email Validation
//     if (email === "") {
//         emailErrorSpan.textContent = "Email cannot be empty.";
//         isValid = false;
//     } else if (!emailPattern.test(email)) {
//         emailErrorSpan.textContent = "Please enter a valid email address.";
//         isValid = false;
//     }

//     // 3. Password Validation
//     if (password.length < minPasswordLength) {
//         passwordErrorSpan.textContent = `Password must be at least ${minPasswordLength} characters.`;
//         isValid = false;
//     }

//     // 4. Handle Final Submission
//     if (!isValid) {
//         event.preventDefault(); // Stop form submission if any check failed
//         return false;
//     }

//     console.log("Validation passed. Submitting form...");
//     alert("Form submitted successfully!");
//     return true;
// }

// // Attach the function to the form submit event
// loginForm.addEventListener('submit', validateLogin);