function validateUser(event)
{
    
    var email=document.getElementById("email").value;
    // var email = emailInput.value;
    var password=document.getElementById("password").value;
    var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if(email=="" ||  email==null)
    {
        alert("Please Enter Your Email ");
        return false;
    }
     if (!emailPattern.test(email)) {
        alert("Please enter a valid email address");
        emailInput.focus();
        emailInput.select();
        return false;
    }
    if(password=="" ||  password==null)
    {
        alert("Please Enter Your Password ");
        return false;
    }
     loginCheck();

}

function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();
    
    
    if(email== "lessile@gmail.com" && password=="1234")
    {
        window.location = "./profile.html";
        
        return true;
    }
    else{
        alert("invalid email or password");
        return false;
    }
}

