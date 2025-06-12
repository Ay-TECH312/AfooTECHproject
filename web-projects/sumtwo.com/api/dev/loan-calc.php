<?php require_once 'config/connection.php'; ?>

<?php

// INPUT SECTION
$loanAmount = trim($_POST['loanAmount']);
$loanDuration = trim($_POST['loanDuration']);

// VALIDATION: LOAN AMOUNT
if (empty($loanAmount)) {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "LOAN AMOUNT REQUIRED! Provide LOAN AMOUNT and try again.",
    ];
    goto end;
}

if (!is_numeric($loanAmount)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID LOAN AMOUNT! ENTER ONLY NUMERIC VALUE.",
    ];
    goto end;
}

$loanAmount = (float)$loanAmount;
if ($loanAmount < 1000 || $loanAmount > 10000000) {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "LOAN AMOUNT OUT OF RANGE! You can only borrow between ₦1,000 and ₦10,000,000.",
    ];
    goto end;
}

// VALIDATION: LOAN DURATION
if (empty($loanDuration)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "LOAN DURATION REQUIRED! Provide LOAN DURATION in months.",
    ];
    goto end;
}

if (!ctype_digit($loanDuration)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID LOAN DURATION! Only whole numbers allowed (months).",
    ];
    goto end;
}

$loanDuration = (int)$loanDuration;
if ($loanDuration < 1 || $loanDuration > 12) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "LOAN DURATION OUT OF RANGE! Please enter between 1 and 12 months.",
    ];
    goto end;
}

// LOAN CALCULATION LOGIC
$principal = $loanAmount;
$totalInterest = 0;
$totalMonthlyRepayment = 0;
$repayment = $loanAmount / $loanDuration;
$monthlySchedule = [];

for ($month = 1; $month <= $loanDuration; $month++) {
    $interestOnLoan = (1.5 / 100) * $principal;
    $monthlyRepayment = $repayment + $interestOnLoan;

    $monthlySchedule[] = [
        'month' => $month,
        'repayment' => "₦" . number_format($repayment, 2),
        'interest' => "₦" . number_format($interestOnLoan, 2),
        'monthlyRepayment' => "₦" . number_format($monthlyRepayment, 2),
        'principal' => "₦" . number_format($principal, 2),
    ];

    $principal -= $repayment;
    $totalInterest += $interestOnLoan;
    $totalMonthlyRepayment += $monthlyRepayment;
}

// RESPONSE: SUCCESS
$response = [
    'response' => 200,
    'success' => true,
    'loanDetails' => [
        'loanAmount' => "₦" . number_format($loanAmount, 2),
        'loanDuration' => "$loanDuration month(s)",
        'totalInterest' => "₦" . number_format($totalInterest, 2),
        'totalMonthlyRepayment' => "₦" . number_format($totalMonthlyRepayment, 2),
    ],
    'monthlySchedule' => $monthlySchedule
];

// OUTPUT SECTION
end:
echo json_encode($response);
?>