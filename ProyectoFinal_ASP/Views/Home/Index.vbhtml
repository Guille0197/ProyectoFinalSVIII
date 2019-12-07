@Code
    ViewData("Title") = "Home Page"
End Code

<!-- Intro Banner
        ================================================== -->
<!-- add class "disable-gradient" to enable consistent background overlay -->
<div class="intro-banner" data-background-image="Content/HireoTemplate/images/home-background.jpg">
    <div class="container">

        <!-- Intro Headline -->
        <div class="row">
            <div class="col-md-12">
                <div class="banner-headline">
                    <h3>
                        <strong>Contrata expertos o ser contratado para cualquier trabajo, en cualquier momento.</strong>
                        <br>
                        <span>Miles de pequeñas empresas utilizan <strong class="color">JobHire</strong> para convertir sus ideas en realidad.</span>
                    </h3>
                </div>
            </div>
        </div>

        <!-- Search Bar -->
        <div class="row">
            <div class="col-md-12">
                <div class="intro-banner-search-form margin-top-95">

                    <!-- Search Field -->
                    <div class="intro-search-field">
                        <label for="intro-keywords" class="field-title ripple-effect">¿Que trabajo quieres?</label>
                        <input id="intro-keywords" type="text" placeholder="Puesto, empresa o palabra clave">
                    </div>

                    <!-- Button -->
                    <div class="intro-search-button">
                        <button class="button ripple-effect" onclick="window.location.href='jobs-list-layout-full-page-map.html'">Buscar</button>
                    </div>
                </div>
            </div>
        </div>

        <!-- Stats -->
        <div class="row">
            <div class="col-md-12">
                <ul class="intro-stats margin-top-45 hide-under-992px">
                    <li>
                        <strong class="counter">1,586</strong>
                        <span>Empleos publicados</span>
                    </li>
                    <li>
                        <strong class="counter">1,232</strong>
                        <span>Clientes</span>
                    </li>
                </ul>
            </div>
        </div>

    </div>
</div>


<!-- Content
================================================== -->
<!-- Popular Job Categories -->
<div class="section margin-top-65 margin-bottom-30">
    <div class="container">
        <div class="row">

            <!-- Section Headline -->
            <div class="col-xl-12">
                <div class="section-headline centered margin-top-0 margin-bottom-45">
                    <h3>Categorías Populares</h3>
                </div>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-1.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-01.jpg">
                    <div class="photo-box-content">
                        <h3>Diseñadores web</h3>
                        <span>612</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-full-page-map.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-02.jpg">
                    <div class="photo-box-content">
                        <h3>Secretarias / Recepcionistas</h3>
                        <span>113</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-grid-layout-full-page.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-03.jpg">
                    <div class="photo-box-content">
                        <h3>Soporte Técnico</h3>
                        <span>186</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-2.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-04.jpg">
                    <div class="photo-box-content">
                        <h3>Diseñadores Gráfico / Diseño</h3>
                        <span>298</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-1.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-05.jpg">
                    <div class="photo-box-content">
                        <h3>Conductores / Choferes</h3>
                        <span>549</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-full-page-map.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-06.jpg">
                    <div class="photo-box-content">
                        <h3>Vendedores</h3>
                        <span>873</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-grid-layout-full-page.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-07.jpg">
                    <div class="photo-box-content">
                        <h3>Contabilidad / Contadores</h3>
                        <span>125</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-2.html" class="photo-box small" data-background-image="Content/HireoTemplate/images/job-category-08.jpg">
                    <div class="photo-box-content">
                        <h3>Desarrolladores / Programadores</h3>
                        <span>445</span>
                    </div>
                </a>
            </div>

        </div>
    </div>
</div>
<!-- Category Boxes / End -->
<!-- Features Jobs -->
<div class="section gray margin-top-45 padding-top-65 padding-bottom-75">
    <div class="container">
        <div class="row">
            <div class="col-xl-12">

                <!-- Section Headline -->
                <div class="section-headline margin-top-0 margin-bottom-35">
                    <h3>Trabajos destacados</h3>
                    <a href="jobs-list-layout-full-page-map.html" class="headline-link">Buscar todos los trabajos</a>
                </div>

                <!-- Jobs Container -->
                <div class="listings-container compact-list-layout margin-top-35">

                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-01.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">Bilingual Event Support Specialist</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> Hexagon <div class="verified-badge" title="Verified Employer" data-tippy-placement="top"></div></li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Tiempo Completo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 1 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>


                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-05.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">Competition Law Officer</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> Laxo</li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Tiempo Completo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 2 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>
                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-02.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">Barista and Cashier</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> Coffee</li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Tiempo Completo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 3 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>


                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-03.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">Restaurant General Manager</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> King <div class="verified-badge" title="Verified Employer" data-tippy-placement="top"></div></li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Medio Tiempo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 3 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>

                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-05.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">International Marketing Coordinator</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> Skyist</li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Tiempo Completo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 4 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>

                    <!-- Job Listing -->
                    <a href="single-job-page.html" class="job-listing with-apply-button">

                        <!-- Job Listing Details -->
                        <div class="job-listing-details">

                            <!-- Logo -->
                            <div class="job-listing-company-logo">
                                <img src="~/Content/HireoTemplate/images/company-logo-05.png" alt="">
                            </div>

                            <!-- Details -->
                            <div class="job-listing-description">
                                <h3 class="job-listing-title">Competition Law Officer</h3>

                                <!-- Job Listing Footer -->
                                <div class="job-listing-footer">
                                    <ul>
                                        <li><i class="icon-material-outline-business"></i> Laxo</li>
                                        <li><i class="icon-material-outline-location-on"></i> San Francissco</li>
                                        <li><i class="icon-material-outline-business-center"></i> Medio Tiempo</li>
                                        <li><i class="icon-material-outline-access-time"></i> Hace 5 día</li>
                                    </ul>
                                </div>
                            </div>

                            <!-- Apply Button -->
                            <span class="list-apply-button ripple-effect">Aplicar</span>
                        </div>
                    </a>

                </div>
                <!-- Jobs Container / End -->

            </div>
        </div>
    </div>
