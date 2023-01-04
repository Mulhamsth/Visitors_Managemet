function OnSave(firstname, lastname, successful) {
    if (successful == true) {
        document.getElementById('divServerValidations').innerHTML = firstname + " " + lastname + " was saved successfully";
    }
    if (successful == false) {
        document.getElementById('divServerValidations').innerHTML = "Invalid Informations of the Visitors ";
    }
}

function setFocusOnElement(element) {
    element.focus();
}