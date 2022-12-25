<?php include_once __DIR__ . '/includes/header.php'; ?>
<style>
    nav {
        position: relative !important;
    }
</style>
<?php include_once __DIR__ . '/includes/nav.php'; ?>

<section id="products">
    <div class="container">

        <div class="row">

            <?php for ($i = 0; $i < 4; $i++) : ?>
                <!-- Card -->
                <div class="col col-md-3">
                    <a href="./product.php?id=...">
                        <div class="card" style="width: 18rem;">
                            <img class="card-img-top" src="./assets/imgs/products/product<?= $i + 1 ?>.jpg" alt="" height="150" style="object-fit: cover;">
                            <div class="p-3">
                                <h5 class="card-title text-center text-muted">Product's name</h5>
                                <p class="card-text text-muted text-truncate" style="line-height: 1.3;">Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit explicabo et consequuntur praesentium saepe suscipit atque laboriosam aperiam.</p>
                                <a href="#" class="btn btn-secondary btn-sm mt-3">More info</a>
                            </div>
                        </div>
                        <!-- Products images -->
                        <div class="product-imgs mt-3">
                            <img src="./assets/imgs/products/product<?= $i + 1 ?>.jpg" alt="" width="90" height="90" class="rounded">
                            <img src="./assets/imgs/products/product<?= $i + 1 ?>.jpg" alt="" width="90" height="90" class="rounded">
                            <img src="./assets/imgs/products/product<?= $i + 1 ?>.jpg" alt="" width="90" height="90" class="rounded">
                        </div>
                </div>
                </a>
                <!-- End card -->

            <?php endfor ?>

        </div>

    </div>
</section>