<?php require_once 'config/connection.php'; ?>

<?php
$loanAmount=trim($_POST['loanAmount']);
$loanDuration=trim($_POST['loanDuration']);

if($loanAmount===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" LOAN AMOUNT REQUIRED! Provide LOAN AMOUNT and try again.",
    ];
	goto end;
}

if (!is_numeric($loanAmount) || $loanAmount <= 100) {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "INVALID LOAN AMOUNT! ENTER ONLY DIGITS."
    ];
    goto end;
}elseif  ($loanAmount <= 1000|| $loanAmount > 10000000) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID LOAN AMOUNT! YOU CAN ONLY BORROW MONEY FROM 1000 TO 10000000."
    ]  ;
    goto end;
}

if($loanDuration===""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>" LOAN DURATION REQUIRED! Provide LOAN DURATION and try again.",
    ];
	goto end;
}

if (!ctype_digit($loanDuration)){
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID LOAN DURATION! ENTER ONLY WHOLE NUMBER."
    ]  ;
    goto end;
}elseif ($loanDuration <= 0|| $loanDuration > 12) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID LOAN DURATION! ENTER MONTHS FROM 1 TO 12."
    ]  ;
    goto end;
}


$loanAmount = (float) $loanAmount;
$principal = $loanAmount;
$totalInterest = 0;
$totalMonthlyRepayment = 0;

for ($month = 1; $month <= $loanDuration; $month++) {
    $repayment = $loanAmount / $loanDuration;
    $interestOnLoan = (1.5 / 100) * $principal;
    $monthlyRepayment = $repayment + $interestOnLoan;
  
    $monthlySchedule[] = [
        'month' => $month,
        'principal' => $principal,
        'repayment' =>  $repayment,
        'interest' =>$interestOnLoan,
        'monthlyRepayment' => $monthlyRepayment,
    ];

    $principal -= $repayment;
    $totalInterest += $interestOnLoan;
    $totalMonthlyRepayment += $monthlyRepayment;
}

$response = [
    'response' => 200,
    'success' => true,
    'loanDetails' => [
        'loanAmount' => $loanAmount,
        'loanDuration' => $loanDuration,
        'totalInterest' => $totalInterest, 
        'totalMonthlyRepayment' => $totalMonthlyRepayment, 
    ],
    'monthlySchedule' => $monthlySchedule
];

end:
echo json_encode($response);
?>