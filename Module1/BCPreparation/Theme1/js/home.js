var home = home || { }

home.showProduct = function(){
    $.ajax({
        url : "http://localhost:3000/products",
        method : "GET",
        dataType : 'json',
        success : function(data){
            $.each(data, function(i, v){
                $('#products').append(
                    '<div class="col-md-4 col-sm-6 portfolio-item">'+
                        '<a href="javascript:;" class="portfolio-link" onclick="home.productDetail('+ v.id +')">'+
                            '<div class="portfolio-hover">'+
                                '<div class="portfolio-hover-content">'+
                                    '<i class="fa fa-plus fa-3x"></i>'+
                                '</div>'+
                            '</div>'+
                            '<img class="img-fluid" src=" ' + v.productImage + ' " alt="">'+
                        '</a>'+
                        '<div class="portfolio-caption">'+
                            '<h4>' + v.productName + '</h4>'+
                            '<p class="text-muted">'+ v.price +'</p>'+
                        '</div>'+
                    '</div>'
                );
            });
        }
    });
}

home.productDetail = function(id){
    $.ajax({
        url : "http://localhost:3000/products/" +id,
        method : "GET",
        dataType : 'json',
        success : function(data){
            $('#ProductName').text(data.productName);
            $('#Price').text(data.price);
            $('#ProductImage').prop('src', data.productImage);
            $('#Description').text(data.description);
            $('#portfolioModal').modal('show');
        }
    });
}

home.init = function(){
    home.showProduct();
}

$(document).ready(function(){
    home.init();
});