<?php require_once 'config/connection.php'; ?>

<?php

$firstNumber=trim($_POST['firstNumber']);
$secondNumber=trim($_POST['secondNumber']);

//////////variable validation////////
if($firstNumber===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>"FIRST NUMBER REQUIRED! Provide FIRST NUMBER and try again.",
    ];
	goto end;
}

if($secondNumber === ""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>"SECOND NUMBER REQUIRED! Provide SECOND NUMBER and try again.",

    ];
	goto end;
}

if (!is_numeric($firstNumber)) {
    $response = [
        'response' => 102,
        'success' => false,
        'message' => "INVALID FIRST NUMBER! ENTER ONLY DIGITS."
    ];
    goto end;
}

if (!is_numeric($secondNumber)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID SECOND NUMBER! ENTER ONLY DIGITS."
    ];
    goto end;

}
////////////system process////
$sum=$firstNumber+$secondNumber;

$response = [
    'response' => 200,
    'success' => true,
    'sum'=> $sum,
    'descriptionOne'=> "The sum of $firstNumber and $secondNumber is $sum" ,
   
];
/////////////////////////// Print result /////////
end:
echo json_encode($response);
?>