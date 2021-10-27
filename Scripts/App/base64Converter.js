let baseString;
let imageName;
let save = true;
const btn = document.getElementById('btnConvert');
btn.addEventListener('click', (evt) => {
    const convertedImage = {
        name: imageName,
        base64: baseString
    }
    console.log(convertedImage);

    if (save == false) {
        evt.preventDefault
    }

    $.ajax({
        type: 'POST',
        data: convertedImage,
        url: '/Home/Image',
    }).done((response) => {
        imageSaveSucces()
        setTimeout(() => {
            window.location.href = response
        }, 2000)
        
    }).fail(() => {
        imageSaveError()
    });
})

function getBaseUrl() {
    let file = document.getElementById('image')['files'][0];
    let fr = new FileReader();
    fr.onloadend = function () {
        baseString = fr.result;
    };
    fr.readAsDataURL(file);
    imageName = file.name;
    if (imageName.length > 50) {
        alert("Image name has to be less than 50 characters");
        save = false
    }
    else {
        save = true
    }
}

function imageSaveSucces() {
    
    clearContainer()
    $(".messageContainer").append('<p class = "alert alert-success">Image saved successfully<span onClick="clearContainer()" style="float:right; cursor:pointer">X</span></p>')
}

function imageSaveError() {
    clearContainer()
    $(".messageContainer").append('<p class = "alert alert-danger">Error saving image<span onClick="clearContainer()" style="float:right; cursor:pointer">X</span></p>')
}

function clearContainer() {
    $(".messageContainer .alert").remove()
}
