var login = login || { };

login.check = function(){
    let email = $('#email').val();
    let pass = $('#pass').val();
    let isLogged = false;
    $.ajax({
        url:"http://192.168.1.3:3000/users",
        method: "GET",
        dataType: "json",
        success: function(data){
            $.each(data, function(i, v){
                if(v.username == email && v.password == pass){
                    isLogged = true;
                    window.location.href = "../admin/dashboard.html";
                }
            })
            if(!isLogged){
                $('#loginFail').removeClass('d-none');
            }
        }
    });
}

$(document).ready(function(){

});