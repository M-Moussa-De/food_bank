<?php include_once __DIR__ . '/includes/header.php'; ?>

<?php include_once __DIR__ . '/includes/nav.php'; ?>

<!-- Hero -->
<header class="py-5" id="hero">
    <div class="container px-4 px-lg-5 my-5">
        <div class="text-center text-white" id="hero-text">
            <h1 class="fw-bolder">Let's start <br> saving food</h1>

            <!-- BTNS -->
            <div class="btns">
                <a href="./signup.php">donators</a>
                <a href="">beneficiaries</a>
            </div>
        </div>
    </div>
</header>

<!-- Our  mission -->
<section id="mission">
    <div class="container">

        <div class="missson-text">
            <h4 class="header text-center">Why are we here?</h4>
            <p class="header-text">
                Every day delicious, fresh food goes to waste in supermarkets, cafeterias, restaurants, hotels,
                stores and manufacturers, simply because it has not been sold in time.
            </p>
        </div>

        <div class="little-facts">
            <div class="row">
                <div class="col">
                    <img src="./assets/imgs/waste_food2.png" alt="waste food statistics" width="120">
                    <p class="fact-details">1/3 of Food Is Lost or Wasted</span>
                </div>

                <div class="col">
                    <img class="rounded-circle" src="./assets/imgs/poverty.png" alt="waste food statistics" width="130" height="130">
                    <p class="fact-details">32.5% of Egyptians live on poverty</span>
                </div>

                <div class="col">
                    <img class="rounded-circle" src="./assets/imgs/malnutration.png" alt="waste food statistics" width="130" height="130">
                    <p class="fact-details">around 21.4% of suffer from malnutrition</span>
                </div>
            </div>
        </div>

    </div>
</section>

<!-- Facts -->
<session id="wedone">
    <div class="wrapper">

        <div class="row">
            <div class="col">
                <img src="./assets/imgs/fact1.png" alt="">
                <h4>102546</h4>
                <h5>Kilos food delivered</h5>
            </div>
            <div class="col">
                <img src="./assets/imgs/fact2.png" alt="">
                <h4>254054</h4>
                <h5>Plates of food delivered</h5>
            </div>
            <div class="col">
                <img src="./assets/imgs/fact3.png" alt="">
                <h4>3541</h4>
                <h5>Recycled waste</h5>
            </div>
            <div class="col">
                <img src="./assets/imgs/fact4.png" alt="">
                <h4>35451</h4>
                <h5>People served</h5>
            </div>
            <div class="col">
                <img src="./assets/imgs/fact5.png" alt="">
                <h4>35451</h4>
                <h5>Benefit organizations</h5>
            </div>
            <div class="col">
                <img src="./assets/imgs/fact6.png" alt="">
                <h4>35451</h4>
                <h5>People served</h5>
            </div>

        </div>

    </div>
</session>

<!-- Signup -->
<session id="signup">
    <div class="container">
        <div class="row">
            <div class="col">
                <h2>DO YOU HAVE A BUSINESS WITH SURPLUS FOOD?</h2>
                <h4>BE PART OF THE SOLUTION</h4>
                <h5>Too Good To Go can help you cut food waste - all while finding new customers and winning back sunk costs.</h5>
                <a class="btn">Sign up your business</a>
            </div>
            <div class="col">
                <img class="rounded" src="./assets/imgs/hero.jpg" alt="" height="350" style="object-fit: cover;">
            </div>
        </div>
    </div>
</session>


<?php include_once __DIR__ . '/includes/footer.php'; ?>