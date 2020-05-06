var dashboard = dashboard || { }

dashboard.drawTable = function(){
    $.ajax({
        url: "http://192.168.1.3:3000/products",
        method: "GET",
        dataType : "json",
        success : function(data){
            $('#tbProducts tbody').empty();
            let id = 1;
            $.each(data, function(i, v){
                $('#tbProducts tbody').append(
                    "<tr>"+
                        "<td>" + (id++) +"</td>"+ //data[i].id
                        "<td>"+ v.productName +"</td>"+
                        "<td><img src='../"+ v.productImage +"' width='120px' height='150px'></td>"+
                        "<td>" + v.price +"</td>"+
                        "<td>" + v.manufactory + "</td>"+
                        "<td>" + v.description + "</td>"+
                        "<td>"+
                            "<a href='javascript:;' onclick='dashboard.productDetail(" + v.id + ");'><i class='fa fa-edit'></i></a> "+
                            "<a href='javascript:;' onclick='dashboard.remove("+ v.id +");'><i class='fa fa-trash'></i></a>"+
                        "</td>"+
                    "</tr>"
                );
            })
        }
    });
}

dashboard.openModal = function(){
    dashboard.restForm();
    $('#addEditModal').modal('show');
}

dashboard.remove = function(id){
    bootbox.confirm({
        title: "Remove Product?",
        message: "Do you want to remove this product?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if(result){
                $.ajax({
                    url : "http://192.168.1.3:3000/products/" + id,
                    method : "DELETE", //"POST"
                    dataType:'json',
                    success : function(data){
                        dashboard.drawTable();
                        bootbox.alert("Product has been deleted successfully");
                    }
                });
            }
        }
    });
}

dashboard.save = function(){
    if($('#formAddEditProduct').valid()){
        if($('#productId').val() == 0){ //Add new product
            var addObj = {};
            addObj.productName = $('#ProductName').val();
            addObj.productImage = $('#ProductImage').val();
            addObj.price = $('#Price').val();
            addObj.manufactory = $('#Manufactory').val(), //$( "#Manufactory option:selected" ).text(); ;
            addObj.description = $('#Description').val();
            
            $.ajax({
                url : "http://192.168.1.3:3000/products",
                method : "POST",
                dataType: "json",
                contentType: "application/json",
                data : JSON.stringify(addObj),
                success : function(data){
                    $('#addEditModal').modal('hide');
                    dashboard.drawTable();
                    bootbox.alert("Product has been added successfully");
    
                }
            })
        }
        else{ //update product
            var updateObj = {};
            updateObj.productName = $('#ProductName').val();
            updateObj.productImage = $('#ProductImage').val();
            updateObj.price = $('#Price').val();
            updateObj.manufactory = $('#Manufactory').val(),
            updateObj.description = $('#Description').val();
            updateObj.id = $('#productId').val();
            
            $.ajax({
                url : "http://192.168.1.3:3000/products/" + updateObj.id,
                method : "PUT",
                dataType: "json",
                contentType: "application/json",
                data : JSON.stringify(updateObj),
                success : function(data){
                    $('#addEditModal').modal('hide');
                    dashboard.drawTable();
                    bootbox.alert("Product has been updated successfully");
    
                }
            })
        }
    };
}


dashboard.productDetail = function(id){
    $.ajax({
        url : "http://192.168.1.3:3000/products/" + id,
        method: "GET",
        dataType: 'json',
        success : function(data){
            $('#ProductName').val(data.productName);
            $('#ProductImage').val(data.productImage);
            $('#Price').val(data.price);
            $('#Manufactory').val(data.manufactory);
            $('#Description').val(data.description);
            $('#productId').val(data.id);

            $('#addEditModal').find('.modal-title').text('Update Product');
            $('#btnProduct').text("Update");
            $('#addEditModal').modal('show');
        }
    });

}

dashboard.restForm = function(){
    $('#ProductName').val('');
    $('#ProductImage').val('');
    $('#Price').val('');
    $('#Manufactory').val('ThaiLand');
    $('#addEditModal').find('.modal-title').text('Create New Product');
    $('#btnProduct').text("Create");
    $('#Description').val('');
    $('#productId').val('0');
}

dashboard.init = function(){
    dashboard.drawTable();
}

$(document).ready(function(){
    dashboard.init();
});