<?php
require_once 'config/connection.php';

$firstNumber = isset($_POST['firstNumber']) ? trim($_POST['firstNumber']) : '';
$secondNumber = isset($_POST['secondNumber']) ? trim($_POST['secondNumber']) : '';

// Validate first number
if (empty($firstNumber)) {
    echo json_encode([
        'response' => 100,
        'success' => false,
        'message' => "FIRST NUMBER REQUIRED! Please provide the first number and try again.",
        'app' => $appName
    ]);
    exit;
}

if (!is_numeric($firstNumber)) {
    echo json_encode([
        'response' => 102,
        'success' => false,
        'message' => "INVALID FIRST NUMBER! Only numeric values are allowed.",
        'app' => $appName
    ]);
    exit;
}

// Validate second number
if (empty($secondNumber)) {
    echo json_encode([
        'response' => 101,
        'success' => false,
        'message' => "SECOND NUMBER REQUIRED! Please provide the second number and try again.",
        'app' => $appName
    ]);
    exit;
}

if (!is_numeric($secondNumber)) {
    echo json_encode([
        'response' => 103,
        'success' => false,
        'message' => "INVALID SECOND NUMBER! Only numeric values are allowed.",
        'app' => $appName
    ]);
    exit;
}

// Perform calculation
$sum = (float)$firstNumber + (float)$secondNumber;

// Success response
echo json_encode([
    'response' => 200,
    'success' => true,
    'sum' => $sum,
    'description' => "The sum of $firstNumber and $secondNumber is $sum.",
    'app' => $appName,
    'note' => $appDescription
]);
exit;
?>
