function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah').attr('src', e.target.result)
                .width(150)
                .height(200);
        };

        reader.readAsDataURL(input.files[0]);
    }
}




//function videotype(code) {
//    var opt1 = document.getElementById("option1");
//    var opt2 = document.getElementById("option2");
//    if (code == 1) {
        

//        opt1.disabled = false;
//        opt2.disabled = true;
//        console.log("1");
        
//    }
//    else if (code == 2) {

//        opt2.disabled = false;
       
//        opt1.disabled = true;
//        console.log("2");
//    }
//}