</div>
<!-- Featured Jobs / End -->
<!-- Features Cities -->
<div class="section margin-top-65 margin-bottom-65">
    <div class="container">
        <div class="row">

            <!-- Section Headline -->
            <div class="col-xl-12">
                <div class="section-headline centered margin-top-0 margin-bottom-45">
                    <h3>Ciudades destacadas</h3>
                </div>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-1.html" class="photo-box" data-background-image="Content/HireoTemplate/images/featured-city-01.jpg">
                    <div class="photo-box-content">
                        <h3>Panamá</h3>
                        <span>876 Trabajos</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-full-page-map.html" class="photo-box" data-background-image="Content/HireoTemplate/images/featured-city-02.jpg">
                    <div class="photo-box-content">
                        <h3>Herrera</h3>
                        <span>645 Trabajos</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-grid-layout-full-page.html" class="photo-box" data-background-image="Content/HireoTemplate/images/featured-city-03.jpg">
                    <div class="photo-box-content">
                        <h3>Los Santos</h3>
                        <span>332 Trabajos</span>
                    </div>
                </a>
            </div>

            <div class="col-xl-3 col-md-6">
                <!-- Photo Box -->
                <a href="jobs-list-layout-2.html" class="photo-box" data-background-image="Content/HireoTemplate/images/featured-city-04.jpg">
                    <div class="photo-box-content">
                        <h3>Chiriqui</h3>
                        <span>113 Trabajos</span>
                    </div>
                </a>
            </div>

        </div>
    </div>
</div>
<!-- Features Cities / End -->
<!-- Icon Boxes -->
<div class="section padding-top-65 padding-bottom-65">
    <div class="container">
        <div class="row">

            <div class="col-xl-12">
                <!-- Section Headline -->
                <div class="section-headline centered margin-top-0 margin-bottom-5">
                    <h3>¿Cómo funciona?</h3>
                </div>
            </div>

            <div class="col-xl-4 col-md-4">
                <!-- Icon Box -->
                <div class="icon-box with-line">
                    <!-- Icon -->
                    <div class="icon-box-circle">
                        <div class="icon-box-circle-inner">
                            <i class="icon-line-awesome-lock"></i>
                            <div class="icon-box-check"><i class="icon-material-outline-check"></i></div>
                        </div>
                    </div>
                    <h3>Crea una cuenta</h3>
                    <p>Traiga a la mesa estrategias de supervivencia de ganar-ganar para garantizar una dominación proactiva en el futuro.</p>
                </div>
            </div>

            <div class="col-xl-4 col-md-4">
                <!-- Icon Box -->
                <div class="icon-box with-line">
                    <!-- Icon -->
                    <div class="icon-box-circle">
                        <div class="icon-box-circle-inner">
                            <i class="icon-line-awesome-legal"></i>
                            <div class="icon-box-check"><i class="icon-material-outline-check"></i></div>
                        </div>
                    </div>
                    <h3>Seleccione la oferta</h3>
                    <p>Libere eficientemente información de medios cruzados y Maximice rápidamente el retorno de la inversión.</p>
                </div>
            </div>

            <div class="col-xl-4 col-md-4">
                <!-- Icon Box -->
                <div class="icon-box">
                    <!-- Icon -->
                    <div class="icon-box-circle">
                        <div class="icon-box-circle-inner">
                            <i class=" icon-line-awesome-trophy"></i>
                            <div class="icon-box-check"><i class="icon-material-outline-check"></i></div>
                        </div>
                    </div>
                    <h3>Trabaje con los mejores</h3>
                    <p>Trabajar contando con la motivación laboral adecuada marca la diferencia en nuestra productividad.</p>
                </div>
            </div>

        </div>
    </div>
