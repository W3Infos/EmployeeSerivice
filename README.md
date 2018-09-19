# Token Based Authentication
#  1. WebAPI Project
#  2. In the root directory create a Register.html
# ------------------------------------------
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Register</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="padding-top:20px;">
    <div class="col-md-10 col-lg-offset-1">
        <div class="well">
            <table class="table table-bordered">
                <thead>
                    <tr class="success">
                        <td colspan="2">
                            New User Regsitration
                            <a class="btn btn-success pull-right" href="Login.html">Login</a>
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            Email
                        </td>
                        <td>
                            <input type="text" id="txtEmail" placeholder="Email" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Password
                        </td>
                        <td>
                            <input type="password" id="txtPassword" placeholder="Password" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Confirm Password
                        </td>
                        <td>
                            <input type="password" id="txtConfirmPassword" placeholder="Confirm Password" />
                        </td>
                    </tr>
                    <tr class="success">
                        <td colspan="2">
                            <input type="button" id="btnRegister" class="btn btn-success" value="Register" />
                        </td>
                    </tr>
                </tbody>
            </table>
            <div id="sucessModal" class="modal fade" tabindex="-1" data-keyboard="false" data-backdrop="static">
                <div class="modal-dialog modal-sm">
                    <div class="modal-content">
                        <div class="modal-header">
                           <button type="button" class="close" data-dismiss="modal">
                               &times;
                           </button>
                            <h4>Success</h4>
                        </div>
                        <div class="modal-body">
                            <h2>Registration Successfule</h2>
                        </div>
                        <div class="modal-footer">
                            <button type="button" data-dismiss="modal" class="btn btn-success">Close</button>
                        </div>
                    </div>
                </div>
            </div>

            <div id="divError" class="alert alert-danger collapse">
                <a id="linkClose" class="close" href="#">&times;</a>
                <div id="divErrorText"></div>
            </div>
        </div>
    </div>


    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {


            $("#linkClose").click(function () {

                $("#divError").hide('fade');
            })
            $("#btnRegister").click(function () {
               
                $.ajax({
                    url: 'api/account/register',
                    method: 'POST',
                    data: {
                        email: $('#txtEmail').val(),
                        password: $('#txtPassword').val(),
                        confirmPassword: $('#txtConfirmPassword').val(),
                    },
                    success: function () {
                        $("#sucessModal").modal('show');
                    },
                    error: function (jqXHR) {
                        $("#divErrorText").text(jqXHR.responseText);
                        $("#divError").show('fade');
                    }
                });

               
            })
        });
    </script>
</body>
</html>
