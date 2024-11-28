/* Register/Login -----------------------------------*/

//password-toggle 
$(document).ready(function () {
    //register password
    const togglePassword = $('#toggle-password');
    const passwordInput = $('#password-input');

    togglePassword.on('click', function () {
        const type = passwordInput.attr('type') === 'password' ? 'text' : 'password';
        passwordInput.attr('type', type);
        $(this).toggleClass('bi-eye-fill bi-eye-slash-fill');
    });

    //register confirm-password
    const toggleConfirmPassword = $('#toggle-confirm-password');
    const confirmPasswordInput = $('#confirm-password-input');

    toggleConfirmPassword.on('click', function () {
        const type = confirmPasswordInput.attr('type') === 'password' ? 'text' : 'password';
        confirmPasswordInput.attr('type', type);
        $(this).toggleClass('bi-eye-fill bi-eye-slash-fill');
    });

    //login password
    const toggleLoginPassword = $('#toggle-login-password');
    const loginPasswordInput = $('#login-password-input');

    toggleLoginPassword.on('click', function () {
        const type = loginPasswordInput.attr('type') === 'password' ? 'text' : 'password';
        loginPasswordInput.attr('type', type);
        $(this).toggleClass('bi-eye-fill bi-eye-slash-fill');
    });
});
