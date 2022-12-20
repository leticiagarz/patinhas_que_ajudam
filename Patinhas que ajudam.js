const inputbutton = document.getElementById("input-button");
        const username = document.getElementById("input-user");
        const password = document.getElementById("input-password");

        const autenticar = function()
        {
           
            if(username.value == "2411" && password.value == "1501"){
                window.location.href = "MenuAdmin.html";
            }
            else{
                alert('Login ou senha incorretos');
            }
        }

        inputbutton.addEventListener('click', () => autenticar())
        
            function myFunction() { 
    document.getElementById("cardContainer").style.display="none"; 
    document.getElementById("secondCardContainer").style.display="block"; 
            }