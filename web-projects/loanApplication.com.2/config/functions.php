<?php
class allClass
{
    function _pagesImage() { ?>
        <div class="image-div">
            <img src="./all-images/images/bank.jpg" alt="bg-image">
        </div>        
    <?php }

    function _header() { ?>
        <header>
                <nav>
                    <div class="logo-div">
                        <img src="all-images/images/logo.png" alt="">
                    </div>
                    <ul>
                        <li><a href="index.php">Request For Loan</a></li>
                        <li><a href="view-loan-request.php">View Loan Request</a></li>
                    </ul>
                </nav>
            </header>   
    <?php }

} //end of class
$callclass = new allClass();
?>