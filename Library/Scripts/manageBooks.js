function editBegin(id) {
    document.getElementById(id).style.display = "none";
    document.getElementById(id).nextSibling.nextSibling.style.display = "inline-block";
    var num = id.replace(/\D/g, '');
    document.getElementById("thumbnailImage-" + num).style.display = "none";
    document.getElementById("imageUpload-" + num).style.display = "inline-block";
}

function editEnd(id) {
    document.getElementById(id).style.display = "none";
    document.getElementById(id).previousSibling.previousSibling.style.display = "inline-block";
    var num = id.replace(/\D/g, '');
    document.getElementById("thumbnailImage-" + num).style.display = "inline";
    document.getElementById("imageUpload-" + num).style.display = "none";
}