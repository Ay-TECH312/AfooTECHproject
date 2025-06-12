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
                        <li>Request For Loan</li>
                        <li onclick="_actionModal('open');">View Loan Request</li>
                    </ul>
                </nav>
            </header>       
    <?php }

} //end of class
$callclass = new allClass();
?>