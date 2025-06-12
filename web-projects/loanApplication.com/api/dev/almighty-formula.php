<?php require_once 'config/connection.php'; ?>

<?php

/////////////////  TO ACCEPT INPUT FROM USER //////
$a=trim($_POST['a']);
$b=trim($_POST['b']);
$c=trim($_POST['c']);

//////////variable validation////////

/////////////////   SECURITY FOR A //////
if($a===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" 'a' REQUIRED! Provide the value for 'a' and try again.",
    ];
	goto end;
}
if (!is_numeric($a)) {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID 'a'! ENTER ONLY DIGITS."
    ];
    goto end;
}

///////////////////  SECURITY FOR B //////
if($b===""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>" 'b' REQUIRED! Provide the value for 'b' and try again.",
    ];
	goto end;
}
if (!is_numeric($b)) {
    $response = [
        'response' => 104,
        'success' => false,
        'message' => "INVALID 'b'! ENTER ONLY DIGITS."
    ];
    goto end;
}

///////////////////  SECURITY FOR C //////
if($c===""){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=>" 'c' REQUIRED! Provide the value for 'c' and try again.",
    ];
	goto end;
}
if (!is_numeric($c)) {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID 'c'! ENTER ONLY DIGITS."
    ];
    goto end;
}

// THE GENERAL FORMULAR //
////////////system process////
$d = $b * $b;
        $e = 4 * $a;
        $f = $e * $c;
        $g = $d - $f;
        $h = Sqrt($g);
        $j = -$b + $h;
        $k = -$b - $h;
        $l = 2 * $a;
        $m = $j / $l;
        $n = $k / $l;
        $x1 = $m;
        $x2 = $n;


        //RESPONSE//
        $response = [
            'response' => 200,
            'success' => true,
            'x1'=> $x1,
            'x2'=> $x2,
          
        ];
        

/////////////////////////// Print result /////////
end:
echo json_encode($response);
?>