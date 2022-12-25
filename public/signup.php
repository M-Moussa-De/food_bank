<?php include_once __DIR__ . '/includes/header.php'; ?>

<style>
    nav {
        position: relative !important;
    }
</style>
<?php include_once __DIR__ . '/includes/nav.php'; ?>

<section id="donators_signup">
    <div class="container">

        <form action="" method="post">

            <h3>Sign up as a donators</h3>

            <div class="row">

                <div class="mb-3 col-12 col-md-6">
                    <label for="name" class="form-label">Organisation name</label>
                    <input type="text" name="name" class="form-control" id="name">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="exampleInputEmail1" class="form-label">Email address</label>
                    <input type="email" class="form-control" id="exampleInputEmail1">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="address" class="form-label">Address</label>
                    <input type="text" name="address" class="form-control" id="address">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="city" class="form-label">City</label>
                    <input type="text" name="city" class="form-control" id="city">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="zip" class="form-label">Zip/Postal code</label>
                    <input type="text" name="zip" class="form-control" id="zip">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="country" class="form-label">Country</label>
                    <input type="text" name="country" class="form-control" id="country">
                </div>

                <div class="mb-3  col-12 col-md-6">
                    <label for="phone" class="form-label">Work phone</label>
                    <input type="tel" name="tel" class="form-control" id="phone">
                </div>

                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1">
                    <label class="form-check-label" for="exampleCheck1">I agree to the terms*</label>
                </div>

            </div>

            <button type="submit" class="btn">Sign up</button>

        </form>

    </div>
</section>

<section id="terms">
    <div class="container">
        <h6>Conditions to sign up as a donaitors*</h6>
        <ol>
            <li>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quod, a?</li>
            <li>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Perspiciatis animi molestias labore possimus sint.</li>
            <li>Lorem ipsum dolor sit amet consectetur adipisicing elit.</li>
        </ol>
    </div>
</section>

<?php include_once __DIR__ . '/includes/footer.php'; ?>