<?php include "config/config.php"; ?>
<?php include "config/functions.php"; ?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title><?php echo $appName ?></title>
    <?php include "meta.php"; ?>
</head>

<body>
    <div class="body-div">
        <div class="body-div-in">
            <?php $callclass->_header();?>
            
            <div class="loan-container">
                <div class="title-div">
                    <h2>All Loan Request</h2>
                    <div class="searchInput">
                        <input type="text" placeholder="search Here.....">
                        <i class="bi-search"></i>
                    </div>
                </div>
            </div>
        </div>

        <?php $callclass->_pagesImage(); ?>
    </div>
</body>