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

            <div class="form-div">
                <div class="input-div">
                    <h2>Request For Loan</h2>
                    <input class="text-field" id="fullName" type="text" placeholder="Enter Full Name Here">
                    <input class="text-field" id="loanAmount" type="number" placeholder="Enter Loan Amount Here">
                    <input class="text-field" id="loanRate" type="number" placeholder="Enter Loan Rate Here">
                    <select class="text-field select-field" id="loanDuration">
                        <option selected="selected" value="">Select Duration</option>
                        <option value="6">6 month</option>
                        <option value="10">10 months</option>
                        <option value="12">12 months</option>
                        <option value="24">24 months</option>
                    </select>
                    <div class="button-div">
                        <button class="btn" onclick="_loanRequest();">Request For Loan <i class="bi-check"></i></button>
                        <button type="delete" class="btn-clear" onclick="_clear();">clear</button>
                    </div>
                </div>
            </div>
        </div>

        <?php $callclass->_pagesImage();?>
    </div>
</body>