</div>
<!-- Icon Boxes / End -->
<!-- Highest Rated Freelancers -->
<div class="section gray padding-top-65 padding-bottom-70 full-width-carousel-fix">
    <div class="container">
        <div class="row">

            <div class="col-xl-12">
                <!-- Section Headline -->
                <div class="section-headline margin-top-0 margin-bottom-25">
                    <h3>Las empresas mejor calificadas</h3>
                </div>
            </div>

            <div class="col-xl-12">
                <div class="default-slick-carousel freelancers-container freelancers-grid-layout">

                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-01.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>

                        <!-- Details -->
                        @*<div class="freelancer-details">
                <div class="freelancer-details-list">
                    <p>Lorem ipsum etc etc ....</p>
                </div>
            </div>*@
                    </div>
                    <!-- Freelancer / End -->
                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-02.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Freelancer / End -->
                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-03.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Freelancer / End -->
                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-04.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Freelancer / End -->
                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-05.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Freelancer / End -->
                    <!--Freelancer -->
                    <div class="freelancer">

                        <!-- Overview -->
                        <div class="freelancer-overview">
                            <div class="freelancer-overview-inner">

                                <!-- Bookmark Icon -->
                                <span class="bookmark-icon"></span>

                                <!-- Avatar -->
                                <div class="freelancer-avatar">
                                    <div class="verified-badge"></div>
                                    <a href="#"><img src="~/Content/HireoTemplate/images/user-avatar-big-06.jpg" alt=""></a>
                                </div>

                                <!-- Name -->
                                <div class="freelancer-name">
                                    <h4><a href="#">Banistmo </a></h4>
                                </div>

                                <!-- Rating -->
                                <div class="freelancer-rating">
                                    <div class="star-rating" data-rating="4.9"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Freelancer / End -->
                </div>
            </div>

        </div>
    </div>
</div>
<!-- Highest Rated Freelancers / End-->
<!-- Membership Plans -->
@*<div class="section padding-top-60 padding-bottom-75">
    <div class="container">
        <div class="row">*@

@*<div class="col-xl-12">*@
<!-- Section Headline -->
@*<div class="section-headline centered margin-top-0 margin-bottom-35">
            <h3>Membership Plans</h3>
        </div>
    </div>*@


@* <div class="col-xl-12">*@

<!-- Billing Cycle  -->
@*<div class="billing-cycle-radios margin-bottom-70">
        <div class="radio billed-monthly-radio">
            <input id="radio-5" name="radio-payment-type" type="radio" checked>
            <label for="radio-5"><span class="radio-label"></span> Billed Monthly</label>
        </div>

        <div class="radio billed-yearly-radio">
            <input id="radio-6" name="radio-payment-type" type="radio">
            <label for="radio-6"><span class="radio-label"></span> Billed Yearly <span class="small-label">Save 10%</span></label>
        </div>
    </div>*@

<!-- Pricing Plans Container -->
@*<div class="pricing-plans-container">*@

<!-- Plan -->
@*<div class="pricing-plan">
        <h3>Basic Plan</h3>
        <p class="margin-top-10">One time fee for one listing or task highlighted in search results.</p>
        <div class="pricing-plan-label billed-monthly-label"><strong>$19</strong>/ monthly</div>
        <div class="pricing-plan-label billed-yearly-label"><strong>$205</strong>/ yearly</div>
        <div class="pricing-plan-features">
            <strong>Features of Basic Plan</strong>
            <ul>
                <li>1 Listing</li>
                <li>30 Days Visibility</li>
                <li>Highlighted in Search Results</li>
            </ul>
        </div>
        <a href="pages-checkout-page.html" class="button full-width margin-top-20">Buy Now</a>
    </div>*@

<!-- Plan -->
@*<div class="pricing-plan recommended">
        <div class="recommended-badge">Recommended</div>
        <h3>Standard Plan</h3>
        <p class="margin-top-10">One time fee for one listing or task highlighted in search results.</p>
        <div class="pricing-plan-label billed-monthly-label"><strong>$49</strong>/ monthly</div>
        <div class="pricing-plan-label billed-yearly-label"><strong>$529</strong>/ yearly</div>
        <div class="pricing-plan-features">
            <strong>Features of Standard Plan</strong>
            <ul>
                <li>5 Listings</li>
                <li>60 Days Visibility</li>
                <li>Highlighted in Search Results</li>
            </ul>
        </div>
        <a href="pages-checkout-page.html" class="button full-width margin-top-20">Buy Now</a>
    </div>*@

<!-- Plan -->
@*<div class="pricing-plan">*@


@*<h3>Extended Plan</h3>
                            <p class="margin-top-10">One time fee for one listing or task highlighted in search results.</p>
                            <div class="pricing-plan-label billed-monthly-label"><strong>$99</strong>/ monthly</div>
                            <div class="pricing-plan-label billed-yearly-label"><strong>$1069</strong>/ yearly</div>
                            <div class="pricing-plan-features">
                                <strong>Features of Extended Plan</strong>
                                <ul>
                                    <li>Unlimited Listings Listing</li>
                                    <li>90 Days Visibility</li>
                                    <li>Highlighted in Search Results</li>
                                </ul>
                            </div>
                            <a href="pages-checkout-page.html" class="button full-width margin-top-20">Buy Now</a>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>*@
<!-- Membership Plans / End-->
