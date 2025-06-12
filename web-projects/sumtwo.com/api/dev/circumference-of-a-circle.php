<?php require_once 'config/connection.php'; ?>

<?php
    $radius = ($_POST['radius']);

    if(empty($radius) || !is_numeric($radius)){
        $response = [
            'response' => 100,
            'success' => false,
            'message' => "Radius is REQUIRED! Provide a valid number and try again.",
        ];
        goto end;
    }

    $circumference = 2 * 3.142 * $radius;

    $response = [
        'response' => 200,
        'success' => true,
        'area' => $circumference,
        'descriptionOne' => "The circumference of the circle wtih radius $radius is $circumference"
    ];
    
end:
echo json_encode($response);
?>