var product = product || {};

product.showProduct = function(){
    $.ajax({
        url: "http://192.168.1.3:3000/products",
        method: "GET",
        dataType : "json",
        success : function(data){
            $.each(data, function(i, v){
                $('#showProducts').append(
                    "<div class='col-lg-3 col-md-6 mb-4'>"+
                    "<div class='card h-100'>"+
                      "<img class='card-img-top' src='" + v.productImage +"' alt=''>"+
                      "<div class='card-body'>"+
                        "<h4 class='card-title'>" + v.productName + "</h4>"+
                        "<p class='card-text'> Manufactory: "+ v.manufactory +" Description: " + v.description +"</p>"+
                      "</div>"+
                      "<div class='card-footer'>"+
                        "<a href='#' class='btn btn-primary'> " + v.price +" vnđ </a>"+
                      "</div>"+
                    "</div>"+
                  "</div>"
                );
            })
        }
    });
}



product.init = function(){
    product.showProduct();
}

$(document).ready(function(){
    product.init();
});