function chklogin() {

    if (document.getElementById("txtUserID").value == "") {

        alert("Please enter UserID");
        return false

    }

    if (document.getElementById("txtPassword").value == "") {

        alert("Please enter Password");
        return false

    }

    return true


}