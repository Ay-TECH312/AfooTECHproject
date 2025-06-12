<?php require_once 'config/connection.php';?>

<?php

$firstNumber = ($_POST['firstNumber']);
$secondNumber = ($_POST['secondNumber']);
$operator = ($_POST['operator']);


if (empty($firstNumber) || !is_numeric($firstNumber)) {
    $response = [
        'response' => 100,
        'success' => false,
        'message' => "First Number is REQUIRED! Provide a valid number and try again.",
    ];
    goto end;
}

if (empty($secondNumber) || !is_numeric($secondNumber)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "Second Number is REQUIRED! Provide a valid number and try again.",
    ];
    goto end;
}

if (empty($operator) || ($operator != "+" && $operator != "-" && $operator != "*" && $operator != "/")) {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "Operator is REQUIRED! Provide a valid operator and try again.",
    ];
    goto end;
}






if ($operator == "+"){
    $result = $firstNumber + $secondNumber;
}
elseif ($operator == "-"){
    $result = $firstNumber - $secondNumber;
}
elseif ($operator == "/"){
    if ($secondNumber == 0){
        $result = "Undefined (division by zero)";
    } 
    else{
        $result = $firstNumber / $secondNumber;
    }
}
elseif ($operator == "*"){
    $result = $firstNumber * $secondNumber;
}
else{
    $result = "Input correct operator";
}



$response = [
    'response' => 200,
    'success' => true,
    'Result' => $result,
    'description' => "The result of $firstNumber $operator $secondNumber is = $result" 
];



end:
echo json_encode($response);
?>