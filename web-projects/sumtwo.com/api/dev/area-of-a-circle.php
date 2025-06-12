<?php require_once 'config/connection.php'; ?>

<?php
    $radius = ($_POST['radius']);


    if(empty($radius ) || !is_numeric($radius)){
        $response = [
        'response' => 100,
        'success' => false,
        'message' => "Radius is REQUIRED! Provide a valid number and try again."
        ];
        goto end;
    }

    $area = 3.142 * $radius * $radius;


    $response = [
        'response' => 200,
        'success' => true,
        'area' => $area,
        'descriptionOne' => "The area of the circle wtih radius $radius is $area"
    ];



end:
echo json_encode($response);
?>