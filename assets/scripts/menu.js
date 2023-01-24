
        const search = () => {
            const searchbox = document.getElementById("search-dogs").value.toUpperCase();
            const dogsavalible = document.getElementById("dogs-to-adopt")
            const dog = document.querySelectorAll(".dog-card")
            const dogdata = dogsavalible.getElementsByClassName('dog-card-data')


            for (var i = 0; i < dogdata.length; i++) {
                let match = dog[i].getElementsByClassName('dog-card-data')[0];

                if (match) {
                    let textvalue = match.textContent || match.innerHTML

                    if (textvalue.toUpperCase().indexOf(searchbox) > -1) {
                        dog[i].style.display = "";
                    } else {
                        dog[i].style.display = "none";
                    }
                }
            }
        }

        function addFunction() {
            document.getElementById("btnContainer").style.display = "none";
            document.getElementById("addCardContainer").style.display = "block";
        }
        function removeFunction() {
            document.getElementById("btnContainer").style.display = "none";
            document.getElementById("removeCardContainer").style.display = "block";
            
        }
        function myFunction() {
            document.getElementById("addCardContainer").style.display = "none";
            document.getElementById("false-add").style.display = "block";
            document.getElementById("btnContainer").style.display = "block";
        }