(function () {

    $(function () {
        $('#ChangePasswordButton').click(function (e) {
           
            e.preventDefault();
            abp.ui.setBusy(
                $('#ChangePasswordArea'),
                abp.ajax({
                    url: abp.appPath + 'Account/ChangePasswordSave',
                    type: 'POST',
                    data: JSON.stringify({
                       
                        usernameOrEmailAddress: $('#EmailAddressInput').val(),
                        currentPassword: $('#CurrentPasswordInput').val(),
                        newPassword: $('#NewPasswordInput').val()
                    })
                })
            );
        });

        $('a.social-login-link').click(function () {
            var $a = $(this);
            var $form = $a.closest('form');
            $form.find('input[name=provider]').val($a.attr('data-provider'));
            $form.submit();
        });

        $('#ReturnUrlHash').val(location.hash);

        $('#LoginForm input:first-child').focus();
    });

})();