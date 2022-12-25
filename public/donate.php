<?php include_once __DIR__ . '/includes/header.php'; ?>
<style>
    nav {
        position: relative !important;
    }
</style>
<?php include_once __DIR__ . '/includes/nav.php'; ?>

<section id="donate">
    <div class="container">


        <form action="" method="post">

            <h3 class="text-center">Donate a Meal/Dish</h3>

            <div class="row">

                <div class="mb-3 col-12 col-md-6">
                    <label for="dish_name" class="form-label">Dish name</label>
                    <input type="text" name="dish_name" class="form-control" id="dish_name" placeholder="Enter the dish name">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="dish_ingredients" class="form-label">Dish ingredients</label>
                    <input type="text" name="dish_ingredients" class="form-control" id="dish_ingredients" placeholder="Enter the dish ingredients...">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="persons_nr" class="form-label">Enough for (Persons nr) </label>
                    <input type="number" name="persons_nr" class="form-control" id="persons_nr" min="1" value="1">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="dish_fotos" class="form-label">Dish fotos</label>
                    <input type="file" name="dish_fotos" class="form-control" id="dish_fotos" multiple>
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="dish_date" class="form-label">Dish prepared date</label>
                    <input type="date" name="dish_date" class="form-control" id="dish_date">
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="dish_description" class="form-label">Dish description</label>
                    <textarea type="text" name="dish_describtion" class="form-control" id="dish_description" placeholder="Describe your dish..."></textarea>
                </div>

                <div class="mb-3 col-12 col-md-6">
                    <label for="extra_notes" class="form-label">Extra notes</label>
                    <textarea type="text" name="dish_describtion" class="form-control" id="extra_notes" placeholder="Extra notes..."></textarea>
                </div>

                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="terms">
                    <label class="form-check-label" for="terms">The meal was controlled and it's eatable</label>
                </div>

            </div>

            <button type="submit" class="btn btn-sm btn-secondary">Share</button>

        </form>


    </div>
</section>