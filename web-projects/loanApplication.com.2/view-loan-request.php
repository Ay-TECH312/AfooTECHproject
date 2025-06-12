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

                <div class="loan-details">

                    <div class="loan-card" onclick="_actionModal('open')">
                        <div class="loanIdANDname">
                            <p>LOAN00120250426045950</p>
                            <h3>Adeyemi Ayobami</h3>
                        </div>

                        <div class="amountANDduration">
                            <p>₦ 600000.00</p>
                            <span>6 months</span>
                        </div>
                    </div>

                    <div class="loan-card" onclick="_actionModal('open')">
                        <div class="loanIdANDname">
                            <p>LOAN00120250426045950</p>
                            <h3>Adeyemi Ayobami</h3>
                        </div>

                        <div class="amountANDduration">
                            <p>₦ 600000.00</p>
                            <span>6 months</span>
                        </div>
                    </div>

                    <div class="loan-card" onclick="_actionModal('open')">
                        <div class="loanIdANDname">
                            <p>LOAN00120250426045950</p>
                            <h3>Adeyemi Ayobami</h3>
                        </div>

                        <div class="amountANDduration">
                            <p>₦ 600000.00</p>
                            <span>6 months</span>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <?php $callclass->_pagesImage(); ?>

        <div class="overlay" id='modal'>
            <div class="table-container">

                <div class="header-table-container">
                    <div class="header-inner-div">
                        <h2>Loan Repayment Schedule</h2>
                        <div class="btn-div" onclick="_actionModal('close')">
                            <button class="btn-back">Back</button>
                        </div>
                    </div>
                </div>

                <div class="table-content-back-div">
                    <div class="table-content-div-in">
                        <div class="loanCard">
                            <div class="loan-card-inner">
                                <div class="loan-details">
                                    <div>Loan Id:</div>
                                    <span>LOAN00120250426045950</span>
                                </div>

                                <div class="loan-details">
                                    <div>Fullname:</div>
                                    <span>ADEYEMI AYOBAMI</span>
                                </div>

                                <div class="loan-details">
                                    <div>Amount:</div>
                                    <span>₦ 600000.00</span>
                                </div>

                                <div class="loan-details">
                                    <div>Total Repayment:</div>
                                    <span>₦ 631500.00</span>
                                </div>

                                <div class="loan-details">
                                    <div>Duration:</div>
                                    <span>6 months</span>
                                </div>

                                <div class="loan-details">
                                    <div>Date:</div>
                                    <span>2025-05-20 12:42:14</span>
                                </div>
                            </div>
                        </div>

                        <table id="loanBreakdown">
                            <thead>
                                <tr>
                                    <th>Month (s)</th>
                                    <th>Repayment (₦)</th>
                                    <th>Interest (₦)</th>
                                    <th>Monthly Repayment (₦)</th>
                                    <th>Principal (₦)</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>100,000.00</td>
                                    <td>9,000.00</td>
                                    <td>109,000.00</td>
                                    <td>600,000.00</td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>100,000.00</td>
                                    <td>7,500.00</td>
                                    <td>107,500.00</td>
                                    <td>500,000.00</td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>100,000.00</td>
                                    <td>6,000.00</td>
                                    <td>106,000.00</td>
                                    <td>400,000.00</td>
                                </tr>
                                <tr>
                                    <td>4</td>
                                    <td>100,000.00</td>
                                    <td>4,500.00</td>
                                    <td>104,500.00</td>
                                    <td>300,000.00</td>
                                </tr>
                                <tr>
                                    <td>5</td>
                                    <td>100,000.00</td>
                                    <td>3,000.00</td>
                                    <td>103,000.00</td>
                                    <td>200,000.00</td>
                                </tr>
                                <tr>
                                    <td>6</td>
                                    <td>100,000.00</td>
                                    <td>1,500.00</td>
                                    <td>101,500.00</td>
                                    <td>100,000.00</td>
                                </tr>
                                
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>