<!doctype html>
<html lang="es-pa">
<head>

    <!-- Basic Page Needs
    ================================================== -->
    <title>JobHire</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

    <!-- CSS
    ================================================== -->
    @Styles.Render("~/Content/Hireo_css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>

    <!-- Wrapper -->
    <div id="wrapper">

        <!-- Header Container
    ================================================== -->
        <header id="header-container" class="fullwidth">

            <!-- Header -->
            <div id="header">
                <div class="container">

                    <!-- Left Side Content -->
                    <div class="left-side">

                        <!-- Logo -->
                        <div id="logo">
                            <a href="@Url.Action("index", "Home")"><img src="~/Content/HireoTemplate/images/logo.png" alt=""></a>
                        </div>

                        <!-- Main Navigation -->
                        <!-- Main Navigation / End -->

                    </div>
                    <!-- Left Side Content / End -->
                    <!-- Right Side Content / End -->
                    <div class="right-side">

                        <div class="header-widget">
                            <a href="#sign-in-dialog" class="popup-with-zoom-anim log-in-button"><i class="icon-feather-log-in"></i> <span> Iniciar sesión / Registrarse</span></a>
                        </div>


                    </div>
                    <!-- Right Side Content / End -->

                </div>
            </div>
            <!-- Header / End -->

        </header>
        <div class="clearfix"></div>
        <!-- Header Container / End -->


        <!-- Se mostrara cada pantalla / Start -->
             @RenderBody()
        <!-- Fin / End -->



        <!-- Footer
    ================================================== -->
        <div id="footer">

            <!-- Footer Top Section -->
            <div class="footer-top-section">
                <div class="container">
                    <div class="row">
                        <div class="col-xl-12">

                            <!-- Footer Rows Container -->
                            <div class="footer-rows-container">

                                <!-- Left Side -->
                                <div class="footer-rows-left">
                                    <div class="footer-row">
                                        <div class="footer-row-inner footer-logo">
                                            <img src="~/Content/HireoTemplate/images/logo2.png" alt="">
                                        </div>
                                    </div>
                                </div>

                                <!-- Right Side -->
                                <div class="footer-rows-right">

                                    <!-- Social Icons -->
                                    <div class="footer-row">
                                        <div class="footer-row-inner">
                                            <ul class="footer-social-links">
                                                <li>
                                                    <a href="#" title="Facebook" data-tippy-placement="bottom" data-tippy-theme="light">
                                                        <i class="icon-brand-facebook-f"></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href="#" title="Twitter" data-tippy-placement="bottom" data-tippy-theme="light">
                                                        <i class="icon-brand-twitter"></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href="#" title="LinkedIn" data-tippy-placement="bottom" data-tippy-theme="light">
                                                        <i class="icon-brand-linkedin-in"></i>
                                                    </a>
                                                </li>
                                            </ul>
                                            <div class="clearfix"></div>
                                        </div>
                                    </div>

                                </div>

                            </div>
                            <!-- Footer Rows Container / End -->
                        </div>
                    </div>
                </div>
            </div>
            <!-- Footer Top Section / End -->
            <!-- Footer Middle Section -->
            <div class="footer-middle-section">
                <div class="container">
                    <div class="row">

                        <!-- Links -->
                        <div class="col-xl-2 col-lg-2 col-md-3">
                            <div class="footer-links">
                                <h3>Para los candidatos</h3>
                                <ul>
                                    <li><a href="#"><span>Añadir currículum</span></a></li>
                                    <li><a href="#"><span>Alertas de trabajo</span></a></li>
                                </ul>
                            </div>
                        </div>

                        <!-- Links -->
                        <div class="col-xl-2 col-lg-2 col-md-3">
                            <div class="footer-links">
                                <h3>Para empleadores</h3>
                                <ul>
                                    <li><a href="#"><span>Examinar candidatos</span></a></li>
                                    <li><a href="#"><span>Anunciar un trabajo</span></a></li>
                                    <li><a href="#"><span>Publica una tarea</span></a></li>
                                </ul>
                            </div>
                        </div>

                        <!-- Links -->
                        <div class="col-xl-2 col-lg-2 col-md-3">
                            <div class="footer-links">
                                <h3>Enlaces Útiles</h3>
                                <ul>
                                    <li><a href="#"><span>Contactos</span></a></li>
                                    <li><a href="#"><span>Política de privacidad</span></a></li>
                                    <li><a href="#"><span>Términos de Uso</span></a></li>
                                </ul>
                            </div>
                        </div>

                        <!-- Newsletter -->
                        <div class="col-xl-4 col-lg-4 col-md-12">
                            <h3><i class="icon-feather-mail"></i>Regístrese para recibir un boletín informativo</h3>
                            <p>Noticias de última hora, análisis y consejos de vanguardia en la búsqueda de empleo.</p>
                            <form action="#" method="get" class="newsletter">
                                <input type="text" name="fname" placeholder="Ingrese su dirección de correo">
                                <button type="submit"><i class="icon-feather-arrow-right"></i></button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Footer Middle Section / End -->
            <!-- Footer Copyrights -->
            <div class="footer-bottom-section">
                <div class="container">
                    <div class="row">
                        <div class="col-xl-12">
                            © 2019 <strong>JobHire</strong>. Todos los derechos reservados. | <a href="https://github.com/Jmangel015/ProyectoFinalSVIII" target="_blank"> <span>Development ❤</span></a>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Footer Copyrights / End -->

        </div>
        <!-- Footer / End -->

    </div>
    <!-- Wrapper / End -->

    <!-- Sign In Popup / iniciar sesion y registrarse
    ================================================== -->
    <div id="sign-in-dialog" class="zoom-anim-dialog mfp-hide dialog-with-tabs">

        <!--Tabs -->
        <div class="sign-in-form">

            <ul class="popup-tabs-nav">
                <li><a href="#login">Iniciar sesión</a></li>
                <li><a href="#register">Registro</a></li>
            </ul>
            
            <div class="popup-tabs-container">

                <!-- Login -->
                <div class="popup-tab-content" id="login">

                    <!-- Welcome Text -->
                    <div class="welcome-text">
                        <h3>¡Nos alegra verte de nuevo!</h3>
                        <span>¿No tienes una cuenta? <a href="#" class="register-tab">¡Regístrate!!</a></span>
                    </div>

                    <!-- Form -->
                    <form method="post" id="login-form">
                        <div class="input-with-icon-left">
                            <i class="icon-material-baseline-mail-outline"></i>
                            <input type="text" class="input-text with-border" name="emailaddress" id="emailaddress" placeholder="Dirección de correo" required />
                        </div>

                        <div class="input-with-icon-left">
                            <i class="icon-material-outline-lock"></i>
                            <input type="password" class="input-text with-border" name="password" id="password" placeholder="Contraseña" required />
                        </div>
                        <a href="#" class="forgot-password">
                            ¿Se te olvidó tu contraseña?
                        </a>
                    </form>

                    <!-- Button -->
                    <button class="button full-width button-sliding-icon ripple-effect" type="submit" form="login-form">Iniciar sesión <i class="icon-material-outline-arrow-right-alt"></i></button>


                </div>

                <!-- Register -->
                <div class="popup-tab-content" id="register">

                    <!-- Welcome Text -->
                    <div class="welcome-text">
                        <h3>¡Creemos su cuenta!</h3>
                    </div>

                    <!-- Account Type -->
                    <div class="account-type">
                        <div>
                            <input type="radio" name="account-type-radio" id="freelancer-radio" class="account-type-radio" checked />
                            <label for="freelancer-radio" class="ripple-effect-dark"><i class="icon-material-outline-account-circle"></i> Usuario</label>
                        </div>
                    </div>

                    <!-- Form -->
                    <form method="post" id="register-account-form">
                        <div class="input-with-icon-left">
                            <i class="icon-material-baseline-mail-outline"></i>
                            <input type="text" class="input-text with-border" name="emailaddress-register" id="emailaddress-register" placeholder="Dirección de correo" required />
                        </div>

                        <div class="input-with-icon-left" title="Should be at least 8 characters long" data-tippy-placement="bottom">
                            <i class="icon-material-outline-lock"></i>
                            <input type="password" class="input-text with-border" name="password-register" id="password-register" placeholder="Contraseña" required />
                        </div>

                        <div class="input-with-icon-left">
                            <i class="icon-material-outline-lock"></i>
                            <input type="password" class="input-text with-border" name="password-repeat-register" id="password-repeat-register" placeholder="Repetir contraseña" required />
                        </div>
                    </form>

                    <!-- Button -->
                    <button class="margin-top-10 button full-width button-sliding-icon ripple-effect" type="submit" form="register-account-form">Registro <i class="icon-material-outline-arrow-right-alt"></i></button>

                </div>

            </div>
        </div>
    </div>
    <!-- Sign In Popup / End -->

    <!-- Scripts
    ================================================== -->

    <!-- Google Autocomplete -->
    <script>
        function initAutocomplete() {
            var options = {
                types: ['(cities)'],
                // componentRestrictions: {country: "us"}
            };

            var input = document.getElementById('autocomplete-input');
            var autocomplete = new google.maps.places.Autocomplete(input, options);
        }

        // Autocomplete adjustment for homepage
        if ($('.intro-banner-search-form')[0]) {
            setTimeout(function () {
                $(".pac-container").prependTo(".intro-search-field.with-autocomplete");
            }, 300);
        }

    </script>

    <!-- Google API -->
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAgeuuDfRlweIs7D6uo4wdIHVvJ0LonQ6g&libraries=places&callback=initAutocomplete"></script>

    @Scripts.Render("~/Content/Hireo_js")
    @* @RenderSection("scripts", required:     false)*@
</body>
</html>
