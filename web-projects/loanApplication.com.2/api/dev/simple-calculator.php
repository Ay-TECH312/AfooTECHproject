<?php require_once 'config/connection.php'; ?>

<?php

/////////////////  TO ACCEPT INPUT FROM USER //////
$firstNumber=trim($_POST['firstNumber']);
$operator=trim($_POST['operator']);
$secondNumber=trim($_POST['secondNumber']);


//////////variable validation////////
/////////////////  SECURITY FOR FIRST NUMBER //////
if($firstNumber===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" FIRST NUMBER REQUIRED! Provide FIRST NUMBER and try again.",
    ];
	goto end;
}
if (!is_numeric($firstNumber)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID FIRST NUMBER! ENTER ONLY DIGITS."
    ];
    goto end;
}


/////////////////  SECURITY FOR SECOND NUMBER //////
if($secondNumber===""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>" SECOND NUMBER REQUIRED! Provide SECOND NUMBER and try again.",
    ];
	goto end;
}
if (!is_numeric($secondNumber)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID SECOND NUMBER! ENTER ONLY DIGITS."
    ];
    goto end;
}

/////////////////  SECURITY FOR ACCEPTING ONLY OPERATOR //////
if($operator===""){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=>" OPERATOR REQUIRED! Provide OPERATOR and try again.",
    ];
	goto end;
}
$allowed_operators = array('+', '-', '/', 'x');
if (!in_array($operator, $allowed_operators)) {
    $response = [ 
        'response' => 105,
        'success' => false,
        'message' => "INVALID OPERATOR! ENTER ONLY ('+','-','/','x')."
    ];
    goto end;
}


//////////////////   THE MAIN CALCULATION    ///////////////////////
if ($operator == "+" ){
    $result = $firstNumber + $secondNumber;
}
elseif ($operator == "-" ){
    $result = $firstNumber - $secondNumber;
}
elseif ($operator == "x" ){
    $result = $firstNumber * $secondNumber;
}
elseif ($operator == "/" ){
    if ($firstNumber != 0){
        $result = $firstNumber / $secondNumber;
    }else{
        $response = [ 
           'response' => 106,
            'success' => false,
            'message' => "DIVISION BY ZERO IS NOT ALLOWED."
        ];
        goto end;
    }
}
else{
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "UNKNOWN OPERATOR."
    ];
    goto end;
}


$response = [
        'response' => 200,
        'success' => true,
        'result' => $result
        ];



////////////////////////// Print result /////////
end:
echo json_encode($response);
?>