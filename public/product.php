<?php include_once __DIR__ . '/includes/header.php'; ?>
<style>
    nav {
        position: relative !important;
    }
</style>
<?php include_once __DIR__ . '/includes/nav.php'; ?>

<section id="product" class="mt-4">
    <div class="container">
        <div class="row">

            <!-- Product imgs -->
            <div class="col-12 col-md-5">

                <div class="main_img">
                    <img class="card-img" src="./assets/imgs/products/product1.jpg" alt="" height="400" style="object-fit: cover;">
                </div>

                <div class="row mt-2 mini_imgs">
                    <div class="col">
                        <img src="./assets/imgs/products/product2.jpg" alt="" height="90">
                    </div>
                    <div class="col">
                        <img src="./assets/imgs/products/product3.jpg" alt="" height="90">
                    </div>
                    <div class="col">
                        <img src="./assets/imgs/products/product1.jpg" alt="" height="90">
                    </div>
                </div>


            </div>

            <!-- Product details -->
            <div class="col-12 col-md-5 mx-auto">

                <div class="product_details">
                    <h3 class="text-uppercase mb-3">Product title</h3>

                    <div>
                        <h6>Description:</h6>
                        <span>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ex rem culpa quae natus eveniet? Molestiae voluptas exercitationem consectetur quam maxime totam.</span>
                    </div>

                    <div>
                        <h6 class="mt-3">Ingredients:</h6>
                        <ul>
                            <li><span> (15 ounce) container ricotta cheese</span></li>
                            <li><span> (8 ounce) package shredded mozzarella cheese, divided</span></li>
                            <li><span> (3 ounce) package Parmesan cheese</span></li>
                            <li><span> egg</span></li>
                            <li><span>2 teaspoons Italian seasoning</span></li>
                            <li><span> pound sausage</span></li>
                            <li><span>½ (26 ounce) jar marinara sauce</span></li>
                            <li><span>6 flatbreads</span></li>
                        </ul>
                    </div>

                    <div>
                        <h6 class="mt-3">Extra notes:</h6>
                        <span>gluten free</span>
                    </div>

                </div>


            </div>
        </div>
    </div>
</section>

<!-- Change img on hover -->
<script>
    const mainImg = document.querySelector('#product .main_img img');
    const miniImgs = [...document.querySelectorAll('#product .mini_imgs img')];

    miniImgs.forEach(img => {
        img.addEventListener('mouseover', () => {
            mainImg.src = img.src;
        });
    });
</script>

<?php include_once __DIR__ . '/includes/footer.php'; ?>