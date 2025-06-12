<?php require_once 'config/connection.php'; ?>

<?php
    $a = ($_POST['a']);
    $b = ($_POST['b']);
    $c = ($_POST['c']);
    

    $d = $b * $b;
    $e = 4 * $a * $c;
    $sqRt = sqrt($d - $e);
    $f = -$b + $sqRt; 
    $g = -$b - $sqRt;
    $h = $f / (2 * $a);
    $i = $g / (2 * $a);

     
    $response = [
        'response' => 200,
        'success' => true,
        'x' => "$h or $i",
        'descriptionOne' => "x is $h or x is $i" 
    ];

end:
echo json_encode($response);
?>