$(document).ready(function () {
    $('#indexP').DataTable();
});


$(document).ready(function () {
    if ('@TempData["message"]' == "Deletd") {
        toastr.success('Action successfully changed....', 'ActionName');
    }
    else { }
});
