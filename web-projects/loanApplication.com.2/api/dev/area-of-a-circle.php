<?php require_once 'config/connection.php'; ?>

<?php

/////////////////  TO ACCEPT RADIUS FROM USER //////
$radius=trim($_POST['radius']);

///////////variable validation////////
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
        'message' => "INVALID RADIUS! ENTER ONLY DIGITS.",
    ];
    goto end;
}

// THE CALCULATION FOR AREA OF CIRCLE//
$area = 3.142 * $radius * $radius;

$response = [
    'response' => 200,
    'success' => true,
    'result'=> $area,
  
];


/////////////////////////// Print result /////////
end:
echo json_encode($response);
?>