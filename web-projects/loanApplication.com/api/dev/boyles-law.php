<?php require_once 'config/connection.php'; ?>

<?php
/////////////////  TO ACCEPT INPUT FROM USER //////
$v1=trim( $_POST['v1']);
$v2=trim($_POST['v2']);
$p1=trim( $_POST['p1']);
$p2=trim($_POST['p2']);

//////////variable validation////////
/////////////////  SECURITY FOR v1 //////


if(!is_numeric($v1)  && $v1 != "?"){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" v1 REQUIRED! Provide v1 and try again.",
    ];
	goto end;
}
if (!is_numeric($v1) && $v1 != "?") {
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID v1! ENTER ONLY DIGITS OR '?'"
    ];
    goto end;
}

/////////////////  SECURITY FOR v2 //////
if(empty($v2)){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=>" v2 REQUIRED! Provide v2 and try again.",
    ];
	goto end;
}
if(!is_numeric($v2) && $v2 != "?") {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID v2! ENTER ONLY DIGITS OR '?'"
    ];
    goto end;
}

/////////////////  SECURITY FOR p1 //////
if($p1 ===""){ 
    $response = [
        'response' => 104,
        'success' => false,
        'message'=>" p1 REQUIRED! Provide p1 and try again.",
    ];
	goto end;
}
if (!is_numeric($p1) && $p1 != "?") {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID p1! ENTER ONLY DIGITS OR '?'"
    ];
    goto end;
}

/////////////////  SECURITY FOR p2 //////
if($p2 ===""){ 
    $response = [
        'response' => 106,
        'success' => false,
        'message'=>" p2 REQUIRED! Provide p2 and try again.",
    ];
	goto end;
}
if(!is_numeric($p2) && $p2 != "?") {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID p2! ENTER ONLY DIGITS OR '?'"
    ];
    goto end;
}



// THE SOLUTION TO THE BOYLE'S LAW //
if ($p1 =="?"){
    if ($v1 == 0){
        $response = [
            'response' => 108,
            'success' => false,
            'message' => "v1 can't be zero, the equation can't be divided by 0"
        ];
   
    } 
    
    elseif ($v2 == "?" || $p2 == "?" || $v1 == "?") {
        $response = [
            'response' => 109,
            'success' => false,
            'message' => "Only one column should carry question mark '?'"
        ];
   
    }

    else{
    $p1 = ($p2 * $v2)/$v1;
    $response = [
        'response' => 200,
        'success' => True,
        'p1' => $p1,
        'message' => "The initial pressure (p1) is $p1",
    ];
 
}
}


elseif ($p2 =="?"){
    if ($v2 == 0){
        $response = [
            'response' => 110,
            'success' => false,
            'message' => "v2 can't be zero, the equation can't be divided by 0"
        ];
        goto end;
    }

    if ($p1 == "?" || $v2 == "?" || $v1 == "?") {
        $response = [
            'response' => 111,
            'success' => false,
            'message' => "Only one column should carry question mark '?'"
        ];
     
    }else{
    $p2 = ($v1 * $p1)/$v2;
    $response = [
        'response' => 201,
        'success' => True,
        'p2' => $p2,
        'message' => "The final pressure (p2) is $p2",
    ];
 
}
}


elseif ($v1 =="?"){
    if ($p1 == 0){
        $response = [
            'response' => 112,
            'success' => false,
            'message' => "p1 can't be zero, the equation can't be divided by 0"
        ];
 
    }elseif ($v2 == "?" || $p2 == "?" || $p1 == "?") {
        $response = [
            'response' => 113,
            'success' => false,
            'message' => "Only one column should carry question mark '?'"
        ];
    
    }else{
    $v1 = ($v2 * $p2)/$p1;
    $response = [
        'response' => 202,
        'success' => True,
        'v1' => $v1,
        'message' => "The initial volume (v1) is $v1",
    ];

}
}


elseif ($v2 =="?"){
    if ($p2 == 0){
        $response = [
            'response' => 114,
            'success' => false,
            'message' => "p2 can't be zero, the equation can't be divided by 0"
        ];
    
    }

    elseif ($v1 == "?" || $p2 == "?" || $p1 == "?") {
        $response = [
            'response' => 115,
            'success' => false,
            'message' => "Only one column should carry question mark '?'"
        ];
     
    }

    else{
    $v2 = ($v1 * $p1)/$p2;
    $response = [
        'response' => 203,
        'success' => True,
        'v2' => $v2,
        'message' => "The final volume (v2) is $v2",
    ];
    
}
}


else{
    $response = [
        'response' => 116,
        'success' => false,
        'message' => "A column must carry question mark'?'",
    ];

}

////////////////////////// Print result /////////
end:
echo json_encode($response);
?>
