<?php require_once 'config/connection.php'; ?>

<?php
// ========== INPUT SECTION ==========

// FULL NAME
$fullName = trim($_POST['fullName'] ?? '');
$fullName = strip_tags($fullName); // remove HTML tags
$fullName = htmlspecialchars($fullName); // convert special characters
if (empty($fullName)) {
    $response = [
        'response' => 98,
        'success' => false,
        'message' => "FULL NAME REQUIRED! Provide your full name.",
    ];
    goto end;
}
if (!preg_match("/^[a-zA-Z\s.'-]+$/", $fullName)) {
    $response = [
        'response' => 99,
        'success' => false,
        'message' => "INVALID NAME FORMAT! Only letters, spaces, dots, apostrophes, and hyphens allowed.",
    ];
    goto end;
}

// LOAN AMOUNT
$loanAmount = trim($_POST['loanAmount'] ?? '');
$loanAmount = strip_tags($loanAmount);
$loanAmount = htmlspecialchars($loanAmount);
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

// LOAN RATE
$loanRate = trim($_POST['loanRate'] ?? '');
$loanRate = strip_tags($loanRate);
$loanRate = htmlspecialchars($loanRate);
if (empty($loanRate)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "LOAN RATE REQUIRED! Provide a rate.",
    ];
    goto end;
}
if (!is_numeric($loanRate)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID RATE! ENTER ONLY NUMERIC VALUE.",
    ];
    goto end;
}
$loanRate = (float)$loanRate;
if ($loanRate <= 0 || $loanRate > 100) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "LOAN RATE OUT OF RANGE! Rate should be between 0.1 and 100.",
    ];
    goto end;
}

// LOAN DURATION
$loanDuration = trim($_POST['loanDuration'] ?? '');
$loanDuration = strip_tags($loanDuration);
$loanDuration = htmlspecialchars($loanDuration);
if (empty($loanDuration)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "LOAN DURATION REQUIRED! Provide LOAN DURATION in months.",
    ];
    goto end;
}
if (!ctype_digit($loanDuration)) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID LOAN DURATION! Only whole numbers allowed (months).",
    ];
    goto end;
}
$loanDuration = (int)$loanDuration;
if ($loanDuration < 1 || $loanDuration > 12) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "LOAN DURATION OUT OF RANGE! Please enter between 1 and 12 months.",
    ];
    goto end;
}

// ========== LOAN CALCULATION ==========

$principal = $loanAmount;
$totalInterest = 0;
$totalMonthlyRepayment = 0;
$repayment = $loanAmount / $loanDuration;
$monthlySchedule = [];

for ($month = 1; $month <= $loanDuration; $month++) {
    $interestOnLoan = ($loanRate / 100) * $principal;
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

// ========== SUCCESS RESPONSE ==========
$response = [
    'response' => 200,
    'success' => true,
    'loanDetails' => [
        'fullName' => $fullName,
        'loanAmount' => "₦" . number_format($loanAmount, 2),
        'loanRate' => $loanRate . "%",
        'loanDuration' => "$loanDuration month(s)",
        'totalInterest' => "₦" . number_format($totalInterest, 2),
        'totalMonthlyRepayment' => "₦" . number_format($totalMonthlyRepayment, 2),
    ],
    'monthlySchedule' => $monthlySchedule
];

// ========== OUTPUT ==========
end:
echo json_encode($response);
?>