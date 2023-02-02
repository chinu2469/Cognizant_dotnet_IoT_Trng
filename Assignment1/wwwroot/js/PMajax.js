
//Object pmobj 
/*var collected = $("#new_template_name").serialize();*/ 

//$("#createbtn").on("click", function () {
//    var collected = '[{"pM_Id": 0,"pM_Name": $("#new_template_name").val(),"asset": "string", "schedules": "string","assigned_To": "string","location": "string"}]';
//    var collectedd = $.parseJSON(collected);        //.serialize();
//    console.log(collectedd)
//    createpm(collectedd);
    
//});


//function getallpm() {                   //the all pmmethod
//    $.ajax({
//        type: 'GET',
//        url: 'https://localhost:44339/api/pmapi1',
//        success: function (pms) {
//            pmlist = pms;
//            console.log(pms);
//            $.each(pms, function (i, pm) {
//                if (pm.pM_Name != null)
//                    $('#text').append('<li> line no:' + i + 'name: ' + pm.pM_Name + ' </li>');
//            });
//        }
//    });
//}


//function getdetails(id) {                       //get pm obj method
//    $.ajax({
//        type: 'GET',
//        url: 'https://localhost:44339/api/pmapi1',
//        data: {}
//        success: function (pms) {
//            pmlist = pms;
//            console.log(pms);
//            $.each(pms, function (i, pm) {
//                if (pm.pM_Name != null)
//                    $('#text').append('<li> line no:' + i + 'name: ' + pm.pM_Name + ' </li>');
//            });
//        }
//    });
//}


//function createpm(e){//creates pm obj
//    $.ajax({
//        type: 'POST',
//        url: 'https://localhost:44339/api/pmapi1',
//        data: e,//JSON.stringify(e),
//        dataType: "json",
//        contentType: "application/json",
//      //headers : { 'Content-Type': 'application/json', 'charset': 'utf-8' },
//      /*  headers: {
//            token: ""
//        },*/
//        success: function () {
//            console.log("crete run" + e);
//            alert( "succes"+x);
//        },
//        error: function (x) {
//            console.log("error in create" + x);
//            alert(x);
//        },
//    });
//    alert(x);
//};

$(document).ready(function () {             //direct call list
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44339/api/pmapi1',
        success: function (pms) {
            pmlist = pms;
            console.log(pms);
            $.each(pms, function (i, pm) {
                if (pm.pM_Name!=null)
                    $('#text').append('<li> line no:' + i + 'name: ' + pm.pM_Name +' </li>');
            });
        },
        error: function () {
            console.log("error ocures")
        },
        
    });
});


////--------------------------------Delicious Donuts Production Facility-------------------------------ajax call

$("#delcio").on( "click",function () {             //direct call list
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44339/api/pmapi1',
        success: function (pms) {
            pmlist = pms;
            console.log(pms);
            
            $.each(pms, function (i, pm) {
                    if (pm.location == "Delicious Donuts Production Facility")
                        $('#Delicious1').append('<button class="text-start mt-1 ms-5 me-3 "> <li id="' + pm.pM_Id + '"> ' + pm.pM_Name + '</li></button >');

                    
            });
            
        },
        error: function () {
            console.log("error occurs")
        },

    });
});


//--------------------------------Greendale Poultry Farm-------------------------------ajax call

$("#greendale").click(function () {             //direct call list
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44339/api/pmapi1',
        success: function (pms) {
            pmlist = pms;
            console.log(pms);
            $.each(pms, function (i, pm) {
                    if (pm.location == "Greendale Poultry Farm")
                        $('#Greendale1').append('<button class="text-start mt-1 ms-5 me-3 "> <li id="' + pm.pM_Id + '"> ' + pm.pM_Name + '</li></button >');

            });
        },
        error: function () {
            console.log("error occurs")
        },

    });
});

////--------------------------------Milwaukee Machine Shop-------------------------------ajax call

$("#").click(function () {             //direct call list
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44339/api/pmapi1',
        success: function (pms) {
            pmlist = pms;
            console.log(pms);
            $.each(pms, function (i, pm) {
                    if (pm.location == "Milwaukee Machine Shop")
                        $('#list3').append('<button class="text-start mt-1 ms-5 me-3 "> <li id="' + pm.pM_Id + '"> ' + pm.pM_Name + '</li></button >');

            });
        },
        error: function () {
            console.log("error ocures")
        },

    });
});

//-------------------------------Nash County Quarry-------------------------------ajax call 

$("#").click(function () {             //direct call list
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44339/api/pmapi1',
        success: function (pms) {
            pmlist = pms;
            console.log(pms);
            $.each(pms, function (i, pm) {
                if (pm.location == "Greendale Poultry Farm")
                    $('#list4').append(<button class="text-start mt-1 ms-5 me-3 "> <li id="' + pm.pM_Id + '"> ' + pm.pM_Name + '</li></button >');


            });
        },
        error: function () {
            console.log("error ocures")
        },

    });
});





//$(document).ready(function () {
//    $().onclick(function () {

//    });
//});
