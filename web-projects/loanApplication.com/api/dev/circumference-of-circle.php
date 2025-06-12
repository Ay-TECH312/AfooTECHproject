<?php require_once 'config/connection.php'; ?>

<?php
/////////////////  TO ACCEPT RADIUS FROM USER //////
$radius=trim($_POST['radius']);

//////////variable validation////////
/////////////////   SECURITY FOR RADIUS //////
if($radius===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" RADIUS REQUIRED! Provide RADIUS and try again.",
    ];
	goto end;
}
if (!is_numeric($radius)) {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID RADIUS! ENTER ONLY DIGITS."
    ];
    goto end;
}

    ////     THE CIRCUMFERENCE OF A CIRCLE   ////
    $circumference = 2 * 3.142 * $radius;

    ////RESPONSE////
    $response = [
        'response' => 200,
        'success' => true,
        'result'=> $circumference,
    
    ];


/////////////////////////// Print result /////////
end:
echo json_encode($response);
